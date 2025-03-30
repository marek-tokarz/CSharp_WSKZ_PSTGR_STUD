namespace EventsExample
{
    public class MusicPlayList
    {
        public delegate bool ValidateTitle(String title);
        public delegate void SendNotification();

        private List<String> songs = new List<string>();

        public event ValidateTitle AdditionalOperationBefore;
        public event SendNotification AdditionalOperationAfter;

        public void AddSong(String title)
        {
            if(ExecuteAdditionalOperationBefore(title))
            {
                songs.Add(title);
                ExecuteAdditionalOperationAfter();
            }
        }

        private bool ExecuteAdditionalOperationBefore(String title)
        {
            if(AdditionalOperationBefore != null)
            {
                return AdditionalOperationBefore.Invoke(title);
            }

            return false;
        }

        private void ExecuteAdditionalOperationAfter()
        {
            AdditionalOperationAfter?.Invoke();
        }
    }

    public class Program
    {
        private static bool CheckSongTitle(String title)
        {
            if(title != null)
            {
                return true;
            }

            return false;
        }

        private static void SendSMS()
        {
            Console.WriteLine("SMS: new song has been added");
        }

        public static void Main()
        {
            MusicPlayList musicPlayList = new MusicPlayList();
            musicPlayList.AdditionalOperationBefore += CheckSongTitle;
            musicPlayList.AdditionalOperationAfter += SendSMS;

            musicPlayList.AddSong("Super Song");

            musicPlayList.AddSong(null);
        }
    }
}