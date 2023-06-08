using System;

namespace Palindrome
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        static bool IsPalindrome(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            

            return IsRecursive(str);
        }

        static bool IsRecursive(string str)
        {
            
        }
    }
}
