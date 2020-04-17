using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._2.Inheristance
{
    /// <summary>
    ///  Tạo lớp động vật với các tính chất chung
    ///  Base class: Lớp cha
    /// </summary>
    class Animal
    {
        // Field
        private int ID;

        protected string Food;
        protected string Activity;

        public string Name;
        //Constructor
        public Animal() { }
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public void Eat()
        {
            Console.WriteLine("Animal Eating");
        }
        public void DoSomething()
        {
            Console.WriteLine("Animal Dosomething");
        }
    }
    /// <summary>
    ///  Lớp Dog => Lớp con; Derived class
    /// </summary>
    class Dog : Animal
    {
        public void DoAction()
        {
            Eat();
            DoSomething();
        }
    }

    class Cat : Animal
    {

        //Constructor
        public Cat() : base() { }
        public Cat(string Name) : base(Name) { }

        public void Input(string food, string activity)
        {
            Food = food;
            Activity = activity;
        }

        public new void Eat()
        {
            Console.WriteLine("Cat eating...");
        }

        public void DoAction()
        {
            Eat(); // Gọi từ lớp Cat
            DoSomething(); // Từ Lớp Animal
            base.Eat(); // Gọi từ lớp animal
        }
    }

}
