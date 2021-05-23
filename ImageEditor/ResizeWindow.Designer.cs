
namespace ImageEditor {
	partial class ResizeWindow {
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
			this.buttonOK = new System.Windows.Forms.Button();
			this.checkBoxMantainAspectRatio = new System.Windows.Forms.CheckBox();
			this.labelHeight = new System.Windows.Forms.Label();
			this.textBoxHeight = new System.Windows.Forms.TextBox();
			this.labelWidth = new System.Windows.Forms.Label();
			this.textBoxWidth = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(164, 71);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// checkBoxMantainAspectRatio
			// 
			this.checkBoxMantainAspectRatio.AutoSize = true;
			this.checkBoxMantainAspectRatio.Location = new System.Drawing.Point(10, 75);
			this.checkBoxMantainAspectRatio.Name = "checkBoxMantainAspectRatio";
			this.checkBoxMantainAspectRatio.Size = new System.Drawing.Size(123, 17);
			this.checkBoxMantainAspectRatio.TabIndex = 10;
			this.checkBoxMantainAspectRatio.Text = "maintain aspect ratio";
			this.checkBoxMantainAspectRatio.UseVisualStyleBackColor = true;
			// 
			// labelHeight
			// 
			this.labelHeight.AutoSize = true;
			this.labelHeight.Location = new System.Drawing.Point(10, 43);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new System.Drawing.Size(36, 13);
			this.labelHeight.TabIndex = 9;
			this.labelHeight.Text = "height";
			// 
			// textBoxHeight
			// 
			this.textBoxHeight.Location = new System.Drawing.Point(92, 40);
			this.textBoxHeight.Name = "textBoxHeight";
			this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
			this.textBoxHeight.TabIndex = 8;
			// 
			// labelWidth
			// 
			this.labelWidth.AutoSize = true;
			this.labelWidth.Location = new System.Drawing.Point(10, 15);
			this.labelWidth.Name = "labelWidth";
			this.labelWidth.Size = new System.Drawing.Size(32, 13);
			this.labelWidth.TabIndex = 7;
			this.labelWidth.Text = "width";
			// 
			// textBoxWidth
			// 
			this.textBoxWidth.Location = new System.Drawing.Point(92, 12);
			this.textBoxWidth.Name = "textBoxWidth";
			this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
			this.textBoxWidth.TabIndex = 6;
			// 
			// ResizeWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(251, 107);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkBoxMantainAspectRatio);
			this.Controls.Add(this.labelHeight);
			this.Controls.Add(this.textBoxHeight);
			this.Controls.Add(this.labelWidth);
			this.Controls.Add(this.textBoxWidth);
			this.Name = "ResizeWindow";
			this.Text = "resize an editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.CheckBox checkBoxMantainAspectRatio;
		private System.Windows.Forms.Label labelHeight;
		public System.Windows.Forms.TextBox textBoxHeight;
		private System.Windows.Forms.Label labelWidth;
		public System.Windows.Forms.TextBox textBoxWidth;
		public System.Windows.Forms.Button buttonOK;
	}
}