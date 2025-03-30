namespace DelegatesAndEvents
{
    public class Delegates
    {
        // Delegate is a reference type concerning a function

        private static double globalResult = 0;

        private delegate void TwoArgFun(double x, double y);

        private delegate string TwoStringArgFun(string word1, string word2);

        private delegate string OneArgStringFunction(string value);
        private static void sum(double a, double b)
        {
            globalResult += a + b;
        }

        private static void multiply(double a, double b)
        {
            globalResult += a * b;
        }

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

        private static string Converter(string word1, string word2, TwoStringArgFun fun)
        {
            return word1 + '-' + word2 + '-' + fun(word1, word2);
        }

        private static string ToLowerJoinToUpper(string word1, string word2)
        {
            return word1.ToLower() + word2.ToUpper();
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

            Console.WriteLine(Converter("ABC", "def", new TwoStringArgFun(ToLowerJoinToUpper)));
            // ABC - def - abcDEF

        }
    }
}