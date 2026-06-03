// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] candies = new int[5] { 2, 3, 5, 1, 3 };
int[] candies1 = new int[5] { 4, 2, 1, 1, 2 };
int[] candies2 = new int[3] { 12,1,12};

//Console.WriteLine(KidsWithCandies(candies, 3));

IList<bool> candiesCon1 = KidsWithCandies(candies, 3);
foreach (bool candy in candiesCon1)
{
    Console.Write(candy + ",");
}


Console.WriteLine();

IList<bool> candiesCon2 = KidsWithCandies(candies1, 1);
foreach (bool candy in candiesCon2)
{
    Console.Write(candy + ",");
}

Console.WriteLine();


IList<bool> candiesCon3 = KidsWithCandies(candies2, 10);
foreach (bool candy in candiesCon3)
{
    Console.Write(candy + ",");
}



Console.ReadKey();


IList<bool> KidsWithCandies(int[] candies, int extraCandies)
{

    // Creating the return
    IList<bool> result = new List<bool> {};

    // Getting the max value for int in the array
    int candiesMaxValue = candies.Max();

    for (int i = 0; i <= candies.Length - 1; i++)
    {

        // Adding the extracandies to the i index of the candies if it equals to the max values of the candiesMaxValue
        if ((candies[i] + extraCandies) >= candiesMaxValue)
        {
            result.Add(true);

        }
        else
        {
            result.Add(false);
        }

    }

    return result;

}
