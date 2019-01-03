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
    public partial class Form1 : Form
    {
        private bool tam;
        //public static  Form1  
        public Form1()
        {
            InitializeComponent();
            txbAccount.MaxLength = 20;
            txbPassword.MaxLength = 20;
        }
        bool Login(string TaiKhoan, string MatKhau)
        {
            
            List<AccountDTO> listacount = AccountDAO.Instance.KTraAccount(TaiKhoan);
            foreach(AccountDTO item in listacount)
            {
                item.MKhau = item.MKhau.Trim();
                item.TKhoang = item.TKhoang.Trim();
                if ((TaiKhoan == item.TKhoang) && (MatKhau == item.MKhau))
                {
                    frmQLTVadmin.QTCap = (int)Convert.ToInt32(item.QuyenTC.ToString());
                    return tam = true;
                }
                else return tam = false;
            }
            return tam;
        }
       bool QuyenTT(string TaiKhoan, string MatKhau)
        {
            List<AccountDTO> listacount = AccountDAO.Instance.KTraAccount(TaiKhoan);
            foreach(AccountDTO item in listacount)
            {
                if (item.TThaiTK == "1 ")
                {
                    return tam = true;
                }
                else return tam = false;
            }
            return tam;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txbAccount.Text, txbPassword.Text)==true)
            {
                if (QuyenTT(txbAccount.Text, txbPassword.Text) == true)
                {
                    frmQLTVadmin f = new frmQLTVadmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã bị khóa");
                }
            }
            else
            {
                MessageBox.Show("sai tên tài khoảng hoặc mật khẩu");
            }

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình? ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
