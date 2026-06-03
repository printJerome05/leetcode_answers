// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

int[] flowerbed1 = { 1, 0, 0, 0, 1 };
int[] flowerbed2 = { 1, 0, 0, 0, 1 };
int[] flowerbed3 = { 1, 0, 0, 0, 0, 0, 1 };
int[] flowerbed4 = { 1,0,0,0,0,1};
Console.WriteLine(CanPlaceFlowers(flowerbed1, 1)); // Expected True
Console.WriteLine(CanPlaceFlowers(flowerbed2, 2)); // Expected False 
Console.WriteLine(CanPlaceFlowers(flowerbed3,2)); // Expected True
Console.WriteLine(CanPlaceFlowers(flowerbed4,2)); // Expected False
Console.ReadKey();

bool CanPlaceFlowers(int[] flowerbed, int n)
{

    for (int i = 0; i <= flowerbed.Length - 1; i++)
    {
        // Loop will continue if the n is not 0
        if (n != 0)
        {

            // if the current index is not 1 and also the index -1 and index + 1 is not 1. It will relace the current index with 1
            if (flowerbed[i] != 1 && (flowerbed[i == 0 ? i : i - 1] != 1) && flowerbed[i != flowerbed.Length - 1 ? i + 1 : i] != 1)
            {

                n -= 1;
               flowerbed[i] = 1; // Replacing the value of the index

            }

        }

    }

    // If then is not 0 means adjacent is not met. Adjacent 1 0 1 0 1 0 1 like this 
    if (n != 0)
    {

        return false;

    }
    else // n is 0 means adjacent is met
    {

        return true;

    }

}