namespace QUẢN_LÝ_BÁN_HÀNG
{
	partial class PHIẾU_GIAO_HÀNG
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
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtMaPGH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNguoiGH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayGH = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.maPGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiGiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuGiaoHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pgh = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21();
            this.phieuGiaoHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21TableAdapters.PhieuGiaoHangTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuGiaoHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKH
            // 
            this.txtKH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "TenKH", true));
            this.txtKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "TenKH", true));
            this.txtKH.Location = new System.Drawing.Point(213, 66);
            this.txtKH.Name = "txtKH";
            this.txtKH.ReadOnly = true;
            this.txtKH.Size = new System.Drawing.Size(200, 22);
            this.txtKH.TabIndex = 0;
            this.txtKH.TabStop = false;
            // 
            // txtMaPGH
            // 
            this.txtMaPGH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaPGH", true));
            this.txtMaPGH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaPGH", true));
            this.txtMaPGH.Location = new System.Drawing.Point(213, 24);
            this.txtMaPGH.Name = "txtMaPGH";
            this.txtMaPGH.Size = new System.Drawing.Size(200, 22);
            this.txtMaPGH.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaKH", true));
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(605, 68);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(177, 22);
            this.txtMaKH.TabIndex = 4;
            this.txtMaKH.Leave += new System.EventHandler(this.txtMaKH_Leave);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaNV", true));
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaNV", true));
            this.txtMaNV.Location = new System.Drawing.Point(605, 112);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(177, 22);
            this.txtMaNV.TabIndex = 5;
            this.txtMaNV.Leave += new System.EventHandler(this.txtMaNV_Leave);
            // 
            // txtNV
            // 
            this.txtNV.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "TenNV", true));
            this.txtNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "TenNV", true));
            this.txtNV.Location = new System.Drawing.Point(213, 110);
            this.txtNV.Name = "txtNV";
            this.txtNV.ReadOnly = true;
            this.txtNV.Size = new System.Drawing.Size(200, 22);
            this.txtNV.TabIndex = 4;
            this.txtNV.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "PHIẾU GIAO HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã Phiếu Giao Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(434, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaHD", true));
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaHD", true));
            this.txtMaHD.Location = new System.Drawing.Point(605, 24);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(177, 22);
            this.txtMaHD.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày Giao Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Người Giao Hàng";
            // 
            // txtNguoiGH
            // 
            this.txtNguoiGH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "NguoiGiao", true));
            this.txtNguoiGH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "NguoiGiao", true));
            this.txtNguoiGH.Location = new System.Drawing.Point(605, 152);
            this.txtNguoiGH.Name = "txtNguoiGH";
            this.txtNguoiGH.Size = new System.Drawing.Size(177, 22);
            this.txtNguoiGH.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dtNgayGH);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtKH);
            this.groupBox1.Controls.Add(this.txtMaPGH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtNV);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNguoiGH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 214);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dtNgayGH
            // 
            this.dtNgayGH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "NgayGiao", true));
            this.dtNgayGH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "NgayGiao", true));
            this.dtNgayGH.Location = new System.Drawing.Point(213, 151);
            this.dtNgayGH.Name = "dtNgayGH";
            this.dtNgayGH.Size = new System.Drawing.Size(200, 22);
            this.dtNgayGH.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.Save_as_37111;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(989, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 47);
            this.btnLuu.TabIndex = 62;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources._62914memo_109205;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(989, 71);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 47);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.delete_file_40456;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(823, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 47);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.document_add_256_icon_icons_com_75994;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(823, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 47);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.log_out_icon_icons_com_50106;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1001, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 47);
            this.btnExit.TabIndex = 60;
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
            this.btnMain.Location = new System.Drawing.Point(835, 11);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(160, 47);
            this.btnMain.TabIndex = 59;
            this.btnMain.Text = "Trang chủ";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPGHDataGridViewTextBoxColumn,
            this.maHDDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.ngayGiaoDataGridViewTextBoxColumn,
            this.nguoiGiaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phieuGiaoHangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 307);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1049, 157);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1049, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(823, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 24);
            this.txtSearch.TabIndex = 63;
            // 
            // maPGHDataGridViewTextBoxColumn
            // 
            this.maPGHDataGridViewTextBoxColumn.DataPropertyName = "MaPGH";
            this.maPGHDataGridViewTextBoxColumn.HeaderText = "MaPGH";
            this.maPGHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPGHDataGridViewTextBoxColumn.Name = "maPGHDataGridViewTextBoxColumn";
            this.maPGHDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayGiaoDataGridViewTextBoxColumn
            // 
            this.ngayGiaoDataGridViewTextBoxColumn.DataPropertyName = "NgayGiao";
            this.ngayGiaoDataGridViewTextBoxColumn.HeaderText = "NgayGiao";
            this.ngayGiaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayGiaoDataGridViewTextBoxColumn.Name = "ngayGiaoDataGridViewTextBoxColumn";
            this.ngayGiaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nguoiGiaoDataGridViewTextBoxColumn
            // 
            this.nguoiGiaoDataGridViewTextBoxColumn.DataPropertyName = "NguoiGiao";
            this.nguoiGiaoDataGridViewTextBoxColumn.HeaderText = "NguoiGiao";
            this.nguoiGiaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nguoiGiaoDataGridViewTextBoxColumn.Name = "nguoiGiaoDataGridViewTextBoxColumn";
            this.nguoiGiaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieuGiaoHangBindingSource
            // 
            this.phieuGiaoHangBindingSource.DataMember = "PhieuGiaoHang";
            this.phieuGiaoHangBindingSource.DataSource = this.pgh;
            // 
            // pgh
            // 
            this.pgh.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21";
            this.pgh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuGiaoHangTableAdapter
            // 
            this.phieuGiaoHangTableAdapter.ClearBeforeFill = true;
            // 
            // PHIẾU_GIAO_HÀNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 597);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PHIẾU_GIAO_HÀNG";
            this.Text = "PHIẾU_GIAO_HÀNG";
            this.Load += new System.EventHandler(this.PHIẾU_GIAO_HÀNG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuGiaoHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtKH;
		private System.Windows.Forms.TextBox txtMaPGH;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.TextBox txtNV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMaHD;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNguoiGH;
		private System.Windows.Forms.Button btnMain;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnLuu;
        private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21 pgh;
        private System.Windows.Forms.BindingSource phieuGiaoHangBindingSource;
        private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21TableAdapters.PhieuGiaoHangTableAdapter phieuGiaoHangTableAdapter;
        private System.Windows.Forms.DateTimePicker dtNgayGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiGiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}