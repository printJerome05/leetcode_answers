using System.Globalization;
using System.Runtime.ExceptionServices;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{TwoSum([2, 7, 11, 15], 9)[0]} || {TwoSum([2, 7, 11, 15], 9)[1]}");
            Console.WriteLine($"{TwoSum([3, 2, 4], 6)[0]} || {TwoSum([3, 2, 4], 6)[1]}");
            Console.WriteLine($"{TwoSum([3, 3], 6)[0]} || {TwoSum([3, 3], 6)[1]}");
            Console.WriteLine($"{TwoSum([2, 5, 5, 11], 10)[0]} || {TwoSum([2, 5, 5, 11], 10)[1]}");
            Console.WriteLine($"{TwoSum([0, 4, 3, 0], 0)[0]} || {TwoSum([0, 4, 3, 0], 0)[1]}");
            Console.WriteLine($"{TwoSum([-3, 4, 3, 90], 0)[0]} || {TwoSum([-3, 4, 3, 90], 0)[1]}");
            Console.ReadKey();

        }

        private static int[] TwoSum(int[] nums, int target)
        {

            int[] resullt = { 0, 0 }; // Replace each index if value less than the target
            int index1 = 0; // Get the index of the i
            int index2 = 0; // index of j
            int sum = 0; // Sum of value1 + value2

            for (int i = 0; i < nums.Length - 1; i++)
            {

                index1 = i;

                for (int j = (i + 1); j < nums.Length; j++)
                {

                    index2 = j;
                    sum = nums[i] + nums[j];
                    if (sum == target) break;

                }

                if (sum == target) break;

            }

            resullt[0] = index1;
            resullt[1] = index2;
            return resullt;

        }

    }

}
