using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEditor {
	public partial class WindowHistogram : Form {
		/*public Image<Bgr, byte> inputImage;
		Image<Gray, byte> R, G, B;*/
		public Bitmap bitmap=new Bitmap(1000, 500);

		public WindowHistogram() {
			InitializeComponent();
			//bitmap = (Bitmap)pictureBox1.Image;
			//inputImage = new Image<Bgr, byte>(bitmap);
			/*B = inputImage[0];
			G = inputImage[1];
			R = inputImage[2];*/
/*
			imageBoxR.Image = R;
			imageBoxG.Image = G;
			imageBoxB.Image = B;

			histogramBox1.GenerateHistograms(R, 256);
			histogramBox2.GenerateHistograms(G, 256);
			histogramBox3.GenerateHistograms(B, 256);
			histogramBox1.Refresh();*/
		}



	}
}