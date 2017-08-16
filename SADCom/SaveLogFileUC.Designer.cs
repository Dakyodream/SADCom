namespace SADCom {
	partial class SaveDataFileUC {
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
			this.tbDataFileAddr = new System.Windows.Forms.TextBox();
			this.pbNewDataFile = new System.Windows.Forms.Button();
			this.pbClearDataFileAddr = new System.Windows.Forms.Button();
			this.cbSaveTimestampInDataFile = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tbDataFileAddr, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbNewDataFile, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbClearDataFileAddr, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 29);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tbDataFileAddr
			// 
			this.tbDataFileAddr.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbDataFileAddr.Location = new System.Drawing.Point(3, 4);
			this.tbDataFileAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
			this.tbDataFileAddr.MinimumSize = new System.Drawing.Size(110, 4);
			this.tbDataFileAddr.Name = "tbDataFileAddr";
			this.tbDataFileAddr.ReadOnly = true;
			this.tbDataFileAddr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tbDataFileAddr.Size = new System.Drawing.Size(262, 20);
			this.tbDataFileAddr.TabIndex = 0;
			// 
			// pbNewDataFile
			// 
			this.pbNewDataFile.AutoSize = true;
			this.pbNewDataFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbNewDataFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbNewDataFile.Location = new System.Drawing.Point(271, 3);
			this.pbNewDataFile.Name = "pbNewDataFile";
			this.pbNewDataFile.Size = new System.Drawing.Size(26, 23);
			this.pbNewDataFile.TabIndex = 1;
			this.pbNewDataFile.Text = "...";
			this.pbNewDataFile.UseVisualStyleBackColor = true;
			this.pbNewDataFile.Click += new System.EventHandler(this.pbNewDataFile_Click);
			// 
			// pbClearDataFileAddr
			// 
			this.pbClearDataFileAddr.AutoSize = true;
			this.pbClearDataFileAddr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbClearDataFileAddr.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbClearDataFileAddr.Location = new System.Drawing.Point(303, 3);
			this.pbClearDataFileAddr.MaximumSize = new System.Drawing.Size(61, 23);
			this.pbClearDataFileAddr.MinimumSize = new System.Drawing.Size(61, 23);
			this.pbClearDataFileAddr.Name = "pbClearDataFileAddr";
			this.pbClearDataFileAddr.Size = new System.Drawing.Size(61, 23);
			this.pbClearDataFileAddr.TabIndex = 2;
			this.pbClearDataFileAddr.Text = "Effacer";
			this.pbClearDataFileAddr.UseVisualStyleBackColor = true;
			this.pbClearDataFileAddr.Click += new System.EventHandler(this.pbClearDataFileAddr_Click);
			// 
			// cbSaveTimestampInDataFile
			// 
			this.cbSaveTimestampInDataFile.AutoSize = true;
			this.cbSaveTimestampInDataFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbSaveTimestampInDataFile.Location = new System.Drawing.Point(0, 29);
			this.cbSaveTimestampInDataFile.Name = "cbSaveTimestampInDataFile";
			this.cbSaveTimestampInDataFile.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.cbSaveTimestampInDataFile.Size = new System.Drawing.Size(367, 17);
			this.cbSaveTimestampInDataFile.TabIndex = 1;
			this.cbSaveTimestampInDataFile.Text = "Sauvegarder l\'horodatage";
			this.cbSaveTimestampInDataFile.UseVisualStyleBackColor = true;
			this.cbSaveTimestampInDataFile.CheckedChanged += new System.EventHandler(this.cbSaveTimestampInDataFile_CheckedChanged);
			// 
			// SaveDataFileUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbSaveTimestampInDataFile);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SaveDataFileUC";
			this.Size = new System.Drawing.Size(367, 67);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox tbDataFileAddr;
		private System.Windows.Forms.Button pbNewDataFile;
		private System.Windows.Forms.Button pbClearDataFileAddr;
		private System.Windows.Forms.CheckBox cbSaveTimestampInDataFile;
	}
}
