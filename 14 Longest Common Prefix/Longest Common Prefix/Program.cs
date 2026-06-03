// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;



string[] strs = ["flower","flow","flight"];
string[] strs1 = ["flow","flow","flow"];
string[] strs2 = ["reflower","flow","flight"];
Console.WriteLine($"Result: {LongestCommonPrefix(strs2)}");
Console.ReadKey();


string LongestCommonPrefix(string[] strs) {

if(strs.Length -1 == 0) return strs[0];

// The 0 index will be the shortest in length
string[] convertedStrs = strs.OrderBy(x => x.Length).ToArray();

string result = "";
string main = convertedStrs[0]; // For my basis
Console.WriteLine($"main: {main}");


    int i = 1;
    do
    {   
        string temp = convertedStrs[i];
        Console.WriteLine($"Temp: {temp}");
        string tempresult = "";
        for (int y = 0;y <= main.Length - 1;y++)
        {

            if (main[y] != temp[y])
            {

            //tempresult = "";
                break;  
              
            }
            else
            {

              tempresult += main[y];  

            }   

        }

        Console.WriteLine($"Temp Result: {tempresult}");

        if (tempresult != "")
        {

            if (result == "") result = tempresult.ToString();
            else
            {
                
                if (tempresult.Length - 1 < result.Length - 1) result = tempresult.ToString();

            }
        
        }
        else
        {
            
            return "";

        }

        i++;

    }while(i <= convertedStrs.Length - 1);
   
return result;

}


string LongestCommonPrefix1(string[] strs) {

if(strs.Length -1 == 0) return strs[0];

// The 0 index will be the shortest in length
string[] convertedStrs = strs.OrderBy(x => x.Length).ToArray();

string result = "";
string main = convertedStrs[0]; // For my basis
Console.WriteLine($"main: {main}");

return result;

}