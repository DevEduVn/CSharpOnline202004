using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Lab01BT2
{
    /// <summary>
    /// Bài 1.2: Viết chương trình thực hiện các yêu cầu sau 
    ///    - Khai báo các biến để lưu trữ thông tin của Nhân Viên bao gồm: 
    ///    o Mã Nhân viên 
    ///    o Họ tên nhân viên 
    ///    o Ngày sinh 
    ///    o Địa chỉ 
    ///    o Điện thoại 
    ///    o Email 
    ///    - Nhập
    ///    - Hiển thị trên màn hình thông tin của nhân viên
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            string MaNV, HoVaTen, DiaChi, Email, DienThoai;
            DateTime NgaySinh;
            // Input
            Console.Write("Ma Nhan Vien:");
            MaNV = Console.ReadLine();

            Console.Write("Ho Va Ten:");
            HoVaTen = Console.ReadLine();

            Console.Write("Email:");
            Email = Console.ReadLine();

            Console.Write("Dia chi:");
            DiaChi = Console.ReadLine();

            Console.Write("Dien thoai:");
            DienThoai = Console.ReadLine();

            Console.Write("Ngay sinh:");
            NgaySinh = DateTime.Parse(Console.ReadLine());

            //Xuất
            Console.WriteLine(MaNV);
            Console.WriteLine(HoVaTen);
            Console.WriteLine(DiaChi);
            Console.WriteLine(Email);
            Console.WriteLine(DienThoai);
            Console.WriteLine(NgaySinh);

            Console.WriteLine(NgaySinh.ToShortDateString());

            Console.WriteLine(NgaySinh.ToString("dd-MM-yyyy"));
            Console.ReadLine();
        }
    }
}
