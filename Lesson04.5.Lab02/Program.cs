using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._5.Lab02
{
    class Program
    {
        //Lab02.5: Viết chương trình in ra các hình sau.  (In tam giác)
        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");

            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,4}", "*");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();

            for (int i = n; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,4}", "*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
            /*
                     *
                   * * 
                 * * *
               * * * *
            */
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write("{0,4}", " ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,4}", "*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

            /*
             * * * * *
               * * * *
                 * * *
                   * *
                     *
             */
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <i; j++)
                {
                    Console.Write("{0,4}", " ");
                }
                for (int j = 1; j <= n-i+1; j++)
                {
                    Console.Write("{0,4}", "*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

            /*
                    *
                  * * *
                * * * * *
              * * * * * * *  
            * * * * * * * * *
            
             */

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("{0,4}", " ");
                }
                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("{0,4}", "*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

    }
}
