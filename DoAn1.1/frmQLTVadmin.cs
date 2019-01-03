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
    public partial class frmQLTVadmin : Form
    {
        public static int QTCap;
        public frmQLTVadmin()
        {
            InitializeComponent();
            LoadSach();
            PhanQuyen(QTCap);
            txbSearch.MaxLength = 20;
        }
        void PhanQuyen(int QTC)
        {
            if(QTC==1)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
        void LoadSach()
        {
            string MaS;
            lvwSach.Items.Clear();
            List<Sach> ListSach = SachDAO.Instance.LoadSachList();
            foreach (Sach item in ListSach)
            {
                ListViewItem lvw = new ListViewItem(item.MaSach.ToString());
                MaS = item.MaSach.ToString();
                lvw.SubItems.Add(item.TenSach.ToString());
                lvw.SubItems.Add(item.TenLSach.ToString());
                lvw.SubItems.Add(item.TenTGia.ToString());
                lvw.SubItems.Add(item.TenNXB.ToString());
                lvw.SubItems.Add(item.SoLuong.ToString());
                lvwSach.Items.Add(lvw);
            }
        }
        void SearchSachList(string Ma)
        {
            string MaS;
            lvwSach.Items.Clear();
            List<Sach> SachList = SachDAO.Instance.SearchSach(Ma);
            foreach (Sach item in SachList)
            {
                ListViewItem lvw = new ListViewItem(item.MaSach.ToString());
                MaS = item.MaSach.ToString();
                lvw.SubItems.Add(item.TenSach.ToString());
                lvw.SubItems.Add(item.TenLSach.ToString());
                lvw.SubItems.Add(item.TenTGia.ToString());
                lvw.SubItems.Add(item.TenNXB.ToString());
                lvw.SubItems.Add(item.SoLuong.ToString());
                lvwSach.Items.Add(lvw);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == "")
            {
                MessageBox.Show("Bạn cần nhập từ khóa");
                return;
            }
            else
                SearchSachList(txbSearch.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmNVien nv = new frmNVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            frmSach s = new frmSach();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void btnDGia_Click(object sender, EventArgs e)
        {
            frmDGia dg = new frmDGia();
            this.Hide();
            dg.ShowDialog();
            this.Show();
        }

        private void btnMTra_Click(object sender, EventArgs e)
        {
            frmMuonSach m = new frmMuonSach();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void cậpNhậtMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK mk = new frmDoiMK();
            this.Hide();
            mk.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLTVadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất? ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbSearch.Text = "";
            LoadSach();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
