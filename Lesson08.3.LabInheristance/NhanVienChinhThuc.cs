using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._3.LabInheristance
{
    /// <summary>
    /// Kế thừa từ lớp NhanVien
    /// </summary>
    class NhanVienChinhThuc:NhanVien
    {
        public float HsLuong { get; set; }
        public NhanVienChinhThuc():base()
        {
        }

        public NhanVienChinhThuc(int mA, string tenNV, double luongCB, float hsLuong) 
            : base(mA, tenNV, luongCB)
        {
            this.HsLuong = hsLuong;
        }


        public override void Display()
        {
            base.Display();
            Console.WriteLine("HsLuong:" + HsLuong);
            Console.WriteLine("Luong\t:" + TinhLuong());
        }

        public double TinhLuong()
        {
            return HsLuong * LuongCB;
        }
    }
}
