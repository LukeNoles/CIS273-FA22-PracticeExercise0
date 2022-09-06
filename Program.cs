using System;
using static System.Net.Mime.MediaTypeNames;

namespace palindromechecker
{
    class Program
    {
        public static bool IsPalindrome(string s)
        {
            int s_length = s.Length;
            for (int checker = 0; checker < s_length / 2; checker++)
            {
                if (s[checker] != s[s_length - checker - 1])
                    return false;
            }
            return true;

        }
    }
}

namespace reversal
{
    class Program
    {
        public static int ReverseInt(int i)
        {
            int reverseInt = 0;
            while (i > 0)
            {
                reverseInt = (reverseInt * 10) + (i % 10);
                i = i / 10;
            }
            return reverseInt;
        }
    }
}

namespace unique
{
    class Program
    {
        public static bool IsUnique(string s)
        {

        }
    }
}

namespace neil
{
    class Program
    {
        public static bool IsNeilNumber(int i)
        {

        }
    }
}