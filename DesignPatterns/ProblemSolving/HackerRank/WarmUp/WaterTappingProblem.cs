using System;
using System.Linq;

namespace ProblemSolving.HackerRank.WarmUp
{
    public class WaterTappingProblem
    {
        public int GetStoredWater(int[] waterTappedArray)
        {
            Console.WriteLine("Algo is : element = min( max_left, max_right) – arr[i] ");
            // Validate water tapped array.
            if (waterTappedArray?.Length == 0)
            {
                return 0;
            }

            // Validate the walls.
            if (waterTappedArray.Length < 3)
            {
                return 0;
            }

            // Validate width.
            if (waterTappedArray.Any(x => x == 0) == false)
            {
                return 0;
            }
            return CalculateWaterVolume(waterTappedArray);
        }

        private int CalculateWaterVolume(int[] waterTappedArray)
        {
            //|     |
            //|_|_ _|

            int volume = 0;
            var right = 0;
            var left = 0;

            for (int i = 1; i < waterTappedArray.Length - 1; i++)
            {
                // Find left maximum.
                for (int j = 0; j < i; j++)
                {
                    left = Math.Max(waterTappedArray[j], left);
                }

                // Find right maximum.
                for (int j = i + 1; j < waterTappedArray.Length; j++)
                {
                    right = Math.Max(right, waterTappedArray[j]);
                }

                volume += Math.Min(right, left) - waterTappedArray[i];
            }

            return volume;
        }

        private int CalculateWaterVolume2(int[] waterTappedArray)
        {
            //   |  |
            //_|_|__|

            int volume = 0;
            var right = 0;
            var left = 0;
            var width = 0;

            foreach (var height in waterTappedArray)
            {
                if (left == 0 && height == 0)
                {
                    continue;
                }

                if (left == 0 && height > 0)
                {
                    left = height;
                    continue;
                }

                if (left > 0 && height == 0)
                {
                    width++;
                    continue;
                }

                if (left > 0 && height > 0 && width == 0)
                {
                    left = height;
                    continue;
                }

                if (left > 0 && height > 0 && width > 0)
                {
                    if (height > right)
                    {
                        right = height;
                    }
                    continue;
                }

                if (left > 0 && right > 0 && height > 0)
                {
                }
            }

            return volume;
        }
    }
}