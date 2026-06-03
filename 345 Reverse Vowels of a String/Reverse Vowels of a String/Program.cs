// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
Console.WriteLine(ReverseVowels("IceCreAm"));
Console.WriteLine(ReverseVowels("leetcode"));
Console.ReadKey();


string ReverseVowels(string s)
{

    // stating the vowels
    char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
    // converting the string to array to index it one by one
    char[] sArray = s.ToCharArray();

    int count = 0;

    // VowelCount count the vowel for the length of the array
    for (int i = 0; i <= sArray.Length - 1; i++)
    {

        for (int j = 0; j <= vowels.Length - 1; j++)
        {

            if (sArray[i] == vowels[j])
            {

                count++;

            }

        }

    }

    // this is where the vowels to be stored then transfered to the s
    char[] vowelToInsert = new char[count];
    int countInsert = 0;

    // looping to the s array
    for (int i = 0; i <= sArray.Length - 1; i++)
    {

        for (int j = 0; j <= vowels.Length - 1; j++)
        {

            if (sArray[i] == vowels[j])
            {

                // marking + for the vowels by replacing the value of the index
                sArray[i] = '+';
                // storing the value in the vowel to insert
                vowelToInsert[countInsert] = vowels[j];
                countInsert++;

            }

        }

    }

    countInsert = 0;
    for (int i = sArray.Length - 1; i >= 0; i--)
    {

        // replacing the + by the vowels to insert
        if (sArray[i] == '+')
        {

            sArray[i] = vowelToInsert[countInsert];
            countInsert++;

        }

    }

    s = new string(sArray);

    return s;
    
    }


