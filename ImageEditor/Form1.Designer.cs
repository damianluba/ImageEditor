namespace ImageEditor {
	partial class MainWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.pictureBoxZoomMinus = new System.Windows.Forms.PictureBox();
			this.pictureBoxZoomPlus = new System.Windows.Forms.PictureBox();
			this.comboBoxColorFilter = new System.Windows.Forms.ComboBox();
			this.buttonEdgeDetection = new System.Windows.Forms.Button();
			this.buttonGreyNumber3 = new System.Windows.Forms.Button();
			this.buttonGreyNumber2 = new System.Windows.Forms.Button();
			this.buttonGreyNumber1 = new System.Windows.Forms.Button();
			this.hScrollBarContrast = new System.Windows.Forms.HScrollBar();
			this.buttonReset = new System.Windows.Forms.Button();
			this.hScrollBarBrightness = new System.Windows.Forms.HScrollBar();
			this.buttonLinear = new System.Windows.Forms.Button();
			this.hScrollBarGamma = new System.Windows.Forms.HScrollBar();
			this.buttonMedian = new System.Windows.Forms.Button();
			this.labelContrast = new System.Windows.Forms.Label();
			this.labelBrightness = new System.Windows.Forms.Label();
			this.pictureBoxHistorgram = new System.Windows.Forms.PictureBox();
			this.labelGamma = new System.Windows.Forms.Label();
			this.pictureBoxResize = new System.Windows.Forms.PictureBox();
			this.buttonLumination = new System.Windows.Forms.Button();
			this.pictureBoxRotateImage = new System.Windows.Forms.PictureBox();
			this.buttonBlur = new System.Windows.Forms.Button();
			this.buttonDraw = new System.Windows.Forms.Button();
			this.buttonPaintOil = new System.Windows.Forms.Button();
			this.buttonInversion = new System.Windows.Forms.Button();
			this.buttonNegative = new System.Windows.Forms.Button();
			this.buttonBW = new System.Windows.Forms.Button();
			this.buttonHistogramEqualization = new System.Windows.Forms.Button();
			this.buttonHistogram = new System.Windows.Forms.Button();
			this.pictureBoxEditorField = new System.Windows.Forms.PictureBox();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomMinus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomPlus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistorgram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditorField)).BeginInit();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.BackColor = System.Drawing.Color.DarkSalmon;
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxZoomMinus);
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxZoomPlus);
			this.splitContainer.Panel1.Controls.Add(this.comboBoxColorFilter);
			this.splitContainer.Panel1.Controls.Add(this.buttonEdgeDetection);
			this.splitContainer.Panel1.Controls.Add(this.buttonGreyNumber3);
			this.splitContainer.Panel1.Controls.Add(this.buttonGreyNumber2);
			this.splitContainer.Panel1.Controls.Add(this.buttonGreyNumber1);
			this.splitContainer.Panel1.Controls.Add(this.hScrollBarContrast);
			this.splitContainer.Panel1.Controls.Add(this.buttonReset);
			this.splitContainer.Panel1.Controls.Add(this.hScrollBarBrightness);
			this.splitContainer.Panel1.Controls.Add(this.buttonLinear);
			this.splitContainer.Panel1.Controls.Add(this.hScrollBarGamma);
			this.splitContainer.Panel1.Controls.Add(this.buttonMedian);
			this.splitContainer.Panel1.Controls.Add(this.labelContrast);
			this.splitContainer.Panel1.Controls.Add(this.labelBrightness);
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxHistorgram);
			this.splitContainer.Panel1.Controls.Add(this.labelGamma);
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxResize);
			this.splitContainer.Panel1.Controls.Add(this.buttonLumination);
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxRotateImage);
			this.splitContainer.Panel1.Controls.Add(this.buttonBlur);
			this.splitContainer.Panel1.Controls.Add(this.buttonDraw);
			this.splitContainer.Panel1.Controls.Add(this.buttonPaintOil);
			this.splitContainer.Panel1.Controls.Add(this.buttonInversion);
			this.splitContainer.Panel1.Controls.Add(this.buttonNegative);
			this.splitContainer.Panel1.Controls.Add(this.buttonBW);
			this.splitContainer.Panel1.Controls.Add(this.buttonHistogramEqualization);
			this.splitContainer.Panel1.Controls.Add(this.buttonHistogram);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.pictureBoxEditorField);
			this.splitContainer.Size = new System.Drawing.Size(827, 707);
			this.splitContainer.SplitterDistance = 181;
			this.splitContainer.TabIndex = 0;
			// 
			// pictureBoxZoomMinus
			// 
			this.pictureBoxZoomMinus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxZoomMinus.Image")));
			this.pictureBoxZoomMinus.Location = new System.Drawing.Point(89, 549);
			this.pictureBoxZoomMinus.Name = "pictureBoxZoomMinus";
			this.pictureBoxZoomMinus.Size = new System.Drawing.Size(42, 38);
			this.pictureBoxZoomMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxZoomMinus.TabIndex = 93;
			this.pictureBoxZoomMinus.TabStop = false;
			this.pictureBoxZoomMinus.Click += new System.EventHandler(this.PictureBoxZoomMinus_Click);
			// 
			// pictureBoxZoomPlus
			// 
			this.pictureBoxZoomPlus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxZoomPlus.Image")));
			this.pictureBoxZoomPlus.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxZoomPlus.InitialImage")));
			this.pictureBoxZoomPlus.Location = new System.Drawing.Point(41, 549);
			this.pictureBoxZoomPlus.Name = "pictureBoxZoomPlus";
			this.pictureBoxZoomPlus.Size = new System.Drawing.Size(42, 38);
			this.pictureBoxZoomPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxZoomPlus.TabIndex = 92;
			this.pictureBoxZoomPlus.TabStop = false;
			this.pictureBoxZoomPlus.Click += new System.EventHandler(this.PictureBoxZoomPlus_Click);
			// 
			// comboBoxColorFilter
			// 
			this.comboBoxColorFilter.BackColor = System.Drawing.Color.GreenYellow;
			this.comboBoxColorFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.comboBoxColorFilter.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxColorFilter.FormattingEnabled = true;
			this.comboBoxColorFilter.Items.AddRange(new object[] {
            "Magenta",
            "Yellow",
            "Cyan",
            "Magenta-Yellow",
            "Cyan-Magenta",
            "Yellow-Cyan"});
			this.comboBoxColorFilter.Location = new System.Drawing.Point(13, 98);
			this.comboBoxColorFilter.Name = "comboBoxColorFilter";
			this.comboBoxColorFilter.Size = new System.Drawing.Size(163, 23);
			this.comboBoxColorFilter.TabIndex = 91;
			this.comboBoxColorFilter.Text = "filter";
			this.comboBoxColorFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColorFilter_SelectedIndexChanged);
			// 
			// buttonEdgeDetection
			// 
			this.buttonEdgeDetection.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonEdgeDetection.FlatAppearance.BorderSize = 0;
			this.buttonEdgeDetection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdgeDetection.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdgeDetection.Location = new System.Drawing.Point(12, 160);
			this.buttonEdgeDetection.Margin = new System.Windows.Forms.Padding(0);
			this.buttonEdgeDetection.Name = "buttonEdgeDetection";
			this.buttonEdgeDetection.Size = new System.Drawing.Size(164, 23);
			this.buttonEdgeDetection.TabIndex = 90;
			this.buttonEdgeDetection.Text = "edge detection";
			this.buttonEdgeDetection.UseVisualStyleBackColor = false;
			this.buttonEdgeDetection.Click += new System.EventHandler(this.ButtonEdgeDetection_Click);
			// 
			// buttonGreyNumber3
			// 
			this.buttonGreyNumber3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonGreyNumber3.FlatAppearance.BorderSize = 0;
			this.buttonGreyNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGreyNumber3.Font = new System.Drawing.Font("Ink Free", 7F, System.Drawing.FontStyle.Bold);
			this.buttonGreyNumber3.Location = new System.Drawing.Point(122, 343);
			this.buttonGreyNumber3.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGreyNumber3.Name = "buttonGreyNumber3";
			this.buttonGreyNumber3.Size = new System.Drawing.Size(54, 23);
			this.buttonGreyNumber3.TabIndex = 89;
			this.buttonGreyNumber3.Text = "grey #3";
			this.buttonGreyNumber3.UseVisualStyleBackColor = false;
			this.buttonGreyNumber3.Click += new System.EventHandler(this.ButtonGreyNumber3_Click);
			// 
			// buttonGreyNumber2
			// 
			this.buttonGreyNumber2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonGreyNumber2.FlatAppearance.BorderSize = 0;
			this.buttonGreyNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGreyNumber2.Font = new System.Drawing.Font("Ink Free", 7F, System.Drawing.FontStyle.Bold);
			this.buttonGreyNumber2.Location = new System.Drawing.Point(65, 343);
			this.buttonGreyNumber2.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGreyNumber2.Name = "buttonGreyNumber2";
			this.buttonGreyNumber2.Size = new System.Drawing.Size(54, 23);
			this.buttonGreyNumber2.TabIndex = 88;
			this.buttonGreyNumber2.Text = "grey #2";
			this.buttonGreyNumber2.UseVisualStyleBackColor = false;
			this.buttonGreyNumber2.Click += new System.EventHandler(this.ButtonGreyNumber2_Click);
			// 
			// buttonGreyNumber1
			// 
			this.buttonGreyNumber1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonGreyNumber1.FlatAppearance.BorderSize = 0;
			this.buttonGreyNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGreyNumber1.Font = new System.Drawing.Font("Ink Free", 7F, System.Drawing.FontStyle.Bold);
			this.buttonGreyNumber1.Location = new System.Drawing.Point(12, 343);
			this.buttonGreyNumber1.Margin = new System.Windows.Forms.Padding(0);
			this.buttonGreyNumber1.Name = "buttonGreyNumber1";
			this.buttonGreyNumber1.Size = new System.Drawing.Size(51, 23);
			this.buttonGreyNumber1.TabIndex = 87;
			this.buttonGreyNumber1.Text = "grey #1";
			this.buttonGreyNumber1.UseVisualStyleBackColor = false;
			this.buttonGreyNumber1.Click += new System.EventHandler(this.ButtonGreyNumber1_Click);
			// 
			// hScrollBarContrast
			// 
			this.hScrollBarContrast.Location = new System.Drawing.Point(12, 457);
			this.hScrollBarContrast.Name = "hScrollBarContrast";
			this.hScrollBarContrast.Size = new System.Drawing.Size(164, 17);
			this.hScrollBarContrast.TabIndex = 60;
			// 
			// buttonReset
			// 
			this.buttonReset.BackColor = System.Drawing.Color.Yellow;
			this.buttonReset.FlatAppearance.BorderSize = 0;
			this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReset.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReset.Location = new System.Drawing.Point(95, 42);
			this.buttonReset.Margin = new System.Windows.Forms.Padding(0);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(75, 23);
			this.buttonReset.TabIndex = 61;
			this.buttonReset.Text = "reset";
			this.buttonReset.UseVisualStyleBackColor = false;
			this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// hScrollBarBrightness
			// 
			this.hScrollBarBrightness.Location = new System.Drawing.Point(12, 416);
			this.hScrollBarBrightness.Name = "hScrollBarBrightness";
			this.hScrollBarBrightness.Size = new System.Drawing.Size(164, 17);
			this.hScrollBarBrightness.TabIndex = 59;
			// 
			// buttonLinear
			// 
			this.buttonLinear.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonLinear.FlatAppearance.BorderSize = 0;
			this.buttonLinear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLinear.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLinear.Location = new System.Drawing.Point(12, 218);
			this.buttonLinear.Margin = new System.Windows.Forms.Padding(0);
			this.buttonLinear.Name = "buttonLinear";
			this.buttonLinear.Size = new System.Drawing.Size(71, 23);
			this.buttonLinear.TabIndex = 86;
			this.buttonLinear.Text = "linear";
			this.buttonLinear.UseVisualStyleBackColor = false;
			this.buttonLinear.Click += new System.EventHandler(this.ButtonLinear_Click);
			// 
			// hScrollBarGamma
			// 
			this.hScrollBarGamma.Location = new System.Drawing.Point(12, 374);
			this.hScrollBarGamma.Name = "hScrollBarGamma";
			this.hScrollBarGamma.Size = new System.Drawing.Size(164, 17);
			this.hScrollBarGamma.TabIndex = 58;
			// 
			// buttonMedian
			// 
			this.buttonMedian.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonMedian.FlatAppearance.BorderSize = 0;
			this.buttonMedian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMedian.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMedian.Location = new System.Drawing.Point(12, 189);
			this.buttonMedian.Margin = new System.Windows.Forms.Padding(0);
			this.buttonMedian.Name = "buttonMedian";
			this.buttonMedian.Size = new System.Drawing.Size(71, 23);
			this.buttonMedian.TabIndex = 85;
			this.buttonMedian.Text = "median";
			this.buttonMedian.UseVisualStyleBackColor = false;
			this.buttonMedian.Click += new System.EventHandler(this.ButtonMedian_Click);
			// 
			// labelContrast
			// 
			this.labelContrast.AutoSize = true;
			this.labelContrast.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelContrast.Location = new System.Drawing.Point(67, 474);
			this.labelContrast.Name = "labelContrast";
			this.labelContrast.Size = new System.Drawing.Size(55, 16);
			this.labelContrast.TabIndex = 54;
			this.labelContrast.Text = "contrast";
			this.labelContrast.Click += new System.EventHandler(this.LabelContrast_Click);
			// 
			// labelBrightness
			// 
			this.labelBrightness.AutoSize = true;
			this.labelBrightness.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBrightness.Location = new System.Drawing.Point(62, 433);
			this.labelBrightness.Name = "labelBrightness";
			this.labelBrightness.Size = new System.Drawing.Size(64, 16);
			this.labelBrightness.TabIndex = 53;
			this.labelBrightness.Text = "brightness";
			this.labelBrightness.Click += new System.EventHandler(this.LabelBrightness_Click);
			// 
			// pictureBoxHistorgram
			// 
			this.pictureBoxHistorgram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHistorgram.Image")));
			this.pictureBoxHistorgram.Location = new System.Drawing.Point(3, 593);
			this.pictureBoxHistorgram.Name = "pictureBoxHistorgram";
			this.pictureBoxHistorgram.Size = new System.Drawing.Size(172, 78);
			this.pictureBoxHistorgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxHistorgram.TabIndex = 56;
			this.pictureBoxHistorgram.TabStop = false;
			this.pictureBoxHistorgram.Click += new System.EventHandler(this.PictureBoxHistorgram_Click);
			// 
			// labelGamma
			// 
			this.labelGamma.AutoSize = true;
			this.labelGamma.BackColor = System.Drawing.Color.Transparent;
			this.labelGamma.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGamma.Location = new System.Drawing.Point(72, 391);
			this.labelGamma.Name = "labelGamma";
			this.labelGamma.Size = new System.Drawing.Size(44, 16);
			this.labelGamma.TabIndex = 52;
			this.labelGamma.Text = "gamma";
			this.labelGamma.Click += new System.EventHandler(this.LabelGamma_Click);
			// 
			// pictureBoxResize
			// 
			this.pictureBoxResize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxResize.Image")));
			this.pictureBoxResize.Location = new System.Drawing.Point(108, 505);
			this.pictureBoxResize.Name = "pictureBoxResize";
			this.pictureBoxResize.Size = new System.Drawing.Size(42, 38);
			this.pictureBoxResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxResize.TabIndex = 57;
			this.pictureBoxResize.TabStop = false;
			this.pictureBoxResize.Click += new System.EventHandler(this.ResizeImage_Click);
			// 
			// buttonLumination
			// 
			this.buttonLumination.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonLumination.FlatAppearance.BorderSize = 0;
			this.buttonLumination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLumination.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLumination.Location = new System.Drawing.Point(12, 277);
			this.buttonLumination.Margin = new System.Windows.Forms.Padding(0);
			this.buttonLumination.Name = "buttonLumination";
			this.buttonLumination.Size = new System.Drawing.Size(71, 32);
			this.buttonLumination.TabIndex = 84;
			this.buttonLumination.Text = "luminance";
			this.buttonLumination.UseVisualStyleBackColor = false;
			this.buttonLumination.Click += new System.EventHandler(this.ButtonLumination_Click);
			// 
			// pictureBoxRotateImage
			// 
			this.pictureBoxRotateImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRotateImage.Image")));
			this.pictureBoxRotateImage.Location = new System.Drawing.Point(21, 505);
			this.pictureBoxRotateImage.Name = "pictureBoxRotateImage";
			this.pictureBoxRotateImage.Size = new System.Drawing.Size(42, 38);
			this.pictureBoxRotateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxRotateImage.TabIndex = 55;
			this.pictureBoxRotateImage.TabStop = false;
			this.pictureBoxRotateImage.Click += new System.EventHandler(this.RotateImage_Click);
			// 
			// buttonBlur
			// 
			this.buttonBlur.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonBlur.FlatAppearance.BorderSize = 0;
			this.buttonBlur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBlur.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBlur.Location = new System.Drawing.Point(94, 219);
			this.buttonBlur.Margin = new System.Windows.Forms.Padding(0);
			this.buttonBlur.Name = "buttonBlur";
			this.buttonBlur.Size = new System.Drawing.Size(81, 23);
			this.buttonBlur.TabIndex = 83;
			this.buttonBlur.Text = "blur";
			this.buttonBlur.UseVisualStyleBackColor = false;
			this.buttonBlur.Click += new System.EventHandler(this.ButtonBlur_Click);
			// 
			// buttonDraw
			// 
			this.buttonDraw.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDraw.FlatAppearance.BorderSize = 0;
			this.buttonDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDraw.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDraw.Location = new System.Drawing.Point(12, 248);
			this.buttonDraw.Margin = new System.Windows.Forms.Padding(0);
			this.buttonDraw.Name = "buttonDraw";
			this.buttonDraw.Size = new System.Drawing.Size(164, 23);
			this.buttonDraw.TabIndex = 82;
			this.buttonDraw.Text = "draw";
			this.buttonDraw.UseVisualStyleBackColor = false;
			this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
			// 
			// buttonPaintOil
			// 
			this.buttonPaintOil.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonPaintOil.FlatAppearance.BorderSize = 0;
			this.buttonPaintOil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPaintOil.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPaintOil.Location = new System.Drawing.Point(94, 277);
			this.buttonPaintOil.Margin = new System.Windows.Forms.Padding(0);
			this.buttonPaintOil.Name = "buttonPaintOil";
			this.buttonPaintOil.Size = new System.Drawing.Size(81, 32);
			this.buttonPaintOil.TabIndex = 81;
			this.buttonPaintOil.Text = "paint oil";
			this.buttonPaintOil.UseVisualStyleBackColor = false;
			this.buttonPaintOil.Click += new System.EventHandler(this.ButtonPaintOil_Click);
			// 
			// buttonInversion
			// 
			this.buttonInversion.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonInversion.FlatAppearance.BorderSize = 0;
			this.buttonInversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonInversion.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInversion.Location = new System.Drawing.Point(95, 316);
			this.buttonInversion.Margin = new System.Windows.Forms.Padding(0);
			this.buttonInversion.Name = "buttonInversion";
			this.buttonInversion.Size = new System.Drawing.Size(81, 23);
			this.buttonInversion.TabIndex = 80;
			this.buttonInversion.Text = "inversion";
			this.buttonInversion.UseVisualStyleBackColor = false;
			this.buttonInversion.Click += new System.EventHandler(this.ButtonInversion_Click);
			// 
			// buttonNegative
			// 
			this.buttonNegative.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonNegative.FlatAppearance.BorderSize = 0;
			this.buttonNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNegative.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNegative.Location = new System.Drawing.Point(12, 316);
			this.buttonNegative.Margin = new System.Windows.Forms.Padding(0);
			this.buttonNegative.Name = "buttonNegative";
			this.buttonNegative.Size = new System.Drawing.Size(71, 23);
			this.buttonNegative.TabIndex = 79;
			this.buttonNegative.Text = "negative";
			this.buttonNegative.UseVisualStyleBackColor = false;
			this.buttonNegative.Click += new System.EventHandler(this.ButtonNegative_Click);
			// 
			// buttonBW
			// 
			this.buttonBW.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonBW.FlatAppearance.BorderSize = 0;
			this.buttonBW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBW.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBW.Location = new System.Drawing.Point(94, 189);
			this.buttonBW.Margin = new System.Windows.Forms.Padding(0);
			this.buttonBW.Name = "buttonBW";
			this.buttonBW.Size = new System.Drawing.Size(81, 23);
			this.buttonBW.TabIndex = 78;
			this.buttonBW.Text = "B/W";
			this.buttonBW.UseVisualStyleBackColor = false;
			this.buttonBW.Click += new System.EventHandler(this.ButtonBW_Click);
			// 
			// buttonHistogramEqualization
			// 
			this.buttonHistogramEqualization.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonHistogramEqualization.FlatAppearance.BorderSize = 0;
			this.buttonHistogramEqualization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHistogramEqualization.Font = new System.Drawing.Font("Ink Free", 6F, System.Drawing.FontStyle.Bold);
			this.buttonHistogramEqualization.Location = new System.Drawing.Point(95, 131);
			this.buttonHistogramEqualization.Margin = new System.Windows.Forms.Padding(0);
			this.buttonHistogramEqualization.Name = "buttonHistogramEqualization";
			this.buttonHistogramEqualization.Size = new System.Drawing.Size(81, 23);
			this.buttonHistogramEqualization.TabIndex = 77;
			this.buttonHistogramEqualization.Text = "histogram Eq";
			this.buttonHistogramEqualization.UseVisualStyleBackColor = false;
			this.buttonHistogramEqualization.Click += new System.EventHandler(this.ButtonHistogramEqualization_Click);
			// 
			// buttonHistogram
			// 
			this.buttonHistogram.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonHistogram.FlatAppearance.BorderSize = 0;
			this.buttonHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHistogram.Font = new System.Drawing.Font("Ink Free", 6F, System.Drawing.FontStyle.Bold);
			this.buttonHistogram.Location = new System.Drawing.Point(12, 131);
			this.buttonHistogram.Margin = new System.Windows.Forms.Padding(0);
			this.buttonHistogram.Name = "buttonHistogram";
			this.buttonHistogram.Size = new System.Drawing.Size(71, 23);
			this.buttonHistogram.TabIndex = 76;
			this.buttonHistogram.Text = "histogram Sh";
			this.buttonHistogram.UseVisualStyleBackColor = false;
			this.buttonHistogram.Click += new System.EventHandler(this.ButtonHistogram_Click);
			// 
			// pictureBoxEditorField
			// 
			this.pictureBoxEditorField.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pictureBoxEditorField.Location = new System.Drawing.Point(6, 23);
			this.pictureBoxEditorField.Name = "pictureBoxEditorField";
			this.pictureBoxEditorField.Size = new System.Drawing.Size(624, 627);
			this.pictureBoxEditorField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxEditorField.TabIndex = 61;
			this.pictureBoxEditorField.TabStop = false;
			this.pictureBoxEditorField.Click += new System.EventHandler(this.PictureBoxEditorField_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.AutoSize = false;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(827, 20);
			this.toolStrip.TabIndex = 32;
			// 
			// toolStripDropDownButton
			// 
			this.toolStripDropDownButton.AutoSize = false;
			this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemSaveAs});
			this.toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
			this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton.Name = "toolStripDropDownButton";
			this.toolStripDropDownButton.Size = new System.Drawing.Size(38, 20);
			this.toolStripDropDownButton.Text = "File";
			// 
			// toolStripMenuItemOpen
			// 
			this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
			this.toolStripMenuItemOpen.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItemOpen.Text = "Open...";
			this.toolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
			// 
			// toolStripMenuItemSave
			// 
			this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
			this.toolStripMenuItemSave.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItemSave.Text = "Save";
			this.toolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
			// 
			// toolStripMenuItemSaveAs
			// 
			this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
			this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItemSaveAs.Text = "Save as...";
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.TimerResizePictureBox_Tick);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 707);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.splitContainer);
			this.Name = "MainWindow";
			this.Text = "Super Graphic Transformer";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomMinus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomPlus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistorgram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotateImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditorField)).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs;
		private System.Windows.Forms.HScrollBar hScrollBarContrast;
		private System.Windows.Forms.HScrollBar hScrollBarBrightness;
		private System.Windows.Forms.HScrollBar hScrollBarGamma;
		private System.Windows.Forms.PictureBox pictureBoxResize;
		private System.Windows.Forms.PictureBox pictureBoxHistorgram;
		private System.Windows.Forms.PictureBox pictureBoxRotateImage;
		public System.Windows.Forms.PictureBox pictureBoxEditorField;
		private System.Windows.Forms.Label labelContrast;
		private System.Windows.Forms.Label labelBrightness;
		private System.Windows.Forms.Label labelGamma;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonHistogramEqualization;
		private System.Windows.Forms.Button buttonHistogram;
		private System.Windows.Forms.Button buttonLinear;
		private System.Windows.Forms.Button buttonMedian;
		private System.Windows.Forms.Button buttonLumination;
		private System.Windows.Forms.Button buttonBlur;
		private System.Windows.Forms.Button buttonDraw;
		private System.Windows.Forms.Button buttonPaintOil;
		private System.Windows.Forms.Button buttonInversion;
		private System.Windows.Forms.Button buttonNegative;
		private System.Windows.Forms.Button buttonBW;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button buttonGreyNumber3;
		private System.Windows.Forms.Button buttonGreyNumber2;
		private System.Windows.Forms.Button buttonGreyNumber1;
		private System.Windows.Forms.Button buttonEdgeDetection;
		private System.Windows.Forms.ComboBox comboBoxColorFilter;
		private System.Windows.Forms.PictureBox pictureBoxZoomMinus;
		private System.Windows.Forms.PictureBox pictureBoxZoomPlus;
	}
}

