namespace Lab4_SV
{
	partial class ThongTinForm
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
			this.menuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemReload = new System.Windows.Forms.ToolStripMenuItem();
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mktbSDT = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mktbMSSV = new System.Windows.Forms.MaskedTextBox();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.openfiledlgPicture = new System.Windows.Forms.OpenFileDialog();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnMacDinh = new System.Windows.Forms.Button();
			this.btnChon = new System.Windows.Forms.Button();
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.rbNam = new System.Windows.Forms.RadioButton();
			this.txtHinh = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDelete,
            this.menuItemReload});
			this.menuStrip1.Name = "contextMenuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(162, 48);
			// 
			// menuItemDelete
			// 
			this.menuItemDelete.Name = "menuItemDelete";
			this.menuItemDelete.Size = new System.Drawing.Size(161, 22);
			this.menuItemDelete.Text = "Xóa";
			this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
			// 
			// menuItemReload
			// 
			this.menuItemReload.Name = "menuItemReload";
			this.menuItemReload.Size = new System.Drawing.Size(161, 22);
			this.menuItemReload.Text = "Tải lại danh sách";
			this.menuItemReload.Click += new System.EventHandler(this.menuItemReload_Click);
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Địa chỉ";
			this.columnHeader8.Width = 246;
			// 
			// mktbSDT
			// 
			this.mktbSDT.Location = new System.Drawing.Point(594, 123);
			this.mktbSDT.Mask = "0000.000.000";
			this.mktbSDT.Name = "mktbSDT";
			this.mktbSDT.Size = new System.Drawing.Size(256, 26);
			this.mktbSDT.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(487, 129);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 19);
			this.label9.TabIndex = 0;
			this.label9.Text = "Số điện thoại";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(488, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 19);
			this.label8.TabIndex = 0;
			this.label8.Text = "Lớp";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Email";
			this.columnHeader7.Width = 160;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Số điện thoại";
			this.columnHeader6.Width = 110;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Lớp";
			this.columnHeader5.Width = 72;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(487, 65);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 19);
			this.label7.TabIndex = 0;
			this.label7.Text = "Phái";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(487, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ngày sinh";
			// 
			// mktbMSSV
			// 
			this.mktbMSSV.Location = new System.Drawing.Point(127, 26);
			this.mktbMSSV.Mask = "0000000";
			this.mktbMSSV.Name = "mktbMSSV";
			this.mktbMSSV.Size = new System.Drawing.Size(320, 26);
			this.mktbMSSV.TabIndex = 0;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Hình";
			this.columnHeader9.Width = 97;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày sinh";
			this.columnHeader4.Width = 101;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ và tên";
			this.columnHeader2.Width = 156;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Phái";
			this.columnHeader3.Width = 62;
			// 
			// openfiledlgPicture
			// 
			this.openfiledlgPicture.FileName = "openFileDialog1";
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lvSinhVien.ContextMenuStrip = this.menuStrip1;
			this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(3, 22);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(1051, 291);
			this.lvSinhVien.TabIndex = 0;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lvSinhVien);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 253);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1057, 316);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách sinh viên";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(23, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "Hình";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(23, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Địa chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(23, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(23, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ và tên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(23, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboLop);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.btnThoat);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.btnMacDinh);
			this.groupBox1.Controls.Add(this.btnChon);
			this.groupBox1.Controls.Add(this.rbNu);
			this.groupBox1.Controls.Add(this.rbNam);
			this.groupBox1.Controls.Add(this.txtHinh);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.mktbSDT);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.mktbMSSV);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(208, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(861, 235);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin sinh viên";
			// 
			// cboLop
			// 
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
			this.cboLop.Location = new System.Drawing.Point(594, 90);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(256, 27);
			this.cboLop.TabIndex = 7;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(594, 27);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(256, 26);
			this.dtpNgaySinh.TabIndex = 4;
			this.dtpNgaySinh.Value = new System.DateTime(2021, 9, 22, 14, 26, 58, 0);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(775, 206);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 12;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(644, 206);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 11;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnMacDinh
			// 
			this.btnMacDinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMacDinh.Location = new System.Drawing.Point(500, 206);
			this.btnMacDinh.Name = "btnMacDinh";
			this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
			this.btnMacDinh.TabIndex = 10;
			this.btnMacDinh.Text = "Mặc định";
			this.btnMacDinh.UseVisualStyleBackColor = true;
			this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
			// 
			// btnChon
			// 
			this.btnChon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChon.Location = new System.Drawing.Point(775, 154);
			this.btnChon.Name = "btnChon";
			this.btnChon.Size = new System.Drawing.Size(75, 23);
			this.btnChon.TabIndex = 9;
			this.btnChon.Text = "Chọn hình";
			this.btnChon.UseVisualStyleBackColor = true;
			this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.Location = new System.Drawing.Point(694, 66);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(48, 23);
			this.rbNu.TabIndex = 6;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			// 
			// rbNam
			// 
			this.rbNam.AutoSize = true;
			this.rbNam.Checked = true;
			this.rbNam.Location = new System.Drawing.Point(594, 66);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(57, 23);
			this.rbNam.TabIndex = 5;
			this.rbNam.TabStop = true;
			this.rbNam.Text = "Nam";
			this.rbNam.UseVisualStyleBackColor = true;
			// 
			// txtHinh
			// 
			this.txtHinh.Location = new System.Drawing.Point(127, 155);
			this.txtHinh.Name = "txtHinh";
			this.txtHinh.ReadOnly = true;
			this.txtHinh.Size = new System.Drawing.Size(631, 26);
			this.txtHinh.TabIndex = 13;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(127, 122);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(320, 26);
			this.txtDiaChi.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(127, 90);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(320, 26);
			this.txtEmail.TabIndex = 2;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(127, 58);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(320, 26);
			this.txtHoTen.TabIndex = 1;
			// 
			// pbHinh
			// 
			this.pbHinh.Location = new System.Drawing.Point(12, 12);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(190, 235);
			this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbHinh.TabIndex = 3;
			this.pbHinh.TabStop = false;
			// 
			// ThongTinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 516);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pbHinh);
			this.Name = "ThongTinForm";
			this.Text = "Thông tin sinh viên khoa CNTT";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongTinForm_FormClosing);
			this.Load += new System.EventHandler(this.ThongTinForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
		private System.Windows.Forms.ToolStripMenuItem menuItemReload;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.MaskedTextBox mktbSDT;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mktbMSSV;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.OpenFileDialog openfiledlgPicture;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.RadioButton rbNam;
		private System.Windows.Forms.TextBox txtHinh;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Button btnChon;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.ComboBox cboLop;
	}
}

