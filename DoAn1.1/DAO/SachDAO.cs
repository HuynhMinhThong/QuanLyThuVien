using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    public class SachDAO
    {
        #region //khai báo
        private static SachDAO instance;
        public static int SachWidth=105;
        public static int SachHeight = 105;
         #endregion
        public static SachDAO Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new SachDAO();

                }
                return SachDAO.instance;
            }
            private  set
            {
                SachDAO.instance = value;
            }
        }
        public SachDAO() { }
        public List<Sach> LoadSachList()
        {
            List<Sach> SachList = new List<Sach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetSachList");
            foreach(DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                SachList.Add(sach);
            }
            return SachList;
        }
        
        public List<Sach> SearchSach(string Ten)
        {
            List<Sach> SachList = new List<Sach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_SearchSachList @TenSach ", new object[] { Ten});
            foreach (DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                SachList.Add(sach);
            }
            return SachList;
        }
        public List<Sach> GetSachList(string ms)
        {
            List<Sach> SachList = new List<Sach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetSachListMa @MaSach ", new object[] { ms });
            foreach (DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                SachList.Add(sach);
            }
            return SachList;
        }
        public List<Sach> GetSachListTen(string Ten)
        {
            List<Sach> SachList = new List<Sach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select s.MaSach, s.TenSach, ls.TenLSach, tg.TenTGia, nxb.TenNXB, s.SoLuong from Sach as s, LSach as ls, TGia as tg, NXB as nxb where  s.MaLSach=ls.MaLSach and s.MaTGia=tg.MaTGia and s.MaNXB=nxb.MaNXB and s.TenSach=N'"+Ten+"'");
            foreach (DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                SachList.Add(sach);
            }
            return SachList;
        }
        public bool  InsertListSach(string MaS, string TenS, string MaLS, string MaTG, string MaNXB, int SL)
        {
            int resulr = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateSach @MaSach , @TenSach , @MaLSach , @MaTGia , @MaNXB , @SoLuong ", new object[] {MaS, TenS, MaLS, MaTG, MaNXB, SL });
            return resulr > 0;
        }
        public bool UpdateSLuong(string maS, int SL)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateSluongS @SoLuong , @MaSach ", new object[] { SL, maS });
            return result > 0;
        }
        public bool DeleteListSach(string Ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec  USP_DeletSach @MaSach ", new object[] { Ma });
            return result > 0;
        }
    }
}
