using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    public class TraSDAO
    {
        private static TraSDAO instance;
        public TraSDAO() { }
        public bool InsertTraSach(int Mam, string MaS, int SLconlai, string NgayTra)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_TraSach @MaMuon , @MaSach , @SLConLai , @NgTra ", new object[] { Mam, MaS, SLconlai, NgayTra });
            return result > 0;
        }
        public static TraSDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraSDAO();
                return TraSDAO. instance;
            }

            private set
            {
                TraSDAO. instance = value;
            }
        }
    }
}
