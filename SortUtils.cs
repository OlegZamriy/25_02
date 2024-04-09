using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    public class SortUtils
    {
        public static void BubbleSort(int[] array, bool ascending)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if ((ascending && array[j] > array[j + 1]) || (!ascending && array[j] < array[j + 1]))
                    {
                         int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }

}
