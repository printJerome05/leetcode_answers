// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
Console.WriteLine(MySqrt(4)); // Should be 2
double result = Math.Sqrt(4);
Console.WriteLine(result);
Console.WriteLine(MySqrt(8)); // Should be 2 rounded of 
Console.ReadKey();

int MySqrt(int x)
{

    double temp = Math.Sqrt(x); // result will be doulbe
    temp = Math.Floor(temp); // result will be rounded down
    return (int)temp; // converting double to int
 
}
