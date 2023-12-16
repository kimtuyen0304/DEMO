namespace QUẢN_LÝ_BÁN_HÀNG
{
	partial class PHIẾU_THU
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuTienKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtChungTu = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.textpt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.textmkh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.textmhd = new System.Windows.Forms.TextBox();
            this.texttien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textmnv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textmpt = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.thuTienKhachHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet3TableAdapters.ThuTienKhachHangTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuTienKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1370, 287);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.maPTDataGridViewTextBoxColumn,
            this.maHDDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.sotienDataGridViewTextBoxColumn,
            this.ngaythuDataGridViewTextBoxColumn,
            this.pTTTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thuTienKhachHangBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1364, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // maPTDataGridViewTextBoxColumn
            // 
            this.maPTDataGridViewTextBoxColumn.DataPropertyName = "MaPT";
            this.maPTDataGridViewTextBoxColumn.HeaderText = "Mã phiếu thu";
            this.maPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPTDataGridViewTextBoxColumn.Name = "maPTDataGridViewTextBoxColumn";
            this.maPTDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.Width = 140;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sotienDataGridViewTextBoxColumn
            // 
            this.sotienDataGridViewTextBoxColumn.DataPropertyName = "Sotien";
            this.sotienDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.sotienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sotienDataGridViewTextBoxColumn.Name = "sotienDataGridViewTextBoxColumn";
            this.sotienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaythuDataGridViewTextBoxColumn
            // 
            this.ngaythuDataGridViewTextBoxColumn.DataPropertyName = "Ngaythu";
            this.ngaythuDataGridViewTextBoxColumn.HeaderText = "Ngày thu";
            this.ngaythuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaythuDataGridViewTextBoxColumn.Name = "ngaythuDataGridViewTextBoxColumn";
            this.ngaythuDataGridViewTextBoxColumn.Width = 125;
            // 
            // pTTTDataGridViewTextBoxColumn
            // 
            this.pTTTDataGridViewTextBoxColumn.DataPropertyName = "PTTT";
            this.pTTTDataGridViewTextBoxColumn.HeaderText = "Phương thức thanh toán";
            this.pTTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pTTTDataGridViewTextBoxColumn.Name = "pTTTDataGridViewTextBoxColumn";
            this.pTTTDataGridViewTextBoxColumn.Width = 200;
            // 
            // thuTienKhachHangBindingSource
            // 
            this.thuTienKhachHangBindingSource.DataMember = "ThuTienKhachHang";
            this.thuTienKhachHangBindingSource.DataSource = this.pt;
            // 
            // pt
            // 
            this.pt.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet3";
            this.pt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtChungTu);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnxem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.textpt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.textmkh);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.textmhd);
            this.groupBox1.Controls.Add(this.texttien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textmnv);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textmpt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1360, 236);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHUNG";
            // 
            // dtChungTu
            // 
            this.dtChungTu.Location = new System.Drawing.Point(126, 184);
            this.dtChungTu.Name = "dtChungTu";
            this.dtChungTu.Size = new System.Drawing.Size(228, 24);
            this.dtChungTu.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(778, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(672, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(466, 184);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 24);
            this.txtSearch.TabIndex = 65;
            // 
            // btnxem
            // 
            this.btnxem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnxem.ForeColor = System.Drawing.Color.Black;
            this.btnxem.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.actions_document_print_preview_15786;
            this.btnxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxem.Location = new System.Drawing.Point(1095, 50);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(160, 47);
            this.btnxem.TabIndex = 64;
            this.btnxem.Text = "Xem Trước";
            this.btnxem.UseVisualStyleBackColor = false;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.Save_as_37111;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1095, 101);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 47);
            this.btnLuu.TabIndex = 63;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // textpt
            // 
            this.textpt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.thuTienKhachHangBindingSource, "PTTT", true));
            this.textpt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuTienKhachHangBindingSource, "PTTT", true));
            this.textpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpt.Location = new System.Drawing.Point(599, 128);
            this.textpt.Name = "textpt";
            this.textpt.Size = new System.Drawing.Size(279, 24);
            this.textpt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Phương thức TT";
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.delete_file_40456;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(929, 100);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(160, 47);
            this.btnxoa.TabIndex = 48;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Mã phiếu thu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(468, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "Mã khách hàng";
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources._62914memo_109205;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(929, 150);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(160, 47);
            this.btnsua.TabIndex = 47;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // textmkh
            // 
            this.textmkh.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.thuTienKhachHangBindingSource, "MaKH", true));
            this.textmkh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuTienKhachHangBindingSource, "MaKH", true));
            this.textmkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmkh.Location = new System.Drawing.Point(599, 41);
            this.textmkh.Name = "textmkh";
            this.textmkh.Size = new System.Drawing.Size(279, 24);
            this.textmkh.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ngày chứng từ";
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.document_add_256_icon_icons_com_75994;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(929, 50);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(160, 47);
            this.btnthem.TabIndex = 46;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // textmhd
            // 
            this.textmhd.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.thuTienKhachHangBindingSource, "MaHD", true));
            this.textmhd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuTienKhachHangBindingSource, "MaHD", true));
            this.textmhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmhd.Location = new System.Drawing.Point(126, 88);
            this.textmhd.Name = "textmhd";
            this.textmhd.Size = new System.Drawing.Size(228, 24);
            this.textmhd.TabIndex = 2;
            // 
            // texttien
            // 
            this.texttien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuTienKhachHangBindingSource, "Sotien", true));
            this.texttien.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.thuTienKhachHangBindingSource, "Sotien", true));
            this.texttien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttien.Location = new System.Drawing.Point(599, 84);
            this.texttien.Name = "texttien";
            this.texttien.Size = new System.Drawing.Size(279, 24);
            this.texttien.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mã nhân viên";
            // 
            // textmnv
            // 
            this.textmnv.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.thuTienKhachHangBindingSource, "MaNV", true));
            this.textmnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuTienKhachHangBindingSource, "MaNV", true));
            this.textmnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmnv.Location = new System.Drawing.Point(126, 134);
            this.textmnv.Name = "textmnv";
            this.textmnv.Size = new System.Drawing.Size(228, 24);
            this.textmnv.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mã hóa Đơn";
            // 
            // textmpt
            // 
            this.textmpt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.thuTienKhachHangBindingSource, "MaPT", true));
            this.textmpt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuTienKhachHangBindingSource, "MaPT", true));
            this.textmpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmpt.Location = new System.Drawing.Point(126, 42);
            this.textmpt.Name = "textmpt";
            this.textmpt.Size = new System.Drawing.Size(228, 24);
            this.textmpt.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.log_out_icon_icons_com_50106;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1081, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 47);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.White;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMain.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources._3643769_building_home_house_main_menu_start_113416;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(888, 12);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(160, 47);
            this.btnMain.TabIndex = 65;
            this.btnMain.Text = "Trang chủ";
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // thuTienKhachHangTableAdapter
            // 
            this.thuTienKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 35);
            this.label2.TabIndex = 67;
            this.label2.Text = "THÔNG TIN PHIẾU THU";
            // 
            // PHIẾU_THU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PHIẾU_THU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PHIẾU_THU";
            this.Load += new System.EventHandler(this.PHIẾU_THU_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuTienKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textpt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.TextBox textmkh;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.TextBox textmhd;
		private System.Windows.Forms.TextBox texttien;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textmnv;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textmpt;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet3 pt;
		private System.Windows.Forms.BindingSource thuTienKhachHangBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet3TableAdapters.ThuTienKhachHangTableAdapter thuTienKhachHangTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnxem;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtChungTu;
    }
}