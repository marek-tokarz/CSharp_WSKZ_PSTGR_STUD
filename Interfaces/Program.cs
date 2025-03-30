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

    public class Program
    {
        private static void archData(IBackup backup)
        {
            Console.WriteLine("archData started");
            backup.CopyData("source1", "source2");
        }
        public static void Main()
        {
            IBackup backup = new DbTableBackup();
            archData(backup);
            backup.defaultMethod();
            archData(new FileBackup());
        }
    }
}