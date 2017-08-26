namespace SADCom {
	partial class OptionCustomButtonUC {
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
			this.pbClearAddrCustomButtonFile = new System.Windows.Forms.Button();
			this.tbAddrCustomButtonFile = new System.Windows.Forms.TextBox();
			this.pbSearchCustomButtonFile = new System.Windows.Forms.Button();
			this.pbNewCustomButtonFile = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbClearAddrCustomButtonFile
			// 
			this.pbClearAddrCustomButtonFile.AutoSize = true;
			this.pbClearAddrCustomButtonFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbClearAddrCustomButtonFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbClearAddrCustomButtonFile.Location = new System.Drawing.Point(3, 3);
			this.pbClearAddrCustomButtonFile.MaximumSize = new System.Drawing.Size(0, 20);
			this.pbClearAddrCustomButtonFile.Name = "pbClearAddrCustomButtonFile";
			this.pbClearAddrCustomButtonFile.Size = new System.Drawing.Size(24, 20);
			this.pbClearAddrCustomButtonFile.TabIndex = 0;
			this.pbClearAddrCustomButtonFile.Text = "X";
			this.pbClearAddrCustomButtonFile.UseVisualStyleBackColor = true;
			this.pbClearAddrCustomButtonFile.Click += new System.EventHandler(this.pbClearAddrCustomButtonFile_Click);
			// 
			// tbAddrCustomButtonFile
			// 
			this.tbAddrCustomButtonFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbAddrCustomButtonFile.Location = new System.Drawing.Point(33, 3);
			this.tbAddrCustomButtonFile.Name = "tbAddrCustomButtonFile";
			this.tbAddrCustomButtonFile.ReadOnly = true;
			this.tbAddrCustomButtonFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tbAddrCustomButtonFile.Size = new System.Drawing.Size(305, 20);
			this.tbAddrCustomButtonFile.TabIndex = 1;
			// 
			// pbSearchCustomButtonFile
			// 
			this.pbSearchCustomButtonFile.AutoSize = true;
			this.pbSearchCustomButtonFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbSearchCustomButtonFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbSearchCustomButtonFile.Location = new System.Drawing.Point(344, 3);
			this.pbSearchCustomButtonFile.MaximumSize = new System.Drawing.Size(0, 20);
			this.pbSearchCustomButtonFile.Name = "pbSearchCustomButtonFile";
			this.pbSearchCustomButtonFile.Size = new System.Drawing.Size(26, 20);
			this.pbSearchCustomButtonFile.TabIndex = 2;
			this.pbSearchCustomButtonFile.Text = "...";
			this.pbSearchCustomButtonFile.UseVisualStyleBackColor = true;
			this.pbSearchCustomButtonFile.Click += new System.EventHandler(this.pbSearchCustomButtonFile_Click);
			// 
			// pbNewCustomButtonFile
			// 
			this.pbNewCustomButtonFile.AutoSize = true;
			this.pbNewCustomButtonFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbNewCustomButtonFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbNewCustomButtonFile.Location = new System.Drawing.Point(376, 3);
			this.pbNewCustomButtonFile.MaximumSize = new System.Drawing.Size(0, 20);
			this.pbNewCustomButtonFile.Name = "pbNewCustomButtonFile";
			this.pbNewCustomButtonFile.Size = new System.Drawing.Size(192, 20);
			this.pbNewCustomButtonFile.TabIndex = 3;
			this.pbNewCustomButtonFile.Text = "Crée ou Modifier une liste de boutons";
			this.pbNewCustomButtonFile.UseVisualStyleBackColor = true;
			this.pbNewCustomButtonFile.Click += new System.EventHandler(this.pbNewCustomButtonFile_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.pbSearchCustomButtonFile, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.pbNewCustomButtonFile, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.tbAddrCustomButtonFile, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.pbClearAddrCustomButtonFile, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 26);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// OptionCustomButtonUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "OptionCustomButtonUC";
			this.Size = new System.Drawing.Size(571, 105);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button pbClearAddrCustomButtonFile;
		private System.Windows.Forms.TextBox tbAddrCustomButtonFile;
		private System.Windows.Forms.Button pbSearchCustomButtonFile;
		private System.Windows.Forms.Button pbNewCustomButtonFile;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}
