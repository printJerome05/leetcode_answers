// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
Console.WriteLine(FizzBuzz(5));

Console.ReadKey();

IList<string> FizzBuzz(int n)
{

    IList<string> Result = new List<string>();

    for (int i = 1; i <= n; i++)
    {

        if (i % 3 == 0 && i % 5 == 0)
        {

            Result.Add("FizzBuzz");

        }
        else if (i % 3 == 0)
        {

            Result.Add("Fizz");

        }
        else if (i % 5 == 0)
        {

            Result.Add("Buzz");

        }
        else
        {

            Result.Add($"{i}");

        }

    }

    for (int i = 0; i <= Result.Count - 1; i++)
    {

        Console.WriteLine(Result[i]);

    }

    return Result;



        
}