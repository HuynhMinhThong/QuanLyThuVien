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

namespace DoAn1._1.DAO
{
    public partial class frmLSach : Form
    {
        private bool Dem;
        public frmLSach()
        {
            InitializeComponent();
            LoadLS();
            PhanQuyen(frmQLTVadmin.QTCap);
            txbMaLSach.MaxLength = 8;
            txbTenLSach.MaxLength = 30;
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
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            AddLS();
            LoadLS();
           
        }
        void AddLS()
        {
            if(LSachDAO.InsTance.UpdateLSachList(txbMaLSach.Text, txbTenLSach.Text))
            {
                MessageBox.Show("bạn đã cập nhật thành công");
                return;

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại mời bạn thao tác lại");
                return;

            }
        }
        
        void LoadLS()
        {
            List<LSach> listlsach = LSachDAO.InsTance.LoadSachList();
            cbbLSach.DataSource = listlsach;
            cbbLSach.DisplayMember = "TenLSach";
        }
        void ShowTextbox(string ma)
        {
            List<LSach> listlsach = LSachDAO.InsTance.LoadSachListWhereMaLS(ma);
            foreach(LSach item in listlsach)
            {
                txbMaLSach.Text = item.MaLSach.ToString();
                txbTenLSach.Text = item.TenLSach.ToString();
            }
        }
        void deleteLS(string ma)
        {

            if (LSachDAO.InsTance.DeleteLSachList(ma))
            {
                MessageBox.Show("Bạn đã xóa loại sách thành công");
                return;
            }
            else
            {
                MessageBox.Show("Không thể xóa. Đang có sách thể loại này");
                return;
            }
            
        }
        bool KTdeleteLS(string Ten)
        {
            List<Sach> listSach = SachDAO.Instance.LoadSachList();
            foreach(Sach item in listSach)
            {
                if (Ten == item.TenLSach)
                {
                    return Dem = false;
                }
                else return Dem = true;
            }
            return Dem;
        }
        private void cbbLSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ma = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            LSach select = cb.SelectedItem as LSach;
            Ma = select.MaLSach;
            ShowTextbox(Ma);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn có thật sự muốn xóa thể loại sách? ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                deleteLS(txbMaLSach.Text);
                LoadLS();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
