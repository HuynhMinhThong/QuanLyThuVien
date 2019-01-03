using DoAn1._1.DAO;
using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1._1
{
    public partial class frmNVien : Form
    {
        private int Quyen;
        public frmNVien()
        {
            InitializeComponent();
            LoadAccount();
            txbSearch.MaxLength = 20;
            txbMaID.MaxLength = 8;
            txbTK.MaxLength = 30;
        }
        void Reset()
        {
            txbTK.Text = "";
            txbMaID.Text = "";
            txbSearch.Text = "";
            rbtnNV.Checked = false;
            rbtnQL.Checked = false;
            LoadAccount();
        }
        void LoadAccount()
        {
            string MaS;
            List<AccountDTO> ListAccount = AccountDAO.Instance.LoadAccount();
            lvwAccount.Items.Clear();
            foreach (AccountDTO item in ListAccount)
            {
                ListViewItem lvw = new ListViewItem(item.ID.ToString());
                MaS = item.ID.ToString();
                lvw.SubItems.Add(item.TKhoang.ToString());
                if (item.TThaiTK == "1 ")
                {
                    lvw.SubItems.Add("Mở");
                }
                else
                {
                    lvw.SubItems.Add("Khóa");
                }
                lvwAccount.Items.Add(lvw);
            }
                
        }
        void SearchAccount(string Ma)
        {
            string MaS;
            List<AccountDTO> ListAccount = AccountDAO.Instance.SearchAccount(Ma);
            lvwAccount.Items.Clear();
            foreach (AccountDTO item in ListAccount)
            {
                ListViewItem lvw = new ListViewItem(item.ID.ToString());
                MaS = item.ID.ToString();
                lvw.SubItems.Add(item.TKhoang.ToString());
                if (item.TThaiTK == "1 ")
                {
                    lvw.SubItems.Add("Mở");
                }
                else
                {
                    lvw.SubItems.Add("Khóa");
                }
                lvwAccount.Items.Add(lvw);
            }
        }
        void ShowAccount(string Ma)
        {
            List<AccountDTO> ListAccount = AccountDAO.Instance.SearchAccount(Ma);
            foreach (AccountDTO item in ListAccount)
            {
                txbMaID.Text = item.ID.ToString();
                txbTK.Text = item.TKhoang.ToString();
                if(item.QuyenTC==1)
                {
                    rbtnQL.Checked = true;
                }
                else
                {
                    rbtnNV.Checked = true;
                }
            }
        }
        int QuyenTruyCap()
        {
            foreach (RadioButton item in pnlQTrCap.Controls)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        string tam = item.Text;
                        if (tam.StartsWith("Q"))
                        {
                            Quyen = 1;
                        }
                        else
                        {
                            Quyen = 0;
                        }
                    }
                }
                else MessageBox.Show("Bạn phải chọn quyền truy cập cho tài khoản");
            }
            return Quyen;
        }
        void UpdateAccount(string Maid, int quyen)
        {
            if(AccountDAO.Instance.UpdateAccount(Maid,quyen,"1"))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("lỗi. Kiểm tra lại thông tin");
            }
        }
        void InsertAccount(string Maid, string TK, string MK, int quyen, string tt)
        {
            if(AccountDAO.Instance.InsertAccount(Maid,TK,MK,quyen,tt))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("lỗi. Kiểm tra lại thông tin");
            }
        }
        void KhoaAccount(string ma,string TK)
        {
            if(AccountDAO.Instance.KhoaAccount(ma,"0"))
            {
                MessageBox.Show("Đã khóa tài khoản: "+TK);
            }
            else
            {
                MessageBox.Show("lỗi. Kiểm tra lại thông tin");
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text != "")
            {
                SearchAccount(txbSearch.Text);
            }
            else MessageBox.Show("Bạn chưa nhập từ khóa");
        }

        private void lvwAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvw = sender as ListView;
            if (lvw.SelectedItems.Count > 0)
            {
                ListViewItem item = lvw.SelectedItems[0];
                ShowAccount(item.Text);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if ((txbMaID.Text != "") && (txbTK.Text != ""))
            {
                InsertAccount(txbMaID.Text, txbTK.Text, "1", QuyenTruyCap(), "1");
                LoadAccount();
            }
            else MessageBox.Show("Bạn chưa nhập thông tin tài khoản");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((txbMaID.Text != "") && (txbTK.Text != ""))
            {
                UpdateAccount(txbMaID.Text, QuyenTruyCap());
                LoadAccount();
            }
            else MessageBox.Show("Bạn chưa nhập thông tin tài khoản");
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if ((txbMaID.Text != "") && (txbTK.Text != ""))
            {
                KhoaAccount(txbMaID.Text, txbTK.Text);
                LoadAccount();
            }
            else MessageBox.Show("Bạn chưa nhập thông tin tài khoản");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
