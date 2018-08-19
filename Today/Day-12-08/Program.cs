using System;

namespace Day_12_08
{
    class Program
    {
        /*
        Given an array of strictly the characters 'R', 'G', and 'B', segregate the values of the array so that all the Rs come first, the Gs come second, and the Bs come last. 
        You can only swap elements of the array. Do this in linear time and in-place.
        For example, given the array ['G', 'B', 'R', 'R', 'B', 'R', 'G'], it should become ['R', 'R', 'R', 'G', 'G', 'B', 'B'].
        */

        static char[] input = {'G', 'B', 'R', 'R', 'B', 'R', 'R', 'G'};

        static void Main(string[] args)
        {
            int lastRIndex = 0;
            int lastBIndex = input.Length -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'R' && input[lastRIndex] != 'R')
                {
                    SawpElements(i, lastRIndex);
                    lastRIndex++;
                    i--;
                }
                else if (input[i] == 'B' && input[lastBIndex] != 'B' && i < lastBIndex)
                {
                    SawpElements(i, lastBIndex);
                    lastBIndex--;
                    i--;
                }
            }
        }

        static void SawpElements(int oldPosition, int newPosition)
        {
            char temp = input[newPosition];
            input[newPosition] = input[oldPosition];
            input[oldPosition] = temp;
        }
    }
}
