namespace SADCom {
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
			this.pbTeminaColor = new System.Windows.Forms.Button();
			this.rtbColorExample = new System.Windows.Forms.RichTextBox();
			this.tlbBufferLength = new System.Windows.Forms.TableLayoutPanel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tlpTimeStamp = new System.Windows.Forms.TableLayoutPanel();
			this.cdTimeStamp = new System.Windows.Forms.ComboBox();
			this.tlbDataAnalyser = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pbOutputDataAnalyser = new System.Windows.Forms.Button();
			this.tlpTerminalColor.SuspendLayout();
			this.tlbBufferLength.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tlpTimeStamp.SuspendLayout();
			this.tlbDataAnalyser.SuspendLayout();
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
			// 
			// cbDataAnalyser
			// 
			this.cbDataAnalyser.AutoSize = true;
			this.cbDataAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbDataAnalyser.Location = new System.Drawing.Point(0, 27);
			this.cbDataAnalyser.Name = "cbDataAnalyser";
			this.cbDataAnalyser.Size = new System.Drawing.Size(441, 17);
			this.cbDataAnalyser.TabIndex = 3;
			this.cbDataAnalyser.Text = "checkBox2";
			this.cbDataAnalyser.UseVisualStyleBackColor = true;
			// 
			// pbFileAnalyser
			// 
			this.pbFileAnalyser.AutoSize = true;
			this.pbFileAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbFileAnalyser.Location = new System.Drawing.Point(224, 3);
			this.pbFileAnalyser.Name = "pbFileAnalyser";
			this.pbFileAnalyser.Size = new System.Drawing.Size(214, 23);
			this.pbFileAnalyser.TabIndex = 4;
			this.pbFileAnalyser.Text = "Fichier d\'analyse";
			this.pbFileAnalyser.UseVisualStyleBackColor = true;
			// 
			// pbCreateNewFileAnalyser
			// 
			this.pbCreateNewFileAnalyser.AutoSize = true;
			this.pbCreateNewFileAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbCreateNewFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbCreateNewFileAnalyser.Location = new System.Drawing.Point(224, 32);
			this.pbCreateNewFileAnalyser.Name = "pbCreateNewFileAnalyser";
			this.pbCreateNewFileAnalyser.Size = new System.Drawing.Size(214, 23);
			this.pbCreateNewFileAnalyser.TabIndex = 5;
			this.pbCreateNewFileAnalyser.Text = "Crée un nouveaux fichier d\'analyse";
			this.pbCreateNewFileAnalyser.UseVisualStyleBackColor = true;
			// 
			// tbLocationFileAnalyser
			// 
			this.tbLocationFileAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbLocationFileAnalyser.Location = new System.Drawing.Point(18, 5);
			this.tbLocationFileAnalyser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.tbLocationFileAnalyser.Name = "tbLocationFileAnalyser";
			this.tbLocationFileAnalyser.ReadOnly = true;
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
			this.tlpTerminalColor.Controls.Add(this.pbTeminaColor, 0, 0);
			this.tlpTerminalColor.Controls.Add(this.rtbColorExample, 1, 0);
			this.tlpTerminalColor.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpTerminalColor.Location = new System.Drawing.Point(0, 132);
			this.tlpTerminalColor.Name = "tlpTerminalColor";
			this.tlpTerminalColor.RowCount = 2;
			this.tlpTerminalColor.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpTerminalColor.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpTerminalColor.Size = new System.Drawing.Size(441, 67);
			this.tlpTerminalColor.TabIndex = 8;
			// 
			// pbTeminaColor
			// 
			this.pbTeminaColor.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbTeminaColor.Location = new System.Drawing.Point(3, 3);
			this.pbTeminaColor.Name = "pbTeminaColor";
			this.pbTeminaColor.Size = new System.Drawing.Size(144, 23);
			this.pbTeminaColor.TabIndex = 10;
			this.pbTeminaColor.Text = "Text && background color";
			this.pbTeminaColor.UseVisualStyleBackColor = true;
			this.pbTeminaColor.Click += new System.EventHandler(this.pbTeminaColor_Click);
			// 
			// rtbColorExample
			// 
			this.rtbColorExample.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbColorExample.Location = new System.Drawing.Point(153, 3);
			this.rtbColorExample.Name = "rtbColorExample";
			this.rtbColorExample.ReadOnly = true;
			this.tlpTerminalColor.SetRowSpan(this.rtbColorExample, 2);
			this.rtbColorExample.ShortcutsEnabled = false;
			this.rtbColorExample.Size = new System.Drawing.Size(285, 61);
			this.rtbColorExample.TabIndex = 11;
			this.rtbColorExample.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis in mi neque. Maecen" +
    "as ac sapien nec risus consectetur faucibus. ";
			// 
			// tlbBufferLength
			// 
			this.tlbBufferLength.AutoSize = true;
			this.tlbBufferLength.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlbBufferLength.ColumnCount = 3;
			this.tlbBufferLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tlbBufferLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tlbBufferLength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
			this.tlbBufferLength.Controls.Add(this.numericUpDown1, 1, 0);
			this.tlbBufferLength.Controls.Add(this.label1, 0, 0);
			this.tlbBufferLength.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlbBufferLength.Location = new System.Drawing.Point(0, 199);
			this.tlbBufferLength.Name = "tlbBufferLength";
			this.tlbBufferLength.RowCount = 1;
			this.tlbBufferLength.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlbBufferLength.Size = new System.Drawing.Size(441, 26);
			this.tlbBufferLength.TabIndex = 9;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
			this.numericUpDown1.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(253, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(144, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.ThousandsSeparator = true;
			this.numericUpDown1.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Taille du buffer (en nombre de caractères)";
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
			this.tlpTimeStamp.Controls.Add(this.cdTimeStamp, 1, 0);
			this.tlpTimeStamp.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpTimeStamp.Location = new System.Drawing.Point(0, 0);
			this.tlpTimeStamp.Name = "tlpTimeStamp";
			this.tlpTimeStamp.RowCount = 1;
			this.tlpTimeStamp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpTimeStamp.Size = new System.Drawing.Size(441, 27);
			this.tlpTimeStamp.TabIndex = 10;
			// 
			// cdTimeStamp
			// 
			this.cdTimeStamp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cdTimeStamp.FormattingEnabled = true;
			this.cdTimeStamp.Location = new System.Drawing.Point(168, 3);
			this.cdTimeStamp.Name = "cdTimeStamp";
			this.cdTimeStamp.Size = new System.Drawing.Size(135, 21);
			this.cdTimeStamp.TabIndex = 3;
			// 
			// tlbDataAnalyser
			// 
			this.tlbDataAnalyser.AutoSize = true;
			this.tlbDataAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlbDataAnalyser.ColumnCount = 3;
			this.tlbDataAnalyser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tlbDataAnalyser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlbDataAnalyser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlbDataAnalyser.Controls.Add(this.pbFileAnalyser, 2, 0);
			this.tlbDataAnalyser.Controls.Add(this.tbLocationFileAnalyser, 1, 0);
			this.tlbDataAnalyser.Controls.Add(this.pbCreateNewFileAnalyser, 2, 1);
			this.tlbDataAnalyser.Controls.Add(this.textBox1, 1, 2);
			this.tlbDataAnalyser.Controls.Add(this.pbOutputDataAnalyser, 2, 2);
			this.tlbDataAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlbDataAnalyser.Location = new System.Drawing.Point(0, 44);
			this.tlbDataAnalyser.Margin = new System.Windows.Forms.Padding(0);
			this.tlbDataAnalyser.MinimumSize = new System.Drawing.Size(0, 88);
			this.tlbDataAnalyser.Name = "tlbDataAnalyser";
			this.tlbDataAnalyser.RowCount = 3;
			this.tlbDataAnalyser.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlbDataAnalyser.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlbDataAnalyser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlbDataAnalyser.Size = new System.Drawing.Size(441, 88);
			this.tlbDataAnalyser.TabIndex = 11;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(18, 63);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(200, 20);
			this.textBox1.TabIndex = 7;
			// 
			// pbOutputDataAnalyser
			// 
			this.pbOutputDataAnalyser.AutoSize = true;
			this.pbOutputDataAnalyser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbOutputDataAnalyser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbOutputDataAnalyser.Location = new System.Drawing.Point(224, 61);
			this.pbOutputDataAnalyser.Name = "pbOutputDataAnalyser";
			this.pbOutputDataAnalyser.Size = new System.Drawing.Size(214, 23);
			this.pbOutputDataAnalyser.TabIndex = 8;
			this.pbOutputDataAnalyser.Text = "Sortie d\'analyse";
			this.pbOutputDataAnalyser.UseVisualStyleBackColor = true;
			// 
			// OptionTerminalDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlbBufferLength);
			this.Controls.Add(this.tlpTerminalColor);
			this.Controls.Add(this.tlbDataAnalyser);
			this.Controls.Add(this.cbDataAnalyser);
			this.Controls.Add(this.tlpTimeStamp);
			this.MinimumSize = new System.Drawing.Size(441, 231);
			this.Name = "OptionTerminalDisplay";
			this.Size = new System.Drawing.Size(441, 231);
			this.tlpTerminalColor.ResumeLayout(false);
			this.tlbBufferLength.ResumeLayout(false);
			this.tlbBufferLength.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tlpTimeStamp.ResumeLayout(false);
			this.tlpTimeStamp.PerformLayout();
			this.tlbDataAnalyser.ResumeLayout(false);
			this.tlbDataAnalyser.PerformLayout();
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
		private System.Windows.Forms.Button pbTeminaColor;
		private System.Windows.Forms.TableLayoutPanel tlbBufferLength;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tlpTimeStamp;
		private System.Windows.Forms.ComboBox cdTimeStamp;
		private System.Windows.Forms.TableLayoutPanel tlbDataAnalyser;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button pbOutputDataAnalyser;
		private System.Windows.Forms.RichTextBox rtbColorExample;
	}
}
