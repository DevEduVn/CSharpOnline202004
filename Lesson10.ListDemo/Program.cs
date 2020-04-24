using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> lstInt = new List<int> { 10, 30, 15, 25, 55, 40, 45};
            Show(lstInt);

            //lstInt.OrderBy(x=>x.ToString());
            //Show(lstInt);

            IList<NhanVien> lstNhanVien = new List<NhanVien>
            {
                new NhanVien(1,"Chung Trinhj",10000),
                new NhanVien(2, "Huong Le", 20000),
                new NhanVien(3, "Le Dinh Hoang", 15000),
                new NhanVien(4, "Trung Tran Anh", 25000),
                new NhanVien(5, "Nam Tran", 50000),
                new NhanVien(6,"Nguyen Huy",90000),
                new NhanVien(7,"Nguyen Chanh",80000),
                new NhanVien(8,"Phong Nguyen",75000),
                new NhanVien(9,"Thoi Chan Long",50000)
            };

            foreach (var item in lstNhanVien)
            {
                item.ShowInfo();
            }
            Console.WriteLine("\n Sap theo luong giam dan");
            foreach (var item in lstNhanVien.OrderByDescending(x=>x.Salary))
            {
                item.ShowInfo();
            }

            Console.WriteLine("\n Sap theo luong giam dan, neu trung sap theo ten giam dan");
            foreach (var item in lstNhanVien.OrderByDescending(x => x.Salary).ThenByDescending(x=>x.Name))
            {
                item.ShowInfo();
            }
            Console.ReadLine();
        }
        static void Show(IList<int> lst)
        {
            Console.WriteLine("\n =====Danh sách");
            foreach (var item in lst )
            {
                Console.Write("{0,10}", item);
            }
        }
    }
}
