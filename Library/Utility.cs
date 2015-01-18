using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.SqlServer;
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using SmsClient;
using ASPSnippets.SmsAPI;
using System.Net;


namespace LibraryDesign_frontEndUI.Library
{

    public class Utility
    {       
        
        public enum CustomerType
        {
            Rental,
            NonRental,
            Other
        }

        /// <summary>
        /// Writes exception details to file
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="strMessage"></param>
        public static void WriteToFile(Exception ex, string strMessage = null)
        {
            StringBuilder sbMsg = null;
            try
            {
                string strPath = ConfigurationSettings.AppSettings["LogDirectoryPath"];

                if (strPath == null)
                {
                    strPath = AppDomain.CurrentDomain.BaseDirectory;

                    strPath = Path.Combine(strPath, "BLSLogs");

                    if (!Directory.Exists(strPath))
                    {
                        Directory.CreateDirectory(strPath);
                    }
                }
                else
                {
                    if (!Directory.Exists(strPath))
                    {
                        Directory.CreateDirectory(strPath);
                    }
                }
                string strLogFile = Path.Combine(strPath, DateTime.Today.ToString("yyMMdd") + ".log");

                sbMsg = new StringBuilder();

                //Log error messages to be highlighted in the log file
                if (ex != null)
                {
                    sbMsg.Append("########################################### ERROR #########################################" +
                    Environment.NewLine + "Log Date : " + DateTime.Now + Environment.NewLine
                                        + strMessage + Environment.NewLine
                                        + "Additional Info :" + Environment.NewLine + ex.Message + Environment.NewLine
                                        + ex.StackTrace + Environment.NewLine);

                    if (ex.InnerException != null)
                    {
                        sbMsg.Append("Inner Exception :" + Environment.NewLine + ex.InnerException.Message + Environment.NewLine +
                                       ex.InnerException.Source + Environment.NewLine + ex.InnerException.StackTrace + Environment.NewLine);
                    }
                    sbMsg.Append("###########################################################################################");
                }
                sbMsg.Append(Environment.NewLine + Environment.NewLine);

                //Write to file
                File.AppendAllText(strLogFile, sbMsg.ToString());
                sbMsg = null;
            }
            catch (Exception wex)
            {
                //Do nothing                
            }
        }


        public static void RegistrationSuccessEmail(string strToEmailAddress, string strMembershipNo, string strRecieptNo, string strAmountPaid, string strRegistrationDate, string strMembershipFee, CustomerType type)
        {
            MailMessage mailMsg = null;
            try
            {
                if (string.IsNullOrWhiteSpace(strToEmailAddress)) return;

                StringBuilder sbAddInfo = new StringBuilder();
                sbAddInfo.Append("<html><body><table cellspacing=\"0\" cellpadding=\"5\" border=\"0\"><tr><td colspan=\"2\" height=\"18\" valign=\"top\"><font color=\"red\"><u><b><i>Please, do not reply to this email.</i></b></u></font></td></tr>");

                sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\">Dear Customer,</td><td align=\"left\" valign=\"top\"><i>");
                sbAddInfo.Append("</td></tr>");
                sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\">Thank you for registering with Treasure Island. Your registration details are as follows.</td><td align=\"left\" valign=\"top\"><i>");
                sbAddInfo.Append("</td></tr>");

                sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\"><i>MemberShip Number : </i>");
                sbAddInfo.Append(strMembershipNo);
                sbAddInfo.Append("</td></tr>");

                if (type == CustomerType.Rental)
                {
                    sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\"><i>Recipt Number : </i>");
                    sbAddInfo.Append(strRecieptNo);
                    sbAddInfo.Append("</td></tr>");

