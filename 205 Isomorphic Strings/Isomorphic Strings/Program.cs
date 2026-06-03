// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");
//Console.WriteLine(IsIsomorphic2("egg", "ads")); // false
//Console.WriteLine(IsIsomorphic2("foo", "bar")); // False
//Console.WriteLine(IsIsomorphic2("aa", "bb")); // true
//Console.WriteLine(IsIsomorphic2("bbbaaaba","aaabbbba")); // false
Console.WriteLine(IsIsomorphic2("badc","baba")); // false
Console.ReadKey();


bool IsIsomorphic2(string s, string t)
{

    bool isnotIspomorphic = true;

    // Making it a dictionary to for key and value pair
    // for s
    Dictionary<char, char> tempStorageS = new Dictionary<char, char>();

    // for t
        Dictionary<char, char> tempStorageT = new Dictionary<char, char>();
    //tempStorage.Clear();

    for (int i = 0; i <= s.Length - 1; i++)
    {

        // if the temp s contains a key it will check if the value is matched if not isnotIspomorphic will result to false
        if (tempStorageS.ContainsKey(s[i]) == true)
        {

            //Console.WriteLine(s[i]);
            // selecting the where the key == s checking the value
            char sValues = tempStorageS
                          .Where(x => x.Key == s[i])
                          .Select(x => x.Value).Distinct().First();

            // Checking the the sValues(using linq to get the value of the key) checking if the key and value match 
            if (sValues != t[i])
            {

                isnotIspomorphic = false;

            }

        }
        else
        {

            // Adding the tempstorageS if not present in the dictionary
            tempStorageS.Add(s[i], t[i]);

        }

    }

    // for t same process as the s
    for (int i = 0; i <= t.Length - 1; i++)
    {
        if (tempStorageT.ContainsKey(t[i]) == true)
        {

            //Console.WriteLine(s[i]);

            char tValues = tempStorageT
                          .Where(x => x.Key == t[i])
                          .Select(x => x.Value).Distinct().First();

            if (tValues != s[i])
            {

                isnotIspomorphic = false;

            }

        }
        else
        {

            tempStorageT.Add(t[i], s[i]);

        }

    }

    return isnotIspomorphic;  
}

bool IsIsomorphic(string s, string t)
{

    if (s.Length != t.Length)
    {

        return false;

    }

    List<char> tempS = s.ToList();
    List<char> tempT = t.ToList();
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    int sameCount = 0;

    for (int i = 0; i <= s.Length - 1; i++)
    {

        if (tempS[0] == tempS[i] && tempT[0] == tempT[i])
        {

            sameCount++;

        }

    }

    if (sameCount == tempS.Count)
    {

        return true;

    }

    for (int i = 0; i <= vowels.Length - 1; i++)
    {

        if (tempS.Contains(vowels[i]))
        {

            tempS.RemoveAll(x => x.Equals(vowels[i]));

        }

        if (tempT.Contains(vowels[i]))
        {

            tempT.RemoveAll(x => x.Equals(vowels[i]));

        }

    }

    if (tempS.Count == tempT.Count)
    {

        return true;

    }
    else
    {

        return false;

    }
        
}
