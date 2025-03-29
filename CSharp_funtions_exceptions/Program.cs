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
            double[] result = new double[numberOfElements];
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

            return result;
        }

        public static void Main()
        {
            double[] test_array_1 = { 1, 2, 3, 4, 5 };

            double[] result_array_1 = ReverseArray(test_array_1);

            double[] test_array_2 = { 1, 2, 3, 4 };

            double[] result_array_2 = ReverseArray(test_array_2);

            Console.WriteLine("Test for even number of elements of an array:");

            for (int i = 0; i< result_array_1.Length; i++)
            {
                Console.WriteLine("array[" + i + "]: " + test_array_1[i]);
            }

            Console.WriteLine("\nTest for odd number of elements of an array:");

            for (int i = 0; i < result_array_2.Length; i++)
            {
                Console.WriteLine("array[" + i + "]: " + test_array_2[i]);
            }
        }
    }
}