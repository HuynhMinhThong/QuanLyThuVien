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
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
            dtpNgayTra.ShowUpDown = true;
            LoadDSMuon();
            txbSearch.MaxLength = 30;
            txbSLuongConlai.MaxLength = 5;
        }
        void Reset()
        {
            LoadDSMuon();
            lbMaID.Text = "______________";
            lbMaDGia.Text = "______________";
            lbTenDGia.Text = "______________";
            lbMaMuon.Text = "______________";
            lbMaSach.Text = "______________";
            lbTenSach.Text = "______________";
            lbSoLuong.Text = "______________";
            lbNgMuon.Text = "______________";
            txbSearch.Text = "";
            txbSLuongConlai.Text = "";
            rbtnDGia.Checked = false;
            rbtnSach.Checked = false;
            
        }
        void LoadDSMuon()
        {
            string Ms;
            lvwTraSach.Items.Clear();
            List<Muon> SachList = MuonSDAO.Instance.LoadDSMuon();
            foreach (Muon item in SachList)
            {
                ListViewItem lvw = new ListViewItem(item.MaMuon.ToString());
                Ms = item.MaMuon.ToString();
                lvw.SubItems.Add(item.MaID.ToString());
                lvw.SubItems.Add(item.MaDGia.ToString());
                lvw.SubItems.Add(item.TenDGia.ToString());
                lvw.SubItems.Add(item.MaSach.ToString());
                lvw.SubItems.Add(item.TenSach.ToString());
                lvw.SubItems.Add(item.SoLuong.ToString());
                lvw.SubItems.Add(item.NgayMuon.ToString());
                if (item.TrangThaiMuon == true)
                {
                    lvw.SubItems.Add("Chưa Trả");
                }
                else
                {
                    lvw.SubItems.Add("Đã Trả");
                }
                lvwTraSach.Items.Add(lvw);
            }
        }
        void SearchSach(string Ten)
        {
            string Ms;
            lvwTraSach.Items.Clear();
            List<Muon> SachList = MuonSDAO.Instance.SearchMuonTenSach(Ten);
            foreach (Muon item in SachList)
            {
                ListViewItem lvw = new ListViewItem(item.MaMuon.ToString());
                Ms = item.MaMuon.ToString();
                lvw.SubItems.Add(item.MaID.ToString());
                lvw.SubItems.Add(item.MaDGia.ToString());
                lvw.SubItems.Add(item.TenDGia.ToString());
                lvw.SubItems.Add(item.MaSach.ToString());
                lvw.SubItems.Add(item.TenSach.ToString());
                lvw.SubItems.Add(item.SoLuong.ToString());
                lvw.SubItems.Add(item.NgayMuon.ToString());
                if (item.TrangThaiMuon == true)
                {
                    lvw.SubItems.Add("Chưa Trả");
                }
                else
                {
                    lvw.SubItems.Add("Đã Trả");
                }
                lvwTraSach.Items.Add(lvw);
            }
        }
        void SearchDGia(string Ten)
        {
            string Ms;
            lvwTraSach.Items.Clear();
            List<Muon> SachList = MuonSDAO.Instance.SearchMuonTenDGia(Ten);
            foreach (Muon item in SachList)
            {
                ListViewItem lvw = new ListViewItem(item.MaMuon.ToString());
                Ms = item.MaMuon.ToString();
                lvw.SubItems.Add(item.MaID.ToString());
                lvw.SubItems.Add(item.MaDGia.ToString());
                lvw.SubItems.Add(item.TenDGia.ToString());
                lvw.SubItems.Add(item.MaSach.ToString());
                lvw.SubItems.Add(item.TenSach.ToString());
                lvw.SubItems.Add(item.SoLuong.ToString());
                lvw.SubItems.Add(item.NgayMuon.ToString());
                if (item.TrangThaiMuon == true)
                {
                    lvw.SubItems.Add("Chưa Trả");
                }
                else
                {
                    lvw.SubItems.Add("Đã Trả");
                }
                lvwTraSach.Items.Add(lvw);
            }
        }
        void ShowDSMuon(string ma)
        {
            List<Muon> ListDSMuon = MuonSDAO.Instance.LoadDSMuonMaMuon(ma);
            foreach(Muon item in ListDSMuon)
            {
                lbMaMuon.Text = item.MaMuon.ToString();
                lbMaDGia.Text = item.MaDGia.ToString();
                lbTenDGia.Text = item.TenDGia.ToString();
                lbNgMuon.Text = item.NgayMuon.ToString().Substring(0, 10);
                lbMaID.Text = item.MaID.ToString();
                lbMaSach.Text = item.MaSach.ToString();
                lbTenSach.Text = item.TenSach.ToString();
                lbSoLuong.Text = item.SoLuong.ToString();
            }
        }
        string XuLyDate(string DateDG)
        {
            string DT;
            string[] art = DateDG.Split(new char[] { '/' });
            return DT = art[1] + "-" + art[0] + "-" + art[2];
        }
        void AddTraSach(int maM, string maS, int sLConLai, string ngayTra)
        {
            if(TraSDAO.Instance.InsertTraSach(maM,maS,sLConLai,ngayTra))
            {
                MessageBox.Show("Trả sách thành công");
            }
            else
            {
                MessageBox.Show("Lỗi: Kiểm tra lại thông tin");
            }
        }
        private void lvwTraSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvw = sender as ListView;
            if (lvw.SelectedItems.Count > 0)
            {
                ListViewItem item = lvw.SelectedItems[0];
                ShowDSMuon(item.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text != "")
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
                                SearchSach(txbSearch.Text);
                            }
                            else
                            {

                                SearchDGia(txbSearch.Text);
                            }
                        }
                    }
                }
            }
            else MessageBox.Show("Bạn chưa nhập từ khóa");
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (lbMaMuon.Text != "______________")
            {
                int MaMuon = (int)Convert.ToInt32(lbMaMuon.Text);
                int SLuongConlai = (int)Convert.ToInt32(txbSLuongConlai.Text);
                if (txbSLuongConlai.Text != "")
                {
                    AddTraSach(MaMuon, lbMaSach.Text, SLuongConlai, XuLyDate(dtpNgayTra.Text));
                }
                else
                {
                    MessageBox.Show("Nhập số lượng cần trả");
                }
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txbSLuongConlai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
