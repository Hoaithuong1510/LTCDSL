namespace OnTap1
{
	partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiNhap = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLuu = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExcel = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiJSon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiIn = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.tvDSKhoa = new System.Windows.Forms.TreeView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvDSSV = new System.Windows.Forms.ListView();
			this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Ho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Khoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTim = new System.Windows.Forms.TextBox();
			this.rbSDT = new System.Windows.Forms.RadioButton();
			this.rbHoten = new System.Windows.Forms.RadioButton();
			this.rbMSSV = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhap,
            this.tsmiLuu,
            this.tsmiIn});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1322, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiNhap
			// 
			this.tsmiNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmiNhap.Name = "tsmiNhap";
			this.tsmiNhap.Size = new System.Drawing.Size(48, 20);
			this.tsmiNhap.Text = "Nhập";
			// 
			// tsmiLuu
			// 
			this.tsmiLuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExcel,
            this.tsmiJSon});
			this.tsmiLuu.Name = "tsmiLuu";
			this.tsmiLuu.Size = new System.Drawing.Size(39, 20);
			this.tsmiLuu.Text = "Lưu";
			// 
			// tsmiExcel
			// 
			this.tsmiExcel.Name = "tsmiExcel";
			this.tsmiExcel.Size = new System.Drawing.Size(152, 22);
			this.tsmiExcel.Text = "Excel";
			this.tsmiExcel.Click += new System.EventHandler(this.tsmiExcel_Click);
			// 
			// tsmiJSon
			// 
			this.tsmiJSon.Name = "tsmiJSon";
			this.tsmiJSon.Size = new System.Drawing.Size(152, 22);
			this.tsmiJSon.Text = "JSon";
			this.tsmiJSon.Click += new System.EventHandler(this.tsmiJSon_Click);
			// 
			// tsmiIn
			// 
			this.tsmiIn.Name = "tsmiIn";
			this.tsmiIn.Size = new System.Drawing.Size(29, 20);
			this.tsmiIn.Text = "In";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(274, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Chọn lớp để hiện thị danh sách sinh viên";
			// 
			// tvDSKhoa
			// 
			this.tvDSKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tvDSKhoa.Location = new System.Drawing.Point(12, 95);
			this.tvDSKhoa.Name = "tvDSKhoa";
			this.tvDSKhoa.Size = new System.Drawing.Size(274, 623);
			this.tvDSKhoa.TabIndex = 2;
			this.tvDSKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDSKhoa_AfterSelect);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvDSSV);
			this.groupBox1.Controls.Add(this.txtTim);
			this.groupBox1.Controls.Add(this.rbSDT);
			this.groupBox1.Controls.Add(this.rbHoten);
			this.groupBox1.Controls.Add(this.rbMSSV);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(292, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1053, 753);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm";
			// 
			// lvDSSV
			// 
			this.lvDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.Ho,
            this.Ten,
            this.GioiTinh,
            this.NgaySinh,
            this.Sdt,
            this.Lop,
            this.Khoa,
            this.DiaChi});
			this.lvDSSV.ContextMenuStrip = this.contextMenuStrip1;
			this.lvDSSV.FullRowSelect = true;
			this.lvDSSV.GridLines = true;
			this.lvDSSV.HideSelection = false;
			this.lvDSSV.Location = new System.Drawing.Point(7, 95);
			this.lvDSSV.Margin = new System.Windows.Forms.Padding(4);
			this.lvDSSV.Name = "lvDSSV";
			this.lvDSSV.Size = new System.Drawing.Size(1104, 748);
			this.lvDSSV.TabIndex = 5;
			this.lvDSSV.UseCompatibleStateImageBehavior = false;
			this.lvDSSV.View = System.Windows.Forms.View.Details;
			this.lvDSSV.DoubleClick += new System.EventHandler(this.lvDSSV_DoubleClick);
			// 
			// MSSV
			// 
			this.MSSV.Text = "MSSV";
			this.MSSV.Width = 77;
			// 
			// Ho
			// 
			this.Ho.Text = "Họ và tên lót";
			this.Ho.Width = 186;
			// 
			// Ten
			// 
			this.Ten.Text = "Tên";
			this.Ten.Width = 108;
			// 
			// GioiTinh
			// 
			this.GioiTinh.Text = "Giới tính";
			this.GioiTinh.Width = 70;
			// 
			// NgaySinh
			// 
			this.NgaySinh.Text = "Ngày sinh";
			this.NgaySinh.Width = 120;
			// 
			// Sdt
			// 
			this.Sdt.Text = "Số điện thoại";
			this.Sdt.Width = 134;
			// 
			// Lop
			// 
			this.Lop.Text = "Lớp";
			this.Lop.Width = 223;
			// 
			// Khoa
			// 
			this.Khoa.Text = "Khoa";
			this.Khoa.Width = 202;
			// 
			// DiaChi
			// 
			this.DiaChi.Text = "Địa chỉ";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiXoa});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
			// 
			// tsmiThem
			// 
			this.tsmiThem.Name = "tsmiThem";
			this.tsmiThem.Size = new System.Drawing.Size(104, 22);
			this.tsmiThem.Text = "Thêm";
			this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
			// 
			// tsmiXoa
			// 
			this.tsmiXoa.Name = "tsmiXoa";
			this.tsmiXoa.Size = new System.Drawing.Size(104, 22);
			this.tsmiXoa.Text = "Xoá";
			this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(223, 55);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(308, 25);
			this.txtTim.TabIndex = 4;
			this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
			// 
			// rbSDT
			// 
			this.rbSDT.AutoSize = true;
			this.rbSDT.Location = new System.Drawing.Point(428, 28);
			this.rbSDT.Name = "rbSDT";
			this.rbSDT.Size = new System.Drawing.Size(103, 21);
			this.rbSDT.TabIndex = 3;
			this.rbSDT.Text = "Số điện thoại";
			this.rbSDT.UseVisualStyleBackColor = true;
			// 
			// rbHoten
			// 
			this.rbHoten.AutoSize = true;
			this.rbHoten.Location = new System.Drawing.Point(326, 28);
			this.rbHoten.Name = "rbHoten";
			this.rbHoten.Size = new System.Drawing.Size(65, 21);
			this.rbHoten.TabIndex = 2;
			this.rbHoten.Text = "Họ tên";
			this.rbHoten.UseVisualStyleBackColor = true;
			// 
			// rbMSSV
			// 
			this.rbMSSV.AutoSize = true;
			this.rbMSSV.Checked = true;
			this.rbMSSV.Location = new System.Drawing.Point(223, 28);
			this.rbMSSV.Name = "rbMSSV";
			this.rbMSSV.Size = new System.Drawing.Size(60, 21);
			this.rbMSSV.TabIndex = 1;
			this.rbMSSV.TabStop = true;
			this.rbMSSV.Text = "MSSV";
			this.rbMSSV.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tìm theo:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1322, 716);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tvDSKhoa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Quản lý sinh viên";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiNhap;
		private System.Windows.Forms.ToolStripMenuItem tsmiLuu;
		private System.Windows.Forms.ToolStripMenuItem tsmiIn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView tvDSKhoa;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiThem;
		private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
		private System.Windows.Forms.TextBox txtTim;
		private System.Windows.Forms.RadioButton rbSDT;
		private System.Windows.Forms.RadioButton rbHoten;
		private System.Windows.Forms.RadioButton rbMSSV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lvDSSV;
		private System.Windows.Forms.ColumnHeader MSSV;
		private System.Windows.Forms.ColumnHeader Ho;
		private System.Windows.Forms.ColumnHeader Ten;
		private System.Windows.Forms.ColumnHeader GioiTinh;
		private System.Windows.Forms.ColumnHeader NgaySinh;
		private System.Windows.Forms.ColumnHeader Sdt;
		private System.Windows.Forms.ColumnHeader Lop;
		private System.Windows.Forms.ColumnHeader Khoa;
		private System.Windows.Forms.ColumnHeader DiaChi;
		private System.Windows.Forms.ToolStripMenuItem tsmiExcel;
		private System.Windows.Forms.ToolStripMenuItem tsmiJSon;
	}
}

