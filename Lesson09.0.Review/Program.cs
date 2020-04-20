using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._0.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            GVCoHuu gVCoHuu = new GVCoHuu(111, "Donal Trump", 100, 500000, 20);
            gVCoHuu.ShowInfo();

            GVTinhGiang gVTinhGiang = new GVTinhGiang(222, "Donal Trinhj", 50, 400000);
            gVTinhGiang.ShowInfo();

            Console.ReadLine();
        }
    }

    // Basic class: 
    /// <summary>
    /// Base class: 
    ///     Lớp -> GiangVien (ID, Name,SoGio, LuongCB)
    ///         -> Constructor
    ///         -> Method: ShowInfo()
    /// Derived Class: GVCoHuu , GVThinhGiang
    ///         - GVCoHuu:
    ///             -> Thuộc tính: DinhMuc (Ví dụ phải giảng 20h)
    ///             -> Phương thức tính lương (TinhLuong)
    ///                 Lương = 5.000.000 + (SoGio-DinhMuc)* LuongCB * 75%
    ///         -> GVThinhGiang:
    ///             -> Lương = SoGio*LuongCB
    ///             
    /// 10'
    /// </summary>
    class GiangVien
    {
        // Properties:
        public int ID { get; set; }
        public string Name { get; set; }
        public int SoGio { get; set; }
        public double LuongCB { get; set; }
        // Constructor
        public GiangVien()
        {
        }

        public GiangVien(int iD, string name, int soGio, double luongCB)
        {
            ID = iD;
            Name = name;
            SoGio = soGio;
            LuongCB = luongCB;
        }

        // Method
        public virtual void ShowInfo()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,5}{3,10}", ID, Name, SoGio, LuongCB);
        }
    }

    // GVCoHuu
    /// <summary>
    ///  - GVCoHuu:
    ///             -> Thuộc tính: DinhMuc (Ví dụ phải giảng 20h)
    ///             -> Phương thức tính lương (TinhLuong)
    ///                 Lương = 5.000.000 + (SoGio-DinhMuc)* LuongCB * 75% (Nếu sogio>dinhmuc)
    /// </summary>
    class GVCoHuu:GiangVien
    {
       
        // Properties
        public int DinhMuc { get; set; }

        //Constructor
        public GVCoHuu():base()
        {
        }

        public GVCoHuu(int iD, string name, int soGio, double luongCB, int dinhMuc) 
            : base(iD, name, soGio, luongCB)
        {
            DinhMuc = dinhMuc;
        }

        // Method
        public double TinhLuong()
        {
            if (SoGio > DinhMuc)
                return 5000000F + (SoGio - DinhMuc) * LuongCB * 75 / 100;
            else
                return 5000000F;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Tong luong: " + TinhLuong());
        }
    }
    // GVTinhGian
    /// <summary>
    ///  - GVThinhGian:
    ///            
    ///             -> Phương thức tính lương (TinhLuong)
    ///                -> Lương = SoGio*LuongCB
    /// </summary>
    class GVTinhGiang : GiangVien
    {

        // Properties
        public int DinhMuc { get; set; }

        //Constructor
        public GVTinhGiang() : base()
        {
        }

        public GVTinhGiang(int iD, string name, int soGio, double luongCB)
            : base(iD, name, soGio, luongCB)
        {
          
        }

        // Method
        public double TinhLuong()
        {
            return SoGio * LuongCB;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Tong luong: " + TinhLuong());
        }
    }
}
