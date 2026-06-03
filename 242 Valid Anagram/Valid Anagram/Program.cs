// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(IsAnagram("anagram","nagaram"));

Console.ReadKey();

bool IsAnagram(string s, string t)
{

    // Converting to to char array 
    char[] tempS = s.ToCharArray();
    char[] tempT = t.ToCharArray();

    // sorting array to compare them if they are same values
    Array.Sort(tempS);
    Array.Sort(tempT);

    // converting the char array to string to strinfg compare them
    string sValue = new string(tempS);
    string tValue = new string(tempT);

    // 0 means they are the same
    if (string.CompareOrdinal(sValue, tValue) == 0)
        return true;
    else
        return false;
        
}