using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.writeLog();

            SmsLogger smsLogger = new();
            smsLogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.writeLog();

        }
    }
}
