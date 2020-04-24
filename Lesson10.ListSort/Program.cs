using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.ListSort
{
    class Program
    {
        static void Main(string[] args)
        {


            // List initialize 
            List<int> list1 = new List<int> { 
            // list elements 
                1, 5, 6, 2, 4, 3

            };

            Console.WriteLine("Original List");

            foreach (int g in list1)
            {

                // Display Original List 
                Console.WriteLine(g);
            }

            Console.WriteLine("\nSorted List");

            // use of List<T>.Sort() method 
            list1.Sort();

            foreach (int g in list1)
            {

                // Display sorted list 
                Console.WriteLine(g);
            }


        }
    }
}
