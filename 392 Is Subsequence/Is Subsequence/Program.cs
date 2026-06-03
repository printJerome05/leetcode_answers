// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");
Console.WriteLine(IsSubsequence("abc", "ahbgdc")); // true
//Console.WriteLine(IsSubsequence("", "")); // True
//Console.WriteLine(IsSubsequence("bb", "ahbgdc")); // False
//Console.WriteLine(IsSubsequence("ahbgdc", "bb")); // False
//Console.WriteLine(IsSubsequence("aa","a")); // False

Console.ReadKey();

bool IsSubsequence(string s, string t)
{


    // return false if the compare is less than the subsequence comparer
    if (s.Length > t.Length)
    {

        return false;

    }

    if (s.Length == 0 && t.Length == 0)
    {

        return true;

    }
    else if (s.Length == 0)
    {

        return true;

    }
    else if (t.Length == 0)
    {

        return false;

    }

    // Convert to array
    char[] Converteds = s.ToCharArray();
    char[] Convertedt = t.ToCharArray();
    int SubCount = 0; // Count for the consecutive subsequence will be match to the legnth of s
    int J_Lastvalue = 0; // Last value of j to get the last index for n repetiton

    if (s.Length > t.Length || s.Length == t.Length)
    {

        for (int i = 0; i <= Convertedt.Length - 1; i++)
        {

            for (int j = J_Lastvalue; j <= Converteds.Length - 1; j++)
            {

                if (Convertedt[i] == Converteds[j])
                {

                    J_Lastvalue = j + 1;
                    SubCount++;
                    break;

                }

            }

        }

        Console.WriteLine(SubCount);
        Console.WriteLine(Convertedt.Length);

        if (Convertedt.Length != SubCount)
        {

            return false;

        }
        else
        {

            return true;

        }

    }
    else
    {

        for (int i = 0; i <= Converteds.Length - 1; i++)
        {

            for (int j = J_Lastvalue; j <= Convertedt.Length - 1; j++)
            {

                if (Converteds[i] == Convertedt[j])
                {

                    J_Lastvalue = j + 1;
                    SubCount++;
                    break;

                }

            }
            
        }

        if (Converteds.Length != SubCount)
        {

            return false;

        }
        else
        {

            return true;

        }


    }

}