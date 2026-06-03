// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

char[] CompressValues1 = ['a', 'a', 'b', 'b', 'c', 'c', 'c']; // Return 6
//char[] CompressValues = ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'];
//char[] CompressValues = ['a', 'a', 'a', 'b', 'b', 'a', 'a'];
char[] CompressValues2 = ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'];
Console.WriteLine(Compress5(CompressValues1));
Console.WriteLine(Compress5(CompressValues2));
Console.ReadKey();


// First Submmision
int Compress5(char[] chars)
{

    // Storing the array
    string result2 = string.Empty;
    // temp for the indexing of the array char to compare
    char temp = '\0'; 
    int x =0;
    int y = chars.Length - 1;

    // Counting the 
    int count = 0;

    do
    {

        // Temp is not equals to the current index of the chars
        if (temp != chars[x])
        {
            
            // temp will be the new comparer to the + 1 of the chars
            temp = chars[x];
            count = 1;
            
        }

        x++;

        // Looping thru the chars if temp have the same to count
        while(x <= y && temp == chars[x])
        {

            // Counting the index and the number of times it hit the same char
            x++;
            count++;



        }

        // adding to the result2 after cleansing
        result2 += count > 1 ? $"{temp}{count}" : temp;
        // reset the value to 0 of count
        count = 0;
     
    }while(x <= y);


    // can do chars = result2.ToCharArray(); but in leetcode it will not push now looping to the result2 to change value of the array
    for (int j = 0; j <= result2.Length - 1;j++)
    {
        
        chars[j] = result2[j];

    }

    // making the array size to the size of result2.length
    chars = result2.Take(result2.Length).ToArray();

    // returning the int value
    return chars.Length;

}




