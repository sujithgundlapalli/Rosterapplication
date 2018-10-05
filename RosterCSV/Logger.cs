using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterCSV
{
    public class Logger
    {
        #region Variables Declaration
        private string errtype;
        private string strErrorMessage;
        private string message;
        private Exception exception;

        #endregion

        static Object publish = "Publishing Object for Locking";
        static Object publishInfo = "Publishing Info Object for Locking";
        public Logger(string type, string msg)
        {
            errtype = type;
            message = msg;
        }

        public Logger(Exception ex, string errorMessage)
        {
            strErrorMessage = errorMessage;
            exception = (Exception)ex;
        }
        public virtual void PublishError()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                lock (Logger.publish)
                {
                    //string date = (String.Format("{0:d}", DateTime.Now)).Replace("/", "");
                    string date = DateTime.Now.ToString("MM-dd-yyyy");
                    string Location = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

                    string filename = Location + @"\RosterCSVLog_" + date + ".log";
                    // Create StringBuilder to maintain publishing information.
                    StringBuilder strInfo = new StringBuilder();
                    strInfo.AppendFormat("{0}", Environment.NewLine);
                    strInfo.AppendFormat("{0}******************** Entry Time : " + DateTime.Now.ToString() + " ******************** ", Environment.NewLine);
                    if (exception != null)
                    {
                        strInfo.AppendFormat("{0}Exception Information : {1}", Environment.NewLine, exception.Message.ToString());
                        if ((strErrorMessage != string.Empty) && (strErrorMessage != "Error"))
                            strInfo.AppendFormat("{0}SQL Query : {1}", Environment.NewLine, strErrorMessage);
                        strInfo.AppendFormat("{0}Stack Trace : {1}", Environment.NewLine, exception.StackTrace);
                    }
                    else
                    {
                        strInfo.AppendFormat("{0}Exception Information : {1}", Environment.NewLine, message);
                    }

                    // Write the entry to the event log.                      
                    if (!File.Exists(filename))
                    {
                        //System.Security.AccessControl.FileSecurity obFs = new System.Security.AccessControl.FileSecurity(filename, System.Security.AccessControl.AccessControlSections.All);
                        fs = File.Create(filename, 2048, FileOptions.None);
                    }
                    else
                        fs = File.Open(filename, FileMode.Append, FileAccess.Write);

                    sw = new StreamWriter(fs);
                    sw.Write(strInfo.ToString());
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sw.Close();
                //dispose for memory
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }

        }
        public virtual void PublishInfo()
        {
            StreamWriter sw = null;
            FileStream fs = null;
            try
            {

                //string date = (String.Format("{0:d}", DateTime.Now)).Replace("/", "");
                string date = DateTime.Now.ToString();//DateTime.Now.ToString("MM-dd-yyyy");
                string Location = AppDomain.CurrentDomain.BaseDirectory + "\\";
                DirectoryInfo dInfo = new DirectoryInfo(Location);
                string filename = Location + "RosterCSVLog_" + date + ".log";
                // Create StringBuilder to maintain publishing information.
                StringBuilder strInfo = new StringBuilder();
                strInfo.AppendFormat(DateTime.Now.ToString() + "  : " + message + Environment.NewLine);
                // Write the entry to the event log.  

                if (!File.Exists(filename))
                {
                    //System.Security.AccessControl.FileSecurity obFs = new System.Security.AccessControl.FileSecurity(filename, System.Security.AccessControl.AccessControlSections.All);
                    fs = File.Create(filename, 2048, FileOptions.None);
                }
                else
                    fs = File.Open(filename, FileMode.Append, FileAccess.Write);

                sw = new StreamWriter(fs);
                sw.Write(strInfo.ToString());

            }
            catch (Exception ex)
            {

            }
            finally
            {
                sw.Close();
                //dispose for memory
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }

        }
    }
}
