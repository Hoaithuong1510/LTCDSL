namespace Demo_01_09_2021
{
	partial class NewsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblPublishedDate = new System.Windows.Forms.Label();
			this.lblDetails = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoEllipsis = true;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Blue;
			this.lblTitle.Location = new System.Drawing.Point(17, 27);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(41, 13);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "label1";
			// 
			// lblDescription
			// 
			this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDescription.AutoEllipsis = true;
			this.lblDescription.Location = new System.Drawing.Point(20, 54);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(411, 67);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "label2";
			// 
			// lblPublishedDate
			// 
			this.lblPublishedDate.AutoSize = true;
			this.lblPublishedDate.Location = new System.Drawing.Point(20, 121);
			this.lblPublishedDate.Name = "lblPublishedDate";
			this.lblPublishedDate.Size = new System.Drawing.Size(35, 13);
			this.lblPublishedDate.TabIndex = 2;
			this.lblPublishedDate.Text = "label3";
			// 
			// lblDetails
			// 
			this.lblDetails.AutoSize = true;
			this.lblDetails.Location = new System.Drawing.Point(376, 121);
			this.lblDetails.Name = "lblDetails";
			this.lblDetails.Size = new System.Drawing.Size(62, 13);
			this.lblDetails.TabIndex = 3;
			this.lblDetails.TabStop = true;
			this.lblDetails.Text = "Xem chi tiết";
			// 
			// NewsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LavenderBlush;
			this.Controls.Add(this.lblDetails);
			this.Controls.Add(this.lblPublishedDate);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTitle);
			this.Name = "NewsControl";
			this.Size = new System.Drawing.Size(469, 145);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblPublishedDate;
		private System.Windows.Forms.LinkLabel lblDetails;
	}
}
