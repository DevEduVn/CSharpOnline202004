using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._3.Lab02
{
    /// <summary>
    /// NhanVien
    ///        Ten
    ///        DiaChi
    ///    abstract TinhLuong()
    ///    abstract HienThi()
    /// </summary>
    abstract class NhanVien
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }

        public abstract double TinhLuong();
        public abstract void HienThi();
    }
}
