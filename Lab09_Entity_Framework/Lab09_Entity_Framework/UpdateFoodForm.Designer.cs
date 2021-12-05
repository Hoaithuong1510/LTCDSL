﻿namespace Lab09_Entity_Framework
{
	partial class UpdateFoodForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtFoodId = new System.Windows.Forms.TextBox();
			this.txtFoodName = new System.Windows.Forms.TextBox();
			this.txtFoodUnit = new System.Windows.Forms.TextBox();
			this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
			this.nudFoodPrice = new System.Windows.Forms.NumericUpDown();
			this.txtFoodNotes = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên món ăn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thuộc danh mục";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Đơn vị tính";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Đơn giá";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ghi chú khác";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(338, 251);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Thoát";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(257, 251);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "&Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtFoodId
			// 
			this.txtFoodId.Location = new System.Drawing.Point(122, 13);
			this.txtFoodId.Name = "txtFoodId";
			this.txtFoodId.ReadOnly = true;
			this.txtFoodId.Size = new System.Drawing.Size(100, 20);
			this.txtFoodId.TabIndex = 8;
			// 
			// txtFoodName
			// 
			this.txtFoodName.Location = new System.Drawing.Point(122, 40);
			this.txtFoodName.Name = "txtFoodName";
			this.txtFoodName.Size = new System.Drawing.Size(291, 20);
			this.txtFoodName.TabIndex = 9;
			// 
			// txtFoodUnit
			// 
			this.txtFoodUnit.Location = new System.Drawing.Point(122, 99);
			this.txtFoodUnit.Name = "txtFoodUnit";
			this.txtFoodUnit.Size = new System.Drawing.Size(291, 20);
			this.txtFoodUnit.TabIndex = 10;
			// 
			// cbbFoodCategory
			// 
			this.cbbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbFoodCategory.FormattingEnabled = true;
			this.cbbFoodCategory.Location = new System.Drawing.Point(122, 69);
			this.cbbFoodCategory.Name = "cbbFoodCategory";
			this.cbbFoodCategory.Size = new System.Drawing.Size(291, 21);
			this.cbbFoodCategory.TabIndex = 11;
			// 
			// nudFoodPrice
			// 
			this.nudFoodPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.nudFoodPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudFoodPrice.Location = new System.Drawing.Point(122, 132);
			this.nudFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.nudFoodPrice.Name = "nudFoodPrice";
			this.nudFoodPrice.Size = new System.Drawing.Size(291, 20);
			this.nudFoodPrice.TabIndex = 12;
			this.nudFoodPrice.ThousandsSeparator = true;
			// 
			// txtFoodNotes
			// 
			this.txtFoodNotes.Location = new System.Drawing.Point(122, 158);
			this.txtFoodNotes.Name = "txtFoodNotes";
			this.txtFoodNotes.Size = new System.Drawing.Size(291, 71);
			this.txtFoodNotes.TabIndex = 13;
			this.txtFoodNotes.Text = "";
			// 
			// UpdateFoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 286);
			this.Controls.Add(this.txtFoodNotes);
			this.Controls.Add(this.nudFoodPrice);
			this.Controls.Add(this.cbbFoodCategory);
			this.Controls.Add(this.txtFoodUnit);
			this.Controls.Add(this.txtFoodName);
			this.Controls.Add(this.txtFoodId);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UpdateFoodForm";
			this.Text = "UpdateFoodForm";
			this.Load += new System.EventHandler(this.UpdateFoodForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtFoodId;
		private System.Windows.Forms.TextBox txtFoodName;
		private System.Windows.Forms.TextBox txtFoodUnit;
		private System.Windows.Forms.ComboBox cbbFoodCategory;
		private System.Windows.Forms.NumericUpDown nudFoodPrice;
		private System.Windows.Forms.RichTextBox txtFoodNotes;
	}
}