namespace SADCom {
	partial class AnalyserDescriptionForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
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
			SADCom.AnalyserKeyWord analyserKeyWord1 = new SADCom.AnalyserKeyWord();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.analyserDescriptionUserControl1 = new SADCom.AnalyserDescriptionUserControl();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 13);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mots clef";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(196, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "text de remplacement";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(482, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "rendue";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// analyserDescriptionUserControl1
			// 
			analyserKeyWord1.KeyWord = "";
			analyserKeyWord1.KeyWordColor = System.Drawing.Color.White;
			analyserKeyWord1.KeyWordFont = new System.Drawing.Font("Lucida Console", 10F);
			analyserKeyWord1.NotifiedLogTerminal = false;
			analyserKeyWord1.SubstitutionWords = "";
			this.analyserDescriptionUserControl1.AnalyserKeyWord = analyserKeyWord1;
			this.analyserDescriptionUserControl1.AutoSize = true;
			this.analyserDescriptionUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.analyserDescriptionUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.analyserDescriptionUserControl1.Location = new System.Drawing.Point(0, 13);
			this.analyserDescriptionUserControl1.Margin = new System.Windows.Forms.Padding(0);
			this.analyserDescriptionUserControl1.Name = "analyserDescriptionUserControl1";
			this.analyserDescriptionUserControl1.Size = new System.Drawing.Size(680, 20);
			this.analyserDescriptionUserControl1.TabIndex = 1;
			// 
			// AnalyserDescriptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 261);
			this.Controls.Add(this.analyserDescriptionUserControl1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AnalyserDescriptionForm";
			this.Text = "AnalyserDescriptionForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private AnalyserDescriptionUserControl analyserDescriptionUserControl1;
	}
}