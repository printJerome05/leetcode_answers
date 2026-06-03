// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.XPath;

Console.WriteLine(ReverseWords("the sky is blue"));
Console.WriteLine(ReverseWords("  hello world  "));
Console.WriteLine(ReverseWords("a good   example"));
Console.ReadKey();

string ReverseWords(string s)
{

    string result = string.Empty; // For the result 
    string temp = string.Empty; // to store temporary result

    s = s.Trim(); // remove the existing leading and trailing spaces
    s = s.Replace(" ", "/"); // my solution for inner spaces 
    //Console.WriteLine(s.Length - 1);
    char[] sConvert = s.ToCharArray(); // to index eeach values or characters
    //Console.WriteLine(sConvert.Length - 1);
    
    // looping in reverse
    for (int i = sConvert.Length - 1; i >= 0; i--)
    {

        //Console.WriteLine(sConvert[i]);

        // getting in the spaces betweeen each words
        if (sConvert[i] != '/')
        {

            // storing the values in the temp 
            temp += sConvert[i];

        }
        else
        {

            // Console.WriteLine(temp);
            // Revesrsing the values then converting it to a string
            result += new string(temp.Reverse().ToArray());
            //Console.WriteLine(temp);
            result += " "; // for adding space in between the word
            temp = ""; // To truncate the value for the temp storage

        }

    }

    // To add the remaining temp value
    if (temp.Length > 0)
    {

        result += new string(temp.Reverse().ToArray());

    }

    // remove the exxesice white spaces in the words
    //while (result.Contains("  "))
    //{
      //  result = result.Replace("  ", " ");
    //}

    return result; // erasing the not removed leading and trailing white spaces

}