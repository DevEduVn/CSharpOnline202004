using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "Dinh", "Le", "Trinh", "Nguyen", "Te", "So", "Tan" };
            int[] arr2 = { 10, 30, 20, 40, 5, 50, 300, 250 };

            Show<string>(arr1, "Mang ban dau");
            Show<int>(arr2, "Mang so nguyen ban dau:");

            Console.ReadLine();

            var result = from str in arr1 select str;
            Show<string>(result, "Du lieu truy van linq");

            var nums =  from num in arr2
                        where num > 30
                        select num;

            Show<int>(nums, " Du lieu truy van dieu khien num>30 ");

            // Tìm kiếm tên có chứa T hoặc
            result = from str in arr1
                     where str.Contains("T") || str.Contains("n")
                     select str;

            Show<string>(result, "Tìm tên có chứa T");

            Console.ReadLine();

        }

        static void Show<T>(IEnumerable<T> list, string msg)
        {
            Console.WriteLine("\n " + msg);
            foreach (var item in list)
            {
                Console.Write("{0,10}",item);
            }
        }
    }
}
