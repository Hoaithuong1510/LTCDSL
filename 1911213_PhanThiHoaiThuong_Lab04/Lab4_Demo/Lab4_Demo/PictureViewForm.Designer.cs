namespace Lab4_Demo
{
	partial class PictureViewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureViewForm));
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.paintToolStrip = new System.Windows.Forms.ToolStripButton();
			this.zoomOutToolStrip = new System.Windows.Forms.ToolStripButton();
			this.zoomInToolStrip = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.minimizeAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maximizeAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arrangeVerticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.arrangeHorizontalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arrangeIconsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLayout = new System.Windows.Forms.ToolStripMenuItem();
			this.cascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
			this.toolStripStatusLabel1.Text = "Tổng số form con: 0";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 505);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(847, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// paintToolStrip
			// 
			this.paintToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.paintToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("paintToolStrip.Image")));
			this.paintToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.paintToolStrip.Name = "paintToolStrip";
			this.paintToolStrip.Size = new System.Drawing.Size(23, 22);
			this.paintToolStrip.Text = "toolStripButton3";
			this.paintToolStrip.Click += new System.EventHandler(this.paintToolStrip_Click);
			// 
			// zoomOutToolStrip
			// 
			this.zoomOutToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStrip.Image")));
			this.zoomOutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutToolStrip.Name = "zoomOutToolStrip";
			this.zoomOutToolStrip.Size = new System.Drawing.Size(23, 22);
			this.zoomOutToolStrip.Text = "toolStripButton2";
			this.zoomOutToolStrip.Click += new System.EventHandler(this.zoomOutToolStrip_Click);
			// 
			// zoomInToolStrip
			// 
			this.zoomInToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStrip.Image")));
			this.zoomInToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInToolStrip.Name = "zoomInToolStrip";
			this.zoomInToolStrip.Size = new System.Drawing.Size(23, 22);
			this.zoomInToolStrip.Text = "toolStripButton1";
			this.zoomInToolStrip.Click += new System.EventHandler(this.zoomInToolStrip_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStrip,
            this.zoomOutToolStrip,
            this.paintToolStrip});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(847, 25);
			this.toolStrip1.TabIndex = 13;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// minimizeAllMenuItem
			// 
			this.minimizeAllMenuItem.Name = "minimizeAllMenuItem";
			this.minimizeAllMenuItem.Size = new System.Drawing.Size(174, 22);
			this.minimizeAllMenuItem.Text = "Mi&nimize All";
			this.minimizeAllMenuItem.Click += new System.EventHandler(this.minimizeAllMenuItem_Click);
			// 
			// maximizeAllMenuItem
			// 
			this.maximizeAllMenuItem.Name = "maximizeAllMenuItem";
			this.maximizeAllMenuItem.Size = new System.Drawing.Size(174, 22);
			this.maximizeAllMenuItem.Text = "Ma&ximize All";
			this.maximizeAllMenuItem.Click += new System.EventHandler(this.maximizeAllMenuItem_Click);
			// 
			// arrangeVerticalMenuItem
			// 
			this.arrangeVerticalMenuItem.Name = "arrangeVerticalMenuItem";
			this.arrangeVerticalMenuItem.Size = new System.Drawing.Size(174, 22);
			this.arrangeVerticalMenuItem.Text = "Arrange &Vertical";
			this.arrangeVerticalMenuItem.Click += new System.EventHandler(this.arrangeVerticalMenuItem_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png";
			// 
			// arrangeHorizontalMenuItem
			// 
			this.arrangeHorizontalMenuItem.Name = "arrangeHorizontalMenuItem";
			this.arrangeHorizontalMenuItem.Size = new System.Drawing.Size(174, 22);
			this.arrangeHorizontalMenuItem.Text = "Arrange &Horizontal";
			this.arrangeHorizontalMenuItem.Click += new System.EventHandler(this.arrangeHorizontalMenuItem_Click);
			// 
			// arrangeIconsMenuItem
			// 
			this.arrangeIconsMenuItem.Name = "arrangeIconsMenuItem";
			this.arrangeIconsMenuItem.Size = new System.Drawing.Size(174, 22);
			this.arrangeIconsMenuItem.Text = "Arrange&Icons";
			this.arrangeIconsMenuItem.Click += new System.EventHandler(this.arrangeIconsMenuItem_Click);
			// 
			// menuLayout
			// 
			this.menuLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsMenuItem,
            this.cascadeMenuItem,
            this.arrangeHorizontalMenuItem,
            this.arrangeVerticalMenuItem,
            this.maximizeAllMenuItem,
            this.minimizeAllMenuItem});
			this.menuLayout.Name = "menuLayout";
			this.menuLayout.Size = new System.Drawing.Size(55, 20);
			this.menuLayout.Text = "Layout";
			// 
			// cascadeMenuItem
			// 
			this.cascadeMenuItem.Name = "cascadeMenuItem";
			this.cascadeMenuItem.Size = new System.Drawing.Size(174, 22);
			this.cascadeMenuItem.Text = "&Cascade";
			this.cascadeMenuItem.Click += new System.EventHandler(this.cascadeMenuItem_Click);
			// 
			// toolStripMenuItem
			// 
			this.toolStripMenuItem.Checked = true;
			this.toolStripMenuItem.CheckOnClick = true;
			this.toolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItem.Name = "toolStripMenuItem";
			this.toolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem.Text = "ToolStrip";
			this.toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
			// 
			// statusStripMenuItem
			// 
			this.statusStripMenuItem.Checked = true;
			this.statusStripMenuItem.CheckOnClick = true;
			this.statusStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.statusStripMenuItem.Name = "statusStripMenuItem";
			this.statusStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.statusStripMenuItem.Text = "StatusStrip";
			this.statusStripMenuItem.Click += new System.EventHandler(this.statusStripMenuItem_Click);
			// 
			// menuView
			// 
			this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripMenuItem,
            this.toolStripMenuItem});
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(44, 20);
			this.menuView.Text = "View";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitMenuItem.Text = "Exit";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// saveAsMenuItem
			// 
			this.saveAsMenuItem.Name = "saveAsMenuItem";
			this.saveAsMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveAsMenuItem.Text = "Save As";
			this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
			// 
			// newMenuItem
			// 
			this.newMenuItem.Name = "newMenuItem";
			this.newMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newMenuItem.Text = "New";
			this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.saveAsMenuItem,
            this.exitMenuItem});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuLayout});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(847, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// PictureViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 527);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.Name = "PictureViewForm";
			this.Text = "PictureViewForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripButton paintToolStrip;
		private System.Windows.Forms.ToolStripButton zoomOutToolStrip;
		private System.Windows.Forms.ToolStripButton zoomInToolStrip;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem minimizeAllMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maximizeAllMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arrangeVerticalMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem arrangeHorizontalMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arrangeIconsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuLayout;
		private System.Windows.Forms.ToolStripMenuItem cascadeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuView;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}