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

        // Printing a result array
        private static void PrintArray(double[] array)
        {
            foreach( double val in array)
            {
                Console.WriteLine(val);
            }
        }

        public static void Main()
        {
            double[] test_array_1 = { 1, 2, 3, 4, 5 };
            double[] result_array_1 = ReverseArray(test_array_1);
            Console.WriteLine("Test for even number of elements of an array:");
            PrintArray(result_array_1);

            double[] test_array_2 = { 1, 2, 3, 4 };
            double[] result_array_2 = ReverseArray(test_array_2);
            Console.WriteLine("\nTest for odd number of elements of an array:");
            PrintArray(result_array_2);
        }
    }
}