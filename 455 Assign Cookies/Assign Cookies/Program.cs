// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");
int[] g = [1, 2, 3];
int[] s = [1, 1];
Console.WriteLine(FindContentChildren2(g, s)); // Result should be 1

int[] g1 = [1, 2];
int[] s1 = [1,2,3];
Console.WriteLine(FindContentChildren2(g1, s1)); // Result should be 2

int[] g2 = [1, 2, 3];
int[] s2 = [3];
Console.WriteLine(FindContentChildren2(g2, s2)); // Result should be 1

int[] g3 = [10,9,8,7];
int[] s3 = [5, 6, 7, 8];
Console.WriteLine(FindContentChildren2(g3, s3)); // Result should be 2

Console.ReadKey();

int FindContentChildren3(int[] g, int[] s)
{

    // If the cokkie array is 0 it means its returning 0
    if(s.Length == 0)
            return 0;

    // For counting of the feeded children
    int childrenFed = 0;
    Array.Sort(g);  // Sorting to easily compare the values
    Array.Sort(s);

    //List<int> tempsG = g.ToList();

    //int total = s.Length > g.Length == true ? s.Length -1 : g.Length - 1;
    
    int i = 0;
    int gIndex = 0; // Index for y

    // Cookies loop
    do
    {
        //Console.WriteLine($"Value of Cookie: {s[i]}");
        // Y equals the last hit index of cookies >= the hunger of the children
        int y = gIndex;

        // Looping thru the children
        do
        {

            if (y > g.Length)
            {

                break;

            }

            //Console.WriteLine($"Value of Children: {g[y]}");
            if (s[i] >= g[y])
            {
                
                childrenFed++;
                gIndex = y + 1; // Childremn value plus 1
                break;

            }

            y++;

        } while (y < g.Length);

        i++;

    } while (i < s.Length);

    return childrenFed;

}

int FindContentChildren2(int[] g, int[] s)
{

    int childrenFed = 0;
    Array.Sort(g);
    Array.Sort(s);

      List<int> tempsG = g.ToList();

    //int total = s.Length > g.Length == true ? s.Length -1 : g.Length - 1;

    for (int i = 0; i <= s.Length - 1; i++)
    {

        //Console.WriteLine($"Value of Cookie: {s[i]}");

        int y = 0;

        do
        {

            if (y > tempsG.Count - 1)
            {

                break;

            }

            //Console.WriteLine($"Value of Children: {g[y]}");
            if (s[i] >= tempsG[y])
            {

                childrenFed++;
                tempsG.Remove(tempsG[y]);
                break;

            }

            y++;


        } while (y != tempsG.Count - 1);

    }

    return childrenFed;

}

int FindContentChildren(int[] g, int[] s)
{

    int totalCookies = s.Sum();
    int i = 0;
    int y = 0;

    int currentChildren = 0;
    int childrenFed = 0;

    while (i <= g.Length - 1)
    {
        
        currentChildren = g[i];

        if (totalCookies != 0)
        {
            y = currentChildren;

            do
            {

                if (totalCookies != 0 && currentChildren != 0)
                {

                    totalCookies--;
                    currentChildren -= 1;

                }

                y--;

            } while (y > 0);

            if (currentChildren == 0)
            {

                childrenFed++;

            }

        }

        i++;

    }

    return childrenFed;

}