namespace DelegatesAndEvents
{
    public class Program
    {
        // Delegate is a reference type concerning a function
        private delegate string OneArgStringFunction(string value);

        private static string StringOperation(string word, OneArgStringFunction fun)
        {
            string temp = word.Replace('a', 'B');

            return fun(temp);

        }

        private static string UpLetters(string w)
        {
            return w.ToUpper();
        }

        private static string DownLetters(string w)
        {
            return w.ToLower();
        }

        public static void Main()
        {
            OneArgStringFunction f = new OneArgStringFunction(UpLetters);
            string result1 = StringOperation("aBac", f); 

            Console.WriteLine(result1); // BBBC

            string result2 = StringOperation("aBac", new OneArgStringFunction(DownLetters));

            Console.WriteLine(result2); // bbbc

        }
    }
}