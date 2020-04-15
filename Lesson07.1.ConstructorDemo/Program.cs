using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07._1.ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng sinh viên
            Student obj = new Student(1010,"Chung Trinh",DateTime.Parse("2020/04/15"),"0978611889");
            obj.ShowInfo();

            obj = new Student();
            obj.RollNo = 1212;

            obj.ShowInfo();

            Console.ReadLine();

        }
    }
    /// <summary>
    /// Class: Student
    /// Properties: RollNo; FullName; BirthDay; Phone;
    /// Constructor:
    ///         - Có tham số
    ///         -> Bổ sung - Không tham số
    /// Method: ShowInfo()
    /// 
    /// </summary>
    class Student
    {
        // Properties:
        public int RollNo { get; set; }
        public string  FullName{ get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }

        // Constructor
        public Student(int rollNo,string FullName, DateTime BirthDay, string Phone)
        {
            RollNo = rollNo;
            this.FullName = FullName;
            this.BirthDay = BirthDay;
            this.Phone = Phone;
        }
        // Constructor => Không tham số
        public Student() { }

        // Method => ShowInfo()
        /// <summary>
        /// Hiển thị thông tin sinh viên
        /// Parmeter: none;
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,15}{3,15}",
                RollNo, FullName, BirthDay, Phone);
        }
    }
}
