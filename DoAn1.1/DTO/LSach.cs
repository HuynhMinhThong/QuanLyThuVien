using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class LSach
    {
        private string maLSach;
        private string tenLSach;
        public LSach(string Ma, string Ten)
        {
            this.MaLSach = Ma;
            this.TenLSach = Ten;
        }
        public LSach(DataRow row)
        {
            this.MaLSach = (string )Convert.ToString( row["MaLSach"].ToString());
            this.TenLSach = (string)Convert.ToString(row["TenLSach"].ToString());
        }
        public string MaLSach
        {
            get
            {
                return maLSach;
            }

            set
            {
                maLSach = value;
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
    }
}
