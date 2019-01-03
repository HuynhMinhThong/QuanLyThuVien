using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1._1
{
    public class Account
    {
        public Account() { }
        // chức năng đăng nhập
        public bool Login(string account, string pass)
        {
            string Query = "select * from ID where TK= '"+account+"' and MK = '"+pass+"' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(Query);
            return result.Rows.Count > 0;
        }
        public bool KTLogin(string account)
        {
            if (account.StartsWith("admin") && account.StartsWith("NV"))
            {
                return true;
            }
            return false;
        }
    }
}
