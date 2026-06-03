// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

//int[] nums = { 1, 2, 3, 4 };
int[] nums = { -1, 1, 0, -3, 3};

int[] result = ProductExceptSelf(nums);

for (int i = 0; i <= result.Length - 1;i++) 
{

    Console.Write($"{result[i]},");

}

Console.ReadKey();


int[] ProductExceptSelf1(int[] nums)
{
    
 int n = nums.Length;
    int[] result = new int[n];

    int zeroCount = 0;
    int totalProduct = 1;

    // First pass: calculate product and count zeros
    for (int i = 0; i < n; i++)
    {
        if (nums[i] == 0)
        {
            zeroCount++;
        }
        else
        {
            totalProduct *= nums[i];
        }
    }

    // Second pass: construct result
    for (int i = 0; i < n; i++)
    {
        if (zeroCount > 1)
        {
            result[i] = 0;
        }
        else if (zeroCount == 1)
        {
            result[i] = (nums[i] == 0) ? totalProduct : 0;
        }
        else
        {
            result[i] = totalProduct / nums[i];
        }
    }

    return result;

}


int[] ProductExceptSelf(int[] nums)
{

    // Values storage for the return
    int[] result = new int[nums.Length];
    int temp = 1; // storage for each index

    // loop for i 
    for (int i = 0; i <= nums.Length - 1; i++)
    {

        for (int j = 0; j <= nums.Length - 1; j++)
        {

            // if count i is not equals the count of the j means they dont multiple with each others
            if (i != j)
            {


                if (nums[j] != 0)
                {

                    temp *= nums[j];

                }
                else if (nums[j] == 0)
                {

                    temp = 0;
                    break;

                }

            }

            // storing the temp in the result
            result[i] = temp;
            // trnucate the temp back to 1
            temp = 1;

        }

    }

    return result;
            
}