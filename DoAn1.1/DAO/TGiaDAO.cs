using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    public class TGiaDAO
    {
        private static TGiaDAO instance;
        public TGiaDAO() { }
        public List<TGia> LoadSachList()
        {
            List<TGia> tgialist = new List<TGia>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TGia");
            foreach (DataRow item in data.Rows)
            {
                TGia tgia = new TGia(item);
                tgialist.Add(tgia);
            }
            return tgialist;
        }
        public List<TGia> LoadSachListWhereMaTG(string ma)
        {
            List<TGia> TGialist = new List<TGia>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select tg.MaTGia, tg.TenTGia from TGia as tg where tg.MaTGia= '" + ma + "'");
            foreach (DataRow item in data.Rows)
            {
                TGia tgia = new TGia(item);
                TGialist.Add(tgia);
            }
            return TGialist;
        }
        public List<TGia> LoadSachListWhereTenTG(string Ten)
        {
            List<TGia> TGialist = new List<TGia>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select tg.MaTGia, tg.TenTGia from TGia as tg where tg.TenTGia= N'" + Ten + "'");
            foreach (DataRow item in data.Rows)
            {
                TGia tgia = new TGia(item);
                TGialist.Add(tgia);
            }
            return TGialist;
        }
        public List<TGia> LoadSachListWhereMaS(string maS)
        {
            List<TGia> tgialist = new List<TGia>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select tg.MaTGia, tg.TenTGia from TGia as tg, Sach as s where s.MaTGia= tg.MaTGia and s.MaSach='" + maS + "'");
            foreach (DataRow item in data.Rows)
            {
                TGia tgia = new TGia(item);
                tgialist.Add(tgia);
            }
            return tgialist;
        }
        public bool UpdateTGiaList(string Ma, string Ten)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_AddTGiaList @MaTGia , @TenTGia ", new object[] { Ma, Ten });
            return result > 0;
        }

        public bool DeleteTGiaList(string Ma)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_DeletTGia @MaTGia ", new object[] { Ma});
            return result > 0;
        }
        public static TGiaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TGiaDAO();
                return TGiaDAO. instance;
            }

            set
            {
               TGiaDAO. instance = value;
            }
        }
    }
}
