namespace Lab3_Demo
{
	partial class frmTuyChon
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbMaSV = new System.Windows.Forms.RadioButton();
			this.rbHoTen = new System.Windows.Forms.RadioButton();
			this.rbNgaySinh = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbNhap = new System.Windows.Forms.Label();
			this.txtText = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnSapXep = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbNgaySinh);
			this.groupBox1.Controls.Add(this.rbHoTen);
			this.groupBox1.Controls.Add(this.rbMaSV);
			this.groupBox1.Location = new System.Drawing.Point(62, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(399, 78);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// rbMaSV
			// 
			this.rbMaSV.AutoSize = true;
			this.rbMaSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMaSV.ForeColor = System.Drawing.Color.MediumBlue;
			this.rbMaSV.Location = new System.Drawing.Point(18, 29);
			this.rbMaSV.Name = "rbMaSV";
			this.rbMaSV.Size = new System.Drawing.Size(75, 23);
			this.rbMaSV.TabIndex = 0;
			this.rbMaSV.TabStop = true;
			this.rbMaSV.Text = "Mã SV";
			this.rbMaSV.UseVisualStyleBackColor = true;
			// 
			// rbHoTen
			// 
			this.rbHoTen.AutoSize = true;
			this.rbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbHoTen.ForeColor = System.Drawing.Color.MediumBlue;
			this.rbHoTen.Location = new System.Drawing.Point(159, 29);
			this.rbHoTen.Name = "rbHoTen";
			this.rbHoTen.Size = new System.Drawing.Size(77, 23);
			this.rbHoTen.TabIndex = 1;
			this.rbHoTen.TabStop = true;
			this.rbHoTen.Text = "Họ Tên";
			this.rbHoTen.UseVisualStyleBackColor = true;
			// 
			// rbNgaySinh
			// 
			this.rbNgaySinh.AutoSize = true;
			this.rbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNgaySinh.ForeColor = System.Drawing.Color.MediumBlue;
			this.rbNgaySinh.Location = new System.Drawing.Point(297, 29);
			this.rbNgaySinh.Name = "rbNgaySinh";
			this.rbNgaySinh.Size = new System.Drawing.Size(96, 23);
			this.rbNgaySinh.TabIndex = 2;
			this.rbNgaySinh.TabStop = true;
			this.rbNgaySinh.Text = "Ngày Sinh";
			this.rbNgaySinh.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Controls.Add(this.txtText);
			this.groupBox2.Controls.Add(this.lbNhap);
			this.groupBox2.Location = new System.Drawing.Point(62, 124);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(399, 55);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// lbNhap
			// 
			this.lbNhap.AutoSize = true;
			this.lbNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhap.Location = new System.Drawing.Point(7, 20);
			this.lbNhap.Name = "lbNhap";
			this.lbNhap.Size = new System.Drawing.Size(98, 19);
			this.lbNhap.TabIndex = 0;
			this.lbNhap.Text = "Nhập thông tin";
			// 
			// txtText
			// 
			this.txtText.Location = new System.Drawing.Point(136, 15);
			this.txtText.Multiline = true;
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(191, 30);
			this.txtText.TabIndex = 1;
			// 
			// btnFind
			// 
			this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.ForeColor = System.Drawing.Color.DarkViolet;
			this.btnFind.Location = new System.Drawing.Point(349, 19);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(44, 23);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Tìm";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnSapXep
			// 
			this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSapXep.ForeColor = System.Drawing.Color.DarkViolet;
			this.btnSapXep.Location = new System.Drawing.Point(143, 197);
			this.btnSapXep.Name = "btnSapXep";
			this.btnSapXep.Size = new System.Drawing.Size(78, 28);
			this.btnSapXep.TabIndex = 3;
			this.btnSapXep.Text = "Sắp xếp";
			this.btnSapXep.UseVisualStyleBackColor = true;
			this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.DarkViolet;
			this.btnThoat.Location = new System.Drawing.Point(311, 197);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(78, 28);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmTuyChon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 232);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSapXep);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmTuyChon";
			this.Text = "Tuỳ Chọn";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbNgaySinh;
		private System.Windows.Forms.RadioButton rbHoTen;
		private System.Windows.Forms.RadioButton rbMaSV;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Label lbNhap;
		private System.Windows.Forms.Button btnSapXep;
		private System.Windows.Forms.Button btnThoat;
	}
}