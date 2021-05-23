using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ImageEditor {
	public partial class MainWindow : Form {
		FIP.FIP fip = new FIP.FIP();
		double aspectRatio, zoom, maxWidthEditorField, maxHeightEditorField;
		ResizeWindow resizeWindow = new ResizeWindow();
		RotateEditorWindow rotateEditorWindow;
		Bitmap editedBitmap, bitmap, tempBitmap;
		public Image originalImage, tempImage;

		public MainWindow() {
			InitializeComponent();
			maxWidthEditorField = (double)pictureBoxEditorField.Width;
			maxHeightEditorField = (double)pictureBoxEditorField.Height;
		}

		private void MaintainAspectRatio() {
			aspectRatio = (double)originalImage.Width / (double)originalImage.Height;
			maxWidthEditorField = pictureBoxEditorField.Width;
			tempBitmap = new Bitmap(originalImage, (int)((double)pictureBoxEditorField.Height * aspectRatio), pictureBoxEditorField.Height);
			pictureBoxEditorField.Width = tempBitmap.Width;
			pictureBoxEditorField.Image = tempBitmap;
		}

		private void ButtonFilter_Click(object sender, EventArgs e) {
			Bitmap median = fip.ImageMedianFilterColor(bitmap, 5); // Median filtration with mask size 5;
			pictureBoxEditorField.Image = median;
		}

		private void PictureBoxEditorField_Click(object sender, EventArgs e) {

		}

		private void ToolStripMenuItemOpen_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select a picture";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			openFileDialog.Filter = "Images (*.bmp;*.jpg;*.gif;*.png;*.tiff)|*.bmp;*.jpg;*.gif;*.png;*.tiff|" + "All files (*.*)|*.*";
			try {
				openFileDialog.ShowDialog();
				originalImage = Image.FromFile(openFileDialog.FileName);
				zoom = (double)originalImage.Height / (double)pictureBoxEditorField.Height;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			MaintainAspectRatio();
			tempImage = tempBitmap;
		}


		private void ToolStripMenuItemSave_Click(object sender, EventArgs e) {
			try {
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
				ImageFormat format = ImageFormat.Png;
				if (saveFileDialog.ShowDialog() == DialogResult.OK) {
					string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
					switch (ext) {
						case ".jpg":
							format = ImageFormat.Jpeg;
							break;
						case ".bmp":
							format = ImageFormat.Bmp;
							break;
					}
					pictureBoxEditorField.Image.Save(saveFileDialog.FileName, format);
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Error: Could not save the picture on disk." + ex.Message);
			}
		}

		private void TimerResizePictureBox_Tick(object sender, EventArgs e) {
			pictureBoxEditorField.Width = Int16.Parse(resizeWindow.textBoxWidth.Text);
			pictureBoxEditorField.Height = Int16.Parse(resizeWindow.textBoxHeight.Text);
			timer.Stop();
			timer.Dispose();
		}
		private void TimerRotateImage_Tick(object sender, EventArgs e) {
			try {
				editedBitmap = fip.Rotate(bitmap, 15.0);
				pictureBoxEditorField.Image = editedBitmap;
				tempImage = editedBitmap;
				timer.Stop();
				timer.Dispose();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}


		private void LabelGamma_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.GammaCorrection(bitmap, hScrollBarGamma.Value);
				pictureBoxEditorField.Image = editedBitmap;
				tempImage = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void LabelBrightness_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ColorAccent(bitmap, 0, hScrollBarBrightness.Value);
				pictureBoxEditorField.Image = editedBitmap;
				tempImage = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void LabelContrast_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ContrastStretching(bitmap, 0, hScrollBarContrast.Value);
				pictureBoxEditorField.Image = editedBitmap;
				tempImage = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonReset_Click(object sender, EventArgs e) {
			pictureBoxEditorField.Image = tempImage;
		}

		public Image<Bgr, byte> inputImage;
		Image<Gray, byte> R, G, B;
		private void PictureBoxHistorgram_Click(object sender, EventArgs e) {
			var windowHistogram  = new WindowHistogram();
			windowHistogram.pictureBox1.Image = tempBitmap;
			windowHistogram.bitmap = tempBitmap;
			inputImage= new Image<Bgr, byte>(tempBitmap);
			R = inputImage[0];
			G = inputImage[1];
			B = inputImage[2];

			DenseHistogram denseHistogram = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
			denseHistogram.Calculate(new Image<Gray, byte>[] { R }, false, null);
			Mat mat = new Mat();
			denseHistogram.CopyTo(mat);

			windowHistogram.imageBoxR.Image = R;
			windowHistogram.imageBoxG.Image = G;
			windowHistogram.imageBoxB.Image = B;

			windowHistogram.histogramBox.GenerateHistograms(R, 256);
			//windowHistogram.histogramBox.GenerateHistograms(G, 256);
			//windowHistogram.histogramBox.GenerateHistograms(B, 256);

			windowHistogram.histogramBox.AddHistogram("Red channel", Color.Red, mat, 256, new float[] { 0f, 255f });
			//windowHistogram.histogramBox.AddHistogram("Green channel", Color.Green, mat, 256, new float[] { 0f, 255f });
			//windowHistogram.histogramBox.AddHistogram("Blue channel", Color.Blue, mat, 256, new float[] { 0f, 255f });

			windowHistogram.histogramBox.Refresh();
			windowHistogram.Show();

		}

		private void ButtonGreyNumber1_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ToGreyscale(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonGreyNumber2_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ToGreyscaleLightness(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		private void ButtonGreyNumber3_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ToGreyscaleAVG(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonNegative_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.NegativeImageColor(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonInversion_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.InverseImage(bitmap, 150);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonLumination_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ImageSDROMFilterGS(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonDraw_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.Sketch(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonBlur_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.Blurring(bitmap, 5, 5, 15);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonLinear_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ImageFilterColor(bitmap, fip.LaplaceF1());
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonBW_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ToBlackwhite(bitmap, 64);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonMedian_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ImageMedianFilterColor(bitmap, 4);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonEdgeDetection_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ImagePrewittFilterColor(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonHistogramEqualization_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.HistoramEqualization(bitmap);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ComboBoxColorFilter_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.ColorFiltration(bitmap, comboBoxColorFilter.SelectedItem.ToString());
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void PictureBoxZoomPlus_Click(object sender, EventArgs e) {
			zoom += 0.05;
			bitmap = new Bitmap(tempImage, (int)((double)pictureBoxEditorField.Width * zoom), (int) ((double)pictureBoxEditorField.Width * zoom));
			pictureBoxEditorField.Image = bitmap;
		}

		private void PictureBoxZoomMinus_Click(object sender, EventArgs e) {
			zoom -= 0.05;
			bitmap = new Bitmap(tempImage, (int)((double)pictureBoxEditorField.Width * zoom), (int)((double)pictureBoxEditorField.Width * zoom));
			pictureBoxEditorField.Image = bitmap;
		}

		private void RotateImage_Click(object sender, EventArgs e) {
			try {
				rotateEditorWindow = new RotateEditorWindow();
				rotateEditorWindow.Show();
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				timer.Tick += TimerResizePictureBox_Tick;
				timer.Interval = 10000;
				timer.Start();

			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ResizeImage_Click(object sender, EventArgs e) {
			resizeWindow.Show();
			timer.Tick += TimerResizePictureBox_Tick;
			timer.Interval = 10000;
			timer.Start();
		}

		private void ButtonHistogram_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.HistogramShift(bitmap, 20);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ButtonPaintOil_Click(object sender, EventArgs e) {
			try {
				bitmap = new Bitmap(pictureBoxEditorField.Image);
				Bitmap editedBitmap = fip.OilPaint(bitmap, 5, 15);
				pictureBoxEditorField.Image = editedBitmap;
				tempBitmap = editedBitmap;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}
}
