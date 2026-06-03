namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
            Console.WriteLine(IsPalindrome(10));

            Console.ReadKey();


        }


        private static bool IsPalindrome(int x)
        {

            char[] OrignalChar = x.ToString().ToCharArray();
            char[] reverseChar = OrignalChar.Reverse().ToArray();
        
            for (int i = 0; i <= OrignalChar.Length - 1; i++)
            {

                if (OrignalChar[i] != reverseChar[i])
                {

                    return false;

                }
      
            }

            return true;

        }
    }
}
