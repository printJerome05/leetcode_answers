namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Reverse(123));
            Console.WriteLine(Reverse(-123));
            Console.WriteLine(Reverse(120));
            Console.WriteLine(Reverse(1534236469));
            Console.ReadKey();
        }

       static public int Reverse(int x)
        {

            string result = string.Empty; // Making my return a string for easy insert and convert to array
            char[] reverse = x.ToString().ToCharArray(); // converting the int to a array to check values by using index    
            
            for (int i = reverse.Length - 1;i >= 0;i--)
            {

                // populating the result if index value is not a negative - or a 0
                if (reverse[i] != 0 && reverse[i] != '-')
                {

                    result += reverse[i];

                }

            }

            // Checking the array if it contains the negative (-)
            if (reverse.Contains('-'))
            {

                // Inserting the - int the 0 index and to be converted to an int
                //string convertResult = result.Insert(0, "-");
                if (int.TryParse(result, out int value1))
                {

                    return -value1;

                }
                else
                {

                    return 0;

                }

            }
            else
            {

                // Return 0 if the max and min value of the integer if not in the scope of integer
                if (int.TryParse(result, out int value))
                {

                    // If reverse doesnt contain - it will return a positive 
                    return value;

                }
                else
                {

                    return 0;

                }

            }




        }
    }
}
