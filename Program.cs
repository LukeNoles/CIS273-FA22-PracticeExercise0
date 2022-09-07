using System;

namespace PracticeExcercise0
{
    public class Program
    {
        public static bool IsPalindrome(string s)
        {
            string cleanString = s.ToLower().Replace(" ", "");

            string reversed = Reverse(cleanString);

            return (reversed == cleanString);
        }

        private static string Reverse(string s)
        {
            string result = "";

            foreach( char c in s)
            {
                result = result.Insert(0, c.ToString() );
            }

            return result;
        }


        public static int ReverseInt(int i)
        {
            int x = i;
            int reverse = 0;

            while( x != 0 )
            {
                int remainder = x % 10;
                reverse = reverse * 10 + remainder;
                x = x / 10;
            }

            return reverse;
        }


        public static bool IsUnique(string s)
        {
            string cleanString = s.ToLower().Replace(" ", "");

            for( int i=0; i < cleanString.Length; i++)
            {

                for(int j=i+1; j < cleanString.Length; j++)
                {
                    if (cleanString[i] == cleanString[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsNeilNumber(int i)
        {
            int nDigits = i.ToString().Length;
            int count = 0;
            int bottom = i.ToString()[count];
            double equation1 = Math.Pow(bottom, nDigits);
            double equation2 = 0;

            while (count < nDigits) ;
            {
                count += 1;
                equation2 = equation1 + equation2;
            }
            if (equation2 == i) ;
            {
                return true;
            }
            else;
            {
                return false;
            }
            
        }

    }
}
