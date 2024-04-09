using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(int number)
        {
            int reverse = 0;
            int original = number;

            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            return original == reverse;
        }
    }

}
