using System;

namespace Day_07_08
{
    class Program
    {
        /*
        You are given an array of non-negative integers that represents a two-dimensional elevation map where each element is unit-width wall and the integer is the height.
        Suppose it will rain and all spots between two walls get filled up. Compute how many units of water remain trapped on the map in O(N) time and O(1) space.
        For example, given the input [2, 1, 2], we can hold 1 unit of water in the middle.
        Given the input [3, 0, 1, 3, 0, 5], we can hold 3 units in the first index, 2 in the second, 
        and 3 in the fourth index (we cannot hold 5 since it would run off to the left), so we can trap 8 units of water.
         */

        protected static void Main(string[] args)
        {

            int[] walls = { 2, 3, 0, 1, 5, 0, 5, 6 };
            Console.WriteLine(GetTrappedWater(walls));
            
        }

        private static int GetTrappedWater(int[] walls)
        {
            if (walls.Length == 0)
                return 0;

            int firstWallSize = walls[0];
            int waterTrappedCount = 0;

            for (int i = 1; i < walls.Length; i++)
            {
                if (firstWallSize < walls[i])
                {
                    firstWallSize = walls[i];
                }

                if (firstWallSize > walls[i])
                {
                    waterTrappedCount += firstWallSize - walls[i];
                }
            }

            return waterTrappedCount;
        }
    }
}
