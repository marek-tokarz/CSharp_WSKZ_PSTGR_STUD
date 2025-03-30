namespace DelegatesAndEvents
{
    public class Program
    {
        private static double globalResult = 0;

        private delegate void TwoArgFun(double x, double y);

        private static void sum(double a, double b)
        {
            globalResult += a + b;
        }

        private static void multiply(double a, double b)
        {
            globalResult += a * b;
        }

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
            // single-cast delegate

            OneArgStringFunction function1 = new OneArgStringFunction(UpLetters);
            string result1 = StringOperation("aBac", function1); 

            Console.WriteLine(result1); // BBBC

            string result2 = StringOperation("aBac", new OneArgStringFunction(DownLetters));

            Console.WriteLine(result2); // bbbc

            // multicast delegate

            TwoArgFun function2 = new TwoArgFun(sum);
            TwoArgFun function3 = new TwoArgFun(multiply);

            TwoArgFun functions = function2;
            functions += function3;

            functions(2, 3);

            Console.WriteLine("globalResult: " + globalResult);

        }
    }
}