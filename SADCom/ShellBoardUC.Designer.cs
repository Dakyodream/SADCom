namespace SADCom {
	partial class ShellBoardUC {
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
			this.tbTimeLabel = new System.Windows.Forms.TextBox();
			this.tbDataLabel = new System.Windows.Forms.TextBox();
			this.tbLogInfoData = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tbTimeLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbDataLabel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbLogInfoData, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox6, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 253);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tbTimeLabel
			// 
			this.tbTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbTimeLabel.Location = new System.Drawing.Point(0, 0);
			this.tbTimeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tbTimeLabel.Name = "tbTimeLabel";
			this.tbTimeLabel.Size = new System.Drawing.Size(160, 13);
			this.tbTimeLabel.TabIndex = 0;
			this.tbTimeLabel.Text = "Time";
			this.tbTimeLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbDataLabel
			// 
			this.tbDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbDataLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbDataLabel.Location = new System.Drawing.Point(160, 0);
			this.tbDataLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tbDataLabel.Name = "tbDataLabel";
			this.tbDataLabel.Size = new System.Drawing.Size(225, 13);
			this.tbDataLabel.TabIndex = 1;
			this.tbDataLabel.Text = "Data";
			this.tbDataLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbLogInfoData
			// 
			this.tbLogInfoData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLogInfoData.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbLogInfoData.Location = new System.Drawing.Point(385, 0);
			this.tbLogInfoData.Margin = new System.Windows.Forms.Padding(0);
			this.tbLogInfoData.Name = "tbLogInfoData";
			this.tbLogInfoData.Size = new System.Drawing.Size(100, 13);
			this.tbLogInfoData.TabIndex = 2;
			this.tbLogInfoData.Text = "Log Information";
			this.tbLogInfoData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox4.Location = new System.Drawing.Point(0, 13);
			this.textBox4.Margin = new System.Windows.Forms.Padding(0);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(160, 13);
			this.textBox4.TabIndex = 3;
			this.textBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_MouseClick);
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox5.Location = new System.Drawing.Point(160, 13);
			this.textBox5.Margin = new System.Windows.Forms.Padding(0);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(225, 13);
			this.textBox5.TabIndex = 4;
			this.textBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_MouseClick);
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox6.Location = new System.Drawing.Point(385, 13);
			this.textBox6.Margin = new System.Windows.Forms.Padding(0);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 13);
			this.textBox6.TabIndex = 5;
			this.textBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_MouseClick);
			// 
			// ShellBoardUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ShellBoardUC";
			this.Size = new System.Drawing.Size(485, 253);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox tbTimeLabel;
		private System.Windows.Forms.TextBox tbDataLabel;
		private System.Windows.Forms.TextBox tbLogInfoData;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
	}
}
