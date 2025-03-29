using CSharp_funtions_exceptions;

namespace FunctionsAndExceptions
{
    public class Program
    {
        // Reversing array: [1, 2, 3, 4] -> [4, 3, 2, 1]
        //                   i        j
        //                      i  j
        private static double[] ReverseArray(double[] array)
        {
            int numberOfElements = array.Length;
            int i = 0;
            int j = numberOfElements - 1;

            for (int k = 0; k < numberOfElements; k++)
            {
                if (i < j)
                {
                    double index_i = array[i];
                    array[i] = array[j];
                    array[j] = index_i;
                    i++;
                    j--;
                }
            }
            return array;
        }

        // Printing a result of array reversing
        private static String CreateResultOfReverseArray(double[] array)
        {
            String result = "";
            foreach (double val in array)
            {
                result += val.ToString() + " ";
            }
            return result;
        }

        // Summing an elements af an array if they are within a specified range
        private static double SumOfElements(double[] sum, double a, double b)
        {
            double result = 0;
            foreach(double val in sum)
            {
                if(val >= a && val <= b)
                {
                    result += val;
                }
            }
            return result;
        }

        // Functions looks for a specific word (string) in an array of strings
        // ["abc", "xyz"], xyz -> 1
        // ["
        private static int FindWord(String[] words, String word)
        {
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    return i;
                }
            }
            throw new ElementNotFoundException();
        }

        private static double MathFunction(double x, double y)
        {
            if(x < 0)
            {
                throw new ArgumentException("Wrong argument 'x', value should be positive");
            }

            if (y == 0)
            {
                throw new ArgumentException("Wrong argument 'y', value can not be equal to 0");
            }

            return Math.Sqrt(x * x) + 1 / y;

        }
 
        public static void Main()
        {
            double[] test_array_1 = { 1, 2, 3, 4, 5 };
            double[] result_array_1 = ReverseArray(test_array_1);
            Console.WriteLine("Test for even number of elements of an array:");
            Console.WriteLine(CreateResultOfReverseArray(result_array_1));

            double[] test_array_2 = { 1, 2, 3, 4 };
            double[] result_array_2 = ReverseArray(test_array_2);
            Console.WriteLine("\nTest for odd number of elements of an array:");
            Console.WriteLine(CreateResultOfReverseArray(result_array_2));

            double sum1 = SumOfElements(test_array_1, 2, 4);
            Console.WriteLine("sum1: " + sum1);
            double sum2 = SumOfElements(test_array_1, 1, 3);
            Console.WriteLine("sum2: " + sum2);

            try
            {
                Console.WriteLine(test_array_2[4]);
            } catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                // return;
            } finally
            {
                // this section will be always executed - independently of an execption
                Console.WriteLine("Cleaning...");
            }

            String[] words = { "abc", "xyz", "www" };
            int index1 = FindWord(words, "www");
            Console.WriteLine("index of a found word is: " + index1);

            try
            {
                int index2 = FindWord(words, "bbb");
                Console.WriteLine("index of a found word is: " + index2);
            } catch(ElementNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                MathFunction(4.0, 0);
            } catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}