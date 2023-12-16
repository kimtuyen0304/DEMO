namespace QUẢN_LÝ_BÁN_HÀNG
{
	partial class SẢN_PHẨM
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.textgia = new System.Windows.Forms.TextBox();
			this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sp = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbGhiChu = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbTenNH = new System.Windows.Forms.TextBox();
			this.dtHSD = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.dtNSX = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNH = new System.Windows.Forms.TextBox();
			this.tbVAT = new System.Windows.Forms.TextBox();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btnthem = new System.Windows.Forms.Button();
			this.btnsua = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tbTenMH = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbMMH = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtgData2 = new System.Windows.Forms.DataGridView();
			this.maNHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nhomHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nhomHang = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet6();
			this.dtgData1 = new System.Windows.Forms.DataGridView();
			this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaySXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hanSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nhomHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet6TableAdapters.NhomHangTableAdapter();
			this.matHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2TableAdapters.MatHangTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgData2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhomHangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nhomHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgData1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(547, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 18);
			this.label1.TabIndex = 27;
			this.label1.Text = "Giá";
			// 
			// textgia
			// 
			this.textgia.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "Gia", true));
			this.textgia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "Gia", true));
			this.textgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textgia.Location = new System.Drawing.Point(668, 28);
			this.textgia.Name = "textgia";
			this.textgia.Size = new System.Drawing.Size(213, 24);
			this.textgia.TabIndex = 8;
			// 
			// matHangBindingSource
			// 
			this.matHangBindingSource.DataMember = "MatHang";
			this.matHangBindingSource.DataSource = this.sp;
			// 
			// sp
			// 
			this.sp.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2";
			this.sp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(352, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(354, 35);
			this.label4.TabIndex = 55;
			this.label4.Text = "THÔNG TIN SẢN PHẨM";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.tbGhiChu);
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.tbTenNH);
			this.groupBox1.Controls.Add(this.dtHSD);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.dtNSX);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textgia);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbNH);
			this.groupBox1.Controls.Add(this.tbVAT);
			this.groupBox1.Controls.Add(this.btnxoa);
			this.groupBox1.Controls.Add(this.btnthem);
			this.groupBox1.Controls.Add(this.btnsua);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.tbTenMH);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbMMH);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(7, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1182, 214);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chung";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(25, 165);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 30);
			this.btnReset.TabIndex = 65;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(547, 171);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 18);
			this.label8.TabIndex = 34;
			this.label8.Text = "Ghi chú";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(131, 165);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 30);
			this.btnSearch.TabIndex = 64;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbGhiChu
			// 
			this.tbGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "MaNH", true));
			this.tbGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "MaNH", true));
			this.tbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGhiChu.Location = new System.Drawing.Point(668, 168);
			this.tbGhiChu.Name = "tbGhiChu";
			this.tbGhiChu.Size = new System.Drawing.Size(213, 24);
			this.tbGhiChu.TabIndex = 33;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(254, 171);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(213, 24);
			this.txtSearch.TabIndex = 63;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(543, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 18);
			this.label7.TabIndex = 32;
			this.label7.Text = "Tên nhóm hàng";
			// 
			// tbTenNH
			// 
			this.tbTenNH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "MaNH", true));
			this.tbTenNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "MaNH", true));
			this.tbTenNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTenNH.Location = new System.Drawing.Point(668, 133);
			this.tbTenNH.Name = "tbTenNH";
			this.tbTenNH.Size = new System.Drawing.Size(213, 24);
			this.tbTenNH.TabIndex = 31;
			// 
			// dtHSD
			// 
			this.dtHSD.Location = new System.Drawing.Point(254, 138);
			this.dtHSD.Name = "dtHSD";
			this.dtHSD.Size = new System.Drawing.Size(213, 24);
			this.dtHSD.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(133, 142);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 18);
			this.label10.TabIndex = 30;
			this.label10.Text = "Hạn sử dụng";
			// 
			// dtNSX
			// 
			this.dtNSX.Location = new System.Drawing.Point(254, 103);
			this.dtNSX.Name = "dtNSX";
			this.dtNSX.Size = new System.Drawing.Size(213, 24);
			this.dtNSX.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(133, 107);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 18);
			this.label9.TabIndex = 28;
			this.label9.Text = "Ngày sản xuất";
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnLuu.ForeColor = System.Drawing.Color.Black;
			this.btnLuu.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.Save_as_37111;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(1018, 161);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(160, 47);
			this.btnLuu.TabIndex = 11;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(547, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 18);
			this.label3.TabIndex = 25;
			this.label3.Text = "Mã nhóm hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(547, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 18);
			this.label2.TabIndex = 24;
			this.label2.Text = "VAT";
			// 
			// tbNH
			// 
			this.tbNH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "MaNH", true));
			this.tbNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "MaNH", true));
			this.tbNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNH.Location = new System.Drawing.Point(668, 98);
			this.tbNH.Name = "tbNH";
			this.tbNH.Size = new System.Drawing.Size(213, 24);
			this.tbNH.TabIndex = 10;
			// 
			// tbVAT
			// 
			this.tbVAT.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "VAT", true));
			this.tbVAT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "VAT", true));
			this.tbVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbVAT.Location = new System.Drawing.Point(668, 63);
			this.tbVAT.Name = "tbVAT";
			this.tbVAT.Size = new System.Drawing.Size(213, 24);
			this.tbVAT.TabIndex = 9;
			// 
			// btnxoa
			// 
			this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxoa.ForeColor = System.Drawing.Color.Black;
			this.btnxoa.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.remove_item_25316;
			this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnxoa.Location = new System.Drawing.Point(1019, 60);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(160, 47);
			this.btnxoa.TabIndex = 2;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = false;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btnthem
			// 
			this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthem.ForeColor = System.Drawing.Color.Black;
			this.btnthem.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.add_item_25362;
			this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnthem.Location = new System.Drawing.Point(1019, 11);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(160, 47);
			this.btnthem.TabIndex = 1;
			this.btnthem.Text = "Thêm ";
			this.btnthem.UseVisualStyleBackColor = false;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// btnsua
			// 
			this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsua.ForeColor = System.Drawing.Color.Black;
			this.btnsua.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources._62914memo_109205;
			this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsua.Location = new System.Drawing.Point(1018, 112);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(160, 47);
			this.btnsua.TabIndex = 3;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = false;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(133, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Tên mặt hàng";
			// 
			// tbTenMH
			// 
			this.tbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "TenMH", true));
			this.tbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "TenMH", true));
			this.tbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTenMH.Location = new System.Drawing.Point(254, 65);
			this.tbTenMH.Multiline = true;
			this.tbTenMH.Name = "tbTenMH";
			this.tbTenMH.Size = new System.Drawing.Size(213, 27);
			this.tbTenMH.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(139, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Mã mặt hàng";
			// 
			// tbMMH
			// 
			this.tbMMH.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "MaMH", true));
			this.tbMMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "MaMH", true));
			this.tbMMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMMH.Location = new System.Drawing.Point(254, 30);
			this.tbMMH.Name = "tbMMH";
			this.tbMMH.Size = new System.Drawing.Size(213, 24);
			this.tbMMH.TabIndex = 4;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnExit.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.log_out_icon_icons_com_50106;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(1029, 8);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(160, 47);
			this.btnExit.TabIndex = 62;
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
			this.btnMain.Location = new System.Drawing.Point(863, 9);
			this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(160, 47);
			this.btnMain.TabIndex = 61;
			this.btnMain.Text = "Trang chủ";
			this.btnMain.UseVisualStyleBackColor = false;
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtgData2);
			this.groupBox2.Controls.Add(this.dtgData1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.groupBox2.Location = new System.Drawing.Point(12, 277);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1177, 319);
			this.groupBox2.TabIndex = 54;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách mặt hàng";
			// 
			// dtgData2
			// 
			this.dtgData2.AllowUserToAddRows = false;
			this.dtgData2.AllowUserToDeleteRows = false;
			this.dtgData2.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgData2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgData2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNHDataGridViewTextBoxColumn1,
            this.tenNHDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
			this.dtgData2.DataSource = this.nhomHangBindingSource;
			this.dtgData2.Location = new System.Drawing.Point(716, 21);
			this.dtgData2.MultiSelect = false;
			this.dtgData2.Name = "dtgData2";
			this.dtgData2.ReadOnly = true;
			this.dtgData2.RowHeadersWidth = 51;
			this.dtgData2.RowTemplate.Height = 24;
			this.dtgData2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgData2.Size = new System.Drawing.Size(455, 287);
			this.dtgData2.TabIndex = 13;
			// 
			// maNHDataGridViewTextBoxColumn1
			// 
			this.maNHDataGridViewTextBoxColumn1.DataPropertyName = "MaNH";
			this.maNHDataGridViewTextBoxColumn1.HeaderText = "Mã nhóm hàng";
			this.maNHDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.maNHDataGridViewTextBoxColumn1.Name = "maNHDataGridViewTextBoxColumn1";
			this.maNHDataGridViewTextBoxColumn1.ReadOnly = true;
			this.maNHDataGridViewTextBoxColumn1.Width = 150;
			// 
			// tenNHDataGridViewTextBoxColumn
			// 
			this.tenNHDataGridViewTextBoxColumn.DataPropertyName = "TenNH";
			this.tenNHDataGridViewTextBoxColumn.HeaderText = "Tên nhóm hàng";
			this.tenNHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tenNHDataGridViewTextBoxColumn.Name = "tenNHDataGridViewTextBoxColumn";
			this.tenNHDataGridViewTextBoxColumn.ReadOnly = true;
			this.tenNHDataGridViewTextBoxColumn.Width = 200;
			// 
			// ghichuDataGridViewTextBoxColumn
			// 
			this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
			this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
			this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
			this.ghichuDataGridViewTextBoxColumn.ReadOnly = true;
			this.ghichuDataGridViewTextBoxColumn.Width = 125;
			// 
			// nhomHangBindingSource
			// 
			this.nhomHangBindingSource.DataMember = "NhomHang";
			this.nhomHangBindingSource.DataSource = this.nhomHang;
			// 
			// nhomHang
			// 
			this.nhomHang.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet6";
			this.nhomHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dtgData1
			// 
			this.dtgData1.AllowUserToAddRows = false;
			this.dtgData1.AllowUserToDeleteRows = false;
			this.dtgData1.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgData1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgData1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMHDataGridViewTextBoxColumn,
            this.maNHDataGridViewTextBoxColumn,
            this.tenMHDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.ngaySXDataGridViewTextBoxColumn,
            this.hanSDDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn});
			this.dtgData1.DataSource = this.matHangBindingSource;
			this.dtgData1.Location = new System.Drawing.Point(6, 21);
			this.dtgData1.Name = "dtgData1";
			this.dtgData1.ReadOnly = true;
			this.dtgData1.RowHeadersWidth = 51;
			this.dtgData1.RowTemplate.Height = 24;
			this.dtgData1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgData1.Size = new System.Drawing.Size(704, 287);
			this.dtgData1.TabIndex = 12;
			this.dtgData1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// maMHDataGridViewTextBoxColumn
			// 
			this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
			this.maMHDataGridViewTextBoxColumn.HeaderText = "Mã mặt hàng";
			this.maMHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
			this.maMHDataGridViewTextBoxColumn.ReadOnly = true;
			this.maMHDataGridViewTextBoxColumn.Width = 125;
			// 
			// maNHDataGridViewTextBoxColumn
			// 
			this.maNHDataGridViewTextBoxColumn.DataPropertyName = "MaNH";
			this.maNHDataGridViewTextBoxColumn.HeaderText = "Mã nhóm hàng";
			this.maNHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maNHDataGridViewTextBoxColumn.Name = "maNHDataGridViewTextBoxColumn";
			this.maNHDataGridViewTextBoxColumn.ReadOnly = true;
			this.maNHDataGridViewTextBoxColumn.Width = 150;
			// 
			// tenMHDataGridViewTextBoxColumn
			// 
			this.tenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH";
			this.tenMHDataGridViewTextBoxColumn.HeaderText = "Tên mặt hàng";
			this.tenMHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tenMHDataGridViewTextBoxColumn.Name = "tenMHDataGridViewTextBoxColumn";
			this.tenMHDataGridViewTextBoxColumn.ReadOnly = true;
			this.tenMHDataGridViewTextBoxColumn.Width = 200;
			// 
			// giaDataGridViewTextBoxColumn
			// 
			this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
			this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
			this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
			this.giaDataGridViewTextBoxColumn.ReadOnly = true;
			this.giaDataGridViewTextBoxColumn.Width = 125;
			// 
			// ngaySXDataGridViewTextBoxColumn
			// 
			this.ngaySXDataGridViewTextBoxColumn.DataPropertyName = "NgaySX";
			this.ngaySXDataGridViewTextBoxColumn.HeaderText = "Ngày sản xuất";
			this.ngaySXDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngaySXDataGridViewTextBoxColumn.Name = "ngaySXDataGridViewTextBoxColumn";
			this.ngaySXDataGridViewTextBoxColumn.ReadOnly = true;
			this.ngaySXDataGridViewTextBoxColumn.Width = 150;
			// 
			// hanSDDataGridViewTextBoxColumn
			// 
			this.hanSDDataGridViewTextBoxColumn.DataPropertyName = "HanSD";
			this.hanSDDataGridViewTextBoxColumn.HeaderText = "Hạn sử dụng";
			this.hanSDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.hanSDDataGridViewTextBoxColumn.Name = "hanSDDataGridViewTextBoxColumn";
			this.hanSDDataGridViewTextBoxColumn.ReadOnly = true;
			this.hanSDDataGridViewTextBoxColumn.Width = 125;
			// 
			// vATDataGridViewTextBoxColumn
			// 
			this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
			this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
			this.vATDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
			this.vATDataGridViewTextBoxColumn.ReadOnly = true;
			this.vATDataGridViewTextBoxColumn.Width = 125;
			// 
			// nhomHangTableAdapter
			// 
			this.nhomHangTableAdapter.ClearBeforeFill = true;
			// 
			// matHangTableAdapter
			// 
			this.matHangTableAdapter.ClearBeforeFill = true;
			// 
			// SẢN_PHẨM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 597);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SẢN_PHẨM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SẢN PHẨM";
			this.Load += new System.EventHandler(this.SẢN_PHẨM_Load);
			((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sp)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgData2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhomHangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nhomHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgData1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textgia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNH;
		private System.Windows.Forms.TextBox tbVAT;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbTenMH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbMMH;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dtgData1;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2 sp;
		private System.Windows.Forms.BindingSource matHangBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2TableAdapters.MatHangTableAdapter matHangTableAdapter;
		private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtHSD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTenNH;
		private System.Windows.Forms.DataGridView dtgData2;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet6 nhomHang;
		private System.Windows.Forms.BindingSource nhomHangBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet6TableAdapters.NhomHangTableAdapter nhomHangTableAdapter;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
    }
}