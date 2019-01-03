using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                 return AccountDAO.instance;
            }

            private  set
            {
               AccountDAO. instance = value;
            }
        }
        public List<AccountDTO> LoadAccount()
        {
            List<AccountDTO> ListAccount = new List<AccountDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select *from ID ");
            foreach (DataRow item in data.Rows)
            {
                AccountDTO sach = new AccountDTO(item);
                ListAccount.Add(sach);
            }
            return ListAccount;
        }
        public List<AccountDTO> LoadAccountMaID(string ma)
        {
            List<AccountDTO> ListAccount = new List<AccountDTO>();
            //DataTable data = DataProvider.Instance.ExecuteQuery("select *from ID where MaID = N'"+ma+"'");
            DataTable data = DataProvider.Instance.ExecuteQuery("select *from ID where MaID = N'" + "01 'begin	insert into id	values	('1234','abc','123',0,1)end--" + "'");
            foreach (DataRow item in data.Rows)
            {
                AccountDTO sach = new AccountDTO(item);
                ListAccount.Add(sach);
            }
            return ListAccount;
        }
        public List<AccountDTO> SearchAccount(string MaID)
        {
            List<AccountDTO> ListAccount = new List<AccountDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select *from ID where MaID like '%"+MaID+"%'");
            foreach (DataRow item in data.Rows)
            {
                AccountDTO sach = new AccountDTO(item);
                ListAccount.Add(sach);
            }
            return ListAccount;
        }
        public List<AccountDTO> KTraMa(string Ma)
        {
            List<AccountDTO> ListAccount = new List<AccountDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ID where MaID = '" + Ma + "'");
            foreach (DataRow item in data.Rows)
            {
                AccountDTO sach = new AccountDTO(item);
                ListAccount.Add(sach);
            }
            return ListAccount;
        }
        public List<AccountDTO> KTraAccount(string TaiKhoan)
        {
            List<AccountDTO> ListAccount = new List<AccountDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ID where TK = N'" + TaiKhoan + "'");
            foreach (DataRow item in data.Rows)
            {
                AccountDTO sach = new AccountDTO(item);
                ListAccount.Add(sach);
            }
            return ListAccount;
        }
        public bool InsertAccount(string maid, string tk, string mk, int quyen, string tt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("insert into ID (MaID, TK, MK, QuyenTC, TThaiTK) values ('"+maid+"','"+tk+"','"+mk+"','"+quyen+"','"+tt+"')");
            return result > 0;
        }
        public bool UpdateAccount(string maid, int quyen, string tt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("update ID set TThaiTK ='"+tt+"', QuyenTC='" + quyen+"' where MaID='"+maid+"'");
            return result > 0;
        }
        public bool KhoaAccount(string maid, string tt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("update ID set TThaiTK ='" + tt + "' where MaID='" + maid + "'");
            return result > 0;
        }
        public bool UpdateMK(string TK, string MK, string MKcu)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("update ID set MK='"+MK+"' where TK='"+TK+"' and MK='"+MKcu+"' ");
            return result > 0;
        }
    }
}
