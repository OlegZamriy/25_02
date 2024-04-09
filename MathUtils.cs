using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class MathUtils
    {
        public static bool IsFibonacciAndPrime(int number)
        {
            if (IsFibonacci(number) && IsPrime(number))
            {
                return true;
            }
            return false;
        }

        private static bool IsFibonacci(int number)
        {
            int a = 0, b = 1;

            while (b < number)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b == number;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}
