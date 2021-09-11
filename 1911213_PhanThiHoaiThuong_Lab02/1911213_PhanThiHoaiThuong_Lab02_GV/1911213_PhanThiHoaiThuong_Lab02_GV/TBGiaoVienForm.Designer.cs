namespace _1911213_PhanThiHoaiThuong_Lab02_GV
{
	partial class TBGiaoVienForm
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
			this.c = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// c
			// 
			this.c.AutoSize = true;
			this.c.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c.ForeColor = System.Drawing.Color.DarkViolet;
			this.c.Location = new System.Drawing.Point(23, 33);
			this.c.Name = "c";
			this.c.Size = new System.Drawing.Size(35, 15);
			this.c.TabIndex = 0;
			this.c.Text = "label1";
			// 
			// TBGiaoVienForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 232);
			this.Controls.Add(this.c);
			this.Name = "TBGiaoVienForm";
			this.Text = "Thông tin giáo viên nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label c;
	}
}