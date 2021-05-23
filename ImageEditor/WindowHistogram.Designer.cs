
namespace ImageEditor {
	partial class WindowHistogram {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.radioButtonRed = new System.Windows.Forms.RadioButton();
			this.radioButtonGreen = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.imageBoxR = new Emgu.CV.UI.ImageBox();
			this.imageBoxG = new Emgu.CV.UI.ImageBox();
			this.imageBoxB = new Emgu.CV.UI.ImageBox();
			this.histogramBox = new Emgu.CV.UI.HistogramBox();
			this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
			this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButtonRed
			// 
			this.radioButtonRed.AutoSize = true;
			this.radioButtonRed.Location = new System.Drawing.Point(878, 27);
			this.radioButtonRed.Name = "radioButtonRed";
			this.radioButtonRed.Size = new System.Drawing.Size(40, 17);
			this.radioButtonRed.TabIndex = 1;
			this.radioButtonRed.TabStop = true;
			this.radioButtonRed.Text = "red";
			this.radioButtonRed.UseVisualStyleBackColor = true;
			// 
			// radioButtonGreen
			// 
			this.radioButtonGreen.AutoSize = true;
			this.radioButtonGreen.Location = new System.Drawing.Point(878, 50);
			this.radioButtonGreen.Name = "radioButtonGreen";
			this.radioButtonGreen.Size = new System.Drawing.Size(52, 17);
			this.radioButtonGreen.TabIndex = 2;
			this.radioButtonGreen.TabStop = true;
			this.radioButtonGreen.Text = "green";
			this.radioButtonGreen.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(878, 73);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(45, 17);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "blue";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// imageBoxR
			// 
			this.imageBoxR.Location = new System.Drawing.Point(110, 12);
			this.imageBoxR.Name = "imageBoxR";
			this.imageBoxR.Size = new System.Drawing.Size(150, 300);
			this.imageBoxR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imageBoxR.TabIndex = 2;
			this.imageBoxR.TabStop = false;
			// 
			// imageBoxG
			// 
			this.imageBoxG.Location = new System.Drawing.Point(370, 12);
			this.imageBoxG.Name = "imageBoxG";
			this.imageBoxG.Size = new System.Drawing.Size(150, 300);
			this.imageBoxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imageBoxG.TabIndex = 4;
			this.imageBoxG.TabStop = false;
			// 
			// imageBoxB
			// 
			this.imageBoxB.Location = new System.Drawing.Point(630, 12);
			this.imageBoxB.Name = "imageBoxB";
			this.imageBoxB.Size = new System.Drawing.Size(150, 300);
			this.imageBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imageBoxB.TabIndex = 5;
			this.imageBoxB.TabStop = false;
			// 
			// histogramBox
			// 
			this.histogramBox.Location = new System.Drawing.Point(12, 246);
			this.histogramBox.Name = "histogramBox";
			this.histogramBox.Size = new System.Drawing.Size(713, 623);
			this.histogramBox.TabIndex = 6;
			// 
			// histogramBox2
			// 
			this.histogramBox2.Location = new System.Drawing.Point(706, 510);
			this.histogramBox2.Name = "histogramBox2";
			this.histogramBox2.Size = new System.Drawing.Size(250, 250);
			this.histogramBox2.TabIndex = 7;
			// 
			// histogramBox3
			// 
			this.histogramBox3.Location = new System.Drawing.Point(530, 334);
			this.histogramBox3.Name = "histogramBox3";
			this.histogramBox3.Size = new System.Drawing.Size(250, 250);
			this.histogramBox3.TabIndex = 8;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(936, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 400);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// WindowHistogram
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 881);
			this.Controls.Add(this.histogramBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.histogramBox3);
			this.Controls.Add(this.histogramBox2);
			this.Controls.Add(this.imageBoxB);
			this.Controls.Add(this.imageBoxG);
			this.Controls.Add(this.imageBoxR);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.radioButtonGreen);
			this.Controls.Add(this.radioButtonRed);
			this.Name = "WindowHistogram";
			this.Text = "WindowHistogram";
			((System.ComponentModel.ISupportInitialize)(this.imageBoxR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageBoxB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton radioButtonRed;
		private System.Windows.Forms.RadioButton radioButtonGreen;
		private System.Windows.Forms.RadioButton radioButton1;
		public System.Windows.Forms.PictureBox pictureBox1;
		public Emgu.CV.UI.ImageBox imageBoxR;
		public Emgu.CV.UI.ImageBox imageBoxG;
		public Emgu.CV.UI.ImageBox imageBoxB;
		public Emgu.CV.UI.HistogramBox histogramBox;
		public Emgu.CV.UI.HistogramBox histogramBox2;
		public Emgu.CV.UI.HistogramBox histogramBox3;
	}
}