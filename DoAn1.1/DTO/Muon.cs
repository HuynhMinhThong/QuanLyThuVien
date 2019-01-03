using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class Muon
    {
        //m.MaMuon, i.MaID, d.MaDGia, d.TenDGia, s.MaSach, s.TenSach, m.SoLuong, m.NgayMuon 
        private int maMuon;
        private string maID;
        private string maDGia;
        private string tenDGia;
        private string maSach;
        private string tenSach;
        private int soLuong;
        private DateTime? ngayMuon;
        private bool trangThaiMuon;

        public Muon(int Mam, string Maid, string Madg, string Tendg, string Mas, string Tens, int Solg, DateTime? Ngm , bool TT)
        {
            this.MaMuon = Mam;
            this.MaID = Maid;
            this.MaDGia = Madg;
            this.TenDGia = Tendg;
            this.MaSach = Mas;
            this.TenSach = Tens;
            this.SoLuong = Solg;
            this.NgayMuon = Ngm;
            this.TrangThaiMuon = TT;
        }
        public Muon(DataRow row)
        {
            this.MaMuon = (int)row["MaMuon"];
            this.MaID = row["MaID"].ToString();
            this.MaDGia = row["MaDGia"].ToString();
            this.TenDGia = row["TenDGia"].ToString();
            this.MaSach = row["MaSach"].ToString();
            this.TenSach = row["TenSach"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            var KT = row["NgayMuon"];
            if (KT.ToString() != "")
                this.NgayMuon = (DateTime?)KT;
            this.TrangThaiMuon = (bool)row["TThaiMuon"];
        }
        public int MaMuon
        {
            get
            {
                return maMuon;
            }

            set
            {
                maMuon = value;
            }
        }

        public string MaID
        {
            get
            {
                return maID;
            }

            set
            {
                maID = value;
            }
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

        public DateTime? NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
            }
        }

        public bool TrangThaiMuon
        {
            get
            {
                return trangThaiMuon;
            }

            set
            {
                trangThaiMuon = value;
            }
        }
    }
}
