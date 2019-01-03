using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private string tenLSach;
        private string tenTGia;
        private string tenNXB;
        private int soLuong;    
        public Sach(string Ma, string TenS, string TenLS, string TenTG, string TenNXB, int SLuong)
        {
            this.MaSach = Ma;
            this.TenSach = TenS;
            this.TenLSach = TenLS;
            this.TenTGia = TenTG;
            this.TenNXB = TenNXB;
            this.SoLuong = SLuong;
        }
        public Sach(DataRow row)
        {
            this.MaSach = row["MaSach"].ToString();
            this.TenSach = row["TenSach"].ToString();
            this.TenLSach = row["TenLSach"].ToString();
            this.TenTGia = row["TenTGia"].ToString();
            this.TenNXB = row["TenNXB"].ToString();
            this.SoLuong = (int)row["SoLuong"];
        }
        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public string TenSach
        {
            get
            {
                return tenSach;
            }

            set
            {
                tenSach = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string TenLSach
        {
            get
            {
                return tenLSach;
            }

            set
            {
                tenLSach = value;
            }
        }

        public string TenTGia
        {
            get
            {
                return tenTGia;
            }

            set
            {
                tenTGia = value;
            }
        }

        public string TenNXB
        {
            get
            {
                return tenNXB;
            }

            set
            {
                tenNXB = value;
            }
        }
    }
}
