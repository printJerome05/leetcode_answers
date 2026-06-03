// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string s = "A man, a plan, a canal: Panama";

Console.WriteLine(IsPalindrome(s));
Console.ReadKey();

    bool IsPalindrome(string s) {

        string temp = string.Empty;
        s = s.Trim();
        // Checking the lenght and the null value of the string
        if (s.Length == 0 || s == null) 
        {

            return true;

        }

        for (int i = s.Length - 1;i >= 0;i--)
        {      
            // Checking if the index is a valid digit or letter
            if (char.IsLetterOrDigit(s[i]) == true  )
            {
                // storing the valid characters
                temp += s[i];

            }

        }

        // Converting the string to lower case and reversing it to compare
        string temp2 = temp.ToLower();
        temp = new string(temp.ToCharArray().Reverse().ToArray()).ToLower();
        Console.WriteLine($"Temp:{temp}");
        Console.WriteLine($"Temp2:{temp2}");

        if (temp.Equals(temp2, StringComparison.OrdinalIgnoreCase) == false)
        {
            
            return false;

        }

        return true;
        
    }



