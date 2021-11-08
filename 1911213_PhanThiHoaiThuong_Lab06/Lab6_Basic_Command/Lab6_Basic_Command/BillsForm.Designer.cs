namespace Lab6_Basic_Command
{
	partial class BillsForm
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
			this.dgvHoaDon = new System.Windows.Forms.DataGridView();
			this.btnFind = new System.Windows.Forms.Button();
			this.dtpEnd = new System.Windows.Forms.DateTimePicker();
			this.dtpStart = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHoaDon
			// 
			this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHoaDon.Location = new System.Drawing.Point(0, 45);
			this.dgvHoaDon.Name = "dgvHoaDon";
			this.dgvHoaDon.ReadOnly = true;
			this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHoaDon.Size = new System.Drawing.Size(775, 374);
			this.dgvHoaDon.TabIndex = 1;
			this.dgvHoaDon.DoubleClick += new System.EventHandler(this.dgvHoaDon_DoubleClick);
			// 
			// btnFind
			// 
			this.btnFind.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(544, 10);
			this.btnFind.Margin = new System.Windows.Forms.Padding(2);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(62, 27);
			this.btnFind.TabIndex = 10;
			this.btnFind.Text = "Tìm";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// dtpEnd
			// 
			this.dtpEnd.CustomFormat = "MM/dd/yyyy";
			this.dtpEnd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEnd.Location = new System.Drawing.Point(311, 10);
			this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
			this.dtpEnd.Name = "dtpEnd";
			this.dtpEnd.Size = new System.Drawing.Size(151, 25);
			this.dtpEnd.TabIndex = 9;
			// 
			// dtpStart
			// 
			this.dtpStart.CustomFormat = "MM/dd/yyyy";
			this.dtpStart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStart.Location = new System.Drawing.Point(86, 11);
			this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.Size = new System.Drawing.Size(151, 25);
			this.dtpStart.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(258, 15);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Đến:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Từ: ";
			// 
			// BillsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 421);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.dtpEnd);
			this.Controls.Add(this.dtpStart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvHoaDon);
			this.Name = "BillsForm";
			this.Text = "BillsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvHoaDon;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.DateTimePicker dtpEnd;
		private System.Windows.Forms.DateTimePicker dtpStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}