using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    public class DGiaDAO
    {
        private static DGiaDAO instance;

        public DGiaDAO() { }

        public List<DGia> LoadDG()
        {
            List<DGia> Listdgia = new List<DTO.DGia>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DGia");
            foreach (DataRow item in data.Rows)
            {
                DGia dgia = new DGia(item);
                Listdgia.Add(dgia);
            }
            return Listdgia;
        }

        public List<DGia> LoadDGMa(string ma)
        {
            List<DGia> Listdgia = new List<DTO.DGia>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DGia as d where d.MaDGia='" + ma + "'");
            foreach (DataRow item in data.Rows)
            {
                DGia dgia = new DGia(item);
                Listdgia.Add(dgia);
            }
            return Listdgia;
        }

        public bool UpdateDG(string Ma, string Ten, string NSinh, string gt, string DChi, string TThai, string Sdt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateListDGia @MaDGia, @TenDGia, @NSinhDGia, @GTinh, @DChi, @TTDGia, @Sdt", new object[] { Ma, Ten, NSinh, gt, DChi, TThai, Sdt });
            return result > 0;
        }

        public bool XoaDG(string ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_DeleteDGia @MaDGia ", new object[] { ma });
            return result > 0;
        }

        public List<DGia> Search(string ma)
        {
            List<DGia> Listdgia = new List<DTO.DGia>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DGia as d where [dbo].[fuConvertToUnsign1] (d.TenDGia) like N'%'+[dbo].[fuConvertToUnsign1] (N'" + ma + "%')");
            foreach (DataRow item in data.Rows)
            {
                DGia dgia = new DGia(item);
                Listdgia.Add(dgia);
            }
            return Listdgia;
        }

        public static DGiaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DGiaDAO();
                return DGiaDAO.instance;
            }

            private  set
            {
                DGiaDAO.instance = value;
            }
        }
    }
}
