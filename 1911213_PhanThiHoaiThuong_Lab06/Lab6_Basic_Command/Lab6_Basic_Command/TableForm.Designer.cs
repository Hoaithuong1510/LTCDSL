namespace Lab6_Basic_Command
{
	partial class TableForm
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
			this.tsmDeleteTable = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmBill = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmBillDiary = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvTable = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeleteTable,
            this.tsmBill,
            this.tsmBillDiary});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(203, 92);
			// 
			// tsmDeleteTable
			// 
			this.tsmDeleteTable.Name = "tsmDeleteTable";
			this.tsmDeleteTable.Size = new System.Drawing.Size(202, 22);
			this.tsmDeleteTable.Text = "Xóa bàn";
			this.tsmDeleteTable.Click += new System.EventHandler(this.tsmDeleteTable_Click);
			// 
			// tsmBill
			// 
			this.tsmBill.Name = "tsmBill";
			this.tsmBill.Size = new System.Drawing.Size(202, 22);
			this.tsmBill.Text = "Xem danh mục hóa đơn";
			this.tsmBill.Click += new System.EventHandler(this.tsmBill_Click);
			// 
			// tsmBillDiary
			// 
			this.tsmBillDiary.Name = "tsmBillDiary";
			this.tsmBillDiary.Size = new System.Drawing.Size(202, 22);
			this.tsmBillDiary.Text = "Xem nhật ký hóa đơn";
			this.tsmBillDiary.Click += new System.EventHandler(this.tsmBillDiary_Click);
			// 
			// dgvTable
			// 
			this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTable.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvTable.Location = new System.Drawing.Point(-6, 31);
			this.dgvTable.Name = "dgvTable";
			this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTable.Size = new System.Drawing.Size(749, 377);
			this.dgvTable.TabIndex = 3;
			// 
			// TableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 407);
			this.Controls.Add(this.dgvTable);
			this.Name = "TableForm";
			this.Text = "TableForm";
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmDeleteTable;
		private System.Windows.Forms.ToolStripMenuItem tsmBill;
		private System.Windows.Forms.ToolStripMenuItem tsmBillDiary;
		private System.Windows.Forms.DataGridView dgvTable;
	}
}