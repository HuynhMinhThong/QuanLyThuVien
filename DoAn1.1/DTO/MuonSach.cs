using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DTO
{
    public class MuonSach
    {
        private string maMuonS;
        private string maID;
        private string maSach;
        private DateTime? ngayMuon;
        public MuonSach() { }

        public string MaMuonS
        {
            get
            {
                return maMuonS;
            }

            set
            {
                maMuonS = value;
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
    }
}
