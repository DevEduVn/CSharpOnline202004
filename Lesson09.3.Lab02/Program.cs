using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09._3.Lab02
{

    /// <summary>
    /// Lab04.2: Tạo ứng dụng C# minh họa lớp abstract và kế thừa như hình sau
    /// 
    /// 15'
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ///NhanVien nv = new NhanVien();

            NhanVien[] nhanViens = new NhanVien[]
            {
                new NhanVienBanHang(){Ten="ABC",DiaChi="25 VNP",SoLuongBanDuoc=10},
                new NhanVienBanHang(){Ten="ABC 2",DiaChi="25 VNP",SoLuongBanDuoc=110},
                new NhanVienBanHang(){Ten="ABC 3 ",DiaChi="26 VNP",SoLuongBanDuoc=120},
                new NhanVienBanHang(){Ten="ABC 4",DiaChi="28 VNP",SoLuongBanDuoc=150},

                new CongNhan(){Ten="CN 1",DiaChi="25 VNP",SoLuongSanPham=10},
                new CongNhan(){Ten="CN 2",DiaChi="27 VNP",SoLuongSanPham=120},
                new CongNhan(){Ten="CN 3",DiaChi="29 VNP",SoLuongSanPham=140},
                new CongNhan(){Ten="CN 4",DiaChi="35 VNP",SoLuongSanPham=160}
            };
            // Hien thi
            foreach (var item in nhanViens)
            {
                //item.HienThi();
                Console.WriteLine(item.ToString());
            }

            // Yeu cau: sắp xếp nhân viên bán hàng theo lương tăng dần, sau đó đến công nhân theo lương giảm dần
            Console.ReadLine();
        }
    }
}
