namespace DoAn1._1
{
    partial class frmTraSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTraSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txbSLuongConlai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.rbtnDGia = new System.Windows.Forms.RadioButton();
            this.rbtnSach = new System.Windows.Forms.RadioButton();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbMaID = new System.Windows.Forms.Label();
            this.lbNgMuon = new System.Windows.Forms.Label();
            this.lbTenDGia = new System.Windows.Forms.Label();
            this.lbMaDGia = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMaMuon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(275, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Mượn Sách";
            // 
            // lvwTraSach
            // 
            this.lvwTraSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvwTraSach.Location = new System.Drawing.Point(12, 290);
            this.lvwTraSach.Name = "lvwTraSach";
            this.lvwTraSach.Size = new System.Drawing.Size(777, 245);
            this.lvwTraSach.TabIndex = 1;
            this.lvwTraSach.UseCompatibleStateImageBehavior = false;
            this.lvwTraSach.View = System.Windows.Forms.View.Details;
            this.lvwTraSach.SelectedIndexChanged += new System.EventHandler(this.lvwTraSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phiếu Mượn";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Nhân Viên";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Đọc Giả";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Đọc Giả";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Sách";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Sách";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.Width = 74;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ngày Mượn";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Trạng Thái";
            this.columnHeader9.Width = 86;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.txbSLuongConlai);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnTraSach);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.pnlSearch);
            this.panel1.Controls.Add(this.lbTenSach);
            this.panel1.Controls.Add(this.lbMaSach);
            this.panel1.Controls.Add(this.lbMaID);
            this.panel1.Controls.Add(this.lbNgMuon);
            this.panel1.Controls.Add(this.lbTenDGia);
            this.panel1.Controls.Add(this.lbMaDGia);
            this.panel1.Controls.Add(this.dtpNgayTra);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbMaMuon);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 213);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(684, 152);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 37);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txbSLuongConlai
            // 
            this.txbSLuongConlai.Location = new System.Drawing.Point(506, 145);
            this.txbSLuongConlai.Name = "txbSLuongConlai";
            this.txbSLuongConlai.Size = new System.Drawing.Size(74, 27);
            this.txbSLuongConlai.TabIndex = 26;
            this.txbSLuongConlai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSLuongConlai_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Số Lượng Còn Lại";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lbSoLuong.Location = new System.Drawing.Point(445, 118);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(135, 19);
            this.lbSoLuong.TabIndex = 24;
            this.lbSoLuong.Text = "______________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Số Lượng";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.Aqua;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.Location = new System.Drawing.Point(593, 152);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(78, 37);
            this.btnTraSach.TabIndex = 22;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(590, 71);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(166, 27);
            this.txbSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(593, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 37);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.rbtnDGia);
            this.pnlSearch.Controls.Add(this.rbtnSach);
            this.pnlSearch.Location = new System.Drawing.Point(590, 26);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(172, 39);
            this.pnlSearch.TabIndex = 19;
            // 
            // rbtnDGia
            // 
            this.rbtnDGia.AutoSize = true;
            this.rbtnDGia.Location = new System.Drawing.Point(85, 13);
            this.rbtnDGia.Name = "rbtnDGia";
            this.rbtnDGia.Size = new System.Drawing.Size(84, 23);
            this.rbtnDGia.TabIndex = 1;
            this.rbtnDGia.TabStop = true;
            this.rbtnDGia.Text = "Đọc Giả";
            this.rbtnDGia.UseVisualStyleBackColor = true;
            // 
            // rbtnSach
            // 
            this.rbtnSach.AutoSize = true;
            this.rbtnSach.Location = new System.Drawing.Point(3, 13);
            this.rbtnSach.Name = "rbtnSach";
            this.rbtnSach.Size = new System.Drawing.Size(59, 23);
            this.rbtnSach.TabIndex = 0;
            this.rbtnSach.TabStop = true;
            this.rbtnSach.Text = "Sách";
            this.rbtnSach.UseVisualStyleBackColor = true;
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.ForeColor = System.Drawing.Color.Black;
            this.lbTenSach.Location = new System.Drawing.Point(445, 89);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(135, 19);
            this.lbTenSach.TabIndex = 18;
            this.lbTenSach.Text = "______________";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.ForeColor = System.Drawing.Color.Black;
            this.lbMaSach.Location = new System.Drawing.Point(445, 59);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(135, 19);
            this.lbMaSach.TabIndex = 17;
            this.lbMaSach.Text = "______________";
            // 
            // lbMaID
            // 
            this.lbMaID.AutoSize = true;
            this.lbMaID.ForeColor = System.Drawing.Color.Black;
            this.lbMaID.Location = new System.Drawing.Point(445, 29);
            this.lbMaID.Name = "lbMaID";
            this.lbMaID.Size = new System.Drawing.Size(135, 19);
            this.lbMaID.TabIndex = 16;
            this.lbMaID.Text = "______________";
            // 
            // lbNgMuon
            // 
            this.lbNgMuon.AutoSize = true;
            this.lbNgMuon.ForeColor = System.Drawing.Color.Black;
            this.lbNgMuon.Location = new System.Drawing.Point(128, 118);
            this.lbNgMuon.Name = "lbNgMuon";
            this.lbNgMuon.Size = new System.Drawing.Size(135, 19);
            this.lbNgMuon.TabIndex = 15;
            this.lbNgMuon.Text = "______________";
            // 
            // lbTenDGia
            // 
            this.lbTenDGia.AutoSize = true;
            this.lbTenDGia.ForeColor = System.Drawing.Color.Black;
            this.lbTenDGia.Location = new System.Drawing.Point(127, 89);
            this.lbTenDGia.Name = "lbTenDGia";
            this.lbTenDGia.Size = new System.Drawing.Size(135, 19);
            this.lbTenDGia.TabIndex = 14;
            this.lbTenDGia.Text = "______________";
            // 
            // lbMaDGia
            // 
            this.lbMaDGia.AutoSize = true;
            this.lbMaDGia.ForeColor = System.Drawing.Color.Black;
            this.lbMaDGia.Location = new System.Drawing.Point(127, 59);
            this.lbMaDGia.Name = "lbMaDGia";
            this.lbMaDGia.Size = new System.Drawing.Size(135, 19);
            this.lbMaDGia.TabIndex = 13;
            this.lbMaDGia.Text = "______________";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(133, 148);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.ShowUpDown = true;
            this.dtpNgayTra.Size = new System.Drawing.Size(131, 27);
            this.dtpNgayTra.TabIndex = 12;
            this.dtpNgayTra.Value = new System.DateTime(2018, 1, 10, 12, 52, 23, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày Trả";
            // 
            // lbMaMuon
            // 
            this.lbMaMuon.AutoSize = true;
            this.lbMaMuon.ForeColor = System.Drawing.Color.Black;
            this.lbMaMuon.Location = new System.Drawing.Point(128, 29);
            this.lbMaMuon.Name = "lbMaMuon";
            this.lbMaMuon.Size = new System.Drawing.Size(135, 19);
            this.lbMaMuon.TabIndex = 8;
            this.lbMaMuon.Text = "______________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày Mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên Sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Đọc Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Đọc Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phiếu Mượn:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmMớiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.làmMớiToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.làmMớiToolStripMenuItem.Text = "Làm Mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwTraSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraSach";
            this.Text = "Quản Lý Thư Viện";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwTraSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.RadioButton rbtnSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbMaID;
        private System.Windows.Forms.Label lbNgMuon;
        private System.Windows.Forms.Label lbTenDGia;
        private System.Windows.Forms.Label lbMaDGia;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMaMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnDGia;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbSLuongConlai;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
    }
}