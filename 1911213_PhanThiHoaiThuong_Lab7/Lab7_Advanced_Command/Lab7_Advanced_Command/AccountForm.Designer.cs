namespace Lab7_Advanced_Command
{
	partial class AccountForm
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmRole = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmDiary = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.txtTell = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAccountName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRole,
            this.tsmDiary});
			this.contextMenuStrip1.Name = "contextMenuStrip2";
			this.contextMenuStrip1.Size = new System.Drawing.Size(196, 48);
			// 
			// tsmRole
			// 
			this.tsmRole.Name = "tsmRole";
			this.tsmRole.Size = new System.Drawing.Size(195, 22);
			this.tsmRole.Text = "Xem danh sách vai trò";
			this.tsmRole.Click += new System.EventHandler(this.tsmRole_Click);
			// 
			// tsmDiary
			// 
			this.tsmDiary.Name = "tsmDiary";
			this.tsmDiary.Size = new System.Drawing.Size(195, 22);
			this.tsmDiary.Text = "Xem nhật kí hoạt động";
			this.tsmDiary.Click += new System.EventHandler(this.tsmDiary_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(626, 19);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(90, 23);
			this.btnAdd.TabIndex = 26;
			this.btnAdd.Text = "Add new";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvAccount
			// 
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvAccount.Location = new System.Drawing.Point(11, 128);
			this.dgvAccount.Margin = new System.Windows.Forms.Padding(2);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.RowHeadersWidth = 51;
			this.dgvAccount.RowTemplate.Height = 24;
			this.dgvAccount.Size = new System.Drawing.Size(705, 326);
			this.dgvAccount.TabIndex = 27;
			this.dgvAccount.Click += new System.EventHandler(this.dgvAccount_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(99, 52);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(177, 21);
			this.txtPassword.TabIndex = 76;
			// 
			// dtpCreateDate
			// 
			this.dtpCreateDate.Enabled = false;
			this.dtpCreateDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCreateDate.Location = new System.Drawing.Point(402, 83);
			this.dtpCreateDate.Margin = new System.Windows.Forms.Padding(2);
			this.dtpCreateDate.Name = "dtpCreateDate";
			this.dtpCreateDate.Size = new System.Drawing.Size(177, 22);
			this.dtpCreateDate.TabIndex = 74;
			// 
			// txtFullName
			// 
			this.txtFullName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFullName.Location = new System.Drawing.Point(99, 83);
			this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(177, 22);
			this.txtFullName.TabIndex = 70;
			// 
			// txtTell
			// 
			this.txtTell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTell.Location = new System.Drawing.Point(402, 51);
			this.txtTell.Margin = new System.Windows.Forms.Padding(2);
			this.txtTell.Name = "txtTell";
			this.txtTell.Size = new System.Drawing.Size(177, 22);
			this.txtTell.TabIndex = 71;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(402, 19);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(177, 22);
			this.txtEmail.TabIndex = 72;
			// 
			// txtAccountName
			// 
			this.txtAccountName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccountName.Location = new System.Drawing.Point(99, 21);
			this.txtAccountName.Margin = new System.Windows.Forms.Padding(2);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new System.Drawing.Size(177, 22);
			this.txtAccountName.TabIndex = 73;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(316, 86);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 15);
			this.label8.TabIndex = 64;
			this.label8.Text = "Ngày tạo ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(316, 55);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 15);
			this.label7.TabIndex = 65;
			this.label7.Text = "Tell";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(316, 24);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 15);
			this.label6.TabIndex = 66;
			this.label6.Text = "Email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 86);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 15);
			this.label5.TabIndex = 67;
			this.label5.Text = "Họ và tên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 55);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 15);
			this.label4.TabIndex = 68;
			this.label4.Text = "Mật khẩu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 26);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 15);
			this.label3.TabIndex = 69;
			this.label3.Text = "Tên tài khoản";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(626, 56);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 23);
			this.btnUpdate.TabIndex = 77;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(626, 87);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(90, 23);
			this.btnCancel.TabIndex = 78;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 454);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.dtpCreateDate);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.txtTell);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtAccountName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvAccount);
			this.Controls.Add(this.btnAdd);
			this.Name = "AccountForm";
			this.Text = "AccountForm";
			this.Load += new System.EventHandler(this.AccountForm_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmRole;
		private System.Windows.Forms.ToolStripMenuItem tsmDiary;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dgvAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.DateTimePicker dtpCreateDate;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.TextBox txtTell;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancel;
	}
}