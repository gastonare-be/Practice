using System;

namespace MergeSortedArrays
{
    class Program
    {
        static int[] mergeSortedArrays(int[] arr1, int[] arr2)
        {
            // [0,3,4,31] , [4,6,30]
            // [0,3,4,4,6,30,31]

            int[] merged = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            var ItemArr1 = arr1[i];
            var ItemArr2 = arr2[j];

            while (i < arr1.Length || j < arr2.Length)
            {
                Console.WriteLine(ItemArr1 + " " + ItemArr2);
                if (ItemArr1 < ItemArr2)
                {
                    merged[k] = arr1[i];
                    ItemArr1 = arr1[i++];
                    k++;
                }

                else
                {
                    merged[k] = arr2[j];
                    ItemArr2 = arr2[j++];
                    k++;
                }
            }
            return merged;
        }



        static void Main(string[] args)
        {
            int[] array1 = { 0, 3, 4, 31 };
            int[] array2 = { 4, 6, 30 };

            mergeSortedArrays(array1, array2);
        }
    }
}
