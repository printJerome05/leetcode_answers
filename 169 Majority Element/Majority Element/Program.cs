// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int[] nums = { 3, 2, 3 };
//int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
//int[] nums = { 3,3,4};
int[] nums = { 6,5,5};
//int[] nums = [8, 8, 7, 7, 7];
Console.WriteLine(MajorityElement(nums));
Console.ReadKey();

int MajorityElement(int[] nums)
{

    int result = 0;
    int[] temp1 = nums.Distinct().ToArray(); // For the loop limit
    int numCount1 = 0;
    int i = 0;
    
    do
    {

        // Finding all the the array of the index of temp1 
        int numCount2 = Array.FindAll(nums, x => x == temp1[i]).Count();
        // If the numcCount 2 is greater than the numCount1
        if (numCount2 > numCount1)
        {

            // Changing the numcount Result
            numCount1 = numCount2;
            result = temp1[i];

        }
        i++;

    } while (i <= temp1.Length - 1);

    return result;
  
}
