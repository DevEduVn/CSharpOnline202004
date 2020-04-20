using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._3.Lab02
{
    class NhanVienBanHang : NhanVien
    {
        public int SoLuongBanDuoc { get; set; }

        public override double TinhLuong()
        {
            return SoLuongBanDuoc * 200000;
        }
        public override void HienThi()
        {
            Console.WriteLine("Ten\t:" + Ten);
            Console.WriteLine("Dia chi \t:" + DiaChi);
            Console.WriteLine("Luong\t:" + TinhLuong());
            Console.WriteLine("===============================");
        }

        public override string ToString()
        {
            return string.Format("{0,-20} | {1,-30} | {2,5} | {3, 15} ", Ten, DiaChi, SoLuongBanDuoc, TinhLuong());
        }

    }
}
