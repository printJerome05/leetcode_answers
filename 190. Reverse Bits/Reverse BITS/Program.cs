// See https://aka.ms/new-console-template for more information
using System.Numerics;



int ReverseBits(int n) {
        
string result = Convert.ToString(n, 2).PadLeft(32, '0' );
//string reverse = Convert.ToInt32(result).ToString();

string reverse = new string(result.Reverse().ToArray()); 
int incremenet = 1;
int reverseResult =0 ;

for (int i = reverse.Length - 1 ; i >= 0; i--)
{
    
    if (reverse[i] == '1')
    {
        
        reverseResult += incremenet;

    }

    incremenet *= 2;

}

//Console.WriteLine($"Result: {result} || Int: {n}");
//Console.WriteLine($"Reversed: {reverse} || Int: {reverseResult}");

return reverseResult;

}

    Console.WriteLine(ReverseBits(1612).ToString());