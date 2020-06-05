namespace QuanLyDiem
{
    partial class FrmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhVien));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMaQue = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMaDanToc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMaChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMaHDT = new System.Windows.Forms.ComboBox();
            this.cmbMaChucVu = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.clmMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaHDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.checkGioiTinh = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(124, 67);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sinh viên :";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(124, 96);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(100, 20);
            this.txtTenSV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã khoa :";
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(124, 129);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbMaKhoa.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(20, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã lớp :";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(124, 161);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(121, 21);
            this.cmbMaLop.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(18, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày sinh :";
            // 
            // mtbNgaySinh
            // 
            this.mtbNgaySinh.Location = new System.Drawing.Point(124, 195);
            this.mtbNgaySinh.Mask = "00/00/0000";
            this.mtbNgaySinh.Name = "mtbNgaySinh";
            this.mtbNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.mtbNgaySinh.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(21, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giới tính :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(21, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã quê :";
            // 
            // cmbMaQue
            // 
            this.cmbMaQue.FormattingEnabled = true;
            this.cmbMaQue.Location = new System.Drawing.Point(124, 262);
            this.cmbMaQue.Name = "cmbMaQue";
            this.cmbMaQue.Size = new System.Drawing.Size(121, 21);
            this.cmbMaQue.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(21, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã dân tộc :";
            // 
            // cmbMaDanToc
            // 
            this.cmbMaDanToc.FormattingEnabled = true;
            this.cmbMaDanToc.Location = new System.Drawing.Point(112, 264);
            this.cmbMaDanToc.Name = "cmbMaDanToc";
            this.cmbMaDanToc.Size = new System.Drawing.Size(121, 26);
            this.cmbMaDanToc.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(21, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã chuyên ngành :";
            // 
            // cmbMaChuyenNganh
            // 
            this.cmbMaChuyenNganh.FormattingEnabled = true;
            this.cmbMaChuyenNganh.Location = new System.Drawing.Point(147, 300);
            this.cmbMaChuyenNganh.Name = "cmbMaChuyenNganh";
            this.cmbMaChuyenNganh.Size = new System.Drawing.Size(121, 26);
            this.cmbMaChuyenNganh.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(20, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mã hệ đào tạo :";
            // 
            // cmbMaHDT
            // 
            this.cmbMaHDT.FormattingEnabled = true;
            this.cmbMaHDT.Location = new System.Drawing.Point(147, 337);
            this.cmbMaHDT.Name = "cmbMaHDT";
            this.cmbMaHDT.Size = new System.Drawing.Size(121, 26);
            this.cmbMaHDT.TabIndex = 20;
            // 
            // cmbMaChucVu
            // 
            this.cmbMaChucVu.FormattingEnabled = true;
            this.cmbMaChucVu.Location = new System.Drawing.Point(147, 381);
            this.cmbMaChucVu.Name = "cmbMaChucVu";
            this.cmbMaChucVu.Size = new System.Drawing.Size(121, 26);
            this.cmbMaChucVu.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(21, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Mã chức vụ :";
            // 
            // GridViewSinhVien
            // 
            this.GridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaSV,
            this.clmTenSV,
            this.clmMaKhoa,
            this.clmMaLop,
            this.clmNgaySinh,
            this.clmGioiTinh,
            this.clmMaQue,
            this.clmMaDanToc,
            this.clmMaChuyenNganh,
            this.clmMaHDT,
            this.clmMaChucVu});
            this.GridViewSinhVien.Location = new System.Drawing.Point(0, 33);
            this.GridViewSinhVien.Name = "GridViewSinhVien";
            this.GridViewSinhVien.Size = new System.Drawing.Size(731, 264);
            this.GridViewSinhVien.TabIndex = 0;
            this.GridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSinhVien_CellClick);
            // 
            // clmMaSV
            // 
            this.clmMaSV.DataPropertyName = "MaSV";
            this.clmMaSV.HeaderText = "Mã sinh viên";
            this.clmMaSV.Name = "clmMaSV";
            // 
            // clmTenSV
            // 
            this.clmTenSV.DataPropertyName = "TenSV";
            this.clmTenSV.HeaderText = "Tên sinh viên";
            this.clmTenSV.Name = "clmTenSV";
            // 
            // clmMaKhoa
            // 
            this.clmMaKhoa.DataPropertyName = "MaKhoa";
            this.clmMaKhoa.HeaderText = "Mã khoa";
            this.clmMaKhoa.Name = "clmMaKhoa";
            // 
            // clmMaLop
            // 
            this.clmMaLop.DataPropertyName = "MaLop";
            this.clmMaLop.HeaderText = "Mã lớp";
            this.clmMaLop.Name = "clmMaLop";
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.DataPropertyName = "NgaySinh";
            this.clmNgaySinh.HeaderText = "Ngày sinh";
            this.clmNgaySinh.Name = "clmNgaySinh";
            // 
            // clmGioiTinh
            // 
            this.clmGioiTinh.DataPropertyName = "GioiTinh";
            this.clmGioiTinh.HeaderText = "Giới tính";
            this.clmGioiTinh.Name = "clmGioiTinh";
            // 
            // clmMaQue
            // 
            this.clmMaQue.DataPropertyName = "MaQue";
            this.clmMaQue.HeaderText = "Mã quê";
            this.clmMaQue.Name = "clmMaQue";
            // 
            // clmMaDanToc
            // 
            this.clmMaDanToc.DataPropertyName = "MaDanToc";
            this.clmMaDanToc.HeaderText = "Mã dân tộc";
            this.clmMaDanToc.Name = "clmMaDanToc";
            // 
            // clmMaChuyenNganh
            // 
            this.clmMaChuyenNganh.DataPropertyName = "MaChuyenNganh";
            this.clmMaChuyenNganh.HeaderText = "Mã chuyên ngành";
            this.clmMaChuyenNganh.Name = "clmMaChuyenNganh";
            // 
            // clmMaHDT
            // 
            this.clmMaHDT.DataPropertyName = "MaHDT";
            this.clmMaHDT.HeaderText = "Mã hệ đào tạo";
            this.clmMaHDT.Name = "clmMaHDT";
            // 
            // clmMaChucVu
            // 
            this.clmMaChucVu.DataPropertyName = "MaChucVu";
            this.clmMaChucVu.HeaderText = "Mã chức vụ";
            this.clmMaChucVu.Name = "clmMaChucVu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridViewSinhVien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(309, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 278);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(852, 402);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 41);
            this.btnThoat.TabIndex = 62;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(768, 402);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(62, 41);
            this.btnHuy.TabIndex = 63;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(686, 402);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(62, 41);
            this.btnLuu.TabIndex = 64;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(603, 402);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 41);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(521, 402);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 41);
            this.btnSua.TabIndex = 66;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(440, 402);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 41);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // checkGioiTinh
            // 
            this.checkGioiTinh.AutoSize = true;
            this.checkGioiTinh.Location = new System.Drawing.Point(124, 228);
            this.checkGioiTinh.Name = "checkGioiTinh";
            this.checkGioiTinh.Size = new System.Drawing.Size(48, 17);
            this.checkGioiTinh.TabIndex = 68;
            this.checkGioiTinh.Text = "Nam";
            this.checkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMaChuyenNganh);
            this.groupBox2.Controls.Add(this.cmbMaHDT);
            this.groupBox2.Controls.Add(this.cmbMaChucVu);
            this.groupBox2.Controls.Add(this.cmbMaDanToc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 410);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin sinh viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(874, 67);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 70;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.checkGioiTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMaQue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbNgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMaKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMaQue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMaDanToc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMaChuyenNganh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMaHDT;
        private System.Windows.Forms.ComboBox cmbMaChucVu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView GridViewSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaChucVu;
        private System.Windows.Forms.CheckBox checkGioiTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
    }
}