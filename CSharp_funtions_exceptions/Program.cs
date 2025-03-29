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
            double[] test_array = { 1, 2, 3, 4, 5 };

            double[] result_array = ReverseArray(test_array);

            for(int i = 0; i< result_array.Length; i++)
            {
                Console.WriteLine("array[" + i + "]: " + test_array[i]);
            }
           
        }



    }
}