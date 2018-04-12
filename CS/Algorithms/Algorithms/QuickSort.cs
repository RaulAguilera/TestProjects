using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class QuickSort
    {
        public static void Sort(ref int[] array,int start,int end)
        {
            if (start < end)
            {
                int pIndex = Partition(ref array, start, end);
                Sort(ref array, start, pIndex - 1);
                Sort(ref array, pIndex + 1, end);
            }


        }

        public static int Partition(ref int[] array, int start, int end)
        {
            int pivot = array[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    int aux = array[i];
              
                    array[i] = array[pIndex];
                    array[pIndex] = aux;

                    pIndex++;
                }
            }

            int aux2 = array[end];
            array[end] = array[pIndex];
            array[pIndex] = aux2;

            return pIndex;
        }
    }
}
