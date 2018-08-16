using System;

namespace Day_09_07
{
    class Program
    {
        /*
            Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
            or example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].
            Follow-up: what if you can't use division?
        */
        static void Main(string[] args)
        {
            int[] input = { 3,2,1 };
            int[] prefixArray = GetPrefixArray(input);
            int[] sufixArray = GetSufixArray(input);
            int[] finalArray = SolveFinalArray(prefixArray, sufixArray);
        }

        private static int[] SolveFinalArray(int[] prefixArray, int[] sufixArray)
        {
            int[] result = new int[prefixArray.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (prefixArray[i] != 0 && sufixArray[i] != 0)
                {
                    result[i] = prefixArray[i] * sufixArray[i];
                }
                else{
                    result[i] = prefixArray[i] + sufixArray[i];
                }
            }
            return result;
        }

        private static int[] GetSufixArray(int[] input)
        {
            int[] result = new int[input.Length];
            result[input.Length - 2] = input[input.Length -1];
            int currentSum = result[input.Length - 2];

            for (int i = input.Length - 2; i >= 1; i--)
            {
                currentSum *= input[i];
                result[i-1] = currentSum;
            }
            return result;
        }

        private static int[] GetPrefixArray(int[] input)
        {
            int[] result = new int[input.Length];
            result[1] = input[0];
            int currentSum = result[1];
            for (int i = 2; i < input.Length; i++)
            {
                currentSum *= input[i-1];
                result[i] = currentSum;
            }
            return result;
        }
    }
}
