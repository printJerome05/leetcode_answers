// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(StrStr("sadbutsad", "sad")); // returned 0
Console.WriteLine(StrStr1("leetcode", "leeto")); // returned -1 no match
//Console.WriteLine(StrStr("hello", "ll")); // returned 2 
//Console.WriteLine(StrStr("mississippi", "issi")); // returned 1
//Console.WriteLine(StrStr1("mississippi","issip")); // returned 4

Console.ReadKey();

int StrStr1(string haystack, string needle)
{

    bool constainsNeedle = haystack.Contains(needle,StringComparison.Ordinal); // validating if the haystack contains the needle
    if (constainsNeedle)
    {

        int result = haystack.IndexOf(needle); // index of the need in the haystack
        return result;

    }
    else
    {

        return -1; // -1 if false

    }

}





int StrStr(string haystack, string needle)
{

    int i = 0;
    int j = 0;
    int start = 0;
    int hit = 0;
    
    while (i <= haystack.Length - 1)
    {

        if (haystack[i] == needle[j])
        {

            hit++;

            if (hit == 1)
            {

                start = i;

            }

            if (hit == needle.Length)
            {

                return start;

            }

        }
        else
        {

            hit = 0;
            j = 0;
                    
        }

        i++;
        if (hit == 0) j = 0;
        else j = j <= needle.Length - 1 ? j += 1 : 0;

    }

    return -1;
        
}