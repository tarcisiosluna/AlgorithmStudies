using System;
using System.Linq;

namespace GoogleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 9, 9, 9, 9 };
            AddNumberToArrat(numbers).ToList().ForEach(i => Console.Write(i.ToString()));
        }

        private static int[] AddNumberToArrat(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            int carry = 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int sum = numbers[i] + carry;

                if (sum == 10)
                    carry = 1;
                else
                    carry = 0;

                result[i] = sum % 10;


            }
            if (carry == 1)
            {
                result = new int[numbers.Length + 1];
                result[0] = 1;
            }
            return result;
        }
    }
}
