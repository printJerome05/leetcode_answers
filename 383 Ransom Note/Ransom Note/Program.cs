// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
Console.WriteLine(CanConstruct("a", "b"));
Console.WriteLine(CanConstruct("aa", "ab"));
Console.WriteLine(CanConstruct("aa", "aab"));
Console.WriteLine(CanConstruct("aab", "baa")); // should be true
Console.WriteLine(CanConstruct("fffbfg","effjfggbffjdgbjjhhdegh")); // true
Console.ReadKey();

bool CanConstruct(string ransomNote, string magazine)
{

    if (ransomNote.Length > magazine.Length)
    {

        if (ransomNote.Contains(magazine)) return true;
        else return false;

    }
    else if (ransomNote.Length == magazine.Length)
    {


        var array1 = ransomNote.ToCharArray();
        var array2 = magazine.ToCharArray();

        Array.Sort(array1);
        Array.Sort(array2);

        string temp1 = new string(array1);
        string temp2 = new string(array2);

        //Console.WriteLine($"{temp1} , {temp2}");

        if (string.Compare(temp1, temp2) == 0) return true;
        else return false;
        
    }
    else
    {

        if (magazine.Contains(ransomNote)) return true;
        else return false;

    }
    

}