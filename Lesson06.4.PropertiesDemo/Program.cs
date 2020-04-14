using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06._4.PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tạo đối tượng Employee
            Employees emp = new Employees();
            // Gán giá trị cho các thuộc tính
            //emp.EmpID = 1234; => Error (Vì là thuộc tính chỉ đọc
            emp.Name = "Donal Trump";
            emp.Salary = 123456789F;

            // Gọi thực hiện phương thức
            emp.DisplayInfo();

            Console.ReadKey();

        }
    }
    /// <summary>
    /// -   Properties  : EmpID (Chỉ đọc), Name, Salary (Chỉ ghi)
    /// -   Method      : Display() => Hiển thị các thông
    /// </summary>
    class Employees
    {
        // 5'
        // Field
        private int _EmpID;
        private string _Name;
        private double _Salary;
        // Properties
        public int EmpID
        {
            get { return _EmpID; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public double Salary
        {
            set { _Salary = value; }
        }
        // Method
        public void DisplayInfo()
        {
            Console.WriteLine("Employee ID:" + EmpID);
            Console.WriteLine("Name\t:" + Name);
            Console.WriteLine("Salary :" + _Salary);
        }
    }
}
