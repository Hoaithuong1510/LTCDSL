﻿namespace Lab7_Advanced_Command
{
	partial class foodInfoForm
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
			this.txtFoodID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.cbbCatName = new System.Windows.Forms.ComboBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.btnUpdateFood = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "FoodID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Unit";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "CategoryName";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(14, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Notes";
			// 
			// txtFoodID
			// 
			this.txtFoodID.Location = new System.Drawing.Point(131, 13);
			this.txtFoodID.Name = "txtFoodID";
			this.txtFoodID.ReadOnly = true;
			this.txtFoodID.Size = new System.Drawing.Size(100, 20);
			this.txtFoodID.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(131, 46);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(359, 20);
			this.txtName.TabIndex = 7;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(131, 78);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(359, 20);
			this.txtUnit.TabIndex = 8;
			// 
			// cbbCatName
			// 
			this.cbbCatName.FormattingEnabled = true;
			this.cbbCatName.Location = new System.Drawing.Point(131, 116);
			this.cbbCatName.Name = "cbbCatName";
			this.cbbCatName.Size = new System.Drawing.Size(269, 21);
			this.cbbCatName.TabIndex = 9;
			// 
			// btnAddNew
			// 
			this.btnAddNew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNew.Location = new System.Drawing.Point(415, 113);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(75, 23);
			this.btnAddNew.TabIndex = 10;
			this.btnAddNew.Text = "Add &New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(131, 147);
			this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(359, 20);
			this.nudPrice.TabIndex = 16;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(131, 174);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(359, 20);
			this.txtNotes.TabIndex = 17;
			// 
			// btnAddFood
			// 
			this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddFood.Location = new System.Drawing.Point(156, 203);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(75, 23);
			this.btnAddFood.TabIndex = 18;
			this.btnAddFood.Text = "&Add ";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// btnUpdateFood
			// 
			this.btnUpdateFood.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateFood.Location = new System.Drawing.Point(290, 203);
			this.btnUpdateFood.Name = "btnUpdateFood";
			this.btnUpdateFood.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateFood.TabIndex = 19;
			this.btnUpdateFood.Text = "&Update";
			this.btnUpdateFood.UseVisualStyleBackColor = true;
			this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(415, 203);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// foodInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 238);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdateFood);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.cbbCatName);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtFoodID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "foodInfoForm";
			this.Text = "foodInfoForm";
			this.Load += new System.EventHandler(this.foodInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
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
		private System.Windows.Forms.TextBox txtFoodID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.ComboBox cbbCatName;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.NumericUpDown nudPrice;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Button btnUpdateFood;
		private System.Windows.Forms.Button btnCancel;
	}
}