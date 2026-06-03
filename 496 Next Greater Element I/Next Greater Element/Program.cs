// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System.Xml;

Console.WriteLine("Hello, World!");
int[] x = {4,1,2};
int[] y= {1,3,4,2};
NextGreaterElement(x,y);

Console.ReadKey();  


int[] NextGreaterElement(int[] nums1, int[] nums2) {

  
    int y = nums1.Length - 1;
    int nums2Count = nums2.Length - 1;  
    int x = 0;
    int[] result = new int[y];

    //var temp = nums2.FirstOrDefault(x => x == nums1[x],-1);
    //var temp2 = nums2.All(x => x == nums1[x]);   
    //Console.WriteLine(temp3);
    //Console.WriteLine(temp);

    do{
        
        int temp = nums1[x];
        Console.WriteLine($"Temp value: {temp}");
        int temp2 = Array.IndexOf(nums2, nums1[x]);
        Console.WriteLine($"Temp2 index: {temp2}");


        if (temp2 + 1 > nums2Count)
        {
            
            result[x] = -1;         
            x++;
            continue;

        }

        if (temp <= nums2[temp2 + 1] )
        {
            
            result[x] = nums2[temp2 + 1];    
            x++;
            continue;

        }

        x++;
        
    }while(x < y);

    for (int i = 0; i < result.Length - 1;i++)
    {
        
        Console.WriteLine($"{i}: {result[i]}");

    }


    return result;

}