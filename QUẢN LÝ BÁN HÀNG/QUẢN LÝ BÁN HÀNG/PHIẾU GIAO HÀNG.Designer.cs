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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtKH = new System.Windows.Forms.TextBox();
			this.phieuGiaoHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pgh = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21();
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
			this.txtMaMH = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dtNgayGH = new System.Windows.Forms.DateTimePicker();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.maPGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NguoiGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phieuGiaoHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21TableAdapters.PhieuGiaoHangTableAdapter();
			this.ctpgh = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet22();
			this.chiTietPhieuGiaoHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.chiTietPhieuGiaoHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet22TableAdapters.ChiTietPhieuGiaoHangTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.phieuGiaoHangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pgh)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ctpgh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuGiaoHangBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKH
			// 
			this.txtKH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "TenKH", true));
			this.txtKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "TenKH", true));
			this.txtKH.Location = new System.Drawing.Point(239, 53);
			this.txtKH.Name = "txtKH";
			this.txtKH.ReadOnly = true;
			this.txtKH.Size = new System.Drawing.Size(229, 22);
			this.txtKH.TabIndex = 0;
			this.txtKH.TabStop = false;
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
			// txtMaPGH
			// 
			this.txtMaPGH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaPGH", true));
			this.txtMaPGH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaPGH", true));
			this.txtMaPGH.Location = new System.Drawing.Point(239, 27);
			this.txtMaPGH.Name = "txtMaPGH";
			this.txtMaPGH.Size = new System.Drawing.Size(229, 22);
			this.txtMaPGH.TabIndex = 1;
			// 
			// txtMaKH
			// 
			this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaKH", true));
			this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaKH", true));
			this.txtMaKH.Location = new System.Drawing.Point(658, 52);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(247, 22);
			this.txtMaKH.TabIndex = 4;
			this.txtMaKH.Leave += new System.EventHandler(this.txtMaKH_Leave);
			// 
			// txtMaNV
			// 
			this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaNV", true));
			this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaNV", true));
			this.txtMaNV.Location = new System.Drawing.Point(658, 80);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(247, 22);
			this.txtMaNV.TabIndex = 5;
			this.txtMaNV.Leave += new System.EventHandler(this.txtMaNV_Leave);
			// 
			// txtNV
			// 
			this.txtNV.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "TenNV", true));
			this.txtNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "TenNV", true));
			this.txtNV.Location = new System.Drawing.Point(239, 81);
			this.txtNV.Name = "txtNV";
			this.txtNV.ReadOnly = true;
			this.txtNV.Size = new System.Drawing.Size(229, 22);
			this.txtNV.TabIndex = 4;
			this.txtNV.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(429, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "PHIẾU GIAO HÀNG";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Khách Hàng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nhân Viên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(488, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Mã Nhân Viên";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(488, 54);
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
			this.label7.Location = new System.Drawing.Point(488, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Mã Hóa Đơn";
			// 
			// txtMaHD
			// 
			this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaHD", true));
			this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaHD", true));
			this.txtMaHD.Location = new System.Drawing.Point(658, 24);
			this.txtMaHD.Name = "txtMaHD";
			this.txtMaHD.Size = new System.Drawing.Size(247, 22);
			this.txtMaHD.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(25, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(146, 20);
			this.label8.TabIndex = 14;
			this.label8.Text = "Ngày Giao Hàng";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(485, 109);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(152, 20);
			this.label9.TabIndex = 16;
			this.label9.Text = "Người Giao Hàng";
			// 
			// txtNguoiGH
			// 
			this.txtNguoiGH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "NguoiGiao", true));
			this.txtNguoiGH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "NguoiGiao", true));
			this.txtNguoiGH.Location = new System.Drawing.Point(658, 107);
			this.txtNguoiGH.Name = "txtNguoiGH";
			this.txtNguoiGH.Size = new System.Drawing.Size(247, 22);
			this.txtNguoiGH.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMaMH);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtSoLuong);
			this.groupBox1.Controls.Add(this.label11);
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
			this.groupBox1.Size = new System.Drawing.Size(1332, 196);
			this.groupBox1.TabIndex = 62;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin";
			// 
			// txtMaMH
			// 
			this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "MaNV", true));
			this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "MaNV", true));
			this.txtMaMH.Location = new System.Drawing.Point(236, 137);
			this.txtMaMH.Name = "txtMaMH";
			this.txtMaMH.Size = new System.Drawing.Size(232, 22);
			this.txtMaMH.TabIndex = 66;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(485, 137);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 20);
			this.label10.TabIndex = 69;
			this.label10.Text = "Số lượng";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "NguoiGiao", true));
			this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "NguoiGiao", true));
			this.txtSoLuong.Location = new System.Drawing.Point(658, 135);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(247, 22);
			this.txtSoLuong.TabIndex = 67;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(25, 134);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(117, 20);
			this.label11.TabIndex = 68;
			this.label11.Text = "Mã mặt hàng";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(1173, 160);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 30);
			this.btnReset.TabIndex = 65;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(1173, 117);
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
			this.txtSearch.Location = new System.Drawing.Point(947, 120);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(220, 24);
			this.txtSearch.TabIndex = 63;
			// 
			// dtNgayGH
			// 
			this.dtNgayGH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.phieuGiaoHangBindingSource, "NgayGiao", true));
			this.dtNgayGH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuGiaoHangBindingSource, "NgayGiao", true));
			this.dtNgayGH.Location = new System.Drawing.Point(239, 109);
			this.dtNgayGH.Name = "dtNgayGH";
			this.dtNgayGH.Size = new System.Drawing.Size(229, 22);
			this.dtNgayGH.TabIndex = 2;
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btnLuu.ForeColor = System.Drawing.Color.Black;
			this.btnLuu.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.Save_as_37111;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(1113, 17);
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
			this.btnSua.Location = new System.Drawing.Point(1113, 67);
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
			this.btnXoa.Location = new System.Drawing.Point(947, 67);
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
			this.btnThem.Location = new System.Drawing.Point(947, 17);
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
			this.btnExit.Location = new System.Drawing.Point(1145, 11);
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
			this.btnMain.Location = new System.Drawing.Point(959, 11);
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
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPGHDataGridViewTextBoxColumn,
            this.MaKH,
            this.MaNV,
            this.MaHD,
            this.TenKH,
            this.TenNV,
            this.NgayGiao,
            this.NguoiGiao});
			this.dataGridView1.DataSource = this.phieuGiaoHangBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 260);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1403, 331);
			this.dataGridView1.TabIndex = 63;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// maPGHDataGridViewTextBoxColumn
			// 
			this.maPGHDataGridViewTextBoxColumn.DataPropertyName = "MaPGH";
			this.maPGHDataGridViewTextBoxColumn.HeaderText = "Mã phiếu giao hàng";
			this.maPGHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maPGHDataGridViewTextBoxColumn.Name = "maPGHDataGridViewTextBoxColumn";
			this.maPGHDataGridViewTextBoxColumn.ReadOnly = true;
			this.maPGHDataGridViewTextBoxColumn.Width = 170;
			// 
			// MaKH
			// 
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã khách hàng";
			this.MaKH.MinimumWidth = 6;
			this.MaKH.Name = "MaKH";
			this.MaKH.ReadOnly = true;
			this.MaKH.Width = 150;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.ReadOnly = true;
			this.MaNV.Width = 125;
			// 
			// MaHD
			// 
			this.MaHD.DataPropertyName = "MaHD";
			this.MaHD.HeaderText = "Mã hóa đơn";
			this.MaHD.MinimumWidth = 6;
			this.MaHD.Name = "MaHD";
			this.MaHD.ReadOnly = true;
			this.MaHD.Width = 125;
			// 
			// TenKH
			// 
			this.TenKH.DataPropertyName = "TenKH";
			this.TenKH.HeaderText = "Tên khách hàng";
			this.TenKH.MinimumWidth = 6;
			this.TenKH.Name = "TenKH";
			this.TenKH.ReadOnly = true;
			this.TenKH.Width = 125;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.ReadOnly = true;
			this.TenNV.Width = 125;
			// 
			// NgayGiao
			// 
			this.NgayGiao.DataPropertyName = "NgayGiao";
			this.NgayGiao.HeaderText = "Ngày giao";
			this.NgayGiao.MinimumWidth = 6;
			this.NgayGiao.Name = "NgayGiao";
			this.NgayGiao.ReadOnly = true;
			this.NgayGiao.Width = 125;
			// 
			// NguoiGiao
			// 
			this.NguoiGiao.DataPropertyName = "NguoiGiao";
			this.NguoiGiao.HeaderText = "Người giao";
			this.NguoiGiao.MinimumWidth = 6;
			this.NguoiGiao.Name = "NguoiGiao";
			this.NguoiGiao.ReadOnly = true;
			this.NguoiGiao.Width = 125;
			// 
			// phieuGiaoHangTableAdapter
			// 
			this.phieuGiaoHangTableAdapter.ClearBeforeFill = true;
			// 
			// ctpgh
			// 
			this.ctpgh.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet22";
			this.ctpgh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// chiTietPhieuGiaoHangBindingSource
			// 
			this.chiTietPhieuGiaoHangBindingSource.DataMember = "ChiTietPhieuGiaoHang";
			this.chiTietPhieuGiaoHangBindingSource.DataSource = this.ctpgh;
			// 
			// chiTietPhieuGiaoHangTableAdapter
			// 
			this.chiTietPhieuGiaoHangTableAdapter.ClearBeforeFill = true;
			// 
			// PHIẾU_GIAO_HÀNG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1427, 603);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "PHIẾU_GIAO_HÀNG";
			this.Text = "PHIẾU_GIAO_HÀNG";
			this.Load += new System.EventHandler(this.PHIẾU_GIAO_HÀNG_Load);
			((System.ComponentModel.ISupportInitialize)(this.phieuGiaoHangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pgh)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ctpgh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuGiaoHangBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet22 ctpgh;
        private System.Windows.Forms.BindingSource chiTietPhieuGiaoHangBindingSource;
        private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet22TableAdapters.ChiTietPhieuGiaoHangTableAdapter chiTietPhieuGiaoHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiGiao;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label11;
    }
}