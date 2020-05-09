using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CommingSoon.Models
{
    public static class Logger
    {
        public static Task Log(Exception ex, string extraInfo = null)
        {
            //New String Builder to hold logged text
            StringBuilder builder = new StringBuilder();
            //Append Exception
            builder.Append(ex);

            if (ex is DbEntityValidationException)
            {
                var validationException = (DbEntityValidationException)ex;

                var errorMessages = validationException.EntityValidationErrors
                                                       .SelectMany(x => x.ValidationErrors)
                                                       .Select(x => x.ErrorMessage);

                string fullErrorMessage = string.Join("\n", errorMessages);

                builder.Append("\n------- Validation Errors ----------------\n");
                builder.Append(fullErrorMessage);
            }

            //Create new reference for inner exception
            Exception innerException = ex.InnerException;

            //While the inner exception is not null
            while (innerException != null)
            {
                //Append Inner Exception
                builder.Append("\n-------- Inner Exception ---------\n");
                builder.Append(innerException);
                //Change innerException Reference to innner's inner Exception
                innerException = innerException.InnerException;
            }

            if (extraInfo != null)
            {
                builder.Append("\n-------------------------Extra Info---------------------------------\n");
                builder.Append(extraInfo);
            }

            WriteExceptionToFile(builder.ToString(), EventLogEntryType.Error);
            //Write Log Entry
            return Log(builder.ToString());

        }

        public static Task Log(string logText, EventLogEntryType logType = EventLogEntryType.Error)
        {
            //Name of Log Source
            string source = "Comming Soon";

            //Create source on Application if not exist
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, "Application");
            }

            //Write Log Entry
            return Task.Run(() =>
            {
                try
                {
                    WriteExceptionToFile(logText, logType);
                    EventLog.WriteEntry(source, logText, logType);
                }
                catch { }
            });
        }

        public static Task Info(string logText)
        {

            return Log(logText, EventLogEntryType.Information);
        }

        public static Task Warn(string logText)
        {
            return Log(logText, EventLogEntryType.Warning);
        }

        private static string CreateExceptionDirectoryIfnotExist()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + @"\Log";
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
        private static void WriteExceptionToFile(string exception, EventLogEntryType logType = EventLogEntryType.Error)
        {
            try
            {
                var directoryPath = CreateExceptionDirectoryIfnotExist();
                var fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                var fullPath = directoryPath + @"\" + fileName;
                if (File.Exists(fullPath) == false)
                {
                    var exceptionFile = File.Create(fullPath);
                    exceptionFile.Close();
                }
                using (TextWriter tw = new StreamWriter(fullPath, true))
                {
                    tw.WriteLine("------------------------------------------");
                    tw.WriteLine("\n\n\n\n------- " + logType.ToString() + " Start ----------------\n");
                    tw.WriteLine(logType.ToString() + " Date: " + DateTime.Now);
                    tw.WriteLine(exception);
                    tw.WriteLine("\n------- " + logType.ToString() + " End ----------------\n");

                    tw.Close();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}