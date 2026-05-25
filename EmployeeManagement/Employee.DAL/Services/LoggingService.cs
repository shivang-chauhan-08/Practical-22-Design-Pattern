using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.DAL.Services
{
    public class LoggingService
    {
        private static LoggingService instance;
        private static readonly object lockObj = new object();

        private LoggingService()
        {
            Console.WriteLine("Logging Service Instance Created");
        }

        public static LoggingService GetInstance()
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    return new LoggingService();
                }
                return instance;
            }
        }

        public void Log(string msg)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now} : {msg}\n");
        }
    }
}
