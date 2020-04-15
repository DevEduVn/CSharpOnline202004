using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07._0.Review
{
    /// <summary>
    /// Review Class And Object
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng nhân viên
            Employees emp = new Employees();
            // Truy xuất đến các thuộc tính
            emp.EmpID = 10001;
            emp.Name = "Donal Trump";
            emp.Phone = "0978611889";
            emp.Email = "tvchung@outlook.com";
            emp.Salary = 12345678;

            // Gọi thực hiện phương thức
            emp.ShowInfo();

            Console.ReadLine();

        }
    }
    /// <summary>
    ///     Class: Employees
    ///         Properties  : EmpID, Name, Phone, Email, Salary
    ///         Method      : ShowInfo()
    /// </summary>
    class Employees
    {
        // Properties:(auto)
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        // Method
        public void ShowInfo()
        {
            Console.WriteLine("{0,-5}{1,-15}{2,10}{3,15}{4,15}",
                EmpID,Name,Phone,Email,Salary);
        }

    }
}
