using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajEnterprise
{
    class Logger
    {
        private static string _location = String.Empty;
        private static string _logfile = "nXGen_RajEnterprise.log";

        //{0} - Current Data Time, {1} - Actual Message
        private const string LOG_MESSAGE_FORMAT = "{0}: {1}";

        public static void InitializeLogger(string location)
        {
            //_logfile = String.Format("Installer_{0}.log", System.DateTime.Now.ToString("ddMMyyyy-hhmmss"));
            _location = location;
        }

        public static void InitializeLogger(string fileName, string location)
        {
            _logfile = fileName;
            _location = location;
        }
        
        public static string GetLogFilepath()
        {
            return _location + "\\" + _logfile;
        }

        private static void WriteToLog(string message)
        {
            try
            {
                string messageToLog = String.Format(LOG_MESSAGE_FORMAT, System.DateTime.Now.ToString(), message);

                StreamWriter stream = File.AppendText(_location + "\\" + _logfile);
                stream.WriteLine(messageToLog);
                stream.Close();
            }
            catch { }
        }

        public static void WriteInfoMessage(string message, params object[] args)
        {
            WriteInfoMessage(String.Format(message, args));
        }

        public static void WriteInfoMessage(string message)
        {
            WriteToLog("Information: " + message);
        }
        
        public static void WriteErrorMessage(string message, params object[] args)
        {
            WriteErrorMessage(String.Format(message, args));
        }

        public static void WriteErrorMessage(string message)
        {
            WriteToLog("Error: " + message);
        }

        public static void WriteErrorMessage(Exception ex)
        {
            string errMessage = "Exception: " + ex.Message;
            if (ex.InnerException != null)
            {
                errMessage += " InnerException: " + ex.InnerException.Message;
            }
            WriteToLog(errMessage);
        }

        public static void WriteErrorMessage(string message, Exception ex)
        {
            string errMessage = "Error: " + message + ". Exception: " + ex.Message;
            if (ex.InnerException != null)
            {
                errMessage += " InnerException: " + ex.InnerException.Message;
            }
            if (ex.StackTrace != null)
            {
                errMessage += " StackTrace: " + ex.StackTrace;
            }
            WriteToLog(errMessage);
        }
        
    }
}
