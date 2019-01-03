namespace DoAn1._1
{
    partial class frmNVien
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
            this.lvwAccount = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlQTrCap = new System.Windows.Forms.Panel();
            this.rbtnNV = new System.Windows.Forms.RadioButton();
            this.rbtnQL = new System.Windows.Forms.RadioButton();
            this.txbMaID = new System.Windows.Forms.TextBox();
            this.txbTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlQTrCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Tài Khoản Đăng Nhập";
            // 
            // lvwAccount
            // 
            this.lvwAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwAccount.Location = new System.Drawing.Point(6, 50);
            this.lvwAccount.Name = "lvwAccount";
            this.lvwAccount.Size = new System.Drawing.Size(484, 418);
            this.lvwAccount.TabIndex = 1;
            this.lvwAccount.UseCompatibleStateImageBehavior = false;
            this.lvwAccount.View = System.Windows.Forms.View.Details;
            this.lvwAccount.SelectedIndexChanged += new System.EventHandler(this.lvwAccount_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Nhân Viên";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tài Khoản";
            this.columnHeader2.Width = 279;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng Thái";
            this.columnHeader3.Width = 87;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnKhoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pnlQTrCap);
            this.panel1.Controls.Add(this.txbMaID);
            this.panel1.Controls.Add(this.txbTK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(496, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 418);
            this.panel1.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Aqua;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(158, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 32);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Thay Đổi";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(158, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 32);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Aqua;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Location = new System.Drawing.Point(11, 338);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(138, 32);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.Aqua;
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Location = new System.Drawing.Point(11, 375);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(277, 32);
            this.btnKhoa.TabIndex = 13;
            this.btnKhoa.Text = "Khóa";
            this.btnKhoa.UseVisualStyleBackColor = false;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Aqua;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(11, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 32);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(194, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 27);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(18, 21);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(159, 27);
            this.txbSearch.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quyền truy cập";
            // 
            // pnlQTrCap
            // 
            this.pnlQTrCap.Controls.Add(this.rbtnNV);
            this.pnlQTrCap.Controls.Add(this.rbtnQL);
            this.pnlQTrCap.Location = new System.Drawing.Point(11, 96);
            this.pnlQTrCap.Name = "pnlQTrCap";
            this.pnlQTrCap.Size = new System.Drawing.Size(242, 64);
            this.pnlQTrCap.TabIndex = 8;
            // 
            // rbtnNV
            // 
            this.rbtnNV.AutoSize = true;
            this.rbtnNV.Location = new System.Drawing.Point(140, 20);
            this.rbtnNV.Name = "rbtnNV";
            this.rbtnNV.Size = new System.Drawing.Size(97, 23);
            this.rbtnNV.TabIndex = 1;
            this.rbtnNV.TabStop = true;
            this.rbtnNV.Text = "Nhân Viên";
            this.rbtnNV.UseVisualStyleBackColor = true;
            // 
            // rbtnQL
            // 
            this.rbtnQL.AutoSize = true;
            this.rbtnQL.Location = new System.Drawing.Point(7, 20);
            this.rbtnQL.Name = "rbtnQL";
            this.rbtnQL.Size = new System.Drawing.Size(84, 23);
            this.rbtnQL.TabIndex = 0;
            this.rbtnQL.TabStop = true;
            this.rbtnQL.Text = "Quản Lý";
            this.rbtnQL.UseVisualStyleBackColor = true;
            // 
            // txbMaID
            // 
            this.txbMaID.Location = new System.Drawing.Point(151, 187);
            this.txbMaID.Name = "txbMaID";
            this.txbMaID.Size = new System.Drawing.Size(137, 27);
            this.txbMaID.TabIndex = 7;
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(151, 221);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(137, 27);
            this.txbTK.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // frmNVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwAccount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNVien";
            this.Text = "Quản Lý Thư Viện";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlQTrCap.ResumeLayout(false);
            this.pnlQTrCap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMaID;
        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlQTrCap;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.RadioButton rbtnNV;
        private System.Windows.Forms.RadioButton rbtnQL;
    }
}