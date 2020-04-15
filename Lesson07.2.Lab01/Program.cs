using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07._2.Lab01
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
                Init() => Khởi tạo 10 tỉnh thành/ phố lư vào 1 mảng
                => Hiển thị danh sách tỉnh thành (ShowInfo())
            */

            DM_TINH_THANH[] lstDM_TINH_THANHs = new DM_TINH_THANH[]
            {
                new DM_TINH_THANH(1,"TPHN","Ha noi","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(2,"TPHCM","Ha noi 1","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(3,"TPDN","Ha noi 3","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(4,"TPCT","Ha noi 3","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(5,"TPNT","Ha noi2","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(6,"TPHP","Ha noi 4","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(7,"TPNB","Ha noi","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(8,"TPTH","Ha noi","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(9,"TPVT","Ha noi","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false),
                new DM_TINH_THANH(10,"TPNA","Ha noi","ha noi thu do",DateTime.Now,"CT",DateTime.Now,"CT",1,false)
            };

            //Hiển thị
            foreach (DM_TINH_THANH item in lstDM_TINH_THANHs)
            {
                item.ShowInfo();
            }

            Console.ReadKey();
        }
    }
    /// <summary>
    ///     Xây dựng lớp DM_TINH_THANH ()
    ///         Properties  :    ID, MA, NAME, MOTA, 
    ///                         NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, IS_ACTIVE, IS_DELETE
    ///         Constructor : Không có tham số / Có tham số
    ///         Method      : ShowInfo()
    ///                         Hiển thị thông tin tỉnh thành theo dạng dòng
    ///                     : 
    ///                  
    ///     Time 15': 
    /// </summary>
    class DM_TINH_THANH
    {

        public int ID { get; set; }
        public string MA { get; set; }
        public string NAME { get; set; }
        public string MO_TA { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public string NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_CAP_NHAT { get; set; }
        public string NGUOI_CAP_NHAT { get; set; }
        public Nullable<int> TRANG_THAI { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public DM_TINH_THANH()
        {
        }

        public DM_TINH_THANH(int iD, string mA, string nAME, string mO_TA,
                    DateTime? nGAY_TAO, string nGUOI_TAO, DateTime? nGAY_CAP_NHAT,
                    string nGUOI_CAP_NHAT, int? tRANG_THAI, bool? iS_DELETE)
        {
            ID = iD;
            MA = mA;
            NAME = nAME;
            MO_TA = mO_TA;
            NGAY_TAO = nGAY_TAO;
            NGUOI_TAO = nGUOI_TAO;
            NGAY_CAP_NHAT = nGAY_CAP_NHAT;
            NGUOI_CAP_NHAT = nGUOI_CAP_NHAT;
            TRANG_THAI = tRANG_THAI;
            IS_DELETE = iS_DELETE;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0,4}{1,5}{2,15}{3,20}{4,10}{5,10}{6,10}{7,10}{8,5}{9,5}",
                ID, MA, NAME, MO_TA, NGAY_TAO, NGUOI_TAO, NGAY_CAP_NHAT, NGUOI_CAP_NHAT, TRANG_THAI, IS_DELETE);
        }
    }
}
