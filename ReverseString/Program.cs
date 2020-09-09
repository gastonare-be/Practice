using System;

namespace ReverseString
{
    class Program
    {
        static char[] reverseArray(char[] originalArray)
        {
            char[] reverseArray = new char[originalArray.Length];
            var indexArray = 0;

            for (int i = originalArray.Length - 1; i >= 0; i--)
            {
                reverseArray[indexArray] += originalArray[i];
                indexArray++;
            };

            return reverseArray;
        }


        static void Main(string[] args)
        {
            string original = "vanhack";
            var originalArray = original.ToCharArray();

            var result = reverseArray(originalArray);
            Console.Write(result);
        }
    }
}
