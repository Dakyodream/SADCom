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
			this.pbDeletButton = new System.Windows.Forms.Button();
			this.tbRequest = new System.Windows.Forms.TextBox();
			this.cbPeriodicRequest = new System.Windows.Forms.CheckBox();
			this.numUpDownPeriodOfRequest = new System.Windows.Forms.NumericUpDown();
			this.tbButtonName = new System.Windows.Forms.TextBox();
			this.pbSilverLight = new System.Windows.Forms.PictureBox();
			this.pbYellowLight = new System.Windows.Forms.PictureBox();
			this.pbRedLight = new System.Windows.Forms.PictureBox();
			this.pbGreenLight = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.cmsCmdButtonMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPeriodOfRequest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSilverLight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbYellowLight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRedLight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreenLight)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 10;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.pbCmd, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbRedLight, 8, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbButtonName, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbDeletButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbSilverLight, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbYellowLight, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbGreenLight, 9, 0);
			this.tableLayoutPanel1.Controls.Add(this.numUpDownPeriodOfRequest, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbPeriodicRequest, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbRequest, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 20);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pbCmd
			// 
			this.pbCmd.AutoSize = true;
			this.pbCmd.ContextMenuStrip = this.cmsCmdButtonMenu;
			this.pbCmd.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbCmd.Location = new System.Drawing.Point(20, 0);
			this.pbCmd.Margin = new System.Windows.Forms.Padding(0);
			this.pbCmd.MaximumSize = new System.Drawing.Size(0, 20);
			this.pbCmd.Name = "pbCmd";
			this.pbCmd.Size = new System.Drawing.Size(167, 20);
			this.pbCmd.TabIndex = 2;
			this.pbCmd.Text = "button1";
			this.pbCmd.UseVisualStyleBackColor = true;
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
			// tbRequest
			// 
			this.tbRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbRequest.Location = new System.Drawing.Point(354, 0);
			this.tbRequest.Margin = new System.Windows.Forms.Padding(0);
			this.tbRequest.Name = "tbRequest";
			this.tbRequest.Size = new System.Drawing.Size(167, 20);
			this.tbRequest.TabIndex = 2;
			this.tbRequest.TextChanged += new System.EventHandler(this.tbRequest_TextChanged);
			// 
			// cbPeriodicRequest
			// 
			this.cbPeriodicRequest.AutoSize = true;
			this.cbPeriodicRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbPeriodicRequest.Location = new System.Drawing.Point(521, 0);
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
			this.numUpDownPeriodOfRequest.Location = new System.Drawing.Point(538, 0);
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
			this.numUpDownPeriodOfRequest.Size = new System.Drawing.Size(93, 20);
			this.numUpDownPeriodOfRequest.TabIndex = 4;
			this.numUpDownPeriodOfRequest.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.numUpDownPeriodOfRequest.ValueChanged += new System.EventHandler(this.numUpDownPeriodOfRequest_ValueChanged);
			// 
			// tbButtonName
			// 
			this.tbButtonName.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbButtonName.Location = new System.Drawing.Point(187, 0);
			this.tbButtonName.Margin = new System.Windows.Forms.Padding(0);
			this.tbButtonName.Name = "tbButtonName";
			this.tbButtonName.Size = new System.Drawing.Size(167, 20);
			this.tbButtonName.TabIndex = 1;
			this.tbButtonName.TextChanged += new System.EventHandler(this.tbButtonName_TextChanged);
			this.tbButtonName.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tbButtonName_ControlRemoved);
			this.tbButtonName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbButtonName_KeyPress);
			this.tbButtonName.Validated += new System.EventHandler(this.tbButtonName_Validated);
			// 
			// pbSilverLight
			// 
			this.pbSilverLight.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbSilverLight.Image = global::SADCom.Properties.Resources.SilverLight;
			this.pbSilverLight.Location = new System.Drawing.Point(631, 0);
			this.pbSilverLight.Margin = new System.Windows.Forms.Padding(0);
			this.pbSilverLight.MaximumSize = new System.Drawing.Size(20, 20);
			this.pbSilverLight.Name = "pbSilverLight";
			this.pbSilverLight.Size = new System.Drawing.Size(20, 20);
			this.pbSilverLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbSilverLight.TabIndex = 1;
			this.pbSilverLight.TabStop = false;
			// 
			// pbYellowLight
			// 
			this.pbYellowLight.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbYellowLight.Image = global::SADCom.Properties.Resources.YellowLight;
			this.pbYellowLight.Location = new System.Drawing.Point(651, 0);
			this.pbYellowLight.Margin = new System.Windows.Forms.Padding(0);
			this.pbYellowLight.MaximumSize = new System.Drawing.Size(20, 20);
			this.pbYellowLight.Name = "pbYellowLight";
			this.pbYellowLight.Size = new System.Drawing.Size(20, 20);
			this.pbYellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbYellowLight.TabIndex = 1;
			this.pbYellowLight.TabStop = false;
			// 
			// pbRedLight
			// 
			this.pbRedLight.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbRedLight.Image = global::SADCom.Properties.Resources.RedLight;
			this.pbRedLight.Location = new System.Drawing.Point(671, 0);
			this.pbRedLight.Margin = new System.Windows.Forms.Padding(0);
			this.pbRedLight.MaximumSize = new System.Drawing.Size(20, 20);
			this.pbRedLight.Name = "pbRedLight";
			this.pbRedLight.Size = new System.Drawing.Size(20, 20);
			this.pbRedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbRedLight.TabIndex = 1;
			this.pbRedLight.TabStop = false;
			// 
			// pbGreenLight
			// 
			this.pbGreenLight.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbGreenLight.Image = global::SADCom.Properties.Resources.GreenLight;
			this.pbGreenLight.Location = new System.Drawing.Point(691, 0);
			this.pbGreenLight.Margin = new System.Windows.Forms.Padding(0);
			this.pbGreenLight.MaximumSize = new System.Drawing.Size(20, 20);
			this.pbGreenLight.Name = "pbGreenLight";
			this.pbGreenLight.Size = new System.Drawing.Size(20, 20);
			this.pbGreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbGreenLight.TabIndex = 1;
			this.pbGreenLight.TabStop = false;
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
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPeriodOfRequest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSilverLight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbYellowLight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRedLight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreenLight)).EndInit();
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
		private System.Windows.Forms.PictureBox pbSilverLight;
		private System.Windows.Forms.PictureBox pbRedLight;
		private System.Windows.Forms.PictureBox pbGreenLight;
		private System.Windows.Forms.PictureBox pbYellowLight;
		private System.Windows.Forms.Button pbCmd;
		private System.Windows.Forms.ContextMenuStrip cmsCmdButtonMenu;
		private System.Windows.Forms.ToolStripMenuItem tlsiEditButtonName;
	}
}
