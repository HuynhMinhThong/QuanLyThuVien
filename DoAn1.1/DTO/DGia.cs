using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class DGia
    {
        private string maDGia;
        private string tenDGia;
        private DateTime? ngaySinh;
        private bool gTinh;
        private string dChiDGia;
        private bool tTDGia;
        private string sdt;

        public DGia(string Ma, string Ten,DateTime? NSinh, bool GT, string DChi, bool TThai, string SDT )
        {
            this.MaDGia = Ma;
            this.TenDGia = Ten;
            this.NgaySinh = NSinh;
            this.GTinh = GT;
            this.DChiDGia = DChi;
            this.TTDGia = TThai;
            this.Sdt = SDT;
        }
        public DGia(DataRow row)
        {
            this.MaDGia = row["MaDGia"].ToString();
            this.TenDGia = row["TenDGia"].ToString();
            var KT= row["NgaySinhDGia"];
            if (KT.ToString() != "")
                this.NgaySinh = (DateTime?)KT;
            this.GTinh = (bool)row["GTinh"];
            this.DChiDGia = row["DChiDGia"].ToString();
            this.TTDGia = (bool)row["TTDGia"];
            this.Sdt = row["SDT"].ToString();
        }
        public string MaDGia
        {
            get
            {
                return maDGia;
            }

            set
            {
                maDGia = value;
            }
        }
        public string TenDGia
        {
            get
            {
                return tenDGia;
            }

            set
            {
                tenDGia = value;
            }
        }
        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
        public DateTime? NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string DChiDGia
        {
            get
            {
                return dChiDGia;
            }

            set
            {
                dChiDGia = value;
            }
        }

        
        public bool GTinh
        {
            get
            {
                return gTinh;
            }

            set
            {
                gTinh = value;
            }
        }

        public bool TTDGia
        {
            get
            {
                return tTDGia;
            }

            set
            {
                tTDGia = value;
            }
        }
    }
}
