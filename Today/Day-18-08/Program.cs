using System;

namespace Day_18_08
{
    class Program
    {
        /*
            Given an array of integers where every integer occurs three times except for one integer, which only occurs once, find and return the non-duplicated integer.
        */
        static void Main(string[] args)
        {
            int[] array = {6, 1, 3, 3, 3, 6, 6};
            FindNonDuplicated(array);
        }

        private static int FindNonDuplicated(int[] array)
        {
            int result = 0;
            int[] counterArray = new int[short.MaxValue];

            for (int i = 0; i < array.Length; i++)
            {
                counterArray[array[i]] += 1;
            }

            for (int i = 0; i < counterArray.Length; i++)
            {
                if (counterArray[i] != 0 && counterArray[i] < 3)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
