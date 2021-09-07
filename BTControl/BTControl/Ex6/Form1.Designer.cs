namespace Ex6
{
	partial class frmListBox
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
			this.lbDanhsach = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbDanhsachchon = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbDanhsach
			// 
			this.lbDanhsach.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbDanhsach.FormattingEnabled = true;
			this.lbDanhsach.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha\t",
            "Hoang Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t"});
			this.lbDanhsach.Location = new System.Drawing.Point(37, 31);
			this.lbDanhsach.Name = "lbDanhsach";
			this.lbDanhsach.Size = new System.Drawing.Size(199, 212);
			this.lbDanhsach.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(34, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách sinh viên lớp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(350, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(252, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Danh sách sinh viên tham gia bóng đá";
			// 
			// lbDanhsachchon
			// 
			this.lbDanhsachchon.ForeColor = System.Drawing.Color.LightCoral;
			this.lbDanhsachchon.FormattingEnabled = true;
			this.lbDanhsachchon.Items.AddRange(new object[] {
            "Tran The Anh",
            "Nguyen Thi Lan Huong"});
			this.lbDanhsachchon.Location = new System.Drawing.Point(353, 31);
			this.lbDanhsachchon.Name = "lbDanhsachchon";
			this.lbDanhsachchon.Size = new System.Drawing.Size(213, 212);
			this.lbDanhsachchon.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(260, 79);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Chọn";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(260, 120);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "Xoá";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// frmListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 261);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbDanhsachchon);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbDanhsach);
			this.Name = "frmListBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListBoxs";
			this.Load += new System.EventHandler(this.frmListBox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbDanhsach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lbDanhsachchon;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
	}
}

