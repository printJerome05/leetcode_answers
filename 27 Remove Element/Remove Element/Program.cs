// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//
int[] nums = [0,1,2,2,3,0,4,2];
//Console.WriteLine(RemoveElement(nums, 3));
Console.WriteLine($"Result: {RemoveElement2(nums,2)}");
Console.ReadKey();

int RemoveElement2(int[] nums, int val)
{

    int i = 0;
    int y = 0;
    int ElementCount = 0;

    while (i <= nums.Length - 1)
    {

        if (nums[i] != val)
        {

            // Changing the index value of the array 
            nums[y] = nums[i];
            y++;

        }
        else
        {

            // Counting the element count
            ElementCount++;

        }

        i++;

    };

    // To return the length of the array of not hit by the same val
    return nums.Length - ElementCount;

}


int RemoveElement(int[] nums, int val)
{

    int i = 0;
    int y = 0;
    int x = nums.Length - 1;
    int ElementCount = 0;

    while (i < nums.Length)
    {

        Console.WriteLine($"Element: {nums[i]}");

        if (nums[i] == val)
        {

            ElementCount++;
            nums[x] = nums[i];
            x--;

        }
        else
        {

            nums[y] = nums[i];
            y++;

        }

        i++;

    }

    for (int z = 0; z <= nums.Length -1; z++)
    {

        Console.Write($"{nums[z]}, ");

    }

    Console.WriteLine();

    return ElementCount;

}