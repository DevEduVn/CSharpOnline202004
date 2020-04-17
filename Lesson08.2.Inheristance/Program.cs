using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._2.Inheristance
{
    class Program
    {
        static void Main(string[] args)
        {
            // tạo đối tượng
            Dog d = new Dog();
            d.Eat();
            d.DoSomething();
            d.DoAction();

            // tạo đối tượng Animal
            Animal a = new Animal();
            a.Name = "Animal";

            Cat c = new Cat();
            c.Name = "Mèo việt";
            // c.Food = "Chuột"; //=> Không thể sử dụng được vì nó là protected
            c.Input("Chuột", "acb");
            Console.WriteLine("================Cat");
            c.DoAction();

            c = new Cat("Meo nhat");
            c.DoAction();
            Console.WriteLine(c.Name);

        }
    }
}
