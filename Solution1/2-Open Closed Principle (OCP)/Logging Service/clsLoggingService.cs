using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _2_Open_Closed_Principle__OCP_.Logging_Service
{
    internal class clsLoggingService
    {
        public interface ILoggin
        {
            void Log(string message);
        }

        public class FileLogginService : ILoggin
        {
            public void Log(string message) => Console.WriteLine($"\nLog to file: {message}");
        }

        public class EventLogginService : ILoggin
        {
            public void Log(string message) => Console.WriteLine($"\nLog to Event Log: {message}");
        }

        public class DataBaseLogginService : ILoggin
        {
            public void Log(string message) => Console.WriteLine($"\nLog to Database: {message}");
        }

        public class CloudLogginService : ILoggin
        {
            public void Log(string message) => Console.WriteLine($"\nLog to Cloud: {message}");
        }

        public class ConsoleLogginService : ILoggin
        {
            public void Log(string message) => Console.WriteLine($"\nLog to Console: {message}");
        }

        public class LoggingService
        {
            private readonly ILoggin _log;

            public LoggingService(ILoggin log)
            {
                _log = log;
            }

            public void Log(string message)
            {
                _log.Log(message);
            }
        }


        public static void LoggingServiceDemo()
        {

            LoggingService fileLogger = new LoggingService(new FileLogginService());
            fileLogger.Log("This is a file log message.");


            LoggingService eventLogger = new LoggingService(new EventLogginService());
            eventLogger.Log("This is an event log message.");


            LoggingService dbLogger = new LoggingService(new DataBaseLogginService());
            dbLogger.Log("This is a database log message.");


            LoggingService cloudLogger = new LoggingService(new CloudLogginService());
            cloudLogger.Log("This is a cloud log message.");


            LoggingService consoleLogger = new LoggingService(new ConsoleLogginService());
            consoleLogger.Log("This is a console log message.");
        }


    }
}
