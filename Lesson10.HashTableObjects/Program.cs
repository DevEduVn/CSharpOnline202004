using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.HashTableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htObj = new Hashtable();
            htObj.Add(1, new NhanVien(1, "Chung Trinhj", 10000));
            htObj.Add(2, new NhanVien(2, "Huong Le", 20000));
            htObj.Add(3, new NhanVien(3, "Le Dinh Hoang", 15000));
            htObj.Add(4, new NhanVien(4, "Trung Tran Anh", 25000));
            htObj.Add(5, new NhanVien(5, "Nam Tran", 50000));
            htObj.Add(6, new NhanVien(6, "Nguyen Huy", 90000));
            htObj.Add(7, new NhanVien(7, "Nguyen Chanh", 80000));
            htObj.Add(8, new NhanVien(8, "Phong Nguyen", 75000));
            htObj.Add(9, new NhanVien(9, "Thoi Chan Long", 50000));

            foreach (var item in htObj.Values)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
