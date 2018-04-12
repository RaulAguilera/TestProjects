using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 6, 5, 4, 3, -5, 1, 0 };

            QuickSort.Sort(ref array, 0, array.Length - 1);

            Console.WriteLine(BinarySearch.Search(array, 5));

           //Comment to test remote repository


            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
        }
    }
}
