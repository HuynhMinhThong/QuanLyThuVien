using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class NXB
    {
        private string maNXB;
        private string tenNXB;
        public NXB (string Ma, string  Ten)
        {
            this.MaNXB = Ma;
            this.TenNXB = Ten;
        }
        public NXB(DataRow row)
        {
            this.MaNXB = (string)Convert.ToString(row["MaNXB"].ToString());
            this.TenNXB = (string)Convert.ToString(row["TenNXB"].ToString());
        }
        public string MaNXB
        {
            get
            {
                return maNXB;
            }

            set
            {
                maNXB = value;
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
