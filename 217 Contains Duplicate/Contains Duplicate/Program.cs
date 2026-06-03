// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = [1, 2, 3, 1];
Console.WriteLine(ContainsDuplicate(nums));
Console.ReadKey();

bool ContainsDuplicate(int[] nums)
{

    int originalLength = nums.Length;
    int[] temp = nums.Distinct().ToArray(); // Distinct means only  1 duplicate remains

    // The length will determine if it shrink it means it have duplicate
    if (originalLength == temp.Length)
    {

        return false;

    }
    else
    {

        return true;

    }

}