namespace QUẢN_LÝ_BÁN_HÀNG
{
	partial class PHIẾU_XUẤT_KHO
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
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tenmhom = new System.Windows.Forms.Label();
            this.dtNgayDH = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayXK = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathang = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet25();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTP = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPXK = new System.Windows.Forms.TextBox();
            this.lbmstp = new System.Windows.Forms.Label();
            this.matHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet25TableAdapters.MatHangTableAdapter();
            this.maPXKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuXuatKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pxk = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet24();
            this.phieuXuatKhoTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet24TableAdapters.PhieuXuatKhoTableAdapter();
            this.chiTietPhieuXuatKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctpxk = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet23();
            this.chiTietPhieuXuatKhoTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet23TableAdapters.ChiTietPhieuXuatKhoTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathang)).BeginInit();
            this.groupBoxTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuXuatKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpxk)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.chiTietPhieuXuatKhoBindingSource, "TenMH", true));
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietPhieuXuatKhoBindingSource, "TenMH", true));
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Location = new System.Drawing.Point(211, 85);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(213, 27);
            this.txtTenMH.TabIndex = 67;
            this.txtTenMH.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.chiTietPhieuXuatKhoBindingSource, "Soluong", true));
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietPhieuXuatKhoBindingSource, "Soluong", true));
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(211, 130);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(213, 27);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.chiTietPhieuXuatKhoBindingSource, "MaMH", true));
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietPhieuXuatKhoBindingSource, "MaMH", true));
            this.txtMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(211, 40);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(213, 27);
            this.txtMaMH.TabIndex = 6;
            this.txtMaMH.Enter += new System.EventHandler(this.txtMaMH_Enter);
            this.txtMaMH.Leave += new System.EventHandler(this.txtMaMH_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Mã Mặt Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 22);
            this.label7.TabIndex = 66;
            this.label7.Text = "Tên mặt hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnMain);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(899, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 390);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.document_add_256_icon_icons_com_75994;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(27, 53);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 47);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.delete_file_40456;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(27, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 47);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources._62914memo_109205;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(271, 115);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 47);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.log_out_icon_icons_com_50106;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(271, 178);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 47);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.White;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMain.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources._3643769_building_home_house_main_menu_start_113416;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(27, 178);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(160, 47);
            this.btnMain.TabIndex = 14;
            this.btnMain.Text = "Trang chủ";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.Save_as_37111;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(271, 53);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 47);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaMH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenMH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.Tenmhom);
            this.groupBox2.Controls.Add(this.dtNgayDH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtNgayXK);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 193);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Xuất";
            // 
            // Tenmhom
            // 
            this.Tenmhom.AutoSize = true;
            this.Tenmhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenmhom.Location = new System.Drawing.Point(6, 135);
            this.Tenmhom.Name = "Tenmhom";
            this.Tenmhom.Size = new System.Drawing.Size(171, 22);
            this.Tenmhom.TabIndex = 60;
            this.Tenmhom.Text = "Số lượng xuất kho";
            // 
            // dtNgayDH
            // 
            this.dtNgayDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietPhieuXuatKhoBindingSource, "NgayDH", true));
            this.dtNgayDH.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.chiTietPhieuXuatKhoBindingSource, "NgayDH", true));
            this.dtNgayDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDH.Location = new System.Drawing.Point(677, 38);
            this.dtNgayDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayDH.Name = "dtNgayDH";
            this.dtNgayDH.Size = new System.Drawing.Size(164, 27);
            this.dtNgayDH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày Xuất Kho";
            // 
            // dtNgayXK
            // 
            this.dtNgayXK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietPhieuXuatKhoBindingSource, "NgayXK", true));
            this.dtNgayXK.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.chiTietPhieuXuatKhoBindingSource, "NgayXK", true));
            this.dtNgayXK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayXK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayXK.Location = new System.Drawing.Point(677, 90);
            this.dtNgayXK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayXK.Name = "dtNgayXK";
            this.dtNgayXK.Size = new System.Drawing.Size(164, 27);
            this.dtNgayXK.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ngày Đặt Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1331, 207);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Xuất";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPXKDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.maKhoDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dataGridView1.DataSource = this.phieuXuatKhoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 178);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.mathang;
            // 
            // mathang
            // 
            this.mathang.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet25";
            this.mathang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 35);
            this.label1.TabIndex = 68;
            this.label1.Text = "QUẢN LÝ XUẤT KHO";
            // 
            // groupBoxTP
            // 
            this.groupBoxTP.BackColor = System.Drawing.Color.White;
            this.groupBoxTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxTP.Controls.Add(this.txtMaKH);
            this.groupBoxTP.Controls.Add(this.label2);
            this.groupBoxTP.Controls.Add(this.txtMaKho);
            this.groupBoxTP.Controls.Add(this.label10);
            this.groupBoxTP.Controls.Add(this.txtTenNV);
            this.groupBoxTP.Controls.Add(this.label9);
            this.groupBoxTP.Controls.Add(this.txtGhiChu);
            this.groupBoxTP.Controls.Add(this.label8);
            this.groupBoxTP.Controls.Add(this.txtMaNV);
            this.groupBoxTP.Controls.Add(this.label3);
            this.groupBoxTP.Controls.Add(this.txtMaPXK);
            this.groupBoxTP.Controls.Add(this.lbmstp);
            this.groupBoxTP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTP.Location = new System.Drawing.Point(12, 46);
            this.groupBoxTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTP.Name = "groupBoxTP";
            this.groupBoxTP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTP.Size = new System.Drawing.Size(881, 192);
            this.groupBoxTP.TabIndex = 67;
            this.groupBoxTP.TabStop = false;
            this.groupBoxTP.Text = "Phiếu Xuất";
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuXuatKhoBindingSource, "MaKH", true));
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatKhoBindingSource, "MaKH", true));
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(665, 42);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(213, 27);
            this.txtMaKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 84;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuXuatKhoBindingSource, "MaKho", true));
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatKhoBindingSource, "MaKho", true));
            this.txtMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.Location = new System.Drawing.Point(665, 98);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(213, 27);
            this.txtMaKho.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(487, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 22);
            this.label10.TabIndex = 82;
            this.label10.Text = "Mã Kho";
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuXuatKhoBindingSource, "TenNV", true));
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatKhoBindingSource, "TenNV", true));
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(211, 147);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(213, 27);
            this.txtTenNV.TabIndex = 81;
            this.txtTenNV.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 22);
            this.label9.TabIndex = 80;
            this.label9.Text = "Tên Nhân Viên";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuXuatKhoBindingSource, "Ghichu", true));
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatKhoBindingSource, "Ghichu", true));
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(665, 147);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(213, 27);
            this.txtGhiChu.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(487, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ghi chú";
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuXuatKhoBindingSource, "MaNV", true));
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatKhoBindingSource, "MaNV", true));
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(211, 98);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(213, 27);
            this.txtMaNV.TabIndex = 2;
            this.txtMaNV.Leave += new System.EventHandler(this.txtMaNV_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // txtMaPXK
            // 
            this.txtMaPXK.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuXuatKhoBindingSource, "MaPXK", true));
            this.txtMaPXK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatKhoBindingSource, "MaPXK", true));
            this.txtMaPXK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPXK.Location = new System.Drawing.Point(211, 44);
            this.txtMaPXK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPXK.Name = "txtMaPXK";
            this.txtMaPXK.Size = new System.Drawing.Size(213, 27);
            this.txtMaPXK.TabIndex = 1;
            // 
            // lbmstp
            // 
            this.lbmstp.AutoSize = true;
            this.lbmstp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmstp.Location = new System.Drawing.Point(6, 45);
            this.lbmstp.Name = "lbmstp";
            this.lbmstp.Size = new System.Drawing.Size(181, 22);
            this.lbmstp.TabIndex = 3;
            this.lbmstp.Text = "Mã Phiếu Xuất Kho";
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // maPXKDataGridViewTextBoxColumn
            // 
            this.maPXKDataGridViewTextBoxColumn.DataPropertyName = "MaPXK";
            this.maPXKDataGridViewTextBoxColumn.HeaderText = "MaPXK";
            this.maPXKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPXKDataGridViewTextBoxColumn.Name = "maPXKDataGridViewTextBoxColumn";
            this.maPXKDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPXKDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKhoDataGridViewTextBoxColumn
            // 
            this.maKhoDataGridViewTextBoxColumn.DataPropertyName = "MaKho";
            this.maKhoDataGridViewTextBoxColumn.HeaderText = "MaKho";
            this.maKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhoDataGridViewTextBoxColumn.Name = "maKhoDataGridViewTextBoxColumn";
            this.maKhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKhoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghichu";
            this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            this.ghichuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghichuDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieuXuatKhoBindingSource
            // 
            this.phieuXuatKhoBindingSource.DataMember = "PhieuXuatKho";
            this.phieuXuatKhoBindingSource.DataSource = this.pxk;
            // 
            // pxk
            // 
            this.pxk.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet24";
            this.pxk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuXuatKhoTableAdapter
            // 
            this.phieuXuatKhoTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietPhieuXuatKhoBindingSource
            // 
            this.chiTietPhieuXuatKhoBindingSource.DataMember = "ChiTietPhieuXuatKho";
            this.chiTietPhieuXuatKhoBindingSource.DataSource = this.ctpxk;
            // 
            // ctpxk
            // 
            this.ctpxk.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet23";
            this.ctpxk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietPhieuXuatKhoTableAdapter
            // 
            this.chiTietPhieuXuatKhoTableAdapter.ClearBeforeFill = true;
            // 
            // PHIẾU_XUẤT_KHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTP);
            this.Name = "PHIẾU_XUẤT_KHO";
            this.Text = "PHIẾU_XUẤT_KHO";
            this.Load += new System.EventHandler(this.PHIẾU_XUẤT_KHO_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathang)).EndInit();
            this.groupBoxTP.ResumeLayout(false);
            this.groupBoxTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuXuatKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpxk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTenMH;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button btnMain;
		private System.Windows.Forms.TextBox txtMaMH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label Tenmhom;
		private System.Windows.Forms.DateTimePicker dtNgayDH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtNgayXK;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxTP;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaKho;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMaPXK;
		private System.Windows.Forms.Label lbmstp;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet23 ctpxk;
		private System.Windows.Forms.BindingSource chiTietPhieuXuatKhoBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet23TableAdapters.ChiTietPhieuXuatKhoTableAdapter chiTietPhieuXuatKhoTableAdapter;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet24 pxk;
		private System.Windows.Forms.BindingSource phieuXuatKhoBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet24TableAdapters.PhieuXuatKhoTableAdapter phieuXuatKhoTableAdapter;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet25 mathang;
		private System.Windows.Forms.BindingSource matHangBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet25TableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPXKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
    }
}