namespace Ex11
{
	partial class frmTabControl
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabSV = new System.Windows.Forms.TabPage();
			this.tabGV = new System.Windows.Forms.TabPage();
			this.tabMH = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabSV.SuspendLayout();
			this.tabGV.SuspendLayout();
			this.tabMH.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl1.Controls.Add(this.tabSV);
			this.tabControl1.Controls.Add(this.tabGV);
			this.tabControl1.Controls.Add(this.tabMH);
			this.tabControl1.Location = new System.Drawing.Point(23, 32);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(249, 171);
			this.tabControl1.TabIndex = 0;
			// 
			// tabSV
			// 
			this.tabSV.Controls.Add(this.textBox2);
			this.tabSV.Controls.Add(this.label2);
			this.tabSV.Controls.Add(this.label1);
			this.tabSV.Controls.Add(this.textBox1);
			this.tabSV.Location = new System.Drawing.Point(4, 25);
			this.tabSV.Name = "tabSV";
			this.tabSV.Padding = new System.Windows.Forms.Padding(3);
			this.tabSV.Size = new System.Drawing.Size(241, 142);
			this.tabSV.TabIndex = 0;
			this.tabSV.Text = "Sinh Viên";
			this.tabSV.UseVisualStyleBackColor = true;
			// 
			// tabGV
			// 
			this.tabGV.Controls.Add(this.textBox3);
			this.tabGV.Controls.Add(this.label3);
			this.tabGV.Location = new System.Drawing.Point(4, 25);
			this.tabGV.Name = "tabGV";
			this.tabGV.Padding = new System.Windows.Forms.Padding(3);
			this.tabGV.Size = new System.Drawing.Size(241, 142);
			this.tabGV.TabIndex = 1;
			this.tabGV.Text = "Giáo Viên";
			this.tabGV.UseVisualStyleBackColor = true;
			// 
			// tabMH
			// 
			this.tabMH.Controls.Add(this.label4);
			this.tabMH.Controls.Add(this.textBox4);
			this.tabMH.Location = new System.Drawing.Point(4, 25);
			this.tabMH.Name = "tabMH";
			this.tabMH.Padding = new System.Windows.Forms.Padding(3);
			this.tabMH.Size = new System.Drawing.Size(241, 142);
			this.tabMH.TabIndex = 2;
			this.tabMH.Text = "Môn Học";
			this.tabMH.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(56, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(84, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Họ tên";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(56, 39);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(130, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Họ tên GV";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(79, 12);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(126, 20);
			this.textBox3.TabIndex = 1;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(83, 7);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Môn Học";
			// 
			// frmTabControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmTabControl";
			this.Text = "Demo TabControl";
			this.Load += new System.EventHandler(this.frmTabControl_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabSV.ResumeLayout(false);
			this.tabSV.PerformLayout();
			this.tabGV.ResumeLayout(false);
			this.tabGV.PerformLayout();
			this.tabMH.ResumeLayout(false);
			this.tabMH.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSV;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabGV;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabMH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
	}
}

