// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime;

Console.WriteLine("Hello, World!");
int[] nums = [1,2,3,4];
Console.WriteLine(MaxOperations2(nums, 5)); // Output is 2

int[] nums2 = [3,1,3,4,3];
Console.WriteLine(MaxOperations2(nums2,6)); // Output is 1

Console.ReadKey();

int MaxOperations2(int[] nums, int k)
{

    List<int> tempNums = nums.ToList();
    tempNums.RemoveAll(x => x > k);
    tempNums.Sort();

    int operationCount = 0;
    int i = 0;
    int y = tempNums.Count - 1;

    while (i < y)
    {
        
            int sum = tempNums[i] + tempNums[y];

            if (sum == k && i != y)
            {

                //Console.WriteLine("===============================");
                //Console.WriteLine($"{tempNums[i]} + {tempNums[y]}");
                //Console.WriteLine($"I index = {i} || Y index = {y}");

                operationCount++;
                //Console.WriteLine($"Index Removed I {i}");
                //Console.WriteLine($"Index Removed Y {y}");
                i++;
                y--;

            }

            if (sum < k)
                i++;
            else if (sum > k)
                y--;

    }

    return operationCount;
}

int MaxOperations(int[] nums, int k)
{

    List<int> tempNums = nums.ToList();
    tempNums.RemoveAll(x => x > k);
    tempNums.Sort();

    int operationCount = 0;
    int i = 0;
    int y = tempNums.Count - 1;

    do
    {

        if (tempNums[i] + tempNums[y] == k && i != y)
        {

            //Console.WriteLine("===============================");
            //Console.WriteLine($"{tempNums[i]} + {tempNums[y]}");
            //Console.WriteLine($"I index = {i} || Y index = {y}");

            operationCount++;
            //Console.WriteLine($"Index Removed I {i}");
            //Console.WriteLine($"Index Removed Y {y}");
            tempNums.RemoveAt(y);
            tempNums.RemoveAt(i);
            y = tempNums.Count - 1;
            i = 0;
            continue;

        }

        if (y > i)
        {

            y--;

        }
        else
        {

            i++;
            y = tempNums.Count - 1;

        }


   
    } while (i < tempNums.Count - 1);

    //for (int x = 0; x <= tempNums.Count - 1; x++)
    //{

      //  Console.WriteLine(tempNums[x]);

    //}

    return operationCount;

}

