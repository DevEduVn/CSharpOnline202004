using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07._3.Lab02
{
    class DM_QUAN_HUYEN
    {
        public DM_QUAN_HUYEN(int iD, string mA, string nAME, string mO_TA, int? iD_TINH_THANH, DateTime? nGAY_TAO, string nGUOI_TAO, DateTime? nGAY_CAP_NHAT, string nGUOI_CAP_NHAT, int? tRANG_THAI, bool? iS_DELETE)
        {
            ID = iD;
            MA = mA;
            NAME = nAME;
            MO_TA = mO_TA;
            ID_TINH_THANH = iD_TINH_THANH;
            NGAY_TAO = nGAY_TAO;
            NGUOI_TAO = nGUOI_TAO;
            NGAY_CAP_NHAT = nGAY_CAP_NHAT;
            NGUOI_CAP_NHAT = nGUOI_CAP_NHAT;
            TRANG_THAI = tRANG_THAI;
            IS_DELETE = iS_DELETE;
        }

        public int ID { get; set; }
        public string MA { get; set; }
        public string NAME { get; set; }
        public string MO_TA { get; set; }
        public Nullable<int> ID_TINH_THANH { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
        public string NGUOI_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_CAP_NHAT { get; set; }
        public string NGUOI_CAP_NHAT { get; set; }
        public Nullable<int> TRANG_THAI { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
    }
}
