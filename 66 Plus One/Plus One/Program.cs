// See https://aka.ms/new-console-template for more information
using System.IO.Pipelines;
using System.Numerics;

Console.WriteLine("Hello, World!");

int[] nums = {7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6};

int[] Result = PlusOne(nums);

for (int i = 0; i <= Result.Length - 1; i++)
{

    Console.Write(Result[i]);

}


Console.ReadKey();






int[] PlusOne(int[] digits)
{

    string Result = string.Empty;
    for (int i = 0; i <= digits.Length - 1; i++)
    {

        Result += digits[i];
        //Console.WriteLine(digits[i]);

    }

    BigInteger Temp = BigInteger.Parse(Result) + 1;

    //Console.WriteLine(Temp);

    string TempString = Temp.ToString();

    //Console.WriteLine(TempString[0]);

  int[] ResultTemp = TempString.Select(c => c - '0').ToArray();


 


    return ResultTemp;

}
