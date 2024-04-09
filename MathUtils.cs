using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    public class MathUtils
    {
        public static int GetProductInRange(int start, int end)
        {
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
    }

}
