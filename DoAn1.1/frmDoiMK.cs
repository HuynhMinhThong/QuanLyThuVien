using DoAn1._1.DAO;
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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
            txbMK.MaxLength = 30;
            txbMK2.MaxLength = 30;
            txbMKcu.MaxLength = 30;
            txbTK.MaxLength = 30;
        }
        void UpdateMK(string MK, string MKcu, string TK)
        {
            if(AccountDAO.Instance.UpdateMK(TK,MK,MKcu))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản");
            }
        }
        void Reset()
        {
            txbTK.Text = "";
            txbMK.Text = "";
            txbMK2.Text = "";
            txbMKcu.Text = "";
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txbTK.Text != "")
            {
                if (txbMKcu.Text != "")
                {
                    if (txbMK.Text != "")
                    {
                        if (txbMK2.Text != "")
                        {
                            if (txbMK.Text == txbMK2.Text)
                            {
                                UpdateMK(txbMK2.Text, txbMKcu.Text, txbTK.Text);
                                Reset();
                            }
                            else
                            {
                                MessageBox.Show("Nhập lại mật khẩu");
                            }
                        }
                        else MessageBox.Show("Bạn chưa nhập mật khẩu");
                    }
                    else MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else MessageBox.Show("Bạn chưa nhập tài khoản");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
