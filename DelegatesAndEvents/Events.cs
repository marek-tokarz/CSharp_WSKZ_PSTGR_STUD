namespace DelegatesAndEvents
{
    public class DataMigrator
    {
        public delegate void Notification();
        public event Notification migrationStarted;

        public void ExecuteDataMigration()
        {
            OnDataMigrationStarted();   // a notofication will be send before migration

            Console.WriteLine("Data migration in progress");

            OnDataMigrationCompleted(); // another logic after finishing migration
        }

        private void OnDataMigrationStarted()
        {
            migrationStarted?.Invoke();
        }

        private void OnDataMigrationCompleted()
        {

        }

    }
    class Events
    {
        private static void SendEmail()
        {
            Console.WriteLine("Email: data migration has been started");
        }

        private static void SendSlackNotification()
        {
            Console.WriteLine("Slack: data migration has been started");
        }
        public static void Main()
        {
            DataMigrator dataMigrator = new DataMigrator();
            dataMigrator.migrationStarted += SendEmail;
            dataMigrator.migrationStarted += SendSlackNotification;
            dataMigrator.ExecuteDataMigration();

        }


    }
}
