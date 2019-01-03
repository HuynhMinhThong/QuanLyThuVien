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
    public partial class frmNXB : Form
    {
        public frmNXB()
        {
            InitializeComponent();
            LoadNXB();
            PhanQuyen(frmQLTVadmin.QTCap);
            txbMaNXB.MaxLength = 8;
            txbTenNXB.MaxLength = 30;
        }
        void PhanQuyen(int QTC)
        {
            if (QTC == 1)
            {
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
        void LoadNXB()
        {
            List<NXB> listnxb = NXBDAO.Instance.LoadSachList();
            cbbNXB.DataSource = listnxb;
            cbbNXB.DisplayMember = "TenNXB";
        }
        void ShowTexboxNXB(string Ma)
        {
            List<NXB> listnxb = NXBDAO.Instance.LoadSachListWhereMaNXB(Ma);
            foreach (NXB item in listnxb)
            {
                txbMaNXB.Text = item.MaNXB.ToString();
                txbTenNXB.Text = item.TenNXB.ToString();
            }
        }
        void UpdateNXBlist(string ma, string ten)
        {
            if(NXBDAO.Instance.UpdateNXB(ma, ten))
            {
                MessageBox.Show("Bạn cập nhật thành công");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại mời bạn thao tác lại");
                return;
            }
        }
        void DeleteNXBlist(string ma)
        {
            if(NXBDAO.Instance.DeleteNXB(ma))
            {
                MessageBox.Show("Bạn xóa thành công");
                return;
            }
            else
            {
                MessageBox.Show("Không thể xóa nhà xuất bản. Đang có sách của nhà xuất bản này");
                return;
            }
        }
        private void cbbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ma = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            NXB select = cb.SelectedItem as NXB;
            Ma = select.MaNXB;
            ShowTexboxNXB(Ma);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateNXBlist(txbMaNXB.Text,txbTenNXB.Text);
            LoadNXB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhà xuất bản? ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                DeleteNXBlist(txbMaNXB.Text);
                LoadNXB();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
