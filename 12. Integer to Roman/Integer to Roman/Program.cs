// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
Console.WriteLine(IntToRoman(3749));
//Console.WriteLine(IntToRoman(58));
//Console.WriteLine(IntToRoman(1994));
Console.ReadKey();

string IntToRoman(int num) {

string result = string.Empty;

    do
    {
        
        if(num >= 1000)
        {
          num = num - 1000; 
          Console.WriteLine(num.ToString()); 
          result += "M";
          Console.WriteLine("M hit");
        } 

        if(num >= 500 && num <= 999)
        {
          num -= 500;  
          result += "D";
          Console.WriteLine("D hit");
        }

        if(num >= 100 && num <= 499)
        {
            num -= 100;
            result += "C";
            Console.WriteLine("C hit");
        }

        if(num <= 80 && num >= 50)
        {
            num -= 50;
            result += "L";
            Console.WriteLine("L hit");
        }

        if (num >= 10 && num <= 40)
        {
            
            num -= 10;
            result += "X";
            

        }

        Console.WriteLine(result);

    }
    while(num >= 0);

return result;

}
