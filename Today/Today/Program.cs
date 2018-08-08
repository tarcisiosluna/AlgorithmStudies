using System;
using System.Collections.Generic;
using System.Text;

namespace Today
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DecodeString("4A3B2C1D2A");
            string[] vs = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            FormatString(vs, 10);


        }

        private static void FormatString(string[] values, int size)
        {
            byte[] counter = new byte[values.Length];
            StringBuilder stringBuilder = new StringBuilder();
            List<string> result = new List<string>();

            for (int i = 0; i < values.Length; i++)
            {
                counter[i] = Convert.ToByte(values[i].Length);
            }

            int currentAmount = counter[0];
            int currentIndex = 0;

            for (int i = 0; i < counter.Length; i++)
            {
                currentAmount += 1;
                if (currentAmount <= size)
                {
                    currentAmount += counter[i];
                }
                else
                {
                    for (int j = currentIndex; j < i; j++)
                    {
                        stringBuilder.Append(values[j]);
                    }
                    result.Add(stringBuilder.ToString());
                    currentIndex = i;
                }
            }
        }

        private static void DecodeString(string stringToDecode)
        {
            StringBuilder finalString = new StringBuilder();
            for (int i = 0; i < stringToDecode.Length - 1; i += 2)
            {
                for (int j = 0; j < Convert.ToInt32(stringToDecode[i].ToString()); j++)
                {
                    finalString.Append(stringToDecode[i + 1]);
                }
            }
        }

        private static void EncodeString(string stringToEncode)
        {
            StringBuilder finalString = new StringBuilder();
            short counter = 1;
            char lastChar = stringToEncode[0];
            for (int i = 1; i < stringToEncode.Length; i++)
            {
                if (lastChar == stringToEncode[i])
                {
                    counter++;
                }
                else
                {
                    finalString.Append(counter).Append(lastChar);
                    lastChar = stringToEncode[i];
                    counter = 1;
                }
            }
            finalString.Append(counter).Append(stringToEncode[stringToEncode.Length - 1]);
        }


        public static string Encode(string str)
        {
            StringBuilder encoding = new StringBuilder();
            short count;

            for (int i = 0; i < str.Length; i++)
            {
                count = 1;
                while (i + 1 < str.Length && str[i] == str[i + 1])
                {
                    count++;
                    i++;
                }

                encoding.Append(count).Append(str[i]);
            }

            return encoding.ToString();
        }

    }
}
