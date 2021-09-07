namespace Ex8
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
			this.btnButton = new System.Windows.Forms.Button();
			this.btnButtonFlat = new System.Windows.Forms.Button();
			this.ckbMauChu = new System.Windows.Forms.CheckBox();
			this.ckbMauNen = new System.Windows.Forms.CheckBox();
			this.rdFlat = new System.Windows.Forms.RadioButton();
			this.rdPopup = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnButton
			// 
			this.btnButton.CausesValidation = false;
			this.btnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnButton.ForeColor = System.Drawing.Color.Red;
			this.btnButton.Location = new System.Drawing.Point(24, 49);
			this.btnButton.Name = "btnButton";
			this.btnButton.Size = new System.Drawing.Size(84, 23);
			this.btnButton.TabIndex = 0;
			this.btnButton.Text = "Button";
			this.btnButton.UseVisualStyleBackColor = true;
			// 
			// btnButtonFlat
			// 
			this.btnButtonFlat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnButtonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnButtonFlat.ForeColor = System.Drawing.Color.Black;
			this.btnButtonFlat.Location = new System.Drawing.Point(24, 123);
			this.btnButtonFlat.Name = "btnButtonFlat";
			this.btnButtonFlat.Size = new System.Drawing.Size(84, 23);
			this.btnButtonFlat.TabIndex = 1;
			this.btnButtonFlat.Text = "Button Flat";
			this.btnButtonFlat.UseVisualStyleBackColor = true;
			// 
			// ckbMauChu
			// 
			this.ckbMauChu.AutoSize = true;
			this.ckbMauChu.Location = new System.Drawing.Point(161, 31);
			this.ckbMauChu.Name = "ckbMauChu";
			this.ckbMauChu.Size = new System.Drawing.Size(112, 17);
			this.ckbMauChu.TabIndex = 2;
			this.ckbMauChu.Text = "Thay đổi màu chữ";
			this.ckbMauChu.UseVisualStyleBackColor = true;
			this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
			// 
			// ckbMauNen
			// 
			this.ckbMauNen.AutoSize = true;
			this.ckbMauNen.Location = new System.Drawing.Point(161, 68);
			this.ckbMauNen.Name = "ckbMauNen";
			this.ckbMauNen.Size = new System.Drawing.Size(112, 17);
			this.ckbMauNen.TabIndex = 3;
			this.ckbMauNen.Text = "Thay đổi màu nền";
			this.ckbMauNen.UseVisualStyleBackColor = true;
			this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
			// 
			// rdFlat
			// 
			this.rdFlat.AutoSize = true;
			this.rdFlat.Location = new System.Drawing.Point(161, 107);
			this.rdFlat.Name = "rdFlat";
			this.rdFlat.Size = new System.Drawing.Size(66, 17);
			this.rdFlat.TabIndex = 4;
			this.rdFlat.TabStop = true;
			this.rdFlat.Text = "Kiểu Flat";
			this.rdFlat.UseVisualStyleBackColor = true;
			this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
			// 
			// rdPopup
			// 
			this.rdPopup.AutoSize = true;
			this.rdPopup.Location = new System.Drawing.Point(161, 144);
			this.rdPopup.Name = "rdPopup";
			this.rdPopup.Size = new System.Drawing.Size(80, 17);
			this.rdPopup.TabIndex = 5;
			this.rdPopup.TabStop = true;
			this.rdPopup.Text = "Kiểu Popup";
			this.rdPopup.UseVisualStyleBackColor = true;
			this.rdPopup.CheckedChanged += new System.EventHandler(this.rdPopup_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.rdPopup);
			this.Controls.Add(this.rdFlat);
			this.Controls.Add(this.ckbMauNen);
			this.Controls.Add(this.ckbMauChu);
			this.Controls.Add(this.btnButtonFlat);
			this.Controls.Add(this.btnButton);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kiểu flat";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnButton;
		private System.Windows.Forms.Button btnButtonFlat;
		private System.Windows.Forms.CheckBox ckbMauChu;
		private System.Windows.Forms.CheckBox ckbMauNen;
		private System.Windows.Forms.RadioButton rdFlat;
		private System.Windows.Forms.RadioButton rdPopup;
	}
}

