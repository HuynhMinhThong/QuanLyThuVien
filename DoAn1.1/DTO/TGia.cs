using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class TGia
    {
        private string maTGia;
        private string tenTGia;
        public TGia(string Ma, string Ten)
        {
            this.MaTGia = Ma;
            this.TenTGia = Ten;
        }
        public TGia(DataRow row)
        {
            this.MaTGia = (string)Convert.ToString(row["MaTGia"].ToString());
            this.TenTGia = (string)Convert.ToString(row["TenTGia"].ToString());
        }
        public string MaTGia
        {
            get
            {
                return maTGia;
            }

            set
            {
                maTGia = value;
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
    }
}
