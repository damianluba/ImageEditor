
namespace ImageEditor {
	partial class RotateEditorWindow {
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
			this.widthLabel = new System.Windows.Forms.Label();
			this.rotationAngleTextBox = new System.Windows.Forms.TextBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(9, 10);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(33, 13);
			this.widthLabel.TabIndex = 11;
			this.widthLabel.Text = "angle";
			// 
			// rotationAngleTextBox
			// 
			this.rotationAngleTextBox.Location = new System.Drawing.Point(91, 7);
			this.rotationAngleTextBox.Name = "rotationAngleTextBox";
			this.rotationAngleTextBox.Size = new System.Drawing.Size(47, 20);
			this.rotationAngleTextBox.TabIndex = 10;
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(56, 40);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(82, 23);
			this.OKButton.TabIndex = 9;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			// 
			// RotateEditorWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(157, 75);
			this.Controls.Add(this.widthLabel);
			this.Controls.Add(this.rotationAngleTextBox);
			this.Controls.Add(this.OKButton);
			this.Name = "RotateEditorWindow";
			this.Text = "rotate your image";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label widthLabel;
		public System.Windows.Forms.TextBox rotationAngleTextBox;
		public System.Windows.Forms.Button OKButton;
	}
}