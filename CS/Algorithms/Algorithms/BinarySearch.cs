using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int find)
        {
            int size = array.Length;
            int low = 0;
            int high = size - 1;
            int position,guess;

            while (low <= high)
            {
                position = (low + high) / 2;
                guess = array[position];
                if (guess == find)
                    return position;
                else if (guess < find)
                    low = position + 1;
                else 
                    high = position - 1;
            }

            return -1;
        }
    }
}
