﻿ 
namespace Business.CCS
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
}
