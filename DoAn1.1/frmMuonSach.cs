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
    public partial class frmMuonSach : Form
    {
        private bool Dem;
        public frmMuonSach()
        {
            InitializeComponent();
            dtNgayMuon.ShowUpDown = true;
            ShowSach();
            ShowDGia();
            txbMaDGia.MaxLength = 8;
            txbMaID.MaxLength = 8;
            txbMaSach.MaxLength = 8;
            txbMKhau.MaxLength = 30;
            txbSoLuong.MaxLength = 5;
            txbTenDGia.MaxLength = 30;
            txbTenSach.MaxLength = 30;
            txbTimKiem.MaxLength = 20;
        }
        void ShowSach()
        {
            string Ms;
            lvwSach.Items.Clear();
            List<Sach> Sachlist = SachDAO.Instance.LoadSachList();
            foreach(Sach item in Sachlist)
            {
                ListViewItem lvw =new ListViewItem(item.MaSach.ToString());
                Ms = item.MaSach.ToString();
                lvw.SubItems.Add(item.TenSach.ToString());
                lvw.SubItems.Add(item.TenLSach.ToString());
                lvw.SubItems.Add(item.TenTGia.ToString());
                lvw.SubItems.Add(item.TenNXB.ToString());
                lvw.SubItems.Add(item.SoLuong.ToString());
                lvwSach.Items.Add(lvw);
            }
        }
        void ShowDGia()
        {
            string Ms;
            lvwDGia.Items.Clear();
            List<DGia> DGialist = DGiaDAO.Instance.LoadDG();
            foreach(DGia item in DGialist)
            {
                ListViewItem lvw = new ListViewItem(item.MaDGia.ToString());
                Ms = item.MaDGia.ToString();
                lvw.SubItems.Add(item.TenDGia.ToString());
                lvw.SubItems.Add(item.Sdt.ToString());
                if(item.TTDGia==true)
                {
                    lvw.SubItems.Add("Mở");
                }
                else
                {
                    lvw.SubItems.Add("khóa");
                }
                lvwDGia.Items.Add(lvw);
            }
        }
        void ShowDGiaTxb(string Ma)
        {
            List<DGia> listDG = DGiaDAO.Instance.LoadDGMa(Ma);
            foreach(DGia item in listDG)
            {
                txbTenDGia.Text = item.TenDGia.ToString();
                txbMaDGia.Text = item.MaDGia.ToString();
            }
        }
        void ShowSachTxb(string Ma)
        {
            List<Sach> listSach = SachDAO.Instance.GetSachList(Ma);
            foreach(Sach item in listSach)
            {
                txbMaSach.Text = item.MaSach.ToString();
                txbTenSach.Text = item.TenSach.ToString();
            }
        }
        bool KTSach(string Ma)
        {
            if (txbTenSach.Text != "")
            {
                if (txbMaSach.Text != "")
                {
                    if (txbSoLuong.Text != "")
                    {
                        double tam = (double)Convert.ToDouble(txbSoLuong.Text.ToString());
                        List<Sach> listSach = SachDAO.Instance.GetSachList(Ma);
                        foreach (Sach item in listSach)
                        {
                            double SL = (double)Convert.ToUInt32(item.SoLuong.ToString());
                            if (tam > SL)
                            {
                                MessageBox.Show("Số lượng Sách chỉ còn: " + item.SoLuong.ToString());
                                return Dem = false;
                            }
                            else
                            {
                                return Dem = true;
                            }
                        }
                        return Dem;
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập số lượng");
                        return false;
                    }
                }
                else { MessageBox.Show("Bạn chưa phập mã sách"); return false; }
            }
            else { MessageBox.Show("Bạn chưa phập tên sách"); return false; }
        }
        bool KTDGia(string Ma)
        {
            if (txbTenDGia.Text != "")
            {
                if (txbMaDGia.Text != "")
                {
                    int tam = (int)Convert.ToInt32(txbSoLuong.Text.ToString());
                    List<DGia> listDGia = DGiaDAO.Instance.LoadDGMa(Ma);
                    foreach (DGia item in listDGia)
                    {
                        if (item.TTDGia == true)
                        {
                            return Dem = true;
                        }
                        else
                        {
                            MessageBox.Show("tài khoản đọc giả đã ngưng hoạt động");
                            return Dem = false;
                        }
                    }
                    return Dem;
                }else { MessageBox.Show("Bạn chưa nhập mã đọc giả"); return Dem; }
            }
            else { MessageBox.Show("Bạn chưa nhập tên đọc giả"); return Dem; }
        }
        bool KTQuyen(string Ma)
        {
            List<DGia> listDGia = DGiaDAO.Instance.LoadDGMa(Ma);
            foreach(DGia item in listDGia)
            {
                if (item.TTDGia == true)
                {
                    return Dem = true;
                }
                else return Dem = false;
            }
            return Dem;
        }
        bool KTAccount(string MaID)
        {
            if ((txbMaID.Text == "") || (txbMaSach.Text == ""))
            {
                MessageBox.Show("Kiểm tra thông tin nhân viên");
                return Dem = false;
            }
            List<AccountDTO> listaccount = AccountDAO.Instance.LoadAccountMaID(MaID);
                foreach (AccountDTO item in listaccount)
                {
                    if ( txbMKhau.Text==item.MKhau.ToString())
                    {
                        return Dem = true;
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra thông tin nhân viên");
                        return Dem = false;
                    }
                }
            return Dem;
        }
        void AddMuonSach(string MaID, string Mk, string MaS, string MaDG, string NMuon, int SL,string TT)
        {
            
            if ((MuonSDAO.Instance.AddMuonSach(MaID, MaS, MaDG, NMuon, SL,TT, Mk))&&(SachDAO.Instance.UpdateSLuong(MaS, SL)))
            {
                MessageBox.Show("Thành Công");
            }
            else
            {
                MessageBox.Show("lỗi: Kiểm tra lại thông tin");
            }
        }
        void SearchSach(string Ten)
        {
            string Ms;
            lvwSach.Items.Clear();
            List<Sach> SachList = SachDAO.Instance.SearchSach(Ten);
            foreach (Sach item in SachList)
            {
                ListViewItem lvw = new ListViewItem(item.MaSach.ToString());
                Ms = item.MaSach.ToString();
                lvw.SubItems.Add(item.TenSach.ToString());
                lvw.SubItems.Add(item.TenLSach.ToString());
                lvw.SubItems.Add(item.TenTGia.ToString());
                lvw.SubItems.Add(item.TenNXB.ToString());
                lvw.SubItems.Add(item.SoLuong.ToString());
                lvwSach.Items.Add(lvw);
            }
        }
        void SearchDGia(string Ten)
        {
            string MaS;
            lvwDGia.Items.Clear();
            List<DGia> dgialis = DGiaDAO.Instance.Search(Ten);
            foreach (DGia item in dgialis)
            {
                ListViewItem lvw = new ListViewItem(item.MaDGia.ToString());
                MaS = item.MaDGia.ToString();
                lvw.SubItems.Add(item.TenDGia.ToString());
                lvw.SubItems.Add(item.Sdt.ToString());
                if (item.TTDGia == true)
                {
                    lvw.SubItems.Add("Mở");
                }
                else
                {
                    lvw.SubItems.Add("Khóa");
                }
                lvwDGia.Items.Add(lvw);
            }
        }
        void Reset()
        {
            ShowSach();
            ShowDGia();
            rbtnSach.Checked = false;
            rbtnDGia.Checked = false;
            txbTimKiem.Text = "";
            txbMaID.Text = "";
            txbMKhau.Text = "";
            txbMaDGia.Text = "";
            txbTenDGia.Text = "";
            txbMaSach.Text = "";
            txbTenSach.Text = "";
            txbSoLuong.Text = "";
        } 
        string XuLyDate(string DateDG)
        {
            string DT;
            string[] art = DateDG.Split(new char[] { '/' });
            return DT = art[1] + "-" + art[0] + "-" + art[2];
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txbTimKiem.Text != "")
            {
                foreach (RadioButton item in pnlSearch.Controls)
                {
                    if (item != null)
                    {
                        if (item.Checked == true)
                        {
                            string tam = item.Text;
                            if (tam.StartsWith("S"))
                            {
                                SearchSach(txbTimKiem.Text);
                            }
                            else
                            {

                                SearchDGia(txbTimKiem.Text);
                            }
                        }
                    }
                }
            }
            else MessageBox.Show("Bạn chưa nhập từ khóa");
        }

        private void lvwDGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvw = sender as ListView;
            if (lvw.SelectedItems.Count > 0)
            {
                ListViewItem item = lvw.SelectedItems[0];
                ShowDGiaTxb(item.Text);
            }
        }

        private void lvwSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvw = sender as ListView;
            if (lvw.SelectedItems.Count > 0)
            {
                ListViewItem item = lvw.SelectedItems[0];
                ShowSachTxb(item.Text);
            }
        }

        private void btnKTra_Click(object sender, EventArgs e)
        {
                if((KTSach(txbMaSach.Text) == true) && (KTDGia(txbMaDGia.Text) == true)&&(txbMaID.Text!="")&&(txbMKhau.Text!=""))
            {
                    MessageBox.Show("Bạn có thể mượn sách");
            }
            else
            {
                MessageBox.Show("lỗi: Kiểm tra lại thông tin");
            }
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if ((KTSach(txbMaSach.Text) == true) && (KTDGia(txbMaDGia.Text) == true))
            {
                if (KTQuyen(txbMaDGia.Text) == true)
                {
                    int SL = (int)Convert.ToInt32(txbSoLuong.Text);
                    AddMuonSach(txbMaID.Text, txbMKhau.Text, txbMaSach.Text, txbMaDGia.Text, XuLyDate(dtNgayMuon.Text), SL, "1");
                    Reset();
                }
                else MessageBox.Show("Hồ sơ đọc giả đã bị khóa");
            }
            else
            {
                MessageBox.Show("Kiểm tra thông tin nhân viên");
            }
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraSach ts = new frmTraSach();
            this.Hide();
            ts.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
