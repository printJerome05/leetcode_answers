// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
//Console.WriteLine(Divide(7, -3)); // Answer is 2
//Console.WriteLine(Divide(1, 1)); // Answer is 1
Console.WriteLine(Divide(-2147483648,-1)); // Answer is 2147483648
Console.ReadKey();

int Divide(int dividend, int divisor)
{ 

    int count = 0;
    long result = 0;
    long tempDivident = Math.Abs((long)dividend);
    long tempDivisor = Math.Abs((long)divisor);

    do
    {

        result += tempDivisor;
        if (result <= tempDivident)
        {

            count++;

        }

    } while (result < tempDivident);

    Console.WriteLine(count);

    if (divisor < 0 && dividend < 0 || divisor > 0 && dividend > 0)
    {

        return count;

    }
    else
    {

        return count * -1;

    }
       
}