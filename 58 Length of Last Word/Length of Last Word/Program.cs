// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));

Console.ReadKey();

int LengthOfLastWord(string s)
{

    s = s.Trim(); // Trimmed spaces
    string[] temp = s.Split(' '); // split the string by ' ' or spaces between.
    int result = temp[temp.Length - 1].Length; // resturn the lenght of the last array of temp length
    return result;

}
