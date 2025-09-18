using System;
using System.Collections.Generic;
using System.Text;

namespace _1___Single_Responsibility_Principle__SRP_.Login_Service
{
    internal class LogginDemo
    {

        private class FileLogService
        {
            public static void Log(string message)
            {
                Console.WriteLine($"\nLog to file: {message}");
            }

        }


        private class EventLogService
        {
            public static void Log(string message)
            {
                Console.WriteLine($"\nLog to Event Log: {message}");
            }

        }


        private class DataBaseLogService
        {
            public  static void Log(string message)
            {
                Console.WriteLine($"\nLog to Database: {message}");
            }

        }
            
        private class LoggingService
        {
            public enum enLoggingType { ToFile , ToEventLog , ToDatabase }

            public void Log(string message, enLoggingType LoggingType)
            {

                if (LoggingType == enLoggingType.ToFile)
                {
                    FileLogService.Log(message);
                }
                else if (LoggingType == enLoggingType.ToEventLog)
                {
                    EventLogService.Log(message);
                }
                else if (LoggingType == enLoggingType.ToDatabase)
                {
                    DataBaseLogService.Log(message);
                }
            }
        }



        public static void RunLogginService()
        {

            LoggingService LoggingService = new LoggingService();

            // Log to File
            LoggingService.Log("file.txt", LoggingService.enLoggingType.ToFile);

            // Log to Event Log
            LoggingService.Log("Event ", LoggingService.enLoggingType.ToEventLog);

            // Log to Database
            LoggingService.Log("DB2", LoggingService.enLoggingType.ToDatabase);

        }

    }
}
