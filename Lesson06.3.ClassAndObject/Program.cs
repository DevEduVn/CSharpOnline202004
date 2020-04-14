using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06._3.ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo đối tượng
            Student obj = new Student();
            // truy xuất thuộc tính của đối tượng
            obj.ID = 1214;
            obj.Name = "Donal Trump";
            obj.Age = 40;
            // Gọi thực hiện phương thức
            obj.ShowInfo();

            Console.ReadLine();
        }
    }

    class Student
    {
        // Field: Mô tả thông tin lưu trữ của đối tượng sinh viên
        private int _ID;
        private string _Name;
        private int _Age;

        // Properties: Thuộc tính của đối tượng
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Age
        {
            get { return _Age; }
            // set { _Age = value; }
            set
            {
                if(value<18 || value > 60)
                {
                    _Age = 0;
                }
                else
                {
                    _Age = value;
                }
            }
        }

        // Method: Chỉ các hoạt động của đối tượng trong lớp
        public void ShowInfo()
        {
            Console.WriteLine("RollNo \t: " + ID);
            Console.WriteLine("Name \t: " + Name);
            Console.WriteLine("Age \t: " + Age);

        }
    }
}
