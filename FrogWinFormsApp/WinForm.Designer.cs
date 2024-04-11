namespace FrogWinFormsApp
{
	partial class WinForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.winLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FrogWinFormsApp.Properties.Resources._115450386_80e5d380_a224_11eb_8ea8_5d0187aafd06;
			this.pictureBox1.Location = new System.Drawing.Point(0, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(202, 167);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// winLabel
			// 
			this.winLabel.AutoSize = true;
			this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.winLabel.Location = new System.Drawing.Point(12, 231);
			this.winLabel.Name = "winLabel";
			this.winLabel.Size = new System.Drawing.Size(53, 20);
			this.winLabel.TabIndex = 1;
			this.winLabel.Text = "label1";
			this.winLabel.Click += new System.EventHandler(this.winLabel_Click);
			// 
			// WinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 343);
			this.Controls.Add(this.winLabel);
			this.Controls.Add(this.pictureBox1);
			this.Name = "WinForm";
			this.Text = "WinForm";
			this.Load += new System.EventHandler(this.WinForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label winLabel;
	}
}