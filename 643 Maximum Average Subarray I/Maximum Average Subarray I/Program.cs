// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Hello, World!");
int[] nums = [1, 12, -5, -6, 50, 3];
Console.WriteLine(FindMaxAverage5(nums, 4)); // should be 12.75000

int[] nums1 = [5];
Console.WriteLine(FindMaxAverage5(nums1, 1)); // should be 5.00000

int[] nums2 = [0, 1, 1, 3, 3];
Console.WriteLine(FindMaxAverage5(nums2,4)); // should be 2.00000

int[] nums3 = [0,4,0,3,2];
Console.WriteLine(FindMaxAverage5(nums3,1)); // should be 1

Console.ReadKey();

double FindMaxAverage5(int[] nums, int k)
{

    double result = 0.00;

    if(nums.Length == -1) return 0;

     nums = nums.OrderDescending().Take(k + 1).ToArray();
     //nums = nums.Take(k).ToArray();

    for (int j = 0; j < nums.Length - 1;j++)
    {
        
       // Console.WriteLine(nums[j]);
          result += nums[j];

    }
    
    result = result / k;
    return result;    

};


double FindMaxAverage4(int[] nums, int k)
{

    if (nums == null || nums.Length < k)
        return 0;

    double maxAverage = double.MinValue;
    int i = 0;

    double sum = 0;

    for (i = 0; i < k; i++)
    {

        sum += nums[i];

    }

    maxAverage = sum / k;

    i = 1;

    if (i + k > nums.Length)
        return maxAverage;

    for (i = 1; i <= nums.Length - k; i++)
    {

        sum = nums[i];

        for (int y = i + 1; y < i + k; y++)
        {

            sum += nums[y];

        }

        double result = sum / k;

        if (result > maxAverage)
            maxAverage = result;


    }

    //while (i <= nums.Length - k)
    //{

        sum = nums[i];


        //while (y < i + k)
        //{
            

        //}


        //i++;


    //}

    return maxAverage;

}

double FindMaxAverage3(int[] nums, int k)
{

    double maxAverage = double.MinValue;

    //var temp1 = nums.Skip(0).Take(k).Sum();
    //var temp2 = nums.Skip(1).Take(k).Sum();
    //var temp3 = nums.Skip(2).Take(k).Sum();

    //Console.WriteLine($"Result: {temp1},{temp2},{temp3}");


    int i = 0;
    do
    {

        double temp = nums.Skip(i).Take(k).Sum();
        double result = temp / k;
        //Console.WriteLine(result);

        if (result > maxAverage)
        {

            maxAverage = result;

        }

        i++;

    } while (i + k < nums.Length+ 1);

    return maxAverage;

}

double FindMaxAverage2(int[] nums, int k)
{

    if (nums == null || nums.Length < k)
        return 0;

    double maxAverage = double.MinValue;
    int i = 0;

    do
    {

        double sum = 0;
        sum += nums[i];

        //Console.WriteLine(nums[i]);

        if (i + k > nums.Length)
        {

            break;

        }

        for (int y = i + 1; y < i + k; y++)
        {

            //Console.WriteLine(nums[y]);
            sum += nums[y];

        }

        //Console.WriteLine($"Sum = {sum}");
        double result = sum / k;
        //Console.WriteLine($"Average = {sum}");
        //Console.WriteLine("===============");

        if (result > maxAverage)
        {

            maxAverage = result;

        }

        i++;
          
    } while (i < nums.Length - 1);

    return maxAverage;

}

double FindMaxAverage(int[] nums, int k)
{

    double maxAverage = double.MinValue;
    int i = 0;

    do
    {

        double sum = 0;
        sum += nums[i];

        //Console.WriteLine(nums[i]);



        if (i + k > nums.Length)
        {

            break;

        }

        for (int y = i + 1; y < i + k; y++)
        {

            //Console.WriteLine(nums[y]);
            sum += nums[y];

        }

        //Console.WriteLine($"Sum = {sum}");
        double result = sum / k;
        //Console.WriteLine($"Average = {sum}");
        //Console.WriteLine("===============");

        if (result > maxAverage)
        {

            maxAverage = result;

        }

        i++;
          
    } while (i < nums.Length - 1);

    return maxAverage;

}
