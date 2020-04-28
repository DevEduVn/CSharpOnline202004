using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.LinqEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEVHRMEntities db = new DEVHRMEntities();
            //var dmTinh = db.DM_TINH_THANH.ToList();
            //foreach (var item in dmTinh)
            //{
            //    Console.WriteLine("{0,10}{1,30}", item.MA, item.NAME);
            //}
            //Console.Write("Nhap ten tinh thanh co chua:");
            //string tt = Console.ReadLine();
            //var Tim = db.DM_TINH_THANH.Where(t => t.NAME.Contains(tt));

            //foreach (var item in Tim)
            //{
            //    Console.WriteLine("{0,10}{1,30}", item.MA, item.NAME);
            //}

            Form2 frm = new Form2();
            frm.Show();
            Console.ReadLine();
        }
    }
}
