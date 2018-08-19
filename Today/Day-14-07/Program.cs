using System;

namespace Day_14_07
{
    class Program
    {
        /*
        Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.
        For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.
        You can assume that the messages are decodable. For example, '001' is not allowed.
         */

        static void Main(string[] args)
        {
            GetDecode("111");
        }

        private static int GetDecode(string v)
        {
            if (v.Contains('0'))
            {
                return 0;
            }
            if (v.Length < 1)
            {
                return 1;
            }
            int currentCount = 1;
            char previousChar = v[0];

            for (int i = 1; i < v.Length; i++)
            {
                if (CheckIfMatch(previousChar, v[i]))
                {
                    previousChar = v[i];
                    currentCount++;
                }
            }

            return currentCount;
        }

        private static bool CheckIfMatch(char previousChar, char v)
        {
            int previousInt = Convert.ToInt32(previousChar.ToString());
            int currentChar = Convert.ToInt32(v.ToString());

            return ((10 * previousInt) + currentChar) <= 27;

        }
    }
}
