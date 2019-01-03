using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    class NXBDAO
    {
        private static NXBDAO instance;
        public NXBDAO() { }
        public List<NXB> LoadSachList()
        {
            List<NXB> LSachList = new List<NXB>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NXB");
            foreach (DataRow item in data.Rows)
            {
                NXB nxb = new NXB(item);
                LSachList.Add(nxb);
            }
            return LSachList;
        }
        public List<NXB> LoadSachListWhereMaNXB(string ma)
        {
            List<NXB> NXBlist = new List<NXB>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select n.MaNXB,n.TenNXB from NXB as n where n.MaNXB= '" + ma + "'");
            foreach (DataRow item in data.Rows)
            {
                NXB tgia = new NXB(item);
                NXBlist.Add(tgia);
            }
            return NXBlist;
        }
        public List<NXB> LoadSachListWhereTenNXB(string Ten)
        {
            List<NXB> NXBlist = new List<NXB>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select n.MaNXB,n.TenNXB from NXB as n where n.TenNXB= N'" + Ten + "'");
            foreach (DataRow item in data.Rows)
            {
                NXB tgia = new NXB(item);
                NXBlist.Add(tgia);
            }
            return NXBlist;
        }
        public List<NXB> LoadSachListWhereMaS(string maS)
        {
            List<NXB> LSachList = new List<NXB>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select n.MaNXB, n.TenNXB from NXB as n, Sach as s where s.MaNXB=n.MaNXB and s.MaSach='"+maS+"'");
            foreach (DataRow item in data.Rows)
            {
                NXB nxb = new NXB(item);
                LSachList.Add(nxb);
            }
            return LSachList;
        }
        public bool UpdateNXB(string Ma, string Ten)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertNXBList @MaNXB , @TenNXB ", new object[] { Ma, Ten });
            return result>0;
        }
        public bool DeleteNXB(string Ma)
        {
            int resule = DataProvider.Instance.ExecuteNonQuery("exec USP_DeleteNXB @MaNXB ", new object[] { Ma });
            return resule > 0;
        }
        internal static NXBDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NXBDAO();
                return NXBDAO. instance;
            }

            set
            {
                NXBDAO. instance = value;
            }
        }
    }
}
