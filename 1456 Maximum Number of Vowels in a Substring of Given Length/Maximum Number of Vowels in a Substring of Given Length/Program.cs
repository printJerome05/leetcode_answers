// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string s = "abciiidef";
Console.WriteLine(MaxVowels(s,3)); // result should be 3 abc,iii,def
Console.WriteLine(MaxVowels("sawad",5));
Console.WriteLine(MaxVowels("awrty",6));

Console.WriteLine(s.Substring(0,3));
Console.WriteLine(s.Substring())

int k = 3;
int i = 0;
do
{
    

}while(i < s.Length - 1);


Console.ReadKey();


int MaxVowels(string s, int k)
{

    int result = 0;
    char[] chars = {'a','e','i','o','u'};
    char[] tempS = s.ToCharArray();
    //List<char> chars2 = new List<char>{'a','e','i','o','u'};
    bool haveVowels = chars.Any(x => tempS.Contains(x));
    if (haveVowels == false) return result;

    //int i = 0;
    //do
    //{

        

    //}while(i <= tempS.Length -1);

    return result;

}
