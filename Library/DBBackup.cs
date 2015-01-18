using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace LibraryDesign_frontEndUI.Library
{

    class DBBackup
    {
        Server _myServer = null;
        Database _myBLSDB = null;

        public DBBackup()
        {
            CreateServerConnection();
            SelectDatabase();
        }

        private void CreateServerConnection()
        {

            try
            {
                _myServer = new Server(ConfigurationSettings.AppSettings["ServerName"]);
                //Using windows authentication
                _myServer.ConnectionContext.LoginSecure = true;
                _myServer.ConnectionContext.Connect();
                
            }
            catch (SqlServerManagementException ex)
            {
                //retry to take backup using sql commands
                DbBackUpHelper backupHelper = new DbBackUpHelper();
                backupHelper.BackUpDatabase(GetPath("BLSFullBackUp"), "BLS");
            }            
        }

        internal void DestroyServerConnection()
        {
            if (_myServer != null && _myServer.ConnectionContext.IsOpen)
                _myServer.ConnectionContext.Disconnect();
        }

        private void SelectDatabase()
        {
            _myBLSDB = _myServer.Databases["BLS"];
        }

        private string GetPath(string strName)
        {
            string strFixedPath = string.Empty;
            string strBackUpLocation = ConfigurationSettings.AppSettings["BackUpLocation"];

            if (string.IsNullOrWhiteSpace(strBackUpLocation))
            {
                strBackUpLocation = AppDomain.CurrentDomain.BaseDirectory;
                strFixedPath = Path.Combine(strBackUpLocation, strName, DateTime.Now.ToString("yyyyMMdd"));
            }
            else
            {
                strFixedPath = Path.Combine(strBackUpLocation, DateTime.Now.ToString("yyyyMMdd"));
            }

            if (!Directory.Exists(strFixedPath))
            {
                Directory.CreateDirectory(strFixedPath);
                if (strName.Contains("Differential"))
                {
                    return Path.Combine(strFixedPath, DateTime.Now.ToString("yyyyMMddHHmmss"));
                }
                else
                {
                    return Path.Combine(strFixedPath, DateTime.Now.ToString("yyyyMMdd"));
                }
            }
            else
            {
                strName = (strName.Contains("Differential")) ? Path.Combine(strFixedPath, DateTime.Now.ToString("yyyyMMddHHmmss")) : Path.Combine(strFixedPath, DateTime.Now.ToString("yyyyMMdd"));

                if (!File.Exists(strName))
                {
                    if (strName.Contains("Differential"))
                    {
                        strName = Path.Combine(strFixedPath, DateTime.Now.ToString("yyyyMMddHHmmss"));
                    }
                    else
                    {
                        strName = Path.Combine(strFixedPath, DateTime.Now.ToString("yyyyMMdd"));
                    }
                    return strName;
                }
                else
                {
                    return string.Empty;
                }
            }


        }


        internal void TakeFullBackUp()
        {
            string strFileName = string.Empty;
            try
            {
                Program.MainObj.tlsPgrs.Minimum = 0;
                Program.MainObj.tlsPgrs.Maximum = 100;
                Backup bkpDBFull = new Backup();
                strFileName = GetPath("BLSFullBackUp");
                
                if (strFileName != string.Empty)
                {
                    /* Specify whether you want to back up database or files or log */
                    bkpDBFull.Action = BackupActionType.Database;
                    /* Specify the name of the database to back up */
                    bkpDBFull.Database = _myBLSDB.Name;
                    /* You can take backup on several media type (disk or tape), here I am
                     * using File type and storing backup on the file system */
                    bkpDBFull.Devices.AddDevice(strFileName, DeviceType.File);
                    bkpDBFull.BackupSetName = "BLS database Backup";
                    bkpDBFull.BackupSetDescription = "BLS database - Full Backup";
                    /* You can specify the expiration date for your backup data
                     * after that date backup data would not be relevant */
                    bkpDBFull.ExpirationDate = DateTime.Today.AddDays(100);
                    /* You can specify Initialize = false (default) to create a new 
                     * backup set which will be appended as last backup set on the media. You
                     * can specify Initialize = true to make the backup as first set on the
                     * medium and to overwrite any other existing backup sets if the all the
                     * backup sets have expired and specified backup set name matches with
                     * the name on the medium */
                    bkpDBFull.Initialize = false;

                    /* Wiring up events for progress monitoring */
                    bkpDBFull.PercentComplete += CompletionStatusInPercent;
                    bkpDBFull.Complete += Backup_Completed;

                    /* SqlBackup method starts to take back up
                     * You can also use SqlBackupAsync method to perform the backup 
                     * operation asynchronously */
                    bkpDBFull.SqlBackup(_myServer);
                }
            }
            catch (SqlServerManagementException seq)
            {
                if (!string.IsNullOrWhiteSpace(strFileName))
                {
                    //retry to take backup using sql commands
                    DbBackUpHelper backupHelper = new DbBackUpHelper();
                    backupHelper.BackUpDatabase(strFileName, "BLS");
                }
                else
                {
                    // MessageBox.Show("Error occured while taking the database backup.", "Critical Error");

                    //log exception
                    Utility.WriteToFile(seq, "Critical Error occured while taking the database full backup.");
                    Utility.SendExceptionMail(seq, "Critical Error occured while taking the database full backup.");
                    Utility.SendCriticalErrorSMS("Critical message. \n Error occured while taking the BLS database full backup");

                    throw seq;
                }
            }         
        }

        internal void TakeDifferentialBackUp()
        {
            try
            {
                string FileName = GetPath("BLSDifferential");
                if (FileName != string.Empty)
                {
                    Backup bkpDBDifferential = new Backup();
                    /* Specify whether you want to backup database, files or log */
                    bkpDBDifferential.Action = BackupActionType.Database;
                    /* Specify the name of the database to backup */
                    bkpDBDifferential.Database = _myBLSDB.Name;
                    /* You can issue backups on several media types (disk or tape), here I am * using the File type and storing the backup on the file system */
                    bkpDBDifferential.Devices.AddDevice(FileName, DeviceType.File);
                    bkpDBDifferential.BackupSetName = "BLS database Backup";
                    bkpDBDifferential.BackupSetDescription = "BLS database - Differential Backup";
                    /* You can specify the expiration date for your backup data
                     * after that date backup data would not be relevant */
                    bkpDBDifferential.ExpirationDate = DateTime.Today.AddDays(100);

                    /* You can specify Initialize = false (default) to create a new 
                     * backup set which will be appended as last backup set on the media.
                     * You can specify Initialize = true to make the backup as the first set
                     * on the medium and to overwrite any other existing backup sets if the
                     * backup sets have expired and specified backup set name matches
                     * with the name on the medium */
                    bkpDBDifferential.Initialize = false;

                    /* You can specify Incremental = false (default) to perform full backup
                     * or Incremental = true to perform differential backup since most recent
                     * full backup */
                    bkpDBDifferential.Incremental = true;

                    /* Wiring up events for progress monitoring */
                    bkpDBDifferential.PercentComplete += CompletionStatusInPercent;
                    bkpDBDifferential.Complete += Backup_Completed;

                    /* SqlBackup method starts to take back up
                     * You cab also use SqlBackupAsync method to perform backup 
                     * operation asynchronously */
                    bkpDBDifferential.SqlBackup(_myServer);
                }
            }
            catch (SqlServerManagementException seq)
            {
                //log exception
                Utility.WriteToFile(seq, "Critical Error occured while taking the database differential backup.");
                Utility.SendExceptionMail(seq, "Critical Error occured while taking the database differential backup.");
                Utility.SendCriticalErrorSMS("Critical message. \n Error occured while taking the BLS database differential backup");

                throw seq;
            }          
        }


        internal void RestoreBackup()
        {
            try
            {
                Restore restoreDB = new Restore();
                restoreDB.Database = _myBLSDB.Name;
                /* Specify whether you want to restore database, files or log */
                restoreDB.Action = RestoreActionType.Database;
                restoreDB.Devices.AddDevice(@"D:\BLSFull\20141125\20141125.bak", DeviceType.File);

                /* You can specify ReplaceDatabase = false (default) to not create a new
                 * database, the specified database must exist on SQL Server
                 * instance. If you can specify ReplaceDatabase = true to create new
                 * database image regardless of the existence of specified database with
                 * the same name */
                restoreDB.ReplaceDatabase = true;

                /* If you have a differential or log restore after the current restore,
                 * you would need to specify NoRecovery = true, this will ensure no
                 * recovery performed and subsequent restores are allowed. It means it
                 * the database will be in a restoring state. */
                restoreDB.NoRecovery = true;

                /* Wiring up events for progress monitoring */
                restoreDB.PercentComplete += CompletionStatusInPercent;
                restoreDB.Complete += Restore_Completed;

                /* SqlRestore method starts to restore the database
                 * You can also use SqlRestoreAsync method to perform restore 
                 * operation asynchronously */
                restoreDB.SqlRestore(_myServer);
            }
            catch (SqlServerManagementException seq)
            {
                throw seq;
            }
            
        }

        private static void CompletionStatusInPercent(object sender, PercentCompleteEventArgs args)
        {
            Program.MainObj.tlsPgrs.Value = args.Percent;
        }
        private static void Backup_Completed(object sender, ServerMessageEventArgs args)
        {
            Program.MainObj.tlsPgrs.Visible = false;

        }
        private static void Restore_Completed(object sender, ServerMessageEventArgs args)
        {
            //Console.WriteLine("Hurray...Restore completed.");
            //Console.WriteLine(args.Error.Message);
        }





    }
}
