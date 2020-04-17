using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._3.LabInheristance
{
    class NhanVien
    {
        public int MA { get; set; }
        public string  TenNV { get; set; }
        public double LuongCB { get; set; }

        public NhanVien() { }

        public NhanVien(int mA, string tenNV, double luongCB)
        {
            MA = mA;
            TenNV = tenNV;
            LuongCB = luongCB;
        }

        public virtual void Display()
        {
            Console.WriteLine("Ma \t:" + MA);
            Console.WriteLine("Ten \t:" + TenNV);
            Console.WriteLine("LuongCB\t:" + LuongCB);
        }
    }
}
