using System;

namespace Palindrome
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static bool IsPalindrome(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length < 2)
            {
                return true;
            }

            return IsRecursive(str);
        }

        private static bool IsRecursive(string str)
        {
            if (str.Length < 2)
            {
                return true;
            }

            if (str[0] == str[^1])
            {
                string substring = str.Substring(1, str.Length - 2);
                return IsRecursive(substring);
            }

            return false;
        }
    }
}
