
using DoAn1._1.DAO;
using DoAn1._1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1._1
{
    public partial class frmTGia : Form
    {
        public frmTGia()
        {
            InitializeComponent();
            LoadTG();
            PhanQuyen(frmQLTVadmin.QTCap);
            txbMaTGia.MaxLength = 8;
            txbTenTGia.MaxLength = 30;
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
        void AddTG()
        {
            if(TGiaDAO.Instance.UpdateTGiaList(txbMaTGia.Text,txbTenTGia.Text))
            {
                MessageBox.Show("Bạn đã cập nhật thành công");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại mời bạn thao tác lại");
                return;
            }
        }
        void LoadTG()
        {
            List<TGia> listtgia = TGiaDAO.Instance.LoadSachList();
            cbbTGia.DataSource = listtgia;
            cbbTGia.DisplayMember = "TenTGia";
        }
        void ShowTxb(string Ma)
        {
            List<TGia> listtgia = TGiaDAO.Instance.LoadSachListWhereMaTG(Ma);
            foreach (TGia item in listtgia)
            {
                txbMaTGia.Text = item.MaTGia.ToString();
                txbTenTGia.Text = item.TenTGia.ToString();
            }
        }
        void DeleteTG(string ma)
        {
            if (TGiaDAO.Instance.DeleteTGiaList(ma))
            {
                MessageBox.Show("Bạn đã xóa tác giả thành công");
            }
            else
                MessageBox.Show("Không thể xóa Tác Giả. Đang có sách của tác giả này");

        }

        private void cbbTGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ma = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            TGia select = cb.SelectedItem as TGia;
            Ma = select.MaTGia;
            ShowTxb(Ma);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa tác giả? ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                DeleteTG(txbMaTGia.Text);
                LoadTG();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            AddTG();
            LoadTG();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
