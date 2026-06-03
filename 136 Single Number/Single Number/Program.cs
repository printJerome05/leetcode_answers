// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.IO.Pipelines;

Console.WriteLine("Hello, World!");
//int[] nums = [2, 2, 1];
int[] nums = [4,1,2,1,2];
Console.WriteLine(SingleNumber(nums));
Console.ReadKey();

int SingleNumber(int[] nums)
{

    // Converting the array to list to have a remove function.
    List<int> tempNums = nums.ToList();
    int i = 0;
    int result = 0;

    while (i <= tempNums.Count - 1)
    {
        
        result = tempNums[i];
        // remving the first occurence means the nums[i]
        tempNums.Remove(result);

        if (tempNums.Contains(result) == true)
        {

            // remove all the occurences that is equal to the result
            tempNums.RemoveAll(x => x == result);

        }
        else
        {
            // return the result if it is nothing
            return result;

        }

    }


    return result;

}



