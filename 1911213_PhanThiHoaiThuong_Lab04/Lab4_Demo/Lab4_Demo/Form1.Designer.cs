namespace Lab4_Demo
{
	partial class PictureForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuItemReload = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuItemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuItemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.vScrollBar = new System.Windows.Forms.VScrollBar();
			this.hScrollBar = new System.Windows.Forms.HScrollBar();
			this.tsStatusLabel = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.tsStatusLabel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(849, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsMenuItem1
			// 
			this.tsMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemReload,
            this.tsMenuItemZoomOut,
            this.tsMenuItemZoomIn,
            this.tsMenuItemEdit});
			this.tsMenuItem1.Name = "tsMenuItem1";
			this.tsMenuItem1.Size = new System.Drawing.Size(52, 20);
			this.tsMenuItem1.Text = "Image";
			this.tsMenuItem1.Click += new System.EventHandler(this.tsMenuItem1_Click);
			// 
			// tsMenuItemReload
			// 
			this.tsMenuItemReload.Name = "tsMenuItemReload";
			this.tsMenuItemReload.Size = new System.Drawing.Size(202, 22);
			this.tsMenuItemReload.Text = "Reload";
			this.tsMenuItemReload.Click += new System.EventHandler(this.tsMenuItemReload_Click);
			// 
			// tsMenuItemZoomOut
			// 
			this.tsMenuItemZoomOut.Name = "tsMenuItemZoomOut";
			this.tsMenuItemZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Up)));
			this.tsMenuItemZoomOut.Size = new System.Drawing.Size(202, 22);
			this.tsMenuItemZoomOut.Text = "Zoom +";
			this.tsMenuItemZoomOut.Click += new System.EventHandler(this.tsMenuItemZoomOut_Click);
			// 
			// tsMenuItemZoomIn
			// 
			this.tsMenuItemZoomIn.Name = "tsMenuItemZoomIn";
			this.tsMenuItemZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Down)));
			this.tsMenuItemZoomIn.Size = new System.Drawing.Size(202, 22);
			this.tsMenuItemZoomIn.Text = "Zoom -";
			this.tsMenuItemZoomIn.Click += new System.EventHandler(this.tsMenuItemZoomIn_Click);
			// 
			// tsMenuItemEdit
			// 
			this.tsMenuItemEdit.Name = "tsMenuItemEdit";
			this.tsMenuItemEdit.Size = new System.Drawing.Size(202, 22);
			this.tsMenuItemEdit.Text = "Edit";
			this.tsMenuItemEdit.Click += new System.EventHandler(this.tsMenuItemEdit_Click);
			// 
			// pbHinh
			// 
			this.pbHinh.Location = new System.Drawing.Point(0, 28);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(849, 496);
			this.pbHinh.TabIndex = 2;
			this.pbHinh.TabStop = false;
			// 
			// vScrollBar
			// 
			this.vScrollBar.Location = new System.Drawing.Point(824, 30);
			this.vScrollBar.Name = "vScrollBar";
			this.vScrollBar.Size = new System.Drawing.Size(25, 472);
			this.vScrollBar.TabIndex = 3;
			this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
			// 
			// hScrollBar
			// 
			this.hScrollBar.Location = new System.Drawing.Point(0, 478);
			this.hScrollBar.Name = "hScrollBar";
			this.hScrollBar.Size = new System.Drawing.Size(824, 24);
			this.hScrollBar.TabIndex = 4;
			this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
			// 
			// tsStatusLabel
			// 
			this.tsStatusLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.tsStatusLabel.Location = new System.Drawing.Point(0, 502);
			this.tsStatusLabel.Name = "tsStatusLabel";
			this.tsStatusLabel.Size = new System.Drawing.Size(849, 22);
			this.tsStatusLabel.TabIndex = 5;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
			this.toolStripStatusLabel1.Text = "tsStatusLabel";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// PictureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 524);
			this.Controls.Add(this.tsStatusLabel);
			this.Controls.Add(this.hScrollBar);
			this.Controls.Add(this.vScrollBar);
			this.Controls.Add(this.pbHinh);
			this.Controls.Add(this.menuStrip1);
			this.Name = "PictureForm";
			this.Text = "Picture 0";
			this.Load += new System.EventHandler(this.PictureForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.tsStatusLabel.ResumeLayout(false);
			this.tsStatusLabel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.ToolStripMenuItem tsMenuItem1;
		public System.Windows.Forms.ToolStripMenuItem tsMenuItemReload;
		public System.Windows.Forms.ToolStripMenuItem tsMenuItemZoomOut;
		public System.Windows.Forms.ToolStripMenuItem tsMenuItemZoomIn;
		public System.Windows.Forms.ToolStripMenuItem tsMenuItemEdit;
		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.VScrollBar vScrollBar;
		private System.Windows.Forms.HScrollBar hScrollBar;
		public System.Windows.Forms.StatusStrip tsStatusLabel;
		public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

