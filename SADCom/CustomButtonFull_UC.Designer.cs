namespace SADCom.UserButton {
	partial class CustomButtonFull_UC {
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
			this.pbSendCmd = new System.Windows.Forms.Button();
			this.tbCmd = new System.Windows.Forms.TextBox();
			this.numUpDownPeriodOfRequest = new System.Windows.Forms.NumericUpDown();
			this.pictureBoxState = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPeriodOfRequest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxState)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.pbSendCmd, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbCmd, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.numUpDownPeriodOfRequest, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBoxState, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 20);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pbSendCmd
			// 
			this.pbSendCmd.AutoSize = true;
			this.pbSendCmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pbSendCmd.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbSendCmd.Location = new System.Drawing.Point(0, 0);
			this.pbSendCmd.Margin = new System.Windows.Forms.Padding(0);
			this.pbSendCmd.MaximumSize = new System.Drawing.Size(0, 20);
			this.pbSendCmd.MinimumSize = new System.Drawing.Size(20, 20);
			this.pbSendCmd.Name = "pbSendCmd";
			this.pbSendCmd.Size = new System.Drawing.Size(128, 20);
			this.pbSendCmd.TabIndex = 0;
			this.pbSendCmd.Text = "button1";
			this.pbSendCmd.UseVisualStyleBackColor = true;
			this.pbSendCmd.Click += new System.EventHandler(this.pbSendCmd_Click);
			// 
			// tbCmd
			// 
			this.tbCmd.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbCmd.Location = new System.Drawing.Point(128, 0);
			this.tbCmd.Margin = new System.Windows.Forms.Padding(0);
			this.tbCmd.Name = "tbCmd";
			this.tbCmd.Size = new System.Drawing.Size(128, 20);
			this.tbCmd.TabIndex = 1;
			this.tbCmd.TextChanged += new System.EventHandler(this.tbCmd_TextChanged);
			// 
			// numUpDownPeriodOfRequest
			// 
			this.numUpDownPeriodOfRequest.DecimalPlaces = 6;
			this.numUpDownPeriodOfRequest.Dock = System.Windows.Forms.DockStyle.Top;
			this.numUpDownPeriodOfRequest.Increment = new decimal(new int[] {
			5,
			0,
			0,
			196608});
			this.numUpDownPeriodOfRequest.Location = new System.Drawing.Point(256, 0);
			this.numUpDownPeriodOfRequest.Margin = new System.Windows.Forms.Padding(0);
			this.numUpDownPeriodOfRequest.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numUpDownPeriodOfRequest.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			393216});
			this.numUpDownPeriodOfRequest.Name = "numUpDownPeriodOfRequest";
			this.numUpDownPeriodOfRequest.Size = new System.Drawing.Size(120, 20);
			this.numUpDownPeriodOfRequest.TabIndex = 2;
			this.numUpDownPeriodOfRequest.Value = new decimal(new int[] {
			1,
			0,
			0,
			393216});
			this.numUpDownPeriodOfRequest.ValueChanged += new System.EventHandler(this.numUpDownPeriodOfRequest_ValueChanged);
			// 
			// pictureBoxState
			// 
			this.pictureBoxState.BackColor = System.Drawing.Color.Gray;
			this.pictureBoxState.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBoxState.Location = new System.Drawing.Point(376, 0);
			this.pictureBoxState.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBoxState.MaximumSize = new System.Drawing.Size(20, 20);
			this.pictureBoxState.MinimumSize = new System.Drawing.Size(20, 20);
			this.pictureBoxState.Name = "pictureBoxState";
			this.pictureBoxState.Size = new System.Drawing.Size(20, 20);
			this.pictureBoxState.TabIndex = 3;
			this.pictureBoxState.TabStop = false;
			// 
			// CustomButtonFull_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "CustomButtonFull_UC";
			this.Size = new System.Drawing.Size(396, 77);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPeriodOfRequest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxState)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button pbSendCmd;
		private System.Windows.Forms.TextBox tbCmd;
		private System.Windows.Forms.NumericUpDown numUpDownPeriodOfRequest;
		private System.Windows.Forms.PictureBox pictureBoxState;
	}
}
