namespace DoAn1._1
{
    partial class frmSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSearchSach = new System.Windows.Forms.TextBox();
            this.btnTKiemSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaS = new System.Windows.Forms.Button();
            this.btnCapNhatS = new System.Windows.Forms.Button();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.cbbTGia = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSach = new System.Windows.Forms.ComboBox();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.txbMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpSach = new System.Windows.Forms.FlowLayoutPanel();
            this.lvwSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Thông Tin Sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txbSearchSach);
            this.panel1.Controls.Add(this.btnTKiemSach);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoaS);
            this.panel1.Controls.Add(this.btnCapNhatS);
            this.panel1.Controls.Add(this.cbbNXB);
            this.panel1.Controls.Add(this.cbbTGia);
            this.panel1.Controls.Add(this.cbbLoaiSach);
            this.panel1.Controls.Add(this.txbSoLuong);
            this.panel1.Controls.Add(this.txbTenSach);
            this.panel1.Controls.Add(this.txbMaSach);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(719, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 440);
            this.panel1.TabIndex = 2;
            // 
            // txbSearchSach
            // 
            this.txbSearchSach.Location = new System.Drawing.Point(11, 33);
            this.txbSearchSach.Name = "txbSearchSach";
            this.txbSearchSach.Size = new System.Drawing.Size(172, 27);
            this.txbSearchSach.TabIndex = 0;
            // 
            // btnTKiemSach
            // 
            this.btnTKiemSach.BackColor = System.Drawing.Color.Aqua;
            this.btnTKiemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKiemSach.ForeColor = System.Drawing.Color.Blue;
            this.btnTKiemSach.Location = new System.Drawing.Point(189, 33);
            this.btnTKiemSach.Name = "btnTKiemSach";
            this.btnTKiemSach.Size = new System.Drawing.Size(92, 27);
            this.btnTKiemSach.TabIndex = 1;
            this.btnTKiemSach.Text = "Tìm Kiếm";
            this.btnTKiemSach.UseVisualStyleBackColor = false;
            this.btnTKiemSach.Click += new System.EventHandler(this.btnTKiemSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(189, 333);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 82);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaS
            // 
            this.btnXoaS.BackColor = System.Drawing.Color.Aqua;
            this.btnXoaS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaS.ForeColor = System.Drawing.Color.Blue;
            this.btnXoaS.Location = new System.Drawing.Point(5, 378);
            this.btnXoaS.Name = "btnXoaS";
            this.btnXoaS.Size = new System.Drawing.Size(178, 37);
            this.btnXoaS.TabIndex = 9;
            this.btnXoaS.Text = "Xóa";
            this.btnXoaS.UseVisualStyleBackColor = false;
            this.btnXoaS.Click += new System.EventHandler(this.btnXoaS_Click);
            // 
            // btnCapNhatS
            // 
            this.btnCapNhatS.BackColor = System.Drawing.Color.Aqua;
            this.btnCapNhatS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatS.ForeColor = System.Drawing.Color.Blue;
            this.btnCapNhatS.Location = new System.Drawing.Point(5, 333);
            this.btnCapNhatS.Name = "btnCapNhatS";
            this.btnCapNhatS.Size = new System.Drawing.Size(178, 39);
            this.btnCapNhatS.TabIndex = 8;
            this.btnCapNhatS.Text = "Cập Nhật";
            this.btnCapNhatS.UseVisualStyleBackColor = false;
            this.btnCapNhatS.Click += new System.EventHandler(this.btnCapNhatS_Click);
            // 
            // cbbNXB
            // 
            this.cbbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(134, 256);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(139, 27);
            this.cbbNXB.TabIndex = 6;
            // 
            // cbbTGia
            // 
            this.cbbTGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTGia.FormattingEnabled = true;
            this.cbbTGia.Location = new System.Drawing.Point(134, 221);
            this.cbbTGia.Name = "cbbTGia";
            this.cbbTGia.Size = new System.Drawing.Size(139, 27);
            this.cbbTGia.TabIndex = 5;
            // 
            // cbbLoaiSach
            // 
            this.cbbLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiSach.FormattingEnabled = true;
            this.cbbLoaiSach.Location = new System.Drawing.Point(134, 188);
            this.cbbLoaiSach.Name = "cbbLoaiSach";
            this.cbbLoaiSach.Size = new System.Drawing.Size(139, 27);
            this.cbbLoaiSach.TabIndex = 4;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(134, 289);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(139, 27);
            this.txbSoLuong.TabIndex = 7;
            this.txbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSoLuong_KeyPress);
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(134, 155);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(139, 27);
            this.txbTenSach.TabIndex = 3;
            // 
            // txbMaSach
            // 
            this.txbMaSach.Location = new System.Drawing.Point(134, 122);
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(139, 27);
            this.txbMaSach.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhà xuất bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thể loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(73, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông Tin Sách";
            // 
            // flpSach
            // 
            this.flpSach.AutoScroll = true;
            this.flpSach.BackColor = System.Drawing.Color.Silver;
            this.flpSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpSach.Location = new System.Drawing.Point(12, 145);
            this.flpSach.Name = "flpSach";
            this.flpSach.Size = new System.Drawing.Size(701, 440);
            this.flpSach.TabIndex = 3;
            // 
            // lvwSach
            // 
            this.lvwSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwSach.GridLines = true;
            this.lvwSach.Location = new System.Drawing.Point(12, 61);
            this.lvwSach.Name = "lvwSach";
            this.lvwSach.Size = new System.Drawing.Size(990, 78);
            this.lvwSach.TabIndex = 4;
            this.lvwSach.UseCompatibleStateImageBehavior = false;
            this.lvwSach.View = System.Windows.Forms.View.Details;
            this.lvwSach.SelectedIndexChanged += new System.EventHandler(this.lvwSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.Width = 211;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thể Loại";
            this.columnHeader3.Width = 183;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tác Giả";
            this.columnHeader4.Width = 186;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "NXB";
            this.columnHeader5.Width = 208;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Lượng";
            this.columnHeader6.Width = 82;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiToolStripMenuItem,
            this.nhàXuấtBảnToolStripMenuItem,
            this.tácGiảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loạiToolStripMenuItem
            // 
            this.loạiToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.loạiToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.loạiToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.loạiToolStripMenuItem.Name = "loạiToolStripMenuItem";
            this.loạiToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.loạiToolStripMenuItem.Text = "Thể Loại Sách";
            this.loạiToolStripMenuItem.Click += new System.EventHandler(this.loạiToolStripMenuItem_Click);
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            this.nhàXuấtBảnToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.nhàXuấtBảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhàXuấtBảnToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            this.nhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(105, 21);
            this.nhàXuấtBảnToolStripMenuItem.Text = "Nhà Xuất Bản";
            this.nhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.nhàXuấtBảnToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.tácGiảToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tácGiảToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.tácGiảToolStripMenuItem.Text = "Tác Giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 597);
            this.Controls.Add(this.lvwSach);
            this.Controls.Add(this.flpSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSach";
            this.Text = "Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaS;
        private System.Windows.Forms.Button btnCapNhatS;
        private System.Windows.Forms.ComboBox cbbNXB;
        private System.Windows.Forms.ComboBox cbbTGia;
        private System.Windows.Forms.ComboBox cbbLoaiSach;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.TextBox txbMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpSach;
        private System.Windows.Forms.Button btnTKiemSach;
        private System.Windows.Forms.ListView lvwSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.TextBox txbSearchSach;
    }
}