                    sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\"><i>Amount Paid : </i>");
                    sbAddInfo.Append(strAmountPaid);
                    sbAddInfo.Append("</td></tr>");
                }
                else if (type == CustomerType.NonRental || type == CustomerType.Other)
                {
                    sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\"><i>Membership Fee : </i>");
                    sbAddInfo.Append(strMembershipFee);
                    sbAddInfo.Append("</td></tr>");
                }

                sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\"><i>Registration date : </i>");
                sbAddInfo.Append(strRegistrationDate);
                sbAddInfo.Append("</td></tr>");

                sbAddInfo.Append("</table></body></html>");

                SendEmail(sbAddInfo.ToString(), "Treasure Island Registration details", strToEmailAddress);

                mailMsg = null;
            }
            catch
            {
                if (mailMsg != null)
                {
                    mailMsg.Dispose();
                    mailMsg = null;
                }
            }
        }

        /// <summary>
        /// Send exception mail
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="strMessage"></param>
        public static void SendExceptionMail(Exception ex, string strMessage = null)
        {
            MailMessage mailMsg = null;
            try
            {
                string strToEmailAddress = "";

                if (ConfigurationSettings.AppSettings["ToErrorEmailAddress"] != null)
                {
                    strToEmailAddress = ConfigurationSettings.AppSettings["ToErrorEmailAddress"];
                }

                if (string.IsNullOrWhiteSpace(strToEmailAddress)) return;

                StringBuilder sbAddInfo = new StringBuilder();
                sbAddInfo.Append("<html><body><table cellspacing=\"0\" cellpadding=\"5\" border=\"0\"><tr><td colspan=\"2\" height=\"18\" valign=\"top\"><font color=\"red\"><u><b><i>Please, do not reply to this email.</i></b></u></font></td></tr><tr><td colspan=\"2\"><b><i><u>Error Info</u></i></b></td></tr>");
                sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\"><i>Source:</i></td><td align=\"left\" valign=\"top\"><i>");
                sbAddInfo.Append(ex.Source);
                sbAddInfo.Append("</td></tr>");
                sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\" nowrap><i>Description:</i></td><td align=\"left\" valign=\"top\"><i>");
                sbAddInfo.Append(ex.Message);
                sbAddInfo.Append("</i></td></tr>");
                sbAddInfo.Append("<tr><td align=\"left\" valign=\"top\"><i>Stack Trace:</i></td><td align=\"left\" valign=\"top\"><i>");
                sbAddInfo.Append(ex.StackTrace);
                sbAddInfo.Append("</i></td></tr>");

                if (!string.IsNullOrWhiteSpace(strMessage))
                {
                    sbAddInfo.Append("<tr><td colspan='2' align='left'><b><u>Additional Info :</u></b></td></tr>");
                    sbAddInfo.Append("<tr><td colspan='2' align=\"left\" nowrap=\"nowrap\" valign=\"top\"><i>" + strMessage + " :</i></td><td align=\"left\" valign=\"top\"><i>");
                    sbAddInfo.Append("</i></td></tr>");
                }

                sbAddInfo.Append("<tr><td align=\"left\" nowrap=\"nowrap\" valign=\"top\"><i>UTC DateTime:</i></td><td align=\"left\" valign=\"top\"><i>");
                sbAddInfo.Append(DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToLongTimeString());
                sbAddInfo.Append("</td></tr>");
                sbAddInfo.Append("</table></body></html>");

                SendEmail(sbAddInfo.ToString(), "BLS Error", strToEmailAddress);

                mailMsg = null;
            }
            catch
            {
                if (mailMsg != null)
                {
                    mailMsg.Dispose();
                    mailMsg = null;
                }
            }
        }

        /// <summary>
        /// Send mail
        /// </summary>
        /// <param name="strMessageBody"></param>
        /// <param name="strSubject"></param>
        /// <param name="strToEmailAddress"></param>
        public static void SendEmail(string strMessageBody, string strSubject, string strToEmailAddress)
        {
            MailMessage mailMsg = null;
            try
            {
                string strFromEmailAddress = "";

                strFromEmailAddress = string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["FromErrorEmailAddress"]) ?
                    "silvercordtechnologies@gmail.com" : ConfigurationSettings.AppSettings["FromErrorEmailAddress"];

                if (string.IsNullOrWhiteSpace(strToEmailAddress)) return;

                SmtpClient smtpClient = new SmtpClient();
                mailMsg = new MailMessage(strFromEmailAddress, strToEmailAddress);
                mailMsg.Subject = strSubject;
                mailMsg.Body = strMessageBody;
                mailMsg.IsBodyHtml = true;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMsg);
                mailMsg.Dispose();
                mailMsg = null;
            }
            catch
            {
                if (mailMsg != null)
                {
                    mailMsg.Dispose();
                    mailMsg = null;
                }
            }
        }

        public static void SendSMS(string strMessage, string strMobileNumber)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["MashapeKey"]) ||
                    string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["Site2SMSUserName"]) ||
                    string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["Site2SMSPwd"]))
                {
                    return;
                }

                SMS.APIType = SMSGateway.Site2SMS;
                SMS.MashapeKey = ConfigurationSettings.AppSettings["MashapeKey"];
                SMS.Username = ConfigurationSettings.AppSettings["Site2SMSUserName"];
                SMS.Password = ConfigurationSettings.AppSettings["Site2SMSPwd"];
                //Single SMS
                SMS.SendSms(strMobileNumber, strMessage);
                
            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }

        /// <summary>
        /// Send critical error through sms
        /// </summary>
        /// <param name="strMessage"></param>
        public static void SendCriticalErrorSMS(string strMessage)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["MashapeKey"]) ||
                    string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["Site2SMSUserName"]) ||
                    string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["Site2SMSPwd"]))
                {
                    return;
                }

                SMS.APIType = SMSGateway.Site2SMS;
                SMS.MashapeKey = ConfigurationSettings.AppSettings["MashapeKey"];
                SMS.Username = ConfigurationSettings.AppSettings["Site2SMSUserName"];
                SMS.Password = ConfigurationSettings.AppSettings["Site2SMSPwd"];

                string strMobileNumber = (string.IsNullOrWhiteSpace(ConfigurationSettings.AppSettings["AdminMobileNumber"])) ? "9535259359":ConfigurationSettings.AppSettings["AdminMobileNumber"];

                //Single SMS
                SMS.SendSms(strMobileNumber, strMessage);

            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }

        public static void BackupBLSDataBase()
        {
            try
            {
                string strBackUpLocation = ConfigurationSettings.AppSettings["BackUpLocation"];

                if (string.IsNullOrWhiteSpace(strBackUpLocation))
                {
                    strBackUpLocation = AppDomain.CurrentDomain.BaseDirectory;

                    strBackUpLocation = Path.Combine(strBackUpLocation, "BLSDbBackup");

                    if (!Directory.Exists(strBackUpLocation))
                    {
                        Directory.CreateDirectory(strBackUpLocation);
                    }
                }
                else
                {
                    if (!Directory.Exists(strBackUpLocation))
                    {
                        Directory.CreateDirectory(strBackUpLocation);
                    }
                }

                DbBackUpHelper backup = new DbBackUpHelper();
                backup.BackUpDatabase(strBackUpLocation, "BLS");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured while taking the database backup.", "Critical Error");

                //log exception
                Utility.WriteToFile(ex, "Critical Error occured while taking the database backup.");
                Utility.SendExceptionMail(ex, "Critical Error occured while taking the database backup.");
                Utility.SendCriticalErrorSMS("Critical message. \n Error occured while taking the BLS database backup");
            }
        }
        
        public static void RestoreBLSDatabse()
        {
            try
            {
                string strBackUpLocation = ConfigurationSettings.AppSettings["BackUpLocation"];

                if (string.IsNullOrWhiteSpace(strBackUpLocation))
                {
                    strBackUpLocation = AppDomain.CurrentDomain.BaseDirectory;
                    strBackUpLocation = Path.Combine(strBackUpLocation, "BLSDbBackup");                  
                }

                DBRestoreHelper restoreHelper = new DBRestoreHelper();
                restoreHelper.RestoreDatabase(strBackUpLocation, "BLS");
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
