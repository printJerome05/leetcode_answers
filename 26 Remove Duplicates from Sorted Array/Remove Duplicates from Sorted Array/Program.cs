// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = [1, 1, 2];
Console.WriteLine(RemoveDuplicates(nums));
Console.ReadKey();

int RemoveDuplicates(int[] nums)
{

    int i = 0;
    int result = 0;
    // Converting the nums to a list if it contains the nums[index]
    List<int> resultNums = new List<int>();

    while (i <= nums.Length - 1)
    {

        // Checking the list to evaluate the duplcates
        if (resultNums.Contains(nums[i]) == false)
        {

            // Adding the nums[index] if resultnums doesnt contains the nums[index]
            resultNums.Add(nums[i]);
            result++;

        }

        i++;
        
    }

    int tempResult = result;
    i = 0;
    while (tempResult > 0)
    {

        nums[i] = resultNums[i];
        i++;
        tempResult--;

    }

    return result;

}
