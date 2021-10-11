namespace OnTap1
{
	partial class frmThongTin
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
			this.btnLuu = new System.Windows.Forms.Button();
			this.cbbKhoa = new System.Windows.Forms.ComboBox();
			this.cbbLop = new System.Windows.Forms.ComboBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.rbNam = new System.Windows.Forms.RadioButton();
			this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
			this.txtDiachi = new System.Windows.Forms.MaskedTextBox();
			this.txtHo = new System.Windows.Forms.TextBox();
			this.txtSdt = new System.Windows.Forms.MaskedTextBox();
			this.txtMSSV = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(534, 189);
			this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(92, 28);
			this.btnLuu.TabIndex = 79;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// cbbKhoa
			// 
			this.cbbKhoa.FormattingEnabled = true;
			this.cbbKhoa.Location = new System.Drawing.Point(470, 121);
			this.cbbKhoa.Margin = new System.Windows.Forms.Padding(2);
			this.cbbKhoa.Name = "cbbKhoa";
			this.cbbKhoa.Size = new System.Drawing.Size(198, 21);
			this.cbbKhoa.TabIndex = 78;
			this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
			// 
			// cbbLop
			// 
			this.cbbLop.FormattingEnabled = true;
			this.cbbLop.Location = new System.Drawing.Point(470, 86);
			this.cbbLop.Margin = new System.Windows.Forms.Padding(2);
			this.cbbLop.Name = "cbbLop";
			this.cbbLop.Size = new System.Drawing.Size(198, 21);
			this.cbbLop.TabIndex = 77;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(470, 53);
			this.txtTen.Margin = new System.Windows.Forms.Padding(2);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(198, 20);
			this.txtTen.TabIndex = 76;
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNu.Location = new System.Drawing.Point(552, 19);
			this.rbNu.Margin = new System.Windows.Forms.Padding(2);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(41, 19);
			this.rbNu.TabIndex = 75;
			this.rbNu.TabStop = true;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			// 
			// rbNam
			// 
			this.rbNam.AutoSize = true;
			this.rbNam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNam.Location = new System.Drawing.Point(470, 19);
			this.rbNam.Margin = new System.Windows.Forms.Padding(2);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(51, 19);
			this.rbNam.TabIndex = 74;
			this.rbNam.TabStop = true;
			this.rbNam.Text = "Nam";
			this.rbNam.UseVisualStyleBackColor = true;
			// 
			// dtpNgaysinh
			// 
			this.dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaysinh.Location = new System.Drawing.Point(149, 86);
			this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(2);
			this.dtpNgaysinh.Name = "dtpNgaysinh";
			this.dtpNgaysinh.Size = new System.Drawing.Size(198, 20);
			this.dtpNgaysinh.TabIndex = 73;
			// 
			// txtDiachi
			// 
			this.txtDiachi.Location = new System.Drawing.Point(149, 153);
			this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
			this.txtDiachi.Name = "txtDiachi";
			this.txtDiachi.Size = new System.Drawing.Size(519, 20);
			this.txtDiachi.TabIndex = 72;
			// 
			// txtHo
			// 
			this.txtHo.Location = new System.Drawing.Point(149, 50);
			this.txtHo.Margin = new System.Windows.Forms.Padding(2);
			this.txtHo.Name = "txtHo";
			this.txtHo.Size = new System.Drawing.Size(198, 20);
			this.txtHo.TabIndex = 71;
			// 
			// txtSdt
			// 
			this.txtSdt.Location = new System.Drawing.Point(149, 118);
			this.txtSdt.Margin = new System.Windows.Forms.Padding(2);
			this.txtSdt.Mask = "0000.000.000";
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(198, 20);
			this.txtSdt.TabIndex = 70;
			// 
			// txtMSSV
			// 
			this.txtMSSV.Location = new System.Drawing.Point(149, 16);
			this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
			this.txtMSSV.Mask = "0000000";
			this.txtMSSV.Name = "txtMSSV";
			this.txtMSSV.ReadOnly = true;
			this.txtMSSV.Size = new System.Drawing.Size(198, 20);
			this.txtMSSV.TabIndex = 69;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(36, 53);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 17);
			this.label9.TabIndex = 68;
			this.label9.Text = "Họ và tên lót :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(36, 89);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 17);
			this.label8.TabIndex = 67;
			this.label8.Text = "Ngày sinh :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(36, 121);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 17);
			this.label7.TabIndex = 66;
			this.label7.Text = "Số ĐT :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(36, 156);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 17);
			this.label6.TabIndex = 65;
			this.label6.Text = "Địa chỉ liên lạc :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(381, 19);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 17);
			this.label5.TabIndex = 64;
			this.label5.Text = "Giới tính :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(381, 53);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 17);
			this.label4.TabIndex = 63;
			this.label4.Text = "Tên :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(381, 89);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 62;
			this.label3.Text = "Lớp :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(381, 121);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 17);
			this.label2.TabIndex = 61;
			this.label2.Text = "Khoa:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 60;
			this.label1.Text = "MSSV :";
			// 
			// frmThongTin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 225);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.cbbKhoa);
			this.Controls.Add(this.cbbLop);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.rbNu);
			this.Controls.Add(this.rbNam);
			this.Controls.Add(this.dtpNgaysinh);
			this.Controls.Add(this.txtDiachi);
			this.Controls.Add(this.txtHo);
			this.Controls.Add(this.txtSdt);
			this.Controls.Add(this.txtMSSV);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmThongTin";
			this.Text = "frmThongTin";
			this.Load += new System.EventHandler(this.frmThongTin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.ComboBox cbbKhoa;
		private System.Windows.Forms.ComboBox cbbLop;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.RadioButton rbNam;
		private System.Windows.Forms.DateTimePicker dtpNgaysinh;
		private System.Windows.Forms.MaskedTextBox txtDiachi;
		private System.Windows.Forms.TextBox txtHo;
		private System.Windows.Forms.MaskedTextBox txtSdt;
		private System.Windows.Forms.MaskedTextBox txtMSSV;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}