namespace Interfaces
{
    public interface IBackup
    {
        void CopyData(string from, string to);
        void defaultMethod()
        {
            Console.WriteLine("Default implementation");
        }
    }

    public class FileBackup : IBackup
    {
        public void CopyData(string from, string to)
        {
            Console.WriteLine("Copying file from {0} to {1}", from, to);
        }
    }

    public class DbTableBackup : IBackup
    {
        public void CopyData(string from, string to)
        {
            Console.WriteLine("Copying table from {0} to {1}", from, to);
        }
    }

    public interface ILogger
    {
        void LogInfo(String message);
        void LogError(String message);
    }

    public class FileLogger: ILogger
    {
        public void LogInfo(String message)
        {
            Console.WriteLine("FileLogger, Info, {0}, {1}", DateTime.Now.ToString("dddd, dd MMMM yyyy"), message);
        }

        public void LogError(String message)
        {
            Console.WriteLine("FileLogger, Error, {0}, {1}", DateTime.Now.ToString("dddd, dd MMMM yyyy"), message);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void LogInfo(String message)
        {
            Console.WriteLine("ConsoleLogger, Info, {0}, {1}", DateTime.Now.ToString("dddd, dd MMMM yyyy"), message);
        }

        public void LogError(String message)
        {
            Console.WriteLine("ConsoleLogger, Error, {0}, {1}", DateTime.Now.ToString("dddd, dd MMMM yyyy"), message);
        }
    }

    public class Program
    {
        private static ILogger logger;
        private static ILogger logger_console;
        

        private static void archData(IBackup backup)
        {
            Console.WriteLine("archData started");
            backup.CopyData("source1", "source2");
        }
        public static void Main()
        {
            logger = new FileLogger();

            logger.LogInfo("application has been started");

            IBackup backup = new DbTableBackup();
            archData(backup);
            backup.defaultMethod();
            archData(new FileBackup());

            logger_console = new ConsoleLogger();
            logger_console.LogInfo("application is saving file to the harddrive");
            logger_console.LogInfo("application has finished");
        }
    }
}