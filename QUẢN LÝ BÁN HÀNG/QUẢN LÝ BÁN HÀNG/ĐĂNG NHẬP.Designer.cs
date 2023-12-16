namespace QUẢN_LÝ_BÁN_HÀNG
{
	partial class dangnhap
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tentk = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btndangnhap = new System.Windows.Forms.Button();
			this.txtmk = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.USER;
			this.pictureBox2.Location = new System.Drawing.Point(411, 168);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(49, 40);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 55;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.KHÓA;
			this.pictureBox1.Location = new System.Drawing.Point(411, 241);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 54;
			this.pictureBox1.TabStop = false;
			// 
			// tentk
			// 
			this.tentk.BackColor = System.Drawing.SystemColors.Info;
			this.tentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tentk.Location = new System.Drawing.Point(491, 168);
			this.tentk.Name = "tentk";
			this.tentk.Size = new System.Drawing.Size(280, 40);
			this.tentk.TabIndex = 48;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(461, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 45);
			this.label1.TabIndex = 53;
			this.label1.Text = "ĐĂNG NHẬP";
			// 
			// btndangnhap
			// 
			this.btndangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndangnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btndangnhap.Location = new System.Drawing.Point(491, 324);
			this.btndangnhap.Name = "btndangnhap";
			this.btndangnhap.Size = new System.Drawing.Size(219, 84);
			this.btndangnhap.TabIndex = 50;
			this.btndangnhap.Text = "ĐĂNG NHẬP";
			this.btndangnhap.UseVisualStyleBackColor = false;
			this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
			// 
			// txtmk
			// 
			this.txtmk.BackColor = System.Drawing.SystemColors.Info;
			this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmk.Location = new System.Drawing.Point(491, 241);
			this.txtmk.Name = "txtmk";
			this.txtmk.PasswordChar = '●';
			this.txtmk.Size = new System.Drawing.Size(280, 40);
			this.txtmk.TabIndex = 49;
			// 
			// dangnhap
			// 
			this.AcceptButton = this.btndangnhap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::QUẢN_LÝ_BÁN_HÀNG.Properties.Resources.bk;
			this.ClientSize = new System.Drawing.Size(1150, 543);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tentk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btndangnhap);
			this.Controls.Add(this.txtmk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "dangnhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tentk;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btndangnhap;
		private System.Windows.Forms.TextBox txtmk;
	}
}

