// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

Console.WriteLine(IsPowerOfThree(27)); // True
//Console.WriteLine(IsPowerOfThree(45)); // False

for (int i = 0;i <= 10;i++ ) 
{

    Console.WriteLine($"{Math.Pow(3,i)}");

}


Console.ReadKey();


bool IsPowerOfThree(int n)
{

    // Below 1 can be in the power of 3
    if (n < 1) return false;

    // If it is divisible by 3 it can be possible to have the power
    if (n % 3 == 0)
    {

        do
        {

            n = n / 3;

        }
        while (n % 3 == 0);
        // iterate thru the n = n / 3 until if it is not modulo to 0 if > 0 it have a remainder

    }

    // Returns true if n = 3 or 1 
    if (n == 3 || n == 1)
    {

        return true;

    }
    else
    {

        return false;

    }
    
}

