using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06._5.PropertiesAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Product
            Product p = new Product();
            p.ID = 1234;
            p.Name = "Iphone";
            p.Quantity = 123;
            p.Price = 100000;

            p.DisplayProduct();

            Console.ReadLine();
        }
    }
    /// <summary>
    ///     Product(ID, Name, Price, Quantity)
    ///     - Tạo các thuộc tính tự động
    ///     - Viết phương thức hiển thị thông tin
    /// </summary>
    class Product
    {
        // Properties Auto
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // public double Price { get; private set; } //Thuộc tính chỉ đọc
        // public int Quantity { private get; set; } // Thuộc tính chỉ ghi
        // Method:
        public void DisplayProduct()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,10}{3,10}", ID, Name, Price, Quantity);
        }
    }
}
