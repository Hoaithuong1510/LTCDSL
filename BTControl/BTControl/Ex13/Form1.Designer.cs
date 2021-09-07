namespace Ex13
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
			this.pcbImage = new System.Windows.Forms.PictureBox();
			this.cbImage = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pcbImage
			// 
			this.pcbImage.Location = new System.Drawing.Point(181, 46);
			this.pcbImage.Name = "pcbImage";
			this.pcbImage.Size = new System.Drawing.Size(548, 203);
			this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbImage.TabIndex = 0;
			this.pcbImage.TabStop = false;
			// 
			// cbImage
			// 
			this.cbImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbImage.FormattingEnabled = true;
			this.cbImage.Location = new System.Drawing.Point(26, 46);
			this.cbImage.Name = "cbImage";
			this.cbImage.Size = new System.Drawing.Size(121, 21);
			this.cbImage.TabIndex = 1;
			this.cbImage.SelectedValueChanged += new System.EventHandler(this.cbImage_SelectedValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 261);
			this.Controls.Add(this.cbImage);
			this.Controls.Add(this.pcbImage);
			this.Name = "Form1";
			this.Text = "Demo PictureBox";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbImage;
		private System.Windows.Forms.ComboBox cbImage;
	}
}

