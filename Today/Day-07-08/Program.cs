using System;

namespace Day_07_08
{
    class Program
    {
        protected static void Main(string[] args)
        {
            int[] walls = {2, 3, 0, 1, 5, 0, 5, 6 };
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
