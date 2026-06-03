// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Globalization;

Console.WriteLine("Hello, World!");
Stopwatch stopwatch= Stopwatch.StartNew();

int[] nums = { 1, 2, 3, 4, 5 };
int[] nums1 = { 5,4,3,2,1};
int[] nums2 = { 2, 1, 5, 0, 4, 6 };

stopwatch.Start();
Console.WriteLine(IncreasingTriplet(nums));
Console.WriteLine(IncreasingTriplet(nums1));
Console.WriteLine(IncreasingTriplet(nums2));
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);

Console.ReadKey();


// Time limit Exceeded
bool IncreasingTriplet2(int[] nums)
{

    List<int> values = new List<int>();


    // count how many different values it there
    for (int i = 0; i <= nums.Length - 1; i++)
    {

        // if values contain the value it loops
        if (values.Contains(nums[i]) == false)
        {

            // adding the value in the values
            values.Add(nums[i]);

        }

    }

    // if values is only two means it will have no third subsequence
    if (values.Count <= 2)
    {

        return false;

    }

    int temp1 = 0;
    int temp2 = 0;

    for (int i = nums.Length - 1; i >= 0; i--)
    {

        temp1 = nums[i];

        for (int j = i != 0 ? i - 1 : i; j >= 0; j--)
        {

            if (temp1 > nums[j])
            {

                temp2 = nums[j];

                for (int k = j != 0 ? j - 1 : j; k >= 0; k--)
                {

                    if (temp2 > nums[k])
                    {

                        return true;

                    }


                }


            }

        }

    }

    return false;
    
}



// Time limit Exceeded
bool IncreasingTriplet(int[] nums)
{

    int temp1 = 0;
    int temp2 = 0;

    for (int i = nums.Length - 1; i >= 0; i--)
    {

        temp1 = nums[i];

        for (int j = i != 0 ? i - 1 : i; j >= 0; j--)
        {

            if (temp1 > nums[j])
            {

                temp2 = nums[j];

                for (int k = j != 0 ? j - 1 : j; k >= 0; k--)
                {

                    if (temp2 > nums[k])
                    {

                        return true;

                    }


                }


            }

        }

    }

    return false;
    
}