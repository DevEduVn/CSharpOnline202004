using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.ListDemo
{
    /// <summary>
    /// Tạo lớp quản lý nhân viên: 
    /// - Các thuộc tính: ID, Name, Salary
    /// - Constructor
    /// - Method: ShowInfo()
    /// 
    /// => Test trên main:
    /// - Tạo ArrayList => Chứa 10 đối tượng nhan vien
    /// - Tìm kiếm, sắp xếp
    /// => 15'
    /// </summary>
    class NhanVien
    {
        
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        // Constructor
        public NhanVien()
        {
        }

        public NhanVien(int iD, string name, double salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }

        // Method
        public void ShowInfo()
        {
            Console.WriteLine("{0,-5} {1,-20} {2, 15}",
                ID, Name, Salary);
        }
        public override string ToString()
        {
            return string.Format("{0,-5} {1,-20} {2, 15}",
                ID, Name, Salary); 
        }

        public static explicit operator NhanVien(double v)
        {
            throw new NotImplementedException();
        }
    }
}
