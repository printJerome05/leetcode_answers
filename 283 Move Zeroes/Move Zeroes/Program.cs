// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");

int[] nums = [0, 1, 0, 3, 12];

//nums = MoveZeroes(nums);

Console.WriteLine();

for (int i = 0; i <= nums.Length - 1; i++)
{

    Console.Write($"{nums[i]},");

}





Console.ReadKey();


void MoveZeroes(int[] nums)
{

    // A storge for values > 0
    List<int> TempStorage = new List<int>();
    int ZeroCount = 0; 

    for (int i = 0; i <= nums.Length - 1; i++)
    {

        if (nums[i] != 0)
        {

            // Adding the value to the list
            TempStorage.Add(nums[i]);

        }
        else
        {
            // Counting the zeros
            ZeroCount++;

        }

    }

    // Adding the zeros in the ends
    for (int i = 0; i <= ZeroCount - 1; i++)
    {

        TempStorage.Add(0);

    }

    //for (int i = 0; i <= TempStorage.Count - 1; i++)
    //{

    //  Console.Write($"{TempStorage[i]},");

    //}


    // To get the values back to the nums itself
    // if method is a return type you can do nums=TempStorage.toArray();
    for (int i = 0; i <= nums.Length - 1; i++)
    {

        nums[i] = TempStorage[i];

    }

}
;
