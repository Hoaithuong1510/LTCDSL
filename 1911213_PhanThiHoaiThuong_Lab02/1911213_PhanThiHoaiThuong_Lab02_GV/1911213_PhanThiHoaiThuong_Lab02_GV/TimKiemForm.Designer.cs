namespace _1911213_PhanThiHoaiThuong_Lab02_GV
{
	partial class TimKiemForm
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
			this.rbSoDT = new System.Windows.Forms.RadioButton();
			this.rbHoTen = new System.Windows.Forms.RadioButton();
			this.rbMaGV = new System.Windows.Forms.RadioButton();
			this.lbFind = new System.Windows.Forms.Label();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbSoDT);
			this.groupBox1.Controls.Add(this.rbHoTen);
			this.groupBox1.Controls.Add(this.rbMaGV);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(22, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(381, 61);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm theo";
			// 
			// rbSoDT
			// 
			this.rbSoDT.AutoSize = true;
			this.rbSoDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSoDT.Location = new System.Drawing.Point(223, 25);
			this.rbSoDT.Name = "rbSoDT";
			this.rbSoDT.Size = new System.Drawing.Size(102, 21);
			this.rbSoDT.TabIndex = 2;
			this.rbSoDT.TabStop = true;
			this.rbSoDT.Text = "Số điện thoại";
			this.rbSoDT.UseVisualStyleBackColor = true;
			// 
			// rbHoTen
			// 
			this.rbHoTen.AutoSize = true;
			this.rbHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbHoTen.Location = new System.Drawing.Point(130, 25);
			this.rbHoTen.Name = "rbHoTen";
			this.rbHoTen.Size = new System.Drawing.Size(71, 21);
			this.rbHoTen.TabIndex = 1;
			this.rbHoTen.TabStop = true;
			this.rbHoTen.Text = "Họ Tên";
			this.rbHoTen.UseVisualStyleBackColor = true;
			// 
			// rbMaGV
			// 
			this.rbMaGV.AutoSize = true;
			this.rbMaGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbMaGV.Location = new System.Drawing.Point(32, 25);
			this.rbMaGV.Name = "rbMaGV";
			this.rbMaGV.Size = new System.Drawing.Size(67, 21);
			this.rbMaGV.TabIndex = 0;
			this.rbMaGV.TabStop = true;
			this.rbMaGV.Text = "MãGV";
			this.rbMaGV.UseVisualStyleBackColor = true;
			// 
			// lbFind
			// 
			this.lbFind.AutoSize = true;
			this.lbFind.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFind.Location = new System.Drawing.Point(19, 94);
			this.lbFind.Name = "lbFind";
			this.lbFind.Size = new System.Drawing.Size(53, 17);
			this.lbFind.TabIndex = 1;
			this.lbFind.Text = "Mã GV";
			// 
			// txtFind
			// 
			this.txtFind.Location = new System.Drawing.Point(126, 88);
			this.txtFind.Multiline = true;
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(197, 23);
			this.txtFind.TabIndex = 2;
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(344, 88);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(59, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// TimKiemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 121);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtFind);
			this.Controls.Add(this.lbFind);
			this.Controls.Add(this.groupBox1);
			this.Name = "TimKiemForm";
			this.Text = "Tìm thông tin Giáo Viên";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbSoDT;
		private System.Windows.Forms.RadioButton rbHoTen;
		private System.Windows.Forms.RadioButton rbMaGV;
		private System.Windows.Forms.Label lbFind;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Button btnOK;
	}
}