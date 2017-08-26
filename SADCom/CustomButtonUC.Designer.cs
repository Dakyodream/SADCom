namespace SADCom.UserButton {
	partial class CustomButtonUC {
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
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pbCmd = new System.Windows.Forms.Button();
			this.cmsCmdButtonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tlsiEditButtonName = new System.Windows.Forms.ToolStripMenuItem();
			this.tbButtonName = new System.Windows.Forms.TextBox();
			this.pbDeletButton = new System.Windows.Forms.Button();
			this.pbConnexionStateLight = new System.Windows.Forms.PictureBox();
			this.numUpDownPeriodOfRequest = new System.Windows.Forms.NumericUpDown();
			this.cbPeriodicRequest = new System.Windows.Forms.CheckBox();
			this.tbRequest = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.cmsCmdButtonMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConnexionStateLight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPeriodOfRequest)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel1.Controls.Add(this.pbCmd, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbButtonName, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbDeletButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbConnexionStateLight, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.numUpDownPeriodOfRequest, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbPeriodicRequest, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbRequest, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 23);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pbCmd
			// 
			this.pbCmd.AutoSize = true;
			this.pbCmd.ContextMenuStrip = this.cmsCmdButtonMenu;
			this.pbCmd.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbCmd.Location = new System.Drawing.Point(23, 0);
			this.pbCmd.Margin = new System.Windows.Forms.Padding(0);
			this.pbCmd.MaximumSize = new System.Drawing.Size(0, 23);
			this.pbCmd.Name = "pbCmd";
			this.pbCmd.Size = new System.Drawing.Size(186, 23);
			this.pbCmd.TabIndex = 2;
			this.pbCmd.Text = "Button";
			this.pbCmd.UseVisualStyleBackColor = false;
			this.pbCmd.Click += new System.EventHandler(this.pbCmd_Click);
			// 
			// cmsCmdButtonMenu
			// 
			this.cmsCmdButtonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsiEditButtonName});
			this.cmsCmdButtonMenu.Name = "cmsCmdButtonMenu";
			this.cmsCmdButtonMenu.Size = new System.Drawing.Size(120, 26);
			// 
			// tlsiEditButtonName
			// 
			this.tlsiEditButtonName.Name = "tlsiEditButtonName";
			this.tlsiEditButtonName.Size = new System.Drawing.Size(119, 22);
			this.tlsiEditButtonName.Text = "Modifier";
			this.tlsiEditButtonName.Click += new System.EventHandler(this.tlsiEditButtonName_Click);
			// 
			// tbButtonName
			// 
			this.tbButtonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbButtonName.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbButtonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbButtonName.Location = new System.Drawing.Point(209, 0);
			this.tbButtonName.Margin = new System.Windows.Forms.Padding(0);
			this.tbButtonName.Name = "tbButtonName";
			this.tbButtonName.Size = new System.Drawing.Size(186, 23);
			this.tbButtonName.TabIndex = 1;
			this.tbButtonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbButtonName.TextChanged += new System.EventHandler(this.tbButtonName_TextChanged);
			this.tbButtonName.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tbButtonName_ControlRemoved);
			this.tbButtonName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbButtonName_KeyPress);
			this.tbButtonName.Validated += new System.EventHandler(this.tbButtonName_Validated);
			// 
			// pbDeletButton
			// 
			this.pbDeletButton.AutoSize = true;
			this.pbDeletButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbDeletButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbDeletButton.Location = new System.Drawing.Point(0, 0);
			this.pbDeletButton.Margin = new System.Windows.Forms.Padding(0);
			this.pbDeletButton.MaximumSize = new System.Drawing.Size(22, 23);
			this.pbDeletButton.MinimumSize = new System.Drawing.Size(22, 23);
			this.pbDeletButton.Name = "pbDeletButton";
			this.pbDeletButton.Size = new System.Drawing.Size(22, 23);
			this.pbDeletButton.TabIndex = 0;
			this.pbDeletButton.Text = "x";
			this.pbDeletButton.UseVisualStyleBackColor = true;
			this.pbDeletButton.Click += new System.EventHandler(this.pbDeletButton_Click);
			// 
			// pbConnexionStateLight
			// 
			this.pbConnexionStateLight.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbConnexionStateLight.Image = global::SADCom.Properties.Resources.SilverLight;
			this.pbConnexionStateLight.Location = new System.Drawing.Point(691, 0);
			this.pbConnexionStateLight.Margin = new System.Windows.Forms.Padding(0);
			this.pbConnexionStateLight.MaximumSize = new System.Drawing.Size(23, 23);
			this.pbConnexionStateLight.MinimumSize = new System.Drawing.Size(23, 23);
			this.pbConnexionStateLight.Name = "pbConnexionStateLight";
			this.pbConnexionStateLight.Size = new System.Drawing.Size(23, 23);
			this.pbConnexionStateLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbConnexionStateLight.TabIndex = 1;
			this.pbConnexionStateLight.TabStop = false;
			// 
			// numUpDownPeriodOfRequest
			// 
			this.numUpDownPeriodOfRequest.AutoSize = true;
			this.numUpDownPeriodOfRequest.DecimalPlaces = 3;
			this.numUpDownPeriodOfRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.numUpDownPeriodOfRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.numUpDownPeriodOfRequest.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
			this.numUpDownPeriodOfRequest.Location = new System.Drawing.Point(598, 0);
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
            196608});
			this.numUpDownPeriodOfRequest.Name = "numUpDownPeriodOfRequest";
			this.numUpDownPeriodOfRequest.Size = new System.Drawing.Size(93, 23);
			this.numUpDownPeriodOfRequest.TabIndex = 4;
			this.numUpDownPeriodOfRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDownPeriodOfRequest.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.numUpDownPeriodOfRequest.ValueChanged += new System.EventHandler(this.numUpDownPeriodOfRequest_ValueChanged);
			// 
			// cbPeriodicRequest
			// 
			this.cbPeriodicRequest.AutoSize = true;
			this.cbPeriodicRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbPeriodicRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cbPeriodicRequest.Location = new System.Drawing.Point(581, 0);
			this.cbPeriodicRequest.Margin = new System.Windows.Forms.Padding(0);
			this.cbPeriodicRequest.Name = "cbPeriodicRequest";
			this.cbPeriodicRequest.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
			this.cbPeriodicRequest.Size = new System.Drawing.Size(17, 19);
			this.cbPeriodicRequest.TabIndex = 3;
			this.cbPeriodicRequest.UseVisualStyleBackColor = true;
			this.cbPeriodicRequest.CheckedChanged += new System.EventHandler(this.cbPeriodicRequest_CheckedChanged);
			// 
			// tbRequest
			// 
			this.tbRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbRequest.Location = new System.Drawing.Point(395, 0);
			this.tbRequest.Margin = new System.Windows.Forms.Padding(0);
			this.tbRequest.Name = "tbRequest";
			this.tbRequest.Size = new System.Drawing.Size(186, 23);
			this.tbRequest.TabIndex = 2;
			this.tbRequest.TextChanged += new System.EventHandler(this.tbRequest_TextChanged);
			// 
			// CustomButtonUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "CustomButtonUC";
			this.Size = new System.Drawing.Size(714, 180);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.cmsCmdButtonMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbConnexionStateLight)).EndInit();
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
		private System.Windows.Forms.PictureBox pbConnexionStateLight;
		private System.Windows.Forms.Button pbCmd;
		private System.Windows.Forms.ContextMenuStrip cmsCmdButtonMenu;
		private System.Windows.Forms.ToolStripMenuItem tlsiEditButtonName;
	}
}
