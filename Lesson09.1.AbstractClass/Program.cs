using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._1.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person p = new Person();
            Employee emp = new Employee();
            emp.DoWork();
            emp.EnviromentWork();
            emp.Speak();

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Lớp trừu tượng, được khai báo với từ khóa abstract
    /// </summary>
    public abstract class Person
    {
        // Properties

        // Method - Có nội dung
        public void Speak()
        {
            Console.WriteLine("Person speak");
        }

        // Method - Không có nội dung => Được khai báo với từ kháo abstract
        public abstract void DoWork();
        public abstract void EnviromentWork();
    }

    // Lớp triển khai

    public class Employee : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Employee work");
        }

        public override void EnviromentWork()
        {
            Console.WriteLine("Moi trong to nhat");
        }
    }

}
