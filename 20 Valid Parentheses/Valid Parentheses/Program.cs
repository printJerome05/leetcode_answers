// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Net.Http.Headers;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");
Console.WriteLine(IsValid("()")); // True
Console.WriteLine(IsValid("(]")); // False
Console.ReadKey();

bool IsValid(string s)
{

    List<char> Temps_S = new List<char>();
    Temps_S = s.ToList();

    for (int i = 0; i <= Temps_S.Count - 1; i++)
    {

        char CloseBracket = IdentifyParenthesis(Temps_S[i]);
        if (CloseBracket != ' ' || CloseBracket == '')
        {

            Temps_S.Remove(Temps_S[i]);
            Temps_S.Remove(CloseBracket);

        }
        else
        {

            return false;

        }

    }

    return true;

}

char IdentifyParenthesis(char item)
{

    switch (item)
    {

        case '(':

            return ')';

        case '{':

            return '}';

        case '[':

            return ']';

        default:

            return ' ';

    }

}
