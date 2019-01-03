
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
    public partial class frmDGia : Form
    {
        public frmDGia()
        {
            InitializeComponent();
            dttNSinhDGia.ShowUpDown = true;
            LoadDGialvw();
            PhanQuyen(frmQLTVadmin.QTCap);
            txbSdtDGia.MaxLength = 11;
            txbMaDGia.MaxLength = 8;
            txbTenDGia.MaxLength = 30;
            txbDChiDGia.MaxLength = 50;
            txbSearchDG.MaxLength = 20;
        }
        private string MaS;
        private string Nam = "Nam";
        private string Nu = "Nữ";
        private string TTD = "Khóa";
        private string TTM = "Mở";
        private string nam;
        private string nu;
        private string  TThai;
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
        void ShowDG(string Ma)
        {
            List < DGia > listDG= DGiaDAO.Instance.LoadDGMa(Ma);
            foreach(DGia item in listDG)
            {

                txbMaDGia.Text = item.MaDGia.ToString();
                txbTenDGia.Text = item.TenDGia.ToString();
                int year = (int)Convert.ToUInt64(item.NgaySinh.Value.Year.ToString());
                int month = (int)Convert.ToUInt64(item.NgaySinh.Value.Month.ToString());
                int day = (int)Convert.ToUInt64(item.NgaySinh.Value.Day.ToString());
                dttNSinhDGia.Value = new DateTime(year, month, day);
                txbSdtDGia.Text = item.Sdt.ToString();
                if (item.GTinh == true)
                {
                    rbtnNamDGia.Checked = true;
                }
                else
                {
                    rbtnNuDGia.Checked = true;
                }
                txbSdtDGia.Text = item.Sdt.ToString();
                if (item.TTDGia == true)
                {
                    rbtnMoDGia.Checked = true;
                }
                else
                {
                    rbtnKhoaDGia.Checked = true;
                }
                txbDChiDGia.Text = item.DChiDGia.ToString();

            }
        } 
       
        void XoaDGia(string Ma)
        {
            if(DGiaDAO.Instance.XoaDG(Ma))
            {
                MessageBox.Show("Bạn đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Không thể xóa đọc giả. Hiện đọc giả đang mượn sách");
            }
        }
        void LoadDGialvw()
        {
            
            lvwNVien.Items.Clear();
            List<DGia> ListDGia = DGiaDAO.Instance.LoadDG();
            foreach(DGia item in ListDGia)
            {
                ListViewItem lvw = new ListViewItem(item.MaDGia.ToString());
                MaS = item.MaDGia.ToString();
                lvw.SubItems.Add(item.TenDGia.ToString());
                lvw.SubItems.Add(item.NgaySinh.ToString());
                if(item.GTinh ==true)
                {
                    lvw.SubItems.Add(Nam);
                }
                else
                {
                    lvw.SubItems.Add(Nu);
                }
                lvw.SubItems.Add(item.Sdt.ToString());
                if(item.TTDGia==true)
                {
                    lvw.SubItems.Add(TTM);
                }
                else
                {
                    lvw.SubItems.Add(TTD);
                }
                lvw.SubItems.Add(item.DChiDGia.ToString());
                lvwNVien.Items.Add(lvw);
            }
        }
        string XuLyDate(string DateDG)
        {
            string DT;
            string[] art = DateDG.Split(new char[] { '/' });
            return DT = art[1] + "-" + art[0] + "-" + art[2];
        }
        void UpdateDGia()
        {
            
            
            foreach(RadioButton item in pnlGTinh.Controls)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        string tam = item.Text;
                        if (tam.StartsWith("N") == true)
                        {
                            nam = "1";
                            

                        }
                        else
                        {
                            nam = "0";
                            

                        }
                    }
                }
                else MessageBox.Show("Bạn phải chọn giới tính");
            }
            foreach(RadioButton item in pnlTThai.Controls)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        string tam = item.Text;
                        if (tam == "Khóa")
                        {
                            TThai = "0";
                        }
                        else
                        {
                            TThai = "1";
                        }
                    }
                }
                else MessageBox.Show("Bạn phải chọn trạng thái");
            }
            if(DGiaDAO.Instance.UpdateDG(txbMaDGia.Text, txbTenDGia.Text, XuLyDate(dttNSinhDGia.Text), nam, txbDChiDGia.Text, TThai, txbSdtDGia.Text))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("cập nhật thất bại mời bạn thao tác lại");
            }

        }
        void SearchDGia(string Ten)
        {
            lvwNVien.Items.Clear();
            List<DGia> dgialis = DGiaDAO.Instance.Search(Ten);
            foreach (DGia item in dgialis)
            {
                ListViewItem lvw = new ListViewItem(item.MaDGia.ToString());
                MaS = item.MaDGia.ToString();
                lvw.SubItems.Add(item.TenDGia.ToString());
                lvw.SubItems.Add(item.NgaySinh.ToString());
                if (item.GTinh == true)
                {
                    lvw.SubItems.Add(Nam);
                }
                else
                {
                    lvw.SubItems.Add(Nu);
                }
                lvw.SubItems.Add(item.Sdt.ToString());
                if (item.TTDGia == true)
                {
                    lvw.SubItems.Add(TTM);
                }
                else
                {
                    lvw.SubItems.Add(TTD);
                }
                lvw.SubItems.Add(item.DChiDGia.ToString());
                lvwNVien.Items.Add(lvw);
            }
        }
        void ResetDG()
        {
            txbMaDGia.Text = "";
            txbTenDGia.Text = "";
            txbDChiDGia.Text = "";
            txbSdtDGia.Text = "";
            txbSearchDG.Text = "";
            rbtnNamDGia.Checked = false;
            rbtnNuDGia.Checked = false;
            rbtnKhoaDGia.Checked = false;
            rbtnMoDGia.Checked = false;
        } 
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txbMaDGia.Text != "")
            {
                if (txbTenDGia.Text != "")
                {
                    if (txbDChiDGia.Text != "")
                    {
                        if (txbSdtDGia.Text != "")
                        {
                            UpdateDGia();
                            LoadDGialvw();
                        }
                        else MessageBox.Show("Bạn chưa nhập sdt đọc giả");
                    }
                    else MessageBox.Show("Bạn chưa nhập địa chỉ đọc giả");
                }
                else MessageBox.Show("Bạn chưa nhập tên đọc giả");
            }
            else MessageBox.Show("Bạn chưa nhập mã đọc giả");
        }

        private void lvwNVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvw = sender as ListView;
            if(lvw.SelectedItems.Count >0)
            {
                ListViewItem item = lvw.SelectedItems[0];
                ShowDG(item.Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txbMaDGia.Text != "")
            {
                if (txbTenDGia.Text != "")
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa dọc giả? ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
                    {
                        XoaDGia(txbMaDGia.Text);
                        LoadDGialvw();
                    }
                }
                else MessageBox.Show("Bạn chưa nhập tên đọc giả");
            }
            else MessageBox.Show("Bạn chưa nhập mã đọc giả");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearchDG.Text != "")
            {
                SearchDGia(txbSearchDG.Text);
            }
            else MessageBox.Show("Bạn chưa nhập từ khóa");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDGialvw();
            ResetDG();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonSach m = new frmMuonSach();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraSach t = new frmTraSach();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void txbSdtDGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
