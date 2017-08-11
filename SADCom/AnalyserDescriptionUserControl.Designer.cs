﻿namespace SADCom {
	partial class AnalyserDescriptionUserControl {
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tbKeyWord = new System.Windows.Forms.TextBox();
			this.tbSubstitutionWords = new System.Windows.Forms.TextBox();
			this.pbFontText = new System.Windows.Forms.Button();
			this.rtbResult = new System.Windows.Forms.RichTextBox();
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
			this.tableLayoutPanel1.Controls.Add(this.tbKeyWord, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbSubstitutionWords, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbFontText, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.rtbResult, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 20);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tbKeyWord
			// 
			this.tbKeyWord.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbKeyWord.Location = new System.Drawing.Point(0, 0);
			this.tbKeyWord.Margin = new System.Windows.Forms.Padding(0);
			this.tbKeyWord.Name = "tbKeyWord";
			this.tbKeyWord.Size = new System.Drawing.Size(184, 20);
			this.tbKeyWord.TabIndex = 0;
			this.tbKeyWord.TextChanged += new System.EventHandler(this.tbKeyWord_TextChanged);
			// 
			// tbSubstitutionWords
			// 
			this.tbSubstitutionWords.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbSubstitutionWords.Location = new System.Drawing.Point(184, 0);
			this.tbSubstitutionWords.Margin = new System.Windows.Forms.Padding(0);
			this.tbSubstitutionWords.Name = "tbSubstitutionWords";
			this.tbSubstitutionWords.Size = new System.Drawing.Size(184, 20);
			this.tbSubstitutionWords.TabIndex = 3;
			this.tbSubstitutionWords.TextChanged += new System.EventHandler(this.tbSubstitutionWords_TextChanged);
			// 
			// pbFontText
			// 
			this.pbFontText.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbFontText.Location = new System.Drawing.Point(368, 0);
			this.pbFontText.Margin = new System.Windows.Forms.Padding(0);
			this.pbFontText.MaximumSize = new System.Drawing.Size(0, 20);
			this.pbFontText.Name = "pbFontText";
			this.pbFontText.Size = new System.Drawing.Size(90, 20);
			this.pbFontText.TabIndex = 4;
			this.pbFontText.Text = "Font && color";
			this.pbFontText.UseVisualStyleBackColor = true;
			this.pbFontText.Click += new System.EventHandler(this.pbFontText_Click);
			// 
			// rtbResult
			// 
			this.rtbResult.Dock = System.Windows.Forms.DockStyle.Top;
			this.rtbResult.Location = new System.Drawing.Point(458, 0);
			this.rtbResult.Margin = new System.Windows.Forms.Padding(0);
			this.rtbResult.Name = "rtbResult";
			this.rtbResult.ReadOnly = true;
			this.rtbResult.Size = new System.Drawing.Size(187, 20);
			this.rtbResult.TabIndex = 5;
			this.rtbResult.Text = "";
			// 
			// AnalyserDescriptionUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "AnalyserDescriptionUserControl";
			this.Size = new System.Drawing.Size(645, 26);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox tbKeyWord;
		private System.Windows.Forms.TextBox tbSubstitutionWords;
		private System.Windows.Forms.Button pbFontText;
		private System.Windows.Forms.RichTextBox rtbResult;
	}
}
