namespace Lab6_Basic_Command
{
	partial class AccountManager
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
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmRole = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmResetPass = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmVaiTro = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAccountant = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPay = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiServer = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAll = new System.Windows.Forms.ToolStripMenuItem();
			this.activiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiActive = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNotActive = new System.Windows.Forms.ToolStripMenuItem();
			this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			this.contextMenuStrip2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAccount
			// 
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.ContextMenuStrip = this.contextMenuStrip2;
			this.dgvAccount.Location = new System.Drawing.Point(2, 60);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.Size = new System.Drawing.Size(694, 351);
			this.dgvAccount.TabIndex = 0;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmRole,
            this.tsmResetPass,
            this.thêmTàiKhoảnToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(192, 92);
			// 
			// tsmDelete
			// 
			this.tsmDelete.Name = "tsmDelete";
			this.tsmDelete.Size = new System.Drawing.Size(191, 22);
			this.tsmDelete.Text = "Xóa tài khoản";
			this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
			// 
			// tsmRole
			// 
			this.tsmRole.Name = "tsmRole";
			this.tsmRole.Size = new System.Drawing.Size(191, 22);
			this.tsmRole.Text = "Xem danh sách vai trò";
			this.tsmRole.Click += new System.EventHandler(this.tsmRole_Click);
			// 
			// tsmResetPass
			// 
			this.tsmResetPass.Name = "tsmResetPass";
			this.tsmResetPass.Size = new System.Drawing.Size(191, 22);
			this.tsmResetPass.Text = "Reset mật khẩu";
			this.tsmResetPass.Click += new System.EventHandler(this.tsmResetPass_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVaiTro,
            this.activiToolStripMenuItem,
            this.tsmAdd});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(693, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmVaiTro
			// 
			this.tsmVaiTro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmiAccountant,
            this.tsmiPay,
            this.tsmiServer,
            this.tsmiAll});
			this.tsmVaiTro.Name = "tsmVaiTro";
			this.tsmVaiTro.Size = new System.Drawing.Size(52, 20);
			this.tsmVaiTro.Text = "Vai trò";
			// 
			// tsmiAdmin
			// 
			this.tsmiAdmin.Name = "tsmiAdmin";
			this.tsmiAdmin.Size = new System.Drawing.Size(189, 22);
			this.tsmiAdmin.Text = "Admin";
			this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);
			// 
			// tsmiAccountant
			// 
			this.tsmiAccountant.Name = "tsmiAccountant";
			this.tsmiAccountant.Size = new System.Drawing.Size(189, 22);
			this.tsmiAccountant.Text = "Kế toán";
			this.tsmiAccountant.Click += new System.EventHandler(this.tsmiAccountant_Click);
			// 
			// tsmiPay
			// 
			this.tsmiPay.Name = "tsmiPay";
			this.tsmiPay.Size = new System.Drawing.Size(189, 22);
			this.tsmiPay.Text = "Nhân viên thanh toán";
			this.tsmiPay.Click += new System.EventHandler(this.tsmiPay_Click);
			// 
			// tsmiServer
			// 
			this.tsmiServer.Name = "tsmiServer";
			this.tsmiServer.Size = new System.Drawing.Size(189, 22);
			this.tsmiServer.Text = "Nhân viên phục vụ";
			this.tsmiServer.Click += new System.EventHandler(this.tsmiServer_Click);
			// 
			// tsmiAll
			// 
			this.tsmiAll.Name = "tsmiAll";
			this.tsmiAll.Size = new System.Drawing.Size(189, 22);
			this.tsmiAll.Text = "Tất cả";
			this.tsmiAll.Click += new System.EventHandler(this.tsmiAll_Click);
			// 
			// activiToolStripMenuItem
			// 
			this.activiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActive,
            this.tsmiNotActive});
			this.activiToolStripMenuItem.Name = "activiToolStripMenuItem";
			this.activiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.activiToolStripMenuItem.Text = "Trạng thái";
			// 
			// tsmiActive
			// 
			this.tsmiActive.Name = "tsmiActive";
			this.tsmiActive.Size = new System.Drawing.Size(152, 22);
			this.tsmiActive.Text = "Active";
			this.tsmiActive.Click += new System.EventHandler(this.tsmiActive_Click);
			// 
			// tsmiNotActive
			// 
			this.tsmiNotActive.Name = "tsmiNotActive";
			this.tsmiNotActive.Size = new System.Drawing.Size(152, 22);
			this.tsmiNotActive.Text = "No Active";
			this.tsmiNotActive.Click += new System.EventHandler(this.tsmiNotActive_Click);
			// 
			// thêmTàiKhoảnToolStripMenuItem
			// 
			this.thêmTàiKhoảnToolStripMenuItem.Name = "thêmTàiKhoảnToolStripMenuItem";
			this.thêmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.thêmTàiKhoảnToolStripMenuItem.Text = "Thêm tài khoản";
			// 
			// tsmAdd
			// 
			this.tsmAdd.Name = "tsmAdd";
			this.tsmAdd.Size = new System.Drawing.Size(49, 20);
			this.tsmAdd.Text = "Thêm";
			this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
			// 
			// AccountManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 412);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.dgvAccount);
			this.Name = "AccountManager";
			this.Text = "AccountManager";
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			this.contextMenuStrip2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAccount;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem tsmDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmRole;
		private System.Windows.Forms.ToolStripMenuItem tsmResetPass;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmVaiTro;
		private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
		private System.Windows.Forms.ToolStripMenuItem tsmiAccountant;
		private System.Windows.Forms.ToolStripMenuItem tsmiPay;
		private System.Windows.Forms.ToolStripMenuItem tsmiServer;
		private System.Windows.Forms.ToolStripMenuItem tsmiAll;
		private System.Windows.Forms.ToolStripMenuItem activiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiActive;
		private System.Windows.Forms.ToolStripMenuItem tsmiNotActive;
		private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmAdd;
	}
}