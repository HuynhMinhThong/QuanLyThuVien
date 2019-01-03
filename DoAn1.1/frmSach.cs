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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
            LoadSach();
            LoadLS();
            LoadTG();
            LoadNXB();
            PhanQuyen(frmQLTVadmin.QTCap);
            txbSearchSach.MaxLength = 30;
            txbMaSach.MaxLength = 8;
            txbTenSach.MaxLength = 30;
            txbSoLuong.MaxLength = 5;
        }
        #region //Phương thức
        void PhanQuyen(int QTC)
        {
            if (QTC == 1)
            {
                btnXoaS.Enabled = true;
            }
            else
            {
                btnXoaS.Enabled = false;
            }
        }
        void ShowSach(string MS)
        {
            string MaS;
            lvwSach.Items.Clear();
            List<Sach> litsSach = SachDAO.Instance.GetSachList(MS);
            foreach (Sach item in litsSach)
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
        void InsertSach(string MaS, string TenS, string MaLS, string MaTG, string MaNXB, int SL)
        {
            if(SachDAO.Instance.InsertListSach(MaS, TenS, MaLS, MaTG, MaNXB, SL))
            {

                MessageBox.Show("Bạn đã cập nhật sách thành công");
                return;
            }
            else
            {
                MessageBox.Show("cập nhật thất bại mời bạn thao tác lại");
                return;
            }
        }
        void LoadLS(string MaS)
        {
            List<LSach> listlsach = LSachDAO.InsTance.LoadSachListWhereMaS(MaS);
            cbbLoaiSach.DataSource = listlsach;
            cbbLoaiSach.DisplayMember = "TenLSach";
        }
        void LoadLS()
        {
            List<LSach> listlsach = LSachDAO.InsTance.LoadSachList();
            cbbLoaiSach.DataSource = listlsach;
            
            cbbLoaiSach.DisplayMember = "TenLSach";
        }
        void LoadTG(string MaS)
        {
            List<TGia> listtgia = TGiaDAO.Instance.LoadSachListWhereMaS(MaS);
            cbbTGia.DataSource = listtgia;
            
            cbbTGia.DisplayMember = "TenTGia";
        }
        void LoadTG()
        {
            List<TGia> listtgia = TGiaDAO.Instance.LoadSachList();
            cbbTGia.DataSource = listtgia;
            cbbTGia.DisplayMember = "TenTGia";
        }
        void LoadNXB(string MaS)
        {
            List<NXB> listnxb = NXBDAO.Instance.LoadSachListWhereMaS(MaS);
            cbbNXB.DataSource = listnxb;
            cbbNXB.DisplayMember = "TenNXB";
        }
        string  ExportMaLS(string Ten)
        {
            string Ma = "";
            List<LSach> ListLSach = LSachDAO.InsTance.LoadSachListWhereTenLS(Ten);
            foreach(LSach item in ListLSach)
            {
                Ma = item.MaLSach;
            }
            return Ma;
        }
        string ExportMaTG(string Ten)
        {
            string Ma = "";
            List<TGia> ListTGia = TGiaDAO.Instance.LoadSachListWhereTenTG(Ten);
            foreach(TGia item in ListTGia)
            {
                Ma = item.MaTGia;
            }
            return Ma;
        }
        string ExportMaNXB(string Ten)
        {
            string Ma = "";
            List<NXB> ListNXB = NXBDAO.Instance.LoadSachListWhereTenNXB(Ten);
            foreach(NXB item in ListNXB)
            {
                Ma = item.MaNXB;
            }
            return Ma;
        }

        void LoadNXB()
        {
            List<NXB> listnxb = NXBDAO.Instance.LoadSachList();
            cbbNXB.DataSource = listnxb;
            cbbNXB.DisplayMember = "TenNXB";
        }
        void ShowSachTextbox(string MaS)
        {
            List<Sach> SachList = SachDAO.Instance.GetSachList(MaS);
            foreach(Sach item in SachList )
            {
                txbMaSach.Text = item.MaSach.ToString();
                txbTenSach.Text = item.TenSach.ToString();

                if (item.MaSach != null)
                {
                    LoadLS(item.MaSach);
                    LoadTG(item.MaSach);
                    LoadNXB(item.MaSach);
                }
                txbSoLuong.Text = item.SoLuong.ToString();
            }
        }
        
        void LoadSach()
        {
            List<Sach> SachList = SachDAO.Instance.LoadSachList();
            int i = 1;
            foreach(Sach item in SachList)
            {
                Button btn = new Button() { Width = SachDAO.SachWidth, Height = SachDAO.SachHeight };
                btn.Text = i  + Environment.NewLine+ item.TenSach + Environment.NewLine +string .Format( "Số lượng"+item.SoLuong.ToString());
                btn.Click += Btn_Click1;
                btn.Tag = item;
                switch (item.SoLuong)
                {
                    case 0:
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;

                }
                flpSach.Controls.Add(btn);
                i++;
            }
        }
        void AddBtn(string ma)
        {
            List<Sach> listSach = SachDAO.Instance.GetSachList(ma);
                foreach (Sach item in listSach)
                {
                Button btn = new Button() { Width = SachDAO.SachWidth, Height = SachDAO.SachHeight };
                btn.Text = item.TenSach + Environment.NewLine + item.SoLuong;
                btn.Click += Btn_Click1;
                btn.Tag = item;
                switch (item.SoLuong)
                    {
                        case 0:
                            btn.BackColor = Color.Red;
                            break;
                        default:
                            btn.BackColor = Color.Yellow;
                            break;

                    }

                flpSach.Controls.Add(btn);
                }

        }
        void DeleteSach(string Ma)
        {
            if(SachDAO.Instance.DeleteListSach(Ma))
            {
                MessageBox.Show("Xóa Thành Công");
                return;
            }
            else
            {
                MessageBox.Show("Không thể xóa sách. Hiện tại có đọc giả đang mượn sách này");
                return;
            }
        }
        void SearchShowTxb(string MaS)
        {
            List<Sach> SachList = SachDAO.Instance.GetSachList(MaS);
            foreach (Sach item in SachList)
            {
                txbMaSach.Text = item.MaSach.ToString();
                txbTenSach.Text = item.TenSach.ToString();
                LoadLS(item.MaSach);
                LoadTG(item.MaSach);
                LoadNXB(item.MaSach);
                txbSoLuong.Text = item.SoLuong.ToString();

            }
            //txbMaSach.Text = item.MaSach.ToString();
            //txbTenSach.Text = item.TenSach.ToString();
            
            //txbSoLuong.Text = item.SoLuong.ToString();
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
        //bool SearchSach(string Ma)
        //{
        //    //if (SachDAO.Instance.KTEnforcemant(Ma, SachDAO.QueryTenS))
        //    //{

        //    //    PhuTK(Ma, SachDAO.QueryTenLS);
        //    //    return true;
        //    //}
        //    //else
        //    //    return false;
        //}
        #endregion
        private void Btn_Click1(object sender, EventArgs e)
        {
            string maSach = ((sender as Button).Tag as Sach).MaSach;
            ShowSach(maSach);
        }
        
        private void btnCapNhatS_Click(object sender, EventArgs e)
        {
            if (txbMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin: Mời bạn kiểm tra lại");
                return;
            }
            string MaLS = ExportMaLS(cbbLoaiSach.Text);
            string MaTG = ExportMaTG(cbbTGia.Text);
            string MaNXB = ExportMaNXB(cbbNXB.Text);
            
            int SL = (int)Convert.ToInt32(txbSoLuong.Text);
            InsertSach(txbMaSach.Text, txbTenSach.Text, MaLS, MaTG, MaNXB, SL);
            frmSach f = new frmSach();
            this.Hide();
            f.ShowDialog();
        }
        
        private void frmSach_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            if (txbMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin: Mời bạn kiểm tra lại");
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa Sách? ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                DeleteSach(txbMaSach.Text);
                frmSach f = new frmSach();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void btnTKiemSach_Click(object sender, EventArgs e)
        {

            if (txbSearchSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin: Mời bạn kiểm tra lại");
                return;
            }
            SearchSachList(txbSearchSach.Text);
        }

        
        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLSach f = new frmLSach();
            f.ShowDialog();
            this.Show();
            LoadLS();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB f = new frmNXB();
            f.ShowDialog();
            this.Show();
            LoadNXB();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTGia f = new frmTGia();
            f.ShowDialog();
            this.Show();
            LoadTG();
        }

        private void lvwSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvw = sender as ListView;
            if (lvw.SelectedItems.Count > 0)
            {
                ListViewItem item = lvw.SelectedItems[0];
                ShowSachTextbox(item.Text);
            }
        }

        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //load combobox theo Ma
        //string Ma=""
        //ComboBox cb = sender as ComboBox;
        //if (cb.SelectedItem == null)
        //    return;
        //LSach select = cb.SelectedItem as LSach;
        //Ma = select.MaLSach;
        //string MaS = txbMaSach.Text;
        //LoadNXB(Ma);

    }
}
