namespace Lab6_Basic_Command
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.lvCategory = new System.Windows.Forms.ListView();
			this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBill = new System.Windows.Forms.Button();
			this.btnTaiKhoan = new System.Windows.Forms.Button();
			this.btnTable = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoad.Location = new System.Drawing.Point(12, 112);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(99, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Lấy danh sách";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lvCategory
			// 
			this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
			this.lvCategory.ContextMenuStrip = this.contextMenuStrip1;
			this.lvCategory.FullRowSelect = true;
			this.lvCategory.Location = new System.Drawing.Point(12, 141);
			this.lvCategory.MultiSelect = false;
			this.lvCategory.Name = "lvCategory";
			this.lvCategory.Size = new System.Drawing.Size(595, 311);
			this.lvCategory.TabIndex = 1;
			this.lvCategory.UseCompatibleStateImageBehavior = false;
			this.lvCategory.View = System.Windows.Forms.View.Details;
			this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
			// 
			// chID
			// 
			this.chID.Text = "Mã Loại";
			this.chID.Width = 112;
			// 
			// chName
			// 
			this.chName.Text = "Tên loại món ăn";
			this.chName.Width = 376;
			// 
			// chType
			// 
			this.chType.Text = "Loại";
			this.chType.Width = 127;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
			// 
			// tsmDelete
			// 
			this.tsmDelete.Name = "tsmDelete";
			this.tsmDelete.Size = new System.Drawing.Size(199, 22);
			this.tsmDelete.Text = "Xoá nhóm sản phẩm";
			this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
			// 
			// tsmViewFood
			// 
			this.tsmViewFood.Name = "tsmViewFood";
			this.tsmViewFood.Size = new System.Drawing.Size(199, 22);
			this.tsmViewFood.Text = "Xem danh sách món ăn";
			this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã nhóm:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tên nhóm thức ăn:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Loại:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(130, 13);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(271, 20);
			this.txtID.TabIndex = 5;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(130, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(271, 20);
			this.txtName.TabIndex = 6;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(130, 70);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(271, 20);
			this.txtType.TabIndex = 7;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(240, 112);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(80, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(371, 112);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(99, 23);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(527, 112);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(80, 23);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Xoá";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnBill
			// 
			this.btnBill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBill.Location = new System.Drawing.Point(230, 461);
			this.btnBill.Name = "btnBill";
			this.btnBill.Size = new System.Drawing.Size(99, 23);
			this.btnBill.TabIndex = 11;
			this.btnBill.Text = "Xem hoá đơn";
			this.btnBill.UseVisualStyleBackColor = true;
			this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
			// 
			// btnTaiKhoan
			// 
			this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaiKhoan.Location = new System.Drawing.Point(371, 461);
			this.btnTaiKhoan.Name = "btnTaiKhoan";
			this.btnTaiKhoan.Size = new System.Drawing.Size(99, 23);
			this.btnTaiKhoan.TabIndex = 12;
			this.btnTaiKhoan.Text = "Xem tài khoản";
			this.btnTaiKhoan.UseVisualStyleBackColor = true;
			this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
			// 
			// btnTable
			// 
			this.btnTable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTable.Location = new System.Drawing.Point(508, 461);
			this.btnTable.Name = "btnTable";
			this.btnTable.Size = new System.Drawing.Size(99, 23);
			this.btnTable.TabIndex = 13;
			this.btnTable.Text = "Xem bàn";
			this.btnTable.UseVisualStyleBackColor = true;
			this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 496);
			this.Controls.Add(this.btnTable);
			this.Controls.Add(this.btnTaiKhoan);
			this.Controls.Add(this.btnBill);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvCategory);
			this.Controls.Add(this.btnLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ListView lvCategory;
		private System.Windows.Forms.ColumnHeader chID;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
		private System.Windows.Forms.Button btnBill;
		private System.Windows.Forms.Button btnTaiKhoan;
		private System.Windows.Forms.Button btnTable;
	}
}

