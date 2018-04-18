using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            List<int> list = array.ToList();
            List<int> newList = new List<int>();
            int arrayLength = array.Length;
            int smallestIndex;
            
            for (int i = 0; i < arrayLength; i++)
            {
                smallestIndex = SmallestIndex(list);
                newList.Add(list[smallestIndex]);
                list.RemoveAt(smallestIndex);
            }

            return newList.ToArray();
        }

        private static int SmallestIndex(List<int> list)
        {
            int smallest = list[0];
            int smallestIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
    }
}
