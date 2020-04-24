using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.ArrayListObject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            // Khởi tạo các đối tượng nhân viên
            arr.AddRange(new NhanVien[] {
                new NhanVien(1,"Chung Trinhj",10000),
                new NhanVien(2, "Huong Le", 20000),
                new NhanVien(3, "Le Dinh Hoang", 15000),
                new NhanVien(4, "Trung Tran Anh", 25000),
                new NhanVien(5, "Nam Tran", 50000),
                new NhanVien(6,"Nguyen Huy",90000),
                new NhanVien(7,"Nguyen Chanh",80000),
                new NhanVien(8,"Phong Nguyen",75000),
                new NhanVien(9,"Thoi Chan Long",50000)
            });

            // Xuất mảng
            Show(arr);

            // Tìm kiếm nhân viên có tên là giá trị chứa giá trị nhập
            Console.Write("Nhap nhan vien can tim:");
            string NameKey = Console.ReadLine();
            foreach (NhanVien item in arr)
            {
                if (item.Name.Contains(NameKey))
                {
                    item.ShowInfo();
                }
            }

            // Săp xếp
            IComparer sort = new SortBySalary();
            arr.Sort(sort);
            Show(arr);
            Console.ReadLine();
        }
        static void Show(ArrayList arr)
        {
            Console.WriteLine("\n===== Danh sach nhan vien");
            foreach (NhanVien item in arr)
            {
                item.ShowInfo();
            }
        }
    }

    class SortBySalary : IComparer
    {
        public int Compare(object x, object y)
        {
            NhanVien a = x as NhanVien;
            NhanVien b = (NhanVien)y;
            if (a.Salary > b.Salary)
                return -1;
            else
                return 1;
        }
    }

}
