// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(MergeAlternately("abc","pqr"));
Console.WriteLine(MergeAlternately("ab", "pqrs"));
Console.WriteLine(MergeAlternately("abcd","pq"));
Console.ReadKey();

string MergeAlternately(string word1, string word2)
{

    string Result = string.Empty;

    // Converting the values to a char
    char[] Word1ToChar = word1.ToCharArray();
    char[] Word2ToChar = word2.ToCharArray();
    
    // Getting the legnth of each array to define who will be inside the for loop length
    int Length1 = Word1ToChar.Length - 1;
    int Length2 = Word2ToChar.Length - 1;

    if (Length1 > Length2)
    {

        for (int i = 0; i <= Word1ToChar.Length - 1; i++)
        {

            // Resull will be += keep adding till loop reached the limit
            Result += Word1ToChar[i].ToString();
            
            // if the index is less than the length of the array who is less than the length of the other array
            if (i <= Length2)
            {

                Result += Word2ToChar[i].ToString();

            }
            
        } 

    }
    else if (Length1 < Length2)
    {

        for (int i = 0; i <= Word2ToChar.Length - 1; i++)
        {

            if (i <= Length1)
            {

                Result += Word1ToChar[i].ToString();

            }

            Result += Word2ToChar[i].ToString();

        }

    }
    else // if both array is equal it will have no if in the for loop
    {

        for (int i = 0; i <= Word1ToChar.Length - 1; i++)
        {

            Result += Word1ToChar[i].ToString();
            Result += Word2ToChar[i].ToString();

        }

    }

return Result;

}