using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class InsertionSort
    {
        public static void Sort(ref int[] array)
        {
            int key;
            int i;
            for (var j = 1; j < array.Length; j++)
            {
                key = array[j];
                i = j - 1;
                while (i >= 0 && array[i] > key)
                {
                    array[i + 1] = array[i];
                    i--;
                }
                array[i + 1] = key;
            }
        }
    }
}
