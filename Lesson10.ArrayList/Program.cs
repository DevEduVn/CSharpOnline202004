using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson10.ArrayListDemo
{
    class Program
    {
        /// <summary>
        /// làm việc collection: ArrayList
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            // Properties
            Console.WriteLine("Capacity:" + arr.Capacity);
            Console.WriteLine("Count:" + arr.Count);
            Console.ReadLine();

            // Add
            arr.Add(10);
            arr.Add(20);
            Console.WriteLine("Capacity:" + arr.Capacity);
            Console.WriteLine("Count:" + arr.Count);
            Console.ReadLine();

            arr.Add(10);
            arr.Add(25);
            arr.Add(50);
            Console.WriteLine("Capacity:" + arr.Capacity);
            Console.WriteLine("Count:" + arr.Count);
            Console.ReadLine();

            // addRange
            arr.AddRange(new int[] { 1, 4, 2, 5 });
            ShowArr(arr);

            // Remove
            arr.Remove(10);
            ShowArr(arr);
            arr.RemoveAt(0);
            ShowArr(arr);

            arr.RemoveRange(0, 3);
            ShowArr(arr);

            // Insert
            arr.Insert(0, "Chung ");
            arr.Insert(0, "Trinhj ");
            ShowArr(arr);
            arr.Remove("Chung ");
            arr.Remove("Trinhj ");

            arr.AddRange(new int[] { 10, 30, 25, 15 });
            ShowArr(arr);

            
            // Sort - Sắp tăng
            arr.Sort();
            ShowArr(arr);

            // Sắp giảm
            IComparer SortDesc = new MySort();
            arr.Sort(SortDesc);
            ShowArr(arr);

            // Tìm kiếm
            if (arr.IndexOf(10)>0)
            {
                Console.WriteLine("\n Tim thay tai vi tri:" + arr.IndexOf(10));
            }
            arr.Add(10);
            ShowArr(arr);
            Console.WriteLine("\n Tim thay tai vi tri:" + arr.LastIndexOf(10));

            // clear
            arr.Clear();
            ShowArr(arr);

            Console.WriteLine("Capacity:" + arr.Capacity);
            Console.WriteLine("Count:" + arr.Count);
            arr.AddRange(new string[] { "Hung", "Dung", "Nam", "Tao", "Bac", "Dau" });
            ShowArr(arr);

            var res = arr.Contains("Nam");
            Console.WriteLine("\n" + res);
            Console.ReadLine();

        }
        
        static void ShowArr(ArrayList lst)
        {
            Console.WriteLine("\n ===== Danh sach:");
            foreach (var item in lst)
            {
                Console.Write("{0,10}", item);
            }
        }

        class MySort : IComparer
        {
            public int Compare(object x, object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }
    }
}
