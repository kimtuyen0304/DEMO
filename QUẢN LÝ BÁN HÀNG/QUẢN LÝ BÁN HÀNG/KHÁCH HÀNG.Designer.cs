namespace QUẢN_LÝ_BÁN_HÀNG
{
	partial class KHÁCH_HÀNG
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtgc = new System.Windows.Forms.TextBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachhang = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1TableAdapters.KhachHangTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 32);
            this.label2.TabIndex = 51;
            this.label2.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtgc);
            this.groupBox1.Controls.Add(this.txtgt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtkh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 151);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHUNG";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(875, 116);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(769, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(583, 119);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 24);
            this.txtSearch.TabIndex = 54;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.Save_as_37111;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(934, 65);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 47);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtgc
            // 
            this.txtgc.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.khachHangBindingSource, "Ghichu", true));
            this.txtgc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Ghichu", true));
            this.txtgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgc.Location = new System.Drawing.Point(519, 89);
            this.txtgc.Name = "txtgc";
            this.txtgc.Size = new System.Drawing.Size(240, 24);
            this.txtgc.TabIndex = 9;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.khachhang;
            // 
            // khachhang
            // 
            this.khachhang.DataSetName = "_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1";
            this.khachhang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtgt
            // 
            this.txtgt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.khachHangBindingSource, "Gioitinh", true));
            this.txtgt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Gioitinh", true));
            this.txtgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgt.Location = new System.Drawing.Point(519, 53);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(240, 24);
            this.txtgt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Giới tính";
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348__1_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(768, 65);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(160, 47);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(933, 12);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(160, 47);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(767, 10);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(160, 47);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "SĐT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 35;
            // 
            // txtsdt
            // 
            this.txtsdt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.khachHangBindingSource, "SDT", true));
            this.txtsdt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SDT", true));
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(183, 83);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(240, 24);
            this.txtsdt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.khachHangBindingSource, "Diachi", true));
            this.txtdiachi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "Diachi", true));
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(183, 53);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(240, 24);
            this.txtdiachi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên";
            // 
            // txtten
            // 
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.khachHangBindingSource, "TenKH", true));
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TenKH", true));
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(519, 12);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(240, 24);
            this.txtten.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtkh
            // 
            this.txtkh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "MaKH", true));
            this.txtkh.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.khachHangBindingSource, "MaKH", true));
            this.txtkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkh.Location = new System.Drawing.Point(183, 17);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(240, 24);
            this.txtkh.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.log_out_icon_icons_com_50106;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(947, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 47);
            this.btnExit.TabIndex = 64;
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
            this.btnMain.Location = new System.Drawing.Point(781, 9);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(160, 47);
            this.btnMain.TabIndex = 63;
            this.btnMain.Text = "Trang chủ";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 375);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết danh mục khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachHangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 335);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tenKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKHDataGridViewTextBoxColumn.Width = 200;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            this.gioitinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioitinhDataGridViewTextBoxColumn.Width = 125;
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
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // KHÁCH_HÀNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 597);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KHÁCH_HÀNG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KHÁCH HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KHÁCH_HÀNG_FormClosing);
            this.Load += new System.EventHandler(this.KHÁCH_HÀNG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtsdt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtdiachi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtten;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtkh;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1 khachhang;
		private System.Windows.Forms.BindingSource khachHangBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
		private System.Windows.Forms.TextBox txtgc;
		private System.Windows.Forms.TextBox txtgt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
    }
}