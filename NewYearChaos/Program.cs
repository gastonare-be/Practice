using System;

class Solution
{

    // Complete the minimumBribes function below.
    static int minimumBribes(int[] q)
    {
        var number = q.Length;

        bool samePerson = false;
        int totalCount = 0;
        int currentCount = 0;

        for (int i = q.Length - 1; i >= 0; i--)
        {
            if (q[i] <= number)
            {
                samePerson = true;
                totalCount++;
                currentCount++;

                if (samePerson && currentCount > 2)
                {
                    return -1;
                }

            }

            else
            {
                currentCount = 0;
                samePerson = false;
            }

            number--;

        }

        return currentCount + totalCount;
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            var bribes = minimumBribes(q);

            if (bribes == -1)
            {
                Console.WriteLine("Too chaotic");
            }

            else
            {
                Console.WriteLine(bribes);
            }
        }
    }
}
