using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class AccountDTO
    {
        private string iD;
        private string tKhoang;
        private string mKhau;
        private int quyenTC;
        private string tThaiTK;
        public AccountDTO(string id, string tk, string mk, int Quyen, string TT)
        {
            this.ID = id;
            this.MKhau = mk;
            this.TKhoang = tk;
            this.QuyenTC = Quyen;
            this.TThaiTK = TT;
        }
        public AccountDTO(DataRow row)
        {
            this.ID = row["MaID"].ToString();
            this.MKhau = row["MK"].ToString();
            this.TKhoang = row["TK"].ToString();
            this.QuyenTC = (int)row["QuyenTC"];
            this.TThaiTK = row["TThaiTK"].ToString();
        }

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string TKhoang
        {
            get
            {
                return tKhoang;
            }

            set
            {
                tKhoang = value;
            }
        }

        public string MKhau
        {
            get
            {
                return mKhau;
            }

            set
            {
                mKhau = value;
            }
        }

        public int QuyenTC
        {
            get
            {
                return quyenTC;
            }

            set
            {
                quyenTC = value;
            }
        }

        public string TThaiTK
        {
            get
            {
                return tThaiTK;
            }

            set
            {
                tThaiTK = value;
            }
        }
    }
}
