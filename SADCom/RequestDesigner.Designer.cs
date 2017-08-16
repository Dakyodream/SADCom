﻿namespace SADCom.UserButton {
	partial class RequestDesigner {
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
			this.pAutoscroll = new System.Windows.Forms.Panel();
			this.pCustomButtonDesigner = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pbSaveAndExit = new System.Windows.Forms.Button();
			this.pbExitWithoutSave = new System.Windows.Forms.Button();
			this.tlpColumnsLabels = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pAutoscroll.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tlpColumnsLabels.SuspendLayout();
			this.SuspendLayout();
			// 
			// pAutoscroll
			// 
			this.pAutoscroll.AutoScroll = true;
			this.pAutoscroll.Controls.Add(this.pCustomButtonDesigner);
			this.pAutoscroll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pAutoscroll.Location = new System.Drawing.Point(0, 13);
			this.pAutoscroll.Name = "pAutoscroll";
			this.pAutoscroll.Size = new System.Drawing.Size(576, 219);
			this.pAutoscroll.TabIndex = 1;
			// 
			// pCustomButtonDesigner
			// 
			this.pCustomButtonDesigner.AutoScroll = true;
			this.pCustomButtonDesigner.AutoSize = true;
			this.pCustomButtonDesigner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pCustomButtonDesigner.Dock = System.Windows.Forms.DockStyle.Top;
			this.pCustomButtonDesigner.Location = new System.Drawing.Point(0, 0);
			this.pCustomButtonDesigner.MinimumSize = new System.Drawing.Size(0, 20);
			this.pCustomButtonDesigner.Name = "pCustomButtonDesigner";
			this.pCustomButtonDesigner.Size = new System.Drawing.Size(576, 20);
			this.pCustomButtonDesigner.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.pbSaveAndExit, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pbExitWithoutSave, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 232);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 29);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// pbSaveAndExit
			// 
			this.pbSaveAndExit.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbSaveAndExit.Location = new System.Drawing.Point(417, 3);
			this.pbSaveAndExit.Name = "pbSaveAndExit";
			this.pbSaveAndExit.Size = new System.Drawing.Size(75, 23);
			this.pbSaveAndExit.TabIndex = 0;
			this.pbSaveAndExit.Text = "&Save && exit";
			this.pbSaveAndExit.UseVisualStyleBackColor = true;
			this.pbSaveAndExit.Click += new System.EventHandler(this.pbSaveAndExit_Click);
			// 
			// pbExitWithoutSave
			// 
			this.pbExitWithoutSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbExitWithoutSave.Location = new System.Drawing.Point(498, 3);
			this.pbExitWithoutSave.Name = "pbExitWithoutSave";
			this.pbExitWithoutSave.Size = new System.Drawing.Size(75, 23);
			this.pbExitWithoutSave.TabIndex = 1;
			this.pbExitWithoutSave.Text = "&Exit without Save";
			this.pbExitWithoutSave.UseVisualStyleBackColor = true;
			this.pbExitWithoutSave.Click += new System.EventHandler(this.pbExitWithoutSave_Click);
			// 
			// tlpColumnsLabels
			// 
			this.tlpColumnsLabels.AutoSize = true;
			this.tlpColumnsLabels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpColumnsLabels.ColumnCount = 5;
			this.tlpColumnsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpColumnsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpColumnsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpColumnsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tlpColumnsLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tlpColumnsLabels.Controls.Add(this.label1, 1, 0);
			this.tlpColumnsLabels.Controls.Add(this.label2, 2, 0);
			this.tlpColumnsLabels.Controls.Add(this.label3, 4, 0);
			this.tlpColumnsLabels.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlpColumnsLabels.Location = new System.Drawing.Point(0, 0);
			this.tlpColumnsLabels.Name = "tlpColumnsLabels";
			this.tlpColumnsLabels.RowCount = 1;
			this.tlpColumnsLabels.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpColumnsLabels.Size = new System.Drawing.Size(576, 13);
			this.tlpColumnsLabels.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(23, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom du boutton";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(246, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Requête";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(486, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Periode";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// RequestDesigner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 261);
			this.Controls.Add(this.pAutoscroll);
			this.Controls.Add(this.tlpColumnsLabels);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "RequestDesigner";
			this.Text = "RequestDesigner";
			this.ResizeEnd += new System.EventHandler(this.RequestDesigner_ResizeEnd);
			this.pAutoscroll.ResumeLayout(false);
			this.pAutoscroll.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tlpColumnsLabels.ResumeLayout(false);
			this.tlpColumnsLabels.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pAutoscroll;
		private System.Windows.Forms.Panel pCustomButtonDesigner;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tlpColumnsLabels;
		private System.Windows.Forms.Button pbSaveAndExit;
		private System.Windows.Forms.Button pbExitWithoutSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}