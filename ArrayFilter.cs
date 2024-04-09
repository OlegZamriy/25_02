using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;
    using System.Collections.Generic;

    public class ArrayFilter
    {
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            List<int> filteredList = new List<int>(originalArray);

            foreach (int item in filterArray)
            {
                filteredList.RemoveAll(i => i == item);
            }

            return filteredList.ToArray();
        }
    }

}
