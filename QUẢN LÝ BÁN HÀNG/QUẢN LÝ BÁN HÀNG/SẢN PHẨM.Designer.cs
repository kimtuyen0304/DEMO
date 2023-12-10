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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textgia = new System.Windows.Forms.TextBox();
			this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sp = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNH = new System.Windows.Forms.TextBox();
			this.tbVAT = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnxoa = new System.Windows.Forms.Button();
			this.tbHSD = new System.Windows.Forms.TextBox();
			this.btnthem = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnsua = new System.Windows.Forms.Button();
			this.tbNSX = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbTenMH = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbMMH = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tenMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaySXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hanSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.matHangTableAdapter = new QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2TableAdapters.MatHangTableAdapter();
			this.btnluu = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnExit.Location = new System.Drawing.Point(947, 29);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(160, 54);
			this.btnExit.TabIndex = 46;
			this.btnExit.Text = "Thoát chương trình";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnMain
			// 
			this.btnMain.BackColor = System.Drawing.Color.White;
			this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnMain.Location = new System.Drawing.Point(946, 100);
			this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(161, 54);
			this.btnMain.TabIndex = 45;
			this.btnMain.Text = "Về màn hình chính";
			this.btnMain.UseVisualStyleBackColor = false;
			this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 128);
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
			this.textgia.Location = new System.Drawing.Point(132, 125);
			this.textgia.Name = "textgia";
			this.textgia.Size = new System.Drawing.Size(213, 24);
			this.textgia.TabIndex = 26;
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
			this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(277, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(354, 35);
			this.label4.TabIndex = 55;
			this.label4.Text = "THÔNG TIN SẢN PHẨM";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.btnluu);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnMain);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textgia);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbNH);
			this.groupBox1.Controls.Add(this.tbVAT);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.btnxoa);
			this.groupBox1.Controls.Add(this.tbHSD);
			this.groupBox1.Controls.Add(this.btnthem);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.btnsua);
			this.groupBox1.Controls.Add(this.tbNSX);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.tbTenMH);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbMMH);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(7, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1175, 203);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chung";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 18);
			this.label3.TabIndex = 25;
			this.label3.Text = "Mã nhóm hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 169);
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
			this.tbNH.Location = new System.Drawing.Point(132, 80);
			this.tbNH.Name = "tbNH";
			this.tbNH.Size = new System.Drawing.Size(213, 24);
			this.tbNH.TabIndex = 22;
			// 
			// tbVAT
			// 
			this.tbVAT.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "VAT", true));
			this.tbVAT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "VAT", true));
			this.tbVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbVAT.Location = new System.Drawing.Point(132, 164);
			this.tbVAT.Name = "tbVAT";
			this.tbVAT.Size = new System.Drawing.Size(213, 24);
			this.tbVAT.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(387, 147);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 18);
			this.label8.TabIndex = 14;
			this.label8.Text = "Hạn sử dụng";
			// 
			// btnxoa
			// 
			this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxoa.ForeColor = System.Drawing.Color.Black;
			this.btnxoa.Location = new System.Drawing.Point(748, 83);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(176, 46);
			this.btnxoa.TabIndex = 18;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = false;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// tbHSD
			// 
			this.tbHSD.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "HanSD", true));
			this.tbHSD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "HanSD", true));
			this.tbHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbHSD.Location = new System.Drawing.Point(502, 147);
			this.tbHSD.Name = "tbHSD";
			this.tbHSD.Size = new System.Drawing.Size(213, 24);
			this.tbHSD.TabIndex = 13;
			// 
			// btnthem
			// 
			this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnthem.ForeColor = System.Drawing.Color.Black;
			this.btnthem.Location = new System.Drawing.Point(748, 27);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(176, 47);
			this.btnthem.TabIndex = 5;
			this.btnthem.Text = "Thêm ";
			this.btnthem.UseVisualStyleBackColor = false;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(387, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 18);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ngày sản xuất";
			// 
			// btnsua
			// 
			this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsua.ForeColor = System.Drawing.Color.Black;
			this.btnsua.Location = new System.Drawing.Point(748, 140);
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(176, 48);
			this.btnsua.TabIndex = 17;
			this.btnsua.Text = "Sửa";
			this.btnsua.UseVisualStyleBackColor = false;
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// tbNSX
			// 
			this.tbNSX.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.matHangBindingSource, "NgaySX", true));
			this.tbNSX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matHangBindingSource, "NgaySX", true));
			this.tbNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNSX.Location = new System.Drawing.Point(502, 102);
			this.tbNSX.Name = "tbNSX";
			this.tbNSX.Size = new System.Drawing.Size(213, 24);
			this.tbNSX.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 41);
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
			this.tbTenMH.Location = new System.Drawing.Point(132, 34);
			this.tbTenMH.Multiline = true;
			this.tbTenMH.Name = "tbTenMH";
			this.tbTenMH.Size = new System.Drawing.Size(213, 27);
			this.tbTenMH.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(387, 56);
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
			this.tbMMH.Location = new System.Drawing.Point(502, 48);
			this.tbMMH.Name = "tbMMH";
			this.tbMMH.Size = new System.Drawing.Size(213, 24);
			this.tbMMH.TabIndex = 7;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 277);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1295, 320);
			this.groupBox2.TabIndex = 54;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách mặt hàng";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenMHDataGridViewTextBoxColumn,
            this.maMHDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.ngaySXDataGridViewTextBoxColumn,
            this.hanSDDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.maNHDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.matHangBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(-5, 21);
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
			this.dataGridView1.Size = new System.Drawing.Size(1294, 193);
			this.dataGridView1.TabIndex = 0;
			// 
			// tenMHDataGridViewTextBoxColumn
			// 
			this.tenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH";
			this.tenMHDataGridViewTextBoxColumn.HeaderText = "TenMH";
			this.tenMHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tenMHDataGridViewTextBoxColumn.Name = "tenMHDataGridViewTextBoxColumn";
			this.tenMHDataGridViewTextBoxColumn.Width = 125;
			// 
			// maMHDataGridViewTextBoxColumn
			// 
			this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
			this.maMHDataGridViewTextBoxColumn.HeaderText = "MaMH";
			this.maMHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
			this.maMHDataGridViewTextBoxColumn.Width = 125;
			// 
			// giaDataGridViewTextBoxColumn
			// 
			this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
			this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
			this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
			this.giaDataGridViewTextBoxColumn.Width = 125;
			// 
			// ngaySXDataGridViewTextBoxColumn
			// 
			this.ngaySXDataGridViewTextBoxColumn.DataPropertyName = "NgaySX";
			this.ngaySXDataGridViewTextBoxColumn.HeaderText = "NgaySX";
			this.ngaySXDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngaySXDataGridViewTextBoxColumn.Name = "ngaySXDataGridViewTextBoxColumn";
			this.ngaySXDataGridViewTextBoxColumn.Width = 125;
			// 
			// hanSDDataGridViewTextBoxColumn
			// 
			this.hanSDDataGridViewTextBoxColumn.DataPropertyName = "HanSD";
			this.hanSDDataGridViewTextBoxColumn.HeaderText = "HanSD";
			this.hanSDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.hanSDDataGridViewTextBoxColumn.Name = "hanSDDataGridViewTextBoxColumn";
			this.hanSDDataGridViewTextBoxColumn.Width = 125;
			// 
			// vATDataGridViewTextBoxColumn
			// 
			this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
			this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
			this.vATDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
			this.vATDataGridViewTextBoxColumn.Width = 125;
			// 
			// maNHDataGridViewTextBoxColumn
			// 
			this.maNHDataGridViewTextBoxColumn.DataPropertyName = "MaNH";
			this.maNHDataGridViewTextBoxColumn.HeaderText = "MaNH";
			this.maNHDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maNHDataGridViewTextBoxColumn.Name = "maNHDataGridViewTextBoxColumn";
			this.maNHDataGridViewTextBoxColumn.Width = 125;
			// 
			// matHangTableAdapter
			// 
			this.matHangTableAdapter.ClearBeforeFill = true;
			// 
			// btnluu
			// 
			this.btnluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnluu.ForeColor = System.Drawing.Color.Black;
			this.btnluu.Location = new System.Drawing.Point(946, 152);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(176, 48);
			this.btnluu.TabIndex = 47;
			this.btnluu.Text = "Lưu";
			this.btnluu.UseVisualStyleBackColor = false;
			this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
			// 
			// SẢN_PHẨM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1319, 715);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "SẢN_PHẨM";
			this.Text = "SẢN_PHẨM";
			this.Load += new System.EventHandler(this.SẢN_PHẨM_Load);
			((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sp)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textgia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNH;
		private System.Windows.Forms.TextBox tbVAT;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnxoa;
		private System.Windows.Forms.TextBox tbHSD;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnsua;
		private System.Windows.Forms.TextBox tbNSX;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbTenMH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbMMH;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2 sp;
		private System.Windows.Forms.BindingSource matHangBindingSource;
		private _8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2TableAdapters.MatHangTableAdapter matHangTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaySXDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hanSDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maNHDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnluu;
	}
}