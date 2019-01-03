using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    public class LSachDAO
    {
        private static LSachDAO insTance;
        public LSachDAO() { }
        public List<LSach> LoadSachList()
        {
            List<LSach> LSachList = new List<LSach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LSach");
            foreach (DataRow item in data.Rows)
            {
                LSach lsach = new LSach(item);
                LSachList.Add(lsach);
            }
            return LSachList;
        }
        
        public List<LSach> LoadSachListWhereMaLS(string ma)
        {
            List<LSach> LSachList = new List<LSach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select ls.MaLSach, ls.TenLSach from LSach as ls where ls.MaLSach= '"+ma+"'");
            foreach (DataRow item in data.Rows)
            {
                LSach lsach = new LSach(item);
                LSachList.Add(lsach);
            }
            return LSachList;
        }

        public List<LSach> LoadSachListWhereTenLS(string Ten)
        {
            List<LSach> LSachList = new List<LSach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select ls.MaLSach, ls.TenLSach from LSach as ls where ls.TenLSach= N'" + Ten + "'");
            foreach (DataRow item in data.Rows)
            {
                LSach lsach = new LSach(item);
                LSachList.Add(lsach);
            }
            return LSachList;
        }

        public List<LSach> LoadSachListWhereMaS(string maS)
        {
            List<LSach> LSachList = new List<LSach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select ls.MaLSach, ls.TenLSach from LSach as ls, Sach as s where s.MaLSach= ls.MaLSach and s.MaSach='"+maS+"'");
            foreach (DataRow item in data.Rows)
            {
                LSach lsach = new LSach(item);
                LSachList.Add(lsach);
            }
            return LSachList;
        }

        public bool AddLSachList(string Ma, string Ten)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_AddLSachList @MaLSach , @TenLSach ", new object[] {Ma, Ten});
            return result > 0;
        }

        public bool  UpdateLSachList(string Ma, string Ten)
        {
           int result= DataProvider.Instance.ExecuteNonQuery("exec  USP_InsertLSachList @MaLSach , @TenLSach ",new object[] { Ma,Ten});
            return result>0;
        }

        public bool  DeleteLSachList(string Ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec  USP_DeleteLSach @MaLSach ", new object[] { Ma});
            return result > 0;
        }
        
        public static LSachDAO InsTance
        {
            get
            {
                if (insTance == null)
                    insTance = new LSachDAO();
                return LSachDAO.insTance;
            }

            private  set
            {
                LSachDAO.insTance = value;
            }
        }
    }
}
