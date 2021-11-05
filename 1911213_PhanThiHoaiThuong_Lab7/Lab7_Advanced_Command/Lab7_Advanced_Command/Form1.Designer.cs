namespace Lab7_Advanced_Command
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.dgvFoodList = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCatName = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSeperator = new System.Windows.Forms.ToolStripMenuItem();
			this.smAddFood = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(91, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn nhóm món ăn:";
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(224, 21);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(206, 21);
			this.cbbCategory.TabIndex = 1;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// dgvFoodList
			// 
			this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvFoodList.Location = new System.Drawing.Point(0, 55);
			this.dgvFoodList.MultiSelect = false;
			this.dgvFoodList.Name = "dgvFoodList";
			this.dgvFoodList.Size = new System.Drawing.Size(519, 307);
			this.dgvFoodList.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 372);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Có tất cả";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(91, 372);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(16, 15);
			this.lblQuantity.TabIndex = 4;
			this.lblQuantity.Text = "...";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(124, 372);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "món ăn thuộc nhóm";
			// 
			// lblCatName
			// 
			this.lblCatName.AutoSize = true;
			this.lblCatName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCatName.Location = new System.Drawing.Point(253, 373);
			this.lblCatName.Name = "lblCatName";
			this.lblCatName.Size = new System.Drawing.Size(16, 15);
			this.lblCatName.TabIndex = 6;
			this.lblCatName.Text = "...";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmSeperator,
            this.smAddFood,
            this.tsmUpdateFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(214, 92);
			// 
			// tsmCalculateQuantity
			// 
			this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
			this.tsmCalculateQuantity.Size = new System.Drawing.Size(213, 22);
			this.tsmCalculateQuantity.Text = "Tính tổng số lượng đã bán";
			this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
			// 
			// tsmSeperator
			// 
			this.tsmSeperator.Name = "tsmSeperator";
			this.tsmSeperator.Size = new System.Drawing.Size(213, 22);
			this.tsmSeperator.Text = "Seperator";
			// 
			// smAddFood
			// 
			this.smAddFood.Name = "smAddFood";
			this.smAddFood.Size = new System.Drawing.Size(213, 22);
			this.smAddFood.Text = "AddFood";
			// 
			// tsmUpdateFood
			// 
			this.tsmUpdateFood.Name = "tsmUpdateFood";
			this.tsmUpdateFood.Size = new System.Drawing.Size(213, 22);
			this.tsmUpdateFood.Text = "UpdateFood";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 397);
			this.Controls.Add(this.lblCatName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvFoodList);
			this.Controls.Add(this.cbbCategory);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.DataGridView dgvFoodList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCatName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
		private System.Windows.Forms.ToolStripMenuItem tsmSeperator;
		private System.Windows.Forms.ToolStripMenuItem smAddFood;
		private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
	}
}

