using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._0.Review
{

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng đối tượng product
            Product[] obj = new Product[]
            {
                new Product(1,"Nokia",1000,10),
                new Product(2,"Samsung",2000,150),
                new Product(3,"BPhone",3000,300),
                new Product(4,"IPhone",10000,50),
                new Product(5,"Vietnam",1000,150)
            };
            // In
            foreach (var item in obj)
            {
                item.ShowProduct();
            }

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Review:
    ///     - Tạo lớp Product
    ///     - Tạo các thuộc tính tự động (PID, Name, Price, Qty)
    ///     - Tạo các constructor tương ứng
    ///     - Tạo các phương thức:
    ///         - ShowProduct: => Hiển thị thông tin sản phẩm
    ///         - MoneyProduct => Tính thành tiền cho từng sản phẩm
    ///     - Test:
    ///         Khởi tạo 1 mảng 5 phần tử Product
    ///         Gọi thưc hiện các phương thức
    ///     - Time: 10'
    /// </summary>

    class Product
    {   
        // Properties
        public int PID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }

        // Constructor
        public Product(){}

        public Product(int pID, string name, float price, int qty)
        {
            PID = pID;
            Name = name;
            Price = price;
            Qty = qty;
        }
        
        // Method
        public void ShowProduct()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,5}{3,10},{4,10}",
                PID,Name,Qty,Price, MoneyProduct());
        }

        public float MoneyProduct()
        {
            return Qty * Price;
        }
    }
}
