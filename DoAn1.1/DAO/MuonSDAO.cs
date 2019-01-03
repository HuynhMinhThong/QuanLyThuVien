using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    public class MuonSDAO
    {
        private static MuonSDAO instance;
        public MuonSDAO() { }
        public bool AddMuonSach(string maID, string MaS, string maDG, string ngayMuon, int SL,string TT, string MK)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertMuonSch @MaID , @MaSach , @MaDGia , @NgayMuon ,  @Soluong , @TTMuon , @MK  ", new object[] { maID, MaS, maDG, ngayMuon, SL, TT, MK});
            return result > 0;
        }
        public List<Muon> SearchMuonTenSach(string Ten)
        {
            List<Muon> ListMuon = new List<Muon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select m.MaMuon, i.MaID, d.MaDGia, d.TenDGia, s.MaSach, s.TenSach, m.SoLuong, m.NgayMuon, m.TThaiMuon from Muon as m, Sach as s, DGia as d, id as i where m.MaDGia = d.MaDGia and m.MaSach = s.MaSach and m.MaID = i.MaID and[dbo].[fuConvertToUnsign1](s.TenSach) like N'%' +[dbo].[fuConvertToUnsign1](N'" + Ten+"') + '%'");
            foreach (DataRow item in data.Rows)
            {
                Muon dsm = new Muon(item);
                ListMuon.Add(dsm);
            }
            return ListMuon;
        }
        public List<Muon> SearchMuonTenDGia(string Ten)
        {
            List<Muon> ListMuon = new List<Muon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select m.MaMuon, i.MaID, d.MaDGia, d.TenDGia, s.MaSach, s.TenSach, m.SoLuong, m.NgayMuon, m.TThaiMuon from Muon as m, Sach as s, DGia as d, id as i where m.MaDGia = d.MaDGia and m.MaSach = s.MaSach and m.MaID = i.MaID and[dbo].[fuConvertToUnsign1](d.TenDGia) like N'%' +[dbo].[fuConvertToUnsign1](N'" + Ten+"') + '%'");
            foreach (DataRow item in data.Rows)
            {
                Muon dsm = new Muon(item);
                ListMuon.Add(dsm);
            }
            return ListMuon;
        }
        public List<Muon> LoadDSMuon()
        {
            List<Muon> ListMuon = new List<Muon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select m.MaMuon, i.MaID, d.MaDGia, d.TenDGia, s.MaSach, s.TenSach, m.SoLuong, m.NgayMuon, m.TThaiMuon from Muon as m, Sach as s, DGia as d, id as i where m.MaDGia = d.MaDGia and m.MaSach = s.MaSach and m.MaID = i.MaID");
            foreach (DataRow item in data.Rows)
            {
                Muon dsm = new Muon(item);
                ListMuon.Add(dsm);
            }
            return ListMuon;
        }
        public List<Muon> LoadDSMuonMaMuon(string ma)
        {
            List<Muon> ListMuon = new List<Muon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select m.MaMuon, i.MaID, d.MaDGia, d.TenDGia, s.MaSach, s.TenSach, m.SoLuong, m.NgayMuon, m.TThaiMuon from Muon as m, Sach as s, DGia as d, id as i where m.MaDGia = d.MaDGia and m.MaSach = s.MaSach and m.MaID = i.MaID and m.MaMuon = '" + ma+"'");
            foreach (DataRow item in data.Rows)
            {
                Muon dsm = new Muon(item);
                ListMuon.Add(dsm);
            }
            return ListMuon;
        }
        public static MuonSDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MuonSDAO();
                return MuonSDAO. instance;
            }

            private  set
            {
                MuonSDAO. instance = value;
            }
        }


    }
}
