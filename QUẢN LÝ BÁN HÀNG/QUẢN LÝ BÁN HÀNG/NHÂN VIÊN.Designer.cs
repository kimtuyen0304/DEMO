namespace QUẢN_LÝ_BÁN_HÀNG
{
	partial class NHÂN_VIÊN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHÂN_VIÊN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dlnv = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtnvl = new System.Windows.Forms.DateTimePicker();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmcv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaolamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSetTableAdapters.NhanVienTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlnv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtnvl);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmcv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtpb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmnv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 225);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHUNG";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1048, 148);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(942, 148);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nhanVienBindingSource, "MaNV", true));
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNV", true));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(756, 151);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 24);
            this.txtSearch.TabIndex = 37;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dlnv;
            // 
            // dlnv
            // 
            this.dlnv.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet";
            this.dlnv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.Save_as_37111;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(955, 32);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(176, 53);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtnvl
            // 
            this.txtnvl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nhanVienBindingSource, "Ngayvaolam", true));
            this.txtnvl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Ngayvaolam", true));
            this.txtnvl.Location = new System.Drawing.Point(161, 146);
            this.txtnvl.Name = "txtnvl";
            this.txtnvl.Size = new System.Drawing.Size(200, 24);
            this.txtnvl.TabIndex = 10;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348__1_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(756, 91);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(176, 53);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(955, 90);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(176, 53);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(755, 32);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(176, 53);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "SĐT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 35;
            // 
            // txtsdt
            // 
            this.txtsdt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nhanVienBindingSource, "SDT", true));
            this.txtsdt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "SDT", true));
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(492, 104);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(240, 24);
            this.txtsdt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ngày vào làm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã công việc";
            // 
            // txtmcv
            // 
            this.txtmcv.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nhanVienBindingSource, "MaCV", true));
            this.txtmcv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaCV", true));
            this.txtmcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmcv.Location = new System.Drawing.Point(492, 148);
            this.txtmcv.Name = "txtmcv";
            this.txtmcv.Size = new System.Drawing.Size(240, 24);
            this.txtmcv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mã phòng ban";
            // 
            // txtpb
            // 
            this.txtpb.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nhanVienBindingSource, "MaPB", true));
            this.txtpb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaPB", true));
            this.txtpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpb.Location = new System.Drawing.Point(161, 99);
            this.txtpb.Name = "txtpb";
            this.txtpb.Size = new System.Drawing.Size(240, 24);
            this.txtpb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên";
            // 
            // txtten
            // 
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nhanVienBindingSource, "TenNV", true));
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNV", true));
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(492, 51);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(240, 24);
            this.txtten.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtmnv
            // 
            this.txtmnv.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nhanVienBindingSource, "MaNV", true));
            this.txtmnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNV", true));
            this.txtmnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmnv.Location = new System.Drawing.Point(161, 49);
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(240, 24);
            this.txtmnv.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.log_out_icon_icons_com_50106;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1060, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 53);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.White;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMain.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources._3643769_building_home_house_main_menu_start_113416;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(878, 4);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(176, 53);
            this.btnMain.TabIndex = 63;
            this.btnMain.Text = "Trang chủ";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 35);
            this.label2.TabIndex = 50;
            this.label2.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 305);
            this.panel1.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.maPBDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn,
            this.ngayvaolamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 302);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "MaCV";
            this.maCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            this.maCVDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayvaolamDataGridViewTextBoxColumn
            // 
            this.ngayvaolamDataGridViewTextBoxColumn.DataPropertyName = "Ngayvaolam";
            this.ngayvaolamDataGridViewTextBoxColumn.HeaderText = "Ngayvaolam";
            this.ngayvaolamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayvaolamDataGridViewTextBoxColumn.Name = "ngayvaolamDataGridViewTextBoxColumn";
            this.ngayvaolamDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // NHÂN_VIÊN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 597);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NHÂN_VIÊN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHÂN_VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NHÂN_VIÊN_FormClosing);
            this.Load += new System.EventHandler(this.NHÂN_VIÊN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlnv)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker txtnvl;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtsdt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtmcv;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtpb;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtten;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtmnv;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet dlnv;
		private System.Windows.Forms.BindingSource nhanVienBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaolamDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReset;
    }
}