using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryDesign_frontEndUI.Library
{
    class DBRestoreHelper
    {
        public void RestoreDatabase(string strBackUpLocation, string strDatabaseName)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                SqlCommand sqlcmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                //Mentioned Connection string make sure that user id and password sufficient previlages
                sqlcon.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];

                //Open connection
                sqlcon.Open();
                //query to take backup database
                sqlcmd = new SqlCommand("Use master; Restore database " + strDatabaseName + " from disk='" + strBackUpLocation + "\\16112014_190513.Bak'", sqlcon);
                sqlcmd.ExecuteNonQuery();
                //Close connection
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while restoring the database backup.", "Critical Error");

                //log exception
                Utility.WriteToFile(ex, "Critical Error occured while restoring the database backup.");
                Utility.SendExceptionMail(ex, "Critical Error occured while restoring the database backup.");
                Utility.SendCriticalErrorSMS("Critical message. \n Error occured while restoring the BLS database backup.");
            }
        }
    }
}
