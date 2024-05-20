using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine("Save log into file : " + message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine("Log is : " + message);
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine("Store in database : " + message);
    }

    public enum LoggerType { File,Console,Database }

    public static class LoggerFactory
    {
        public static ILogger CreateObject(LoggerType loggerType) => loggerType switch
        {
            LoggerType.File => new FileLogger(),
            LoggerType.Console => new ConsoleLogger(),
            LoggerType.Database => new DatabaseLogger(),
            _ => throw new ArgumentException("Logger type is not valid"),
        };
    }
}
