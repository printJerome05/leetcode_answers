// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

Console.WriteLine("Hello, World!");

int[] nums = { 1, 3, 5, 6 };
int[] nums2 = { 1, 3, 5, 6 };
int[] nums3 = {1,3,5,6};
Console.WriteLine(SearchInsert(nums, 5)); // Output 2 indexn of 5 is 2
Console.WriteLine(SearchInsert(nums2, 2)); // Output 1 indexn of 2 is 1 becuase no match i wi;; be inserted and it will be order by ascesding
Console.WriteLine(SearchInsert(nums3,7)); // Output 4 indexn of 7 is 4 becuase no match i wi;; be inserted and it will be order by ascesding

Console.ReadKey();


int SearchInsert(int[] nums, int target)
{

    if (nums.Contains(target) == false)
    {

        //List<int> TempNums = new List<int>();
        //TempNums = nums.OfType<int>().ToList();
        //TempNums.Add(target);
        //TempNums.Sort();
        //Result = TempNums.IndexOf(target);

        Array.Resize(ref nums, nums.Length + 1); // Resize the array
        nums[nums.Length - 1] = target; // Add the array to the last index
        Array.Sort(nums); // Sort the array
        return Array.IndexOf(nums, target); 
     
    }
    else // Ifi t contains the target it will return the index of the target
    {

      return Array.IndexOf(nums, target);

    }
     
}
