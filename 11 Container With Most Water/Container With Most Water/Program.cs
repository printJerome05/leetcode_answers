// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

int[] height1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 }; // output 49
int[] height2 = { 1, 1 }; // output 1
int[] height3 = { 1, 2, 1 }; // output 2
int[] height4 = { 4,3,2,1,4 }; // output 16
int[] height5 = { 1, 2 }; // output is 1
int[] height6 = { 2, 1 }; // output is 1
int[] height7 = { 0, 1 }; // output is 0
int[] height8 = { 8, 7, 2, 1 }; // output is 7
int[] height9 = { 1, 2, 4, 3 }; // output is 4

Console.WriteLine($"{MaxArea4(height1)} : output 49");
//Console.WriteLine($"{MaxArea3(height2)} : output 1");
//Console.WriteLine($"{MaxArea3(height3)} : output 2");
//Console.WriteLine($"{MaxArea3(height4)} : output 16");
//Console.WriteLine($"{MaxArea3(height5)} : output 1");
//Console.WriteLine($"{MaxArea3(height6)} : output 1");
//Console.WriteLine($"{MaxArea3(height7)} : output 0");
//Console.WriteLine($"{MaxArea3(height8)} : output 7");
//Console.WriteLine($"{MaxArea3(height9)} : output 4");
Console.ReadKey();

int MaxArea4(int[] height)
{

    int Result = 0;
    int i = 0;
    int j = height.Length - 1;

    while (i < j)
    {

        // returing the less than of the index i and index j of height
        int temp = Math.Min(height[i], height[j]) * (j - i);
        // Replacing the result for the final value
        if (temp > Result)
        {
            Result = temp;
        }

        // Reducing the time if index i it will i++
        if (height[i] < height[j])
        {
            i++;
        }
        else
        {
            j--;
        }

    }

    return Result;
         
}

int MaxArea3(int[] height)
{

    int Result = 0;

    for (int i = 0; i <= height.Length - 1; i++)
    {

        for (int j = i + 1 < height.Length - 1 ? i + 1 : i; j <= height.Length - 1; j++)
        {

            int temp = Math.Min(height[i], height[j]) * (j - i);
            if (temp > Result)
            {
                Result = temp;

            }

        }

    }

    return Result;
         
}

int MaxArea2(int[] height)
{

    //  Console.WriteLine(height.Length);
    if (height.Length == 2)
    {

        if (height.Contains(0) == true)
        {

            return 0;

        }

        return 1;

    }

    int result = 0;
    int MaxHeight = height.Max();
    //Console.WriteLine(MaxHeight);
    int Maxheight_Index = Array.IndexOf(height, MaxHeight);

    int EndHeight = 0;
    int Count = 0;

    for (int i = Maxheight_Index + 1 < height.Length - 1 ? Maxheight_Index + 1 : Maxheight_Index; i <= height.Length - 1; i++)
    {

        Count += 1;
        if (MaxHeight == height[i])
        {

            EndHeight = height[i];

        }
        else if (MaxHeight - 1 == height[i])
        {

            int TempCount = 0;
            bool LowerValuesMinus1 = false;
            for (int j = i + 1 < height.Length - 1 ? i + 1 : i; j <= height.Length - 1; j++)
            {

                TempCount += 1;
                if (height[j] == MaxHeight)
                {

                    Count += TempCount;
                    EndHeight = height[j];
                    LowerValuesMinus1 = true;
                    break;

                }

            }

            if (LowerValuesMinus1 == false)
            {

                EndHeight = height[i];
                break;

            }
            else
            {

                break;

            }

        }

    }

    // Console.WriteLine($"Maxheight_Index: {Maxheight_Index}");
    // Console.WriteLine($"Count: {Count}");
    //Console.WriteLine(Maxheight_Index - 1);

    result = Count * EndHeight;
    return result;

    // Maxheight_Index = Maxheight_Index > 0 ? Maxheight_Index : 1;
    // Console.WriteLine($"MaxHeigth = {Maxheight_Index}");
    
}

int MaxArea(int[] height)
{

    int result = 0;
    int MaxHeight = height.Max();
    int Maxheight_Index = Array.IndexOf(height,MaxHeight); // Get the index of the maximun value
                                                           //Console.WriteLine(Maxheight_Index);
                                                           //Console.WriteLine(MaxHeight - 1);


    Console.WriteLine(height.Length - 1);
    Console.WriteLine(height.Length);
    if (height.Length - 1 == 1)
    {

        return 1;

    }

    int EndHeight = 0;
    int ICount = 0; 

    for (int i = Maxheight_Index + 1 < height.Length - 1 ? Maxheight_Index + 1 : Maxheight_Index; i <= height.Length - 1; i++)
    {

        ICount = i;
        if (MaxHeight == height[i] || MaxHeight - 1 == height[i])
        {

            EndHeight = height[i];

            //if (Maxheight_Index == i - 1)
            // {

            //  return MaxHeight;

            //}

            if (i == height.Length - 1)
            {

                break;

            }

        }

    }

    if (Maxheight_Index == ICount - 1)
    {

        return MaxHeight;

    }

    //Console.WriteLine($"End height:  {EndHeight}");
    int EndHeight_Index = Array.LastIndexOf(height, EndHeight);
    //Console.WriteLine($"End heigth Index: {EndHeight_Index}");

    //Console.WriteLine($"End heigth Index: {EndHeight_Index}");
    //Console.WriteLine($"Maxheight_Index: {Maxheight_Index}");
    //Console.WriteLine($"EndHeight: {EndHeight}");
   
    int IndexDifference = EndHeight_Index - Maxheight_Index; 
    //Console.WriteLine($"{EndHeight_Index} - {Maxheight_Index} = {IndexDifference}");
    result = IndexDifference * EndHeight;
    return result;

}
