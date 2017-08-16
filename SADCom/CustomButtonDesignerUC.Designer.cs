namespace SADCom.UserButton {
	partial class CustomButtonDesignerUC {
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
			this.pbDeletButton = new System.Windows.Forms.Button();
			this.tbButtonName = new System.Windows.Forms.TextBox();
			this.tbRequest = new System.Windows.Forms.TextBox();
			this.cbPeriodicRequest = new System.Windows.Forms.CheckBox();
			this.numUpDownPeriodOfRequest = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPeriodOfRequest)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
			this.tableLayoutPanel1.Controls.Add(this.pbDeletButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbButtonName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbRequest, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbPeriodicRequest, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.numUpDownPeriodOfRequest, 4, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 20);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pbDeletButton
			// 
			this.pbDeletButton.AutoSize = true;
			this.pbDeletButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbDeletButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbDeletButton.Location = new System.Drawing.Point(0, 0);
			this.pbDeletButton.Margin = new System.Windows.Forms.Padding(0);
			this.pbDeletButton.MaximumSize = new System.Drawing.Size(20, 20);
			this.pbDeletButton.MinimumSize = new System.Drawing.Size(20, 20);
			this.pbDeletButton.Name = "pbDeletButton";
			this.pbDeletButton.Size = new System.Drawing.Size(20, 20);
			this.pbDeletButton.TabIndex = 0;
			this.pbDeletButton.Text = "x";
			this.pbDeletButton.UseVisualStyleBackColor = true;
			this.pbDeletButton.Click += new System.EventHandler(this.pbDeletButton_Click);
			// 
			// tbButtonName
			// 
			this.tbButtonName.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbButtonName.Location = new System.Drawing.Point(20, 0);
			this.tbButtonName.Margin = new System.Windows.Forms.Padding(0);
			this.tbButtonName.Name = "tbButtonName";
			this.tbButtonName.Size = new System.Drawing.Size(154, 20);
			this.tbButtonName.TabIndex = 1;
			this.tbButtonName.TextChanged += new System.EventHandler(this.tbButtonName_TextChanged);
			// 
			// tbRequest
			// 
			this.tbRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbRequest.Location = new System.Drawing.Point(174, 0);
			this.tbRequest.Margin = new System.Windows.Forms.Padding(0);
			this.tbRequest.Name = "tbRequest";
			this.tbRequest.Size = new System.Drawing.Size(154, 20);
			this.tbRequest.TabIndex = 2;
			this.tbRequest.TextChanged += new System.EventHandler(this.tbRequest_TextChanged);
			// 
			// cbPeriodicRequest
			// 
			this.cbPeriodicRequest.AutoSize = true;
			this.cbPeriodicRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbPeriodicRequest.Location = new System.Drawing.Point(328, 0);
			this.cbPeriodicRequest.Margin = new System.Windows.Forms.Padding(0);
			this.cbPeriodicRequest.Name = "cbPeriodicRequest";
			this.cbPeriodicRequest.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
			this.cbPeriodicRequest.Size = new System.Drawing.Size(17, 17);
			this.cbPeriodicRequest.TabIndex = 3;
			this.cbPeriodicRequest.UseVisualStyleBackColor = true;
			this.cbPeriodicRequest.CheckedChanged += new System.EventHandler(this.cbPeriodicRequest_CheckedChanged);
			// 
			// numUpDownPeriodOfRequest
			// 
			this.numUpDownPeriodOfRequest.AutoSize = true;
			this.numUpDownPeriodOfRequest.DecimalPlaces = 6;
			this.numUpDownPeriodOfRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.numUpDownPeriodOfRequest.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
			this.numUpDownPeriodOfRequest.Location = new System.Drawing.Point(345, 0);
			this.numUpDownPeriodOfRequest.Margin = new System.Windows.Forms.Padding(0);
			this.numUpDownPeriodOfRequest.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numUpDownPeriodOfRequest.MaximumSize = new System.Drawing.Size(100, 0);
			this.numUpDownPeriodOfRequest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
			this.numUpDownPeriodOfRequest.Name = "numUpDownPeriodOfRequest";
			this.numUpDownPeriodOfRequest.Size = new System.Drawing.Size(92, 20);
			this.numUpDownPeriodOfRequest.TabIndex = 4;
			this.numUpDownPeriodOfRequest.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.numUpDownPeriodOfRequest.ValueChanged += new System.EventHandler(this.numUpDownPeriodOfRequest_ValueChanged);
			// 
			// CustomButtonDesignerUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "CustomButtonDesignerUC";
			this.Size = new System.Drawing.Size(437, 60);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPeriodOfRequest)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button pbDeletButton;
		private System.Windows.Forms.TextBox tbButtonName;
		private System.Windows.Forms.TextBox tbRequest;
		private System.Windows.Forms.CheckBox cbPeriodicRequest;
		private System.Windows.Forms.NumericUpDown numUpDownPeriodOfRequest;
	}
}
