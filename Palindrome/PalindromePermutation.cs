using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public class PalindromePermutation
    {
        public int checkPalindrome(string word)
        {
            Dictionary<int, string> words = new Dictionary<int, string>();

            var sum = 0;
            var lenght = words.Count;

            words.Add(0, "c");
            words.Add(1, "i");
            words.Add(2, "v");
            words.Add(3, "i");
            words.Add(4, "c");

            foreach (var item in words)
            {
                if (item.Value[0] == item.Value[4] && item.Value[1] == item.Value[3])
                {
                    return 1;
                }
            }

            return sum;
        }

    };
}
