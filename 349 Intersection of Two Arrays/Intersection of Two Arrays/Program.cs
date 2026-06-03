// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int[] nums1 = [1, 2, 2, 1];
//int[] nums2 = [2,2];

int[] nums1 = [4,9,5];
int[] nums2 = [9,4,9,8,4];

Console.WriteLine(Intersection(nums1,nums2));
Console.ReadKey();




int[] Intersection(int[] nums1, int[] nums2)
{

    List<int> temp1 = new List<int>();
    List<int> temp2 = new List<int>();
    List<int> tempresult = new List<int>();

    temp1 = nums1.Distinct().ToList(); // nums to array convert
    temp2 = nums2.Distinct().ToList(); // nums to array convert


    if (temp1.Count > temp2.Count || temp1.Count == temp2.Count)
    {

        for (int i = 0; i <= temp2.Count - 1; i++)
        {

            if (temp1.Contains(temp2[i])) // Checking if it contains the nums[index]
            {

                tempresult.Add(temp2[i]); // adding it to the temp list

            }

        }

    }
    else if (temp2.Count > temp1.Count)
    {

        for (int i = 0; i <= temp1.Count - 1; i++)
        {

            if (temp2.Contains(temp1[i]))
            {

                tempresult.Add(temp1[i]);

            }

        }

    }

    int[] result = tempresult.ToArray(); // list converted to an array
    return result; 

}