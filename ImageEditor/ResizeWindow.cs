using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor {
	public partial class ResizeWindow : Form {
		public Boolean buttonOKIsClicked = false;
		public event EventHandler ReclickRequest;

		public ResizeWindow() {
			InitializeComponent();
		}

		protected virtual void OnReclickRequest(EventArgs e) {
			EventHandler eh = ReclickRequest;
			if (eh != null)
				eh(this, e);
		}

		public void ButtonOK_Click(object sender, EventArgs e) {
				buttonOKIsClicked = true;
			/*try {
				MainWindow mainWindow = new MainWindow();
				mainWindow.editorFieldPictureBox.Width = Int16.Parse(textBoxWidth.Text);
				mainWindow.editorFieldPictureBox.Height = Int16.Parse(textBoxHeight.Text);
				this.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}*/
			MainWindow mainWindow = new MainWindow();
			mainWindow.pictureBoxEditorField.Width = 300;
			mainWindow.pictureBoxEditorField.Height = 300;;
			this.Close();
		}
	} 
}
