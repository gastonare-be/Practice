using System;

namespace FirstOcurrence
{
    public class Program
    {
        public static int getFirstOcurrence(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return arr[i];
                    }
                }
            return 0;
        }


        static void Main(string[] args)
        {
            int[] arr1 = { 2, 5, 1, 2, 3, 5, 1, 2, 4 };

            int[] arr2 = { 2, 1, 1, 2, 3, 5, 1, 2, 4 };

            int[] arr3 = { 2, 3, 4, 5 };

            var res1 = getFirstOcurrence(arr1);
            Console.WriteLine(res1);

            var res2 = getFirstOcurrence(arr2);
            Console.WriteLine(res2);

            var res3 = getFirstOcurrence(arr3);
            Console.WriteLine(res3);
        }
    }
}
