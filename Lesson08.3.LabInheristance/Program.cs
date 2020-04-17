using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._3.LabInheristance
{
   /// <summary>
   /// Overidding
   /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien(12, "Chung", 1000);
            nv.Display();

            NhanVienChinhThuc NvCT = new NhanVienChinhThuc(123, "Donal Trump", 1000, 3.5F);
            NvCT.Display();

            NhanVienCongTac NvCtac = new NhanVienCongTac(234, "Trump Donal", 34555, 4.5f);
            NvCtac.Display();

            Console.ReadLine();
        }
    }
}
/// <summary>
///  - Tạo lớp cơ sở NhanVien(ID,Name, BasicSalary)
///  - Tạo 2 lớp dẫn xuất:
///     NhanVienChinhThuc: Kế thừa lớp NhanVien
///                         - Thêm thuộc tính hệ số lương (HsLuong)
///     NhanVienCongTac:    kế thừa từ lớp NhanVien
///                         - Thêm thuộc tính HsLuong
///  - Trên 2 lớp kế thừa: Tạo phương thức tính lương tương ứng
///     -> tạo phương thức hiển thị
///     
///   *=> Có thuộc tính, constructor
///   => 15'
///  // tạo mảng 10 nhân viên (5 nhân viên chính thức , 5 nhân viên cơ hữu)
///  
/// </summary>
