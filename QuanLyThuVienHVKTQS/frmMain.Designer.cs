namespace QuanLyThuVienHVKTQS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLiHêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiDanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMucDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDanhMucNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMucSach = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiMươnTraSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiemDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiemSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiemSachDaChoMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKetsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTKDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupedit_NV = new System.Windows.Forms.GroupBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.ngaysinhnv = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.sdttxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.socmtndtxt = new System.Windows.Forms.TextBox();
            this.diachitxt = new System.Windows.Forms.TextBox();
            this.tennvtxt = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anhnv_picture = new System.Windows.Forms.PictureBox();
            this.anhmoinvbtn = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupedit_NV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhnv_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLiHêThôngToolStripMenuItem,
            this.quanLiDanhMucToolStripMenuItem,
            this.quanLiMươnTraSachToolStripMenuItem,
            this.timKiêmToolStripMenuItem,
            this.ThongKetsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLiHêThôngToolStripMenuItem
            // 
            this.quanLiHêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhanVien,
            this.tsmiDangXuat,
            this.toolStripSeparator1,
            this.tsmiThoat});
            this.quanLiHêThôngToolStripMenuItem.Name = "quanLiHêThôngToolStripMenuItem";
            this.quanLiHêThôngToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.quanLiHêThôngToolStripMenuItem.Text = "Quản lí hệ thống";
            // 
            // tsmiNhanVien
            // 
            this.tsmiNhanVien.Enabled = false;
            this.tsmiNhanVien.Name = "tsmiNhanVien";
            this.tsmiNhanVien.Size = new System.Drawing.Size(177, 22);
            this.tsmiNhanVien.Text = "Quản lí Nhân viên";
            this.tsmiNhanVien.Click += new System.EventHandler(this.tsmiNhanVien_Click);
            // 
            // tsmiDangXuat
            // 
            this.tsmiDangXuat.Name = "tsmiDangXuat";
            this.tsmiDangXuat.Size = new System.Drawing.Size(177, 22);
            this.tsmiDangXuat.Text = "Đăng xuất";
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(177, 22);
            this.tsmiThoat.Text = "Thoát chương trình";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // quanLiDanhMucToolStripMenuItem
            // 
            this.quanLiDanhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDanhMucDocGia,
            this.toolStripSeparator2,
            this.tsmiDanhMucNXB,
            this.tsmiDanhMucSach});
            this.quanLiDanhMucToolStripMenuItem.Name = "quanLiDanhMucToolStripMenuItem";
            this.quanLiDanhMucToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quanLiDanhMucToolStripMenuItem.Text = "Quản lí danh mục";
            // 
            // tsmiDanhMucDocGia
            // 
            this.tsmiDanhMucDocGia.Name = "tsmiDanhMucDocGia";
            this.tsmiDanhMucDocGia.Size = new System.Drawing.Size(200, 22);
            this.tsmiDanhMucDocGia.Text = "Danh mục độc giả";
            this.tsmiDanhMucDocGia.Click += new System.EventHandler(this.tsmiDanhMucDocGia_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // tsmiDanhMucNXB
            // 
            this.tsmiDanhMucNXB.Name = "tsmiDanhMucNXB";
            this.tsmiDanhMucNXB.Size = new System.Drawing.Size(200, 22);
            this.tsmiDanhMucNXB.Text = "Danh mục nhà xuất bản";
            this.tsmiDanhMucNXB.Click += new System.EventHandler(this.tsmiDanhMucNXB_Click);
            // 
            // tsmiDanhMucSach
            // 
            this.tsmiDanhMucSach.Name = "tsmiDanhMucSach";
            this.tsmiDanhMucSach.Size = new System.Drawing.Size(200, 22);
            this.tsmiDanhMucSach.Text = "Danh mục sách";
            this.tsmiDanhMucSach.Click += new System.EventHandler(this.tsmiDanhMucSach_Click);
            // 
            // quanLiMươnTraSachToolStripMenuItem
            // 
            this.quanLiMươnTraSachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMuonSach});
            this.quanLiMươnTraSachToolStripMenuItem.Name = "quanLiMươnTraSachToolStripMenuItem";
            this.quanLiMươnTraSachToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.quanLiMươnTraSachToolStripMenuItem.Text = "Quản lí mượn, trả sách";
            // 
            // tsmiMuonSach
            // 
            this.tsmiMuonSach.Name = "tsmiMuonSach";
            this.tsmiMuonSach.Size = new System.Drawing.Size(163, 22);
            this.tsmiMuonSach.Text = "Mượn && trả sách";
            this.tsmiMuonSach.Click += new System.EventHandler(this.tsmiMuonSach_Click);
            // 
            // timKiêmToolStripMenuItem
            // 
            this.timKiêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTimKiemDocGia,
            this.tsmiTimKiemSach,
            this.tsmiTimKiemSachDaChoMuon});
            this.timKiêmToolStripMenuItem.Name = "timKiêmToolStripMenuItem";
            this.timKiêmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.timKiêmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tsmiTimKiemDocGia
            // 
            this.tsmiTimKiemDocGia.Name = "tsmiTimKiemDocGia";
            this.tsmiTimKiemDocGia.Size = new System.Drawing.Size(196, 22);
            this.tsmiTimKiemDocGia.Text = "Tìm độc giả";
            this.tsmiTimKiemDocGia.Click += new System.EventHandler(this.tsmiTimKiemDocGia_Click);
            // 
            // tsmiTimKiemSach
            // 
            this.tsmiTimKiemSach.Name = "tsmiTimKiemSach";
            this.tsmiTimKiemSach.Size = new System.Drawing.Size(196, 22);
            this.tsmiTimKiemSach.Text = "Tìm sách";
            this.tsmiTimKiemSach.Click += new System.EventHandler(this.tsmiTimKiemSach_Click);
            // 
            // tsmiTimKiemSachDaChoMuon
            // 
            this.tsmiTimKiemSachDaChoMuon.Name = "tsmiTimKiemSachDaChoMuon";
            this.tsmiTimKiemSachDaChoMuon.Size = new System.Drawing.Size(196, 22);
            this.tsmiTimKiemSachDaChoMuon.Text = "Tìm sách đã cho mượn";
            this.tsmiTimKiemSachDaChoMuon.Click += new System.EventHandler(this.tsmiTimKiemSachDaChoMuon_Click);
            // 
            // ThongKetsmi
            // 
            this.ThongKetsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTKDocGia});
            this.ThongKetsmi.Name = "ThongKetsmi";
            this.ThongKetsmi.Size = new System.Drawing.Size(56, 20);
            this.ThongKetsmi.Text = "Lịch sử";
            this.ThongKetsmi.Visible = false;
            // 
            // tsmiTKDocGia
            // 
            this.tsmiTKDocGia.Name = "tsmiTKDocGia";
            this.tsmiTKDocGia.Size = new System.Drawing.Size(176, 22);
            this.tsmiTKDocGia.Text = "Lịch sử mượn && trả";
            this.tsmiTKDocGia.Click += new System.EventHandler(this.tsmiTKDocGia_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupedit_NV
            // 
            this.groupedit_NV.Controls.Add(this.txtMatKhau);
            this.groupedit_NV.Controls.Add(this.label7);
            this.groupedit_NV.Controls.Add(this.cbbGioiTinh);
            this.groupedit_NV.Controls.Add(this.btnBoQua);
            this.groupedit_NV.Controls.Add(this.ngaysinhnv);
            this.groupedit_NV.Controls.Add(this.btnLuu);
            this.groupedit_NV.Controls.Add(this.sdttxt);
            this.groupedit_NV.Controls.Add(this.label6);
            this.groupedit_NV.Controls.Add(this.label5);
            this.groupedit_NV.Controls.Add(this.textBox1);
            this.groupedit_NV.Controls.Add(this.socmtndtxt);
            this.groupedit_NV.Controls.Add(this.diachitxt);
            this.groupedit_NV.Controls.Add(this.tennvtxt);
            this.groupedit_NV.Controls.Add(this.txtTenDangNhap);
            this.groupedit_NV.Controls.Add(this.label9);
            this.groupedit_NV.Controls.Add(this.label8);
            this.groupedit_NV.Controls.Add(this.label4);
            this.groupedit_NV.Controls.Add(this.label3);
            this.groupedit_NV.Controls.Add(this.label2);
            this.groupedit_NV.Controls.Add(this.label1);
            this.groupedit_NV.Enabled = false;
            this.groupedit_NV.Location = new System.Drawing.Point(226, 27);
            this.groupedit_NV.Name = "groupedit_NV";
            this.groupedit_NV.Size = new System.Drawing.Size(409, 440);
            this.groupedit_NV.TabIndex = 8;
            this.groupedit_NV.TabStop = false;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(93, 179);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(100, 21);
            this.cbbGioiTinh.TabIndex = 32;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(328, 401);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 31;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // ngaysinhnv
            // 
            this.ngaysinhnv.CustomFormat = "dd/MM/yyyy";
            this.ngaysinhnv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinhnv.Location = new System.Drawing.Point(93, 140);
            this.ngaysinhnv.Name = "ngaysinhnv";
            this.ngaysinhnv.Size = new System.Drawing.Size(190, 20);
            this.ngaysinhnv.TabIndex = 29;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(241, 401);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // sdttxt
            // 
            this.sdttxt.Location = new System.Drawing.Point(93, 216);
            this.sdttxt.Name = "sdttxt";
            this.sdttxt.Size = new System.Drawing.Size(174, 20);
            this.sdttxt.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ghi chú";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(93, 333);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 54);
            this.textBox1.TabIndex = 23;
            // 
            // socmtndtxt
            // 
            this.socmtndtxt.Location = new System.Drawing.Point(93, 294);
            this.socmtndtxt.Name = "socmtndtxt";
            this.socmtndtxt.Size = new System.Drawing.Size(174, 20);
            this.socmtndtxt.TabIndex = 18;
            // 
            // diachitxt
            // 
            this.diachitxt.Location = new System.Drawing.Point(93, 255);
            this.diachitxt.Name = "diachitxt";
            this.diachitxt.Size = new System.Drawing.Size(297, 20);
            this.diachitxt.TabIndex = 14;
            // 
            // tennvtxt
            // 
            this.tennvtxt.Location = new System.Drawing.Point(105, 103);
            this.tennvtxt.Name = "tennvtxt";
            this.tennvtxt.Size = new System.Drawing.Size(162, 20);
            this.tennvtxt.TabIndex = 13;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(105, 24);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(162, 20);
            this.txtTenDangNhap.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giới tinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số CMTND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // anhnv_picture
            // 
            this.anhnv_picture.Location = new System.Drawing.Point(12, 36);
            this.anhnv_picture.Name = "anhnv_picture";
            this.anhnv_picture.Size = new System.Drawing.Size(200, 200);
            this.anhnv_picture.TabIndex = 27;
            this.anhnv_picture.TabStop = false;
            this.anhnv_picture.WaitOnLoad = true;
            // 
            // anhmoinvbtn
            // 
            this.anhmoinvbtn.Location = new System.Drawing.Point(69, 245);
            this.anhmoinvbtn.Name = "anhmoinvbtn";
            this.anhmoinvbtn.Size = new System.Drawing.Size(81, 26);
            this.anhmoinvbtn.TabIndex = 28;
            this.anhmoinvbtn.Text = "ảnh mới";
            this.anhmoinvbtn.UseVisualStyleBackColor = true;
            this.anhmoinvbtn.Click += new System.EventHandler(this.anhmoinvbtn_Click);
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(402, 473);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(140, 23);
            this.btnSuaThongTin.TabIndex = 29;
            this.btnSuaThongTin.Text = "Sửa thông tin cá nhân";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(554, 473);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(105, 63);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(162, 20);
            this.txtMatKhau.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mật khẩu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 508);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuaThongTin);
            this.Controls.Add(this.groupedit_NV);
            this.Controls.Add(this.anhmoinvbtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.anhnv_picture);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupedit_NV.ResumeLayout(false);
            this.groupedit_NV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhnv_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLiHêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem quanLiDanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMucDocGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMucNXB;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMucSach;
        private System.Windows.Forms.ToolStripMenuItem quanLiMươnTraSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuonSach;
        private System.Windows.Forms.ToolStripMenuItem timKiêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiemDocGia;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiemSach;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiemSachDaChoMuon;
        private System.Windows.Forms.ToolStripMenuItem ThongKetsmi;
        private System.Windows.Forms.ToolStripMenuItem tsmiTKDocGia;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhanVien;
        private System.Windows.Forms.GroupBox groupedit_NV;
        private System.Windows.Forms.DateTimePicker ngaysinhnv;
        private System.Windows.Forms.TextBox sdttxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox socmtndtxt;
        private System.Windows.Forms.TextBox diachitxt;
        private System.Windows.Forms.TextBox tennvtxt;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox anhnv_picture;
        private System.Windows.Forms.Button anhmoinvbtn;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label7;
    }
}

