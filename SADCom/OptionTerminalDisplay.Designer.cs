namespace SADCom.Configuration {
	partial class OptionTerminalDisplay {
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			this.cbTimeStamp = new System.Windows.Forms.CheckBox();
			this.cbDataAnalyser = new System.Windows.Forms.CheckBox();
			this.pbFileAnalyser = new System.Windows.Forms.Button();
			this.pbCreateNewFileAnalyser = new System.Windows.Forms.Button();
			this.tbLocationFileAnalyser = new System.Windows.Forms.TextBox();
			this.tlpTerminalColor = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lMinOpacity = new System.Windows.Forms.Label();
			this.lMaxOpacity = new System.Windows.Forms.Label();
			this.lOpacityCurrentLvl = new System.Windows.Forms.Label();
			this.tbOpacity = new System.Windows.Forms.TrackBar();
			this.pbTeminalFont = new System.Windows.Forms.Button();
			this.rtbColorExample = new System.Windows.Forms.RichTextBox();
			this.pbTerminalBackgroundColor = new System.Windows.Forms.Button();
			this.lOpacity = new System.Windows.Forms.Label();
			this.tlbBufferLength = new System.Windows.Forms.TableLayoutPanel();
			this.numMaxLengthBuffer = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tlpTimeStamp = new System.Windows.Forms.TableLayoutPanel();
			this.cbDataTimeStamp = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tlbDataAnalyser = new System.Windows.Forms.TableLayoutPanel();
			this.tbOutputAnalyserLogFile = new System.Windows.Forms.TextBox();
			this.pbOutputDataAnalyser = new System.Windows.Forms.Button();
			this.pbClearFileAnalyser = new System.Windows.Forms.Button();
			this.pbClearbOutputAnalyserLogFile = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pbSelectFileAnalyser = new System.Windows.Forms.Button();
			this.tlpTerminalColor.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
			this.tlbBufferLength.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxLengthBuffer)).BeginInit();
			this.tlpTimeStamp.SuspendLayout();
			this.tlbDataAnalyser.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbTimeStamp
			// 
			this.cbTimeStamp.AutoSize = true;
			this.cbTimeStamp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbTimeStamp.Location = new System.Drawing.Point(0, 0);
			this.cbTimeStamp.Margin = new System.Windows.Forms.Padding(0);
			this.cbTimeStamp.Name = "cbTimeStamp";
			this.cbTimeStamp.Size = new System.Drawing.Size(165, 27);
			this.cbTimeStamp.TabIndex = 2;
			this.cbTimeStamp.Text = "horodatage des données";
			this.cbTimeStamp.UseVisualStyleBackColor = true;
			this.cbTimeStamp.CheckedChanged += new System.EventHandler(this.cbTimeStamp_CheckedChanged);
			// 
			// cbDataAnalyser
			// 
			this.cbDataAnalyser.AutoSize = true;
			this.cbDataAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbDataAnalyser.Location = new System.Drawing.Point(0, 27);
			this.cbDataAnalyser.Name = "cbDataAnalyser";
			this.cbDataAnalyser.Size = new System.Drawing.Size(440, 17);
			this.cbDataAnalyser.TabIndex = 3;
			this.cbDataAnalyser.Text = "Activation de l\'analyseur de données";
			this.cbDataAnalyser.UseVisualStyleBackColor = true;
			this.cbDataAnalyser.CheckedChanged += new System.EventHandler(this.cbDataAnalyser_CheckedChanged);
			// 
			// pbFileAnalyser
			// 
			this.pbFileAnalyser.AutoSize = true;
			this.pbFileAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbFileAnalyser.Location = new System.Drawing.Point(35, 3);
			this.pbFileAnalyser.Name = "pbFileAnalyser";
			this.pbFileAnalyser.Size = new System.Drawing.Size(170, 23);
			this.pbFileAnalyser.TabIndex = 4;
			this.pbFileAnalyser.Text = "Modifier le fichier d\'analyse";
			this.pbFileAnalyser.UseVisualStyleBackColor = true;
			this.pbFileAnalyser.Click += new System.EventHandler(this.pbFileAnalyser_Click);
			// 
			// pbCreateNewFileAnalyser
			// 
			this.pbCreateNewFileAnalyser.AutoSize = true;
			this.pbCreateNewFileAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbCreateNewFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbCreateNewFileAnalyser.Location = new System.Drawing.Point(235, 32);
			this.pbCreateNewFileAnalyser.Name = "pbCreateNewFileAnalyser";
			this.pbCreateNewFileAnalyser.Size = new System.Drawing.Size(202, 23);
			this.pbCreateNewFileAnalyser.TabIndex = 5;
			this.pbCreateNewFileAnalyser.Text = "Crée un nouveaux fichier d\'analyse";
			this.pbCreateNewFileAnalyser.UseVisualStyleBackColor = true;
			this.pbCreateNewFileAnalyser.Click += new System.EventHandler(this.pbCreateNewFileAnalyser_Click);
			// 
			// tbLocationFileAnalyser
			// 
			this.tbLocationFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbLocationFileAnalyser.Location = new System.Drawing.Point(29, 5);
			this.tbLocationFileAnalyser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.tbLocationFileAnalyser.Name = "tbLocationFileAnalyser";
			this.tbLocationFileAnalyser.ReadOnly = true;
			this.tbLocationFileAnalyser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tbLocationFileAnalyser.Size = new System.Drawing.Size(200, 20);
			this.tbLocationFileAnalyser.TabIndex = 6;
			// 
			// tlpTerminalColor
			// 
			this.tlpTerminalColor.AutoSize = true;
			this.tlpTerminalColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpTerminalColor.ColumnCount = 2;
			this.tlpTerminalColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tlpTerminalColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpTerminalColor.Controls.Add(this.tableLayoutPanel1, 1, 2);
			this.tlpTerminalColor.Controls.Add(this.pbTeminalFont, 0, 0);
			this.tlpTerminalColor.Controls.Add(this.rtbColorExample, 1, 0);
			this.tlpTerminalColor.Controls.Add(this.pbTerminalBackgroundColor, 0, 1);
			this.tlpTerminalColor.Controls.Add(this.lOpacity, 0, 2);
			this.tlpTerminalColor.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpTerminalColor.Location = new System.Drawing.Point(0, 132);
			this.tlpTerminalColor.Name = "tlpTerminalColor";
			this.tlpTerminalColor.RowCount = 3;
			this.tlpTerminalColor.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpTerminalColor.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpTerminalColor.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpTerminalColor.Size = new System.Drawing.Size(440, 97);
			this.tlpTerminalColor.TabIndex = 8;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Controls.Add(this.lMinOpacity, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lMaxOpacity, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lOpacityCurrentLvl, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tbOpacity, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 58);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 39);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// lMinOpacity
			// 
			this.lMinOpacity.AutoSize = true;
			this.lMinOpacity.Dock = System.Windows.Forms.DockStyle.Right;
			this.lMinOpacity.Location = new System.Drawing.Point(10, 0);
			this.lMinOpacity.Name = "lMinOpacity";
			this.lMinOpacity.Size = new System.Drawing.Size(27, 26);
			this.lMinOpacity.TabIndex = 15;
			this.lMinOpacity.Text = "30%";
			this.lMinOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lMaxOpacity
			// 
			this.lMaxOpacity.AutoSize = true;
			this.lMaxOpacity.Dock = System.Windows.Forms.DockStyle.Left;
			this.lMaxOpacity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lMaxOpacity.Location = new System.Drawing.Point(254, 0);
			this.lMaxOpacity.Name = "lMaxOpacity";
			this.lMaxOpacity.Size = new System.Drawing.Size(33, 26);
			this.lMaxOpacity.TabIndex = 16;
			this.lMaxOpacity.Text = "100%";
			this.lMaxOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lOpacityCurrentLvl
			// 
			this.lOpacityCurrentLvl.AutoSize = true;
			this.lOpacityCurrentLvl.Dock = System.Windows.Forms.DockStyle.Top;
			this.lOpacityCurrentLvl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lOpacityCurrentLvl.Location = new System.Drawing.Point(43, 26);
			this.lOpacityCurrentLvl.Name = "lOpacityCurrentLvl";
			this.lOpacityCurrentLvl.Size = new System.Drawing.Size(205, 13);
			this.lOpacityCurrentLvl.TabIndex = 17;
			this.lOpacityCurrentLvl.Text = "50%";
			this.lOpacityCurrentLvl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tbOpacity
			// 
			this.tbOpacity.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbOpacity.Location = new System.Drawing.Point(43, 3);
			this.tbOpacity.Maximum = 100;
			this.tbOpacity.MaximumSize = new System.Drawing.Size(0, 20);
			this.tbOpacity.Minimum = 30;
			this.tbOpacity.Name = "tbOpacity";
			this.tbOpacity.Size = new System.Drawing.Size(205, 20);
			this.tbOpacity.TabIndex = 14;
			this.tbOpacity.TickFrequency = 10;
			this.tbOpacity.Value = 100;
			this.tbOpacity.ValueChanged += new System.EventHandler(this.tbOpacity_ValueChanged);
			this.tbOpacity.MouseCaptureChanged += new System.EventHandler(this.tbOpacity_MouseCaptureChanged);
			// 
			// pbTeminalFont
			// 
			this.pbTeminalFont.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbTeminalFont.Location = new System.Drawing.Point(3, 3);
			this.pbTeminalFont.Name = "pbTeminalFont";
			this.pbTeminalFont.Size = new System.Drawing.Size(144, 23);
			this.pbTeminalFont.TabIndex = 10;
			this.pbTeminalFont.Text = "Text && color";
			this.pbTeminalFont.UseVisualStyleBackColor = true;
			this.pbTeminalFont.Click += new System.EventHandler(this.pbTeminalFont_Click);
			// 
			// rtbColorExample
			// 
			this.rtbColorExample.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbColorExample.Location = new System.Drawing.Point(153, 3);
			this.rtbColorExample.Name = "rtbColorExample";
			this.rtbColorExample.ReadOnly = true;
			this.tlpTerminalColor.SetRowSpan(this.rtbColorExample, 2);
			this.rtbColorExample.ShortcutsEnabled = false;
			this.rtbColorExample.Size = new System.Drawing.Size(285, 52);
			this.rtbColorExample.TabIndex = 11;
			this.rtbColorExample.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis in mi neque. Maecen" +
    "as ac sapien nec risus consectetur faucibus. ";
			// 
			// pbTerminalBackgroundColor
			// 
			this.pbTerminalBackgroundColor.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbTerminalBackgroundColor.Location = new System.Drawing.Point(3, 32);
			this.pbTerminalBackgroundColor.Name = "pbTerminalBackgroundColor";
			this.pbTerminalBackgroundColor.Size = new System.Drawing.Size(144, 23);
			this.pbTerminalBackgroundColor.TabIndex = 12;
			this.pbTerminalBackgroundColor.Text = "Background color";
			this.pbTerminalBackgroundColor.UseVisualStyleBackColor = true;
			this.pbTerminalBackgroundColor.Click += new System.EventHandler(this.pbTerminalBackgroundColor_Click);
			// 
			// lOpacity
			// 
			this.lOpacity.AutoSize = true;
			this.lOpacity.Dock = System.Windows.Forms.DockStyle.Left;
			this.lOpacity.Location = new System.Drawing.Point(3, 61);
			this.lOpacity.Margin = new System.Windows.Forms.Padding(3);
			this.lOpacity.Name = "lOpacity";
			this.lOpacity.Size = new System.Drawing.Size(44, 33);
			this.lOpacity.TabIndex = 13;
			this.lOpacity.Text = "Opacité";
			this.lOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tlbBufferLength
			// 
			this.tlbBufferLength.AutoSize = true;
			this.tlbBufferLength.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlbBufferLength.ColumnCount = 3;
			this.tlbBufferLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tlbBufferLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tlbBufferLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
			this.tlbBufferLength.Controls.Add(this.numMaxLengthBuffer, 1, 0);
			this.tlbBufferLength.Controls.Add(this.label1, 0, 0);
			this.tlbBufferLength.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlbBufferLength.Location = new System.Drawing.Point(0, 229);
			this.tlbBufferLength.Name = "tlbBufferLength";
			this.tlbBufferLength.RowCount = 1;
			this.tlbBufferLength.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlbBufferLength.Size = new System.Drawing.Size(440, 26);
			this.tlbBufferLength.TabIndex = 9;
			// 
			// numMaxLengthBuffer
			// 
			this.numMaxLengthBuffer.Dock = System.Windows.Forms.DockStyle.Top;
			this.numMaxLengthBuffer.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numMaxLengthBuffer.Location = new System.Drawing.Point(253, 3);
			this.numMaxLengthBuffer.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numMaxLengthBuffer.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numMaxLengthBuffer.Name = "numMaxLengthBuffer";
			this.numMaxLengthBuffer.Size = new System.Drawing.Size(144, 20);
			this.numMaxLengthBuffer.TabIndex = 0;
			this.numMaxLengthBuffer.ThousandsSeparator = true;
			this.numMaxLengthBuffer.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Taille du buffer (en nombre de caractères)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tlpTimeStamp
			// 
			this.tlpTimeStamp.AutoSize = true;
			this.tlpTimeStamp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpTimeStamp.ColumnCount = 3;
			this.tlpTimeStamp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
			this.tlpTimeStamp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
			this.tlpTimeStamp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpTimeStamp.Controls.Add(this.cbTimeStamp, 0, 0);
			this.tlpTimeStamp.Controls.Add(this.cbDataTimeStamp, 1, 0);
			this.tlpTimeStamp.Controls.Add(this.label2, 2, 0);
			this.tlpTimeStamp.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpTimeStamp.Location = new System.Drawing.Point(0, 0);
			this.tlpTimeStamp.Name = "tlpTimeStamp";
			this.tlpTimeStamp.RowCount = 1;
			this.tlpTimeStamp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpTimeStamp.Size = new System.Drawing.Size(440, 27);
			this.tlpTimeStamp.TabIndex = 10;
			// 
			// cbDataTimeStamp
			// 
			this.cbDataTimeStamp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbDataTimeStamp.FormattingEnabled = true;
			this.cbDataTimeStamp.Location = new System.Drawing.Point(168, 3);
			this.cbDataTimeStamp.Name = "cbDataTimeStamp";
			this.cbDataTimeStamp.Size = new System.Drawing.Size(135, 21);
			this.cbDataTimeStamp.TabIndex = 3;
			this.cbDataTimeStamp.SelectedIndexChanged += new System.EventHandler(this.cbDataTimeStamp_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Location = new System.Drawing.Point(309, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 27);
			this.label2.TabIndex = 4;
			this.label2.Text = "secondes";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tlbDataAnalyser
			// 
			this.tlbDataAnalyser.AutoSize = true;
			this.tlbDataAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlbDataAnalyser.ColumnCount = 3;
			this.tlbDataAnalyser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tlbDataAnalyser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlbDataAnalyser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlbDataAnalyser.Controls.Add(this.tbLocationFileAnalyser, 1, 0);
			this.tlbDataAnalyser.Controls.Add(this.pbCreateNewFileAnalyser, 2, 1);
			this.tlbDataAnalyser.Controls.Add(this.tbOutputAnalyserLogFile, 1, 2);
			this.tlbDataAnalyser.Controls.Add(this.pbOutputDataAnalyser, 2, 2);
			this.tlbDataAnalyser.Controls.Add(this.pbClearFileAnalyser, 0, 0);
			this.tlbDataAnalyser.Controls.Add(this.pbClearbOutputAnalyserLogFile, 0, 2);
			this.tlbDataAnalyser.Controls.Add(this.tableLayoutPanel2, 2, 0);
			this.tlbDataAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlbDataAnalyser.Location = new System.Drawing.Point(0, 44);
			this.tlbDataAnalyser.Margin = new System.Windows.Forms.Padding(0);
			this.tlbDataAnalyser.MinimumSize = new System.Drawing.Size(0, 88);
			this.tlbDataAnalyser.Name = "tlbDataAnalyser";
			this.tlbDataAnalyser.RowCount = 3;
			this.tlbDataAnalyser.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlbDataAnalyser.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlbDataAnalyser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlbDataAnalyser.Size = new System.Drawing.Size(440, 88);
			this.tlbDataAnalyser.TabIndex = 11;
			// 
			// tbOutputAnalyserLogFile
			// 
			this.tbOutputAnalyserLogFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbOutputAnalyserLogFile.Location = new System.Drawing.Point(29, 63);
			this.tbOutputAnalyserLogFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.tbOutputAnalyserLogFile.Name = "tbOutputAnalyserLogFile";
			this.tbOutputAnalyserLogFile.ReadOnly = true;
			this.tbOutputAnalyserLogFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tbOutputAnalyserLogFile.Size = new System.Drawing.Size(200, 20);
			this.tbOutputAnalyserLogFile.TabIndex = 7;
			// 
			// pbOutputDataAnalyser
			// 
			this.pbOutputDataAnalyser.AutoSize = true;
			this.pbOutputDataAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbOutputDataAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbOutputDataAnalyser.Location = new System.Drawing.Point(235, 61);
			this.pbOutputDataAnalyser.Name = "pbOutputDataAnalyser";
			this.pbOutputDataAnalyser.Size = new System.Drawing.Size(202, 23);
			this.pbOutputDataAnalyser.TabIndex = 8;
			this.pbOutputDataAnalyser.Text = "Sortie d\'analyse";
			this.pbOutputDataAnalyser.UseVisualStyleBackColor = true;
			this.pbOutputDataAnalyser.Click += new System.EventHandler(this.pbOutputDataAnalyser_Click);
			// 
			// pbClearFileAnalyser
			// 
			this.pbClearFileAnalyser.AutoSize = true;
			this.pbClearFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbClearFileAnalyser.Location = new System.Drawing.Point(3, 3);
			this.pbClearFileAnalyser.Name = "pbClearFileAnalyser";
			this.pbClearFileAnalyser.Size = new System.Drawing.Size(20, 23);
			this.pbClearFileAnalyser.TabIndex = 9;
			this.pbClearFileAnalyser.Text = "x";
			this.pbClearFileAnalyser.UseVisualStyleBackColor = true;
			this.pbClearFileAnalyser.Click += new System.EventHandler(this.pbClearFileAnalyser_Click);
			// 
			// pbClearbOutputAnalyserLogFile
			// 
			this.pbClearbOutputAnalyserLogFile.AutoSize = true;
			this.pbClearbOutputAnalyserLogFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbClearbOutputAnalyserLogFile.Location = new System.Drawing.Point(3, 61);
			this.pbClearbOutputAnalyserLogFile.Name = "pbClearbOutputAnalyserLogFile";
			this.pbClearbOutputAnalyserLogFile.Size = new System.Drawing.Size(20, 23);
			this.pbClearbOutputAnalyserLogFile.TabIndex = 10;
			this.pbClearbOutputAnalyserLogFile.Text = "x";
			this.pbClearbOutputAnalyserLogFile.UseVisualStyleBackColor = true;
			this.pbClearbOutputAnalyserLogFile.Click += new System.EventHandler(this.pbClearbOutputAnalyserLogFile_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.pbFileAnalyser, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.pbSelectFileAnalyser, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(232, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 29);
			this.tableLayoutPanel2.TabIndex = 11;
			// 
			// pbSelectFileAnalyser
			// 
			this.pbSelectFileAnalyser.AutoSize = true;
			this.pbSelectFileAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbSelectFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbSelectFileAnalyser.Location = new System.Drawing.Point(3, 3);
			this.pbSelectFileAnalyser.Name = "pbSelectFileAnalyser";
			this.pbSelectFileAnalyser.Size = new System.Drawing.Size(26, 23);
			this.pbSelectFileAnalyser.TabIndex = 5;
			this.pbSelectFileAnalyser.Text = "...";
			this.pbSelectFileAnalyser.UseVisualStyleBackColor = true;
			this.pbSelectFileAnalyser.Click += new System.EventHandler(this.pbSelectFileAnalyser_Click);
			// 
			// OptionTerminalDisplay
			// 
			this.AccessibleName = "OptionsTerminal";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlbBufferLength);
			this.Controls.Add(this.tlpTerminalColor);
			this.Controls.Add(this.tlbDataAnalyser);
			this.Controls.Add(this.cbDataAnalyser);
			this.Controls.Add(this.tlpTimeStamp);
			this.MinimumSize = new System.Drawing.Size(440, 0);
			this.Name = "OptionTerminalDisplay";
			this.Size = new System.Drawing.Size(440, 280);
			this.tlpTerminalColor.ResumeLayout(false);
			this.tlpTerminalColor.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
			this.tlbBufferLength.ResumeLayout(false);
			this.tlbBufferLength.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxLengthBuffer)).EndInit();
			this.tlpTimeStamp.ResumeLayout(false);
			this.tlpTimeStamp.PerformLayout();
			this.tlbDataAnalyser.ResumeLayout(false);
			this.tlbDataAnalyser.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbTimeStamp;
		private System.Windows.Forms.CheckBox cbDataAnalyser;
		private System.Windows.Forms.Button pbFileAnalyser;
		private System.Windows.Forms.Button pbCreateNewFileAnalyser;
		private System.Windows.Forms.TextBox tbLocationFileAnalyser;
		private System.Windows.Forms.TableLayoutPanel tlpTerminalColor;
		private System.Windows.Forms.Button pbTeminalFont;
		private System.Windows.Forms.TableLayoutPanel tlbBufferLength;
		private System.Windows.Forms.NumericUpDown numMaxLengthBuffer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tlpTimeStamp;
		private System.Windows.Forms.ComboBox cbDataTimeStamp;
		private System.Windows.Forms.TableLayoutPanel tlbDataAnalyser;
		private System.Windows.Forms.TextBox tbOutputAnalyserLogFile;
		private System.Windows.Forms.Button pbOutputDataAnalyser;
		private System.Windows.Forms.RichTextBox rtbColorExample;
		private System.Windows.Forms.Button pbTerminalBackgroundColor;
		private System.Windows.Forms.Label lOpacity;
		private System.Windows.Forms.TrackBar tbOpacity;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lMinOpacity;
		private System.Windows.Forms.Label lMaxOpacity;
		private System.Windows.Forms.Label lOpacityCurrentLvl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button pbClearFileAnalyser;
		private System.Windows.Forms.Button pbClearbOutputAnalyserLogFile;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button pbSelectFileAnalyser;
	}
}
