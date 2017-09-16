namespace SADCom {
	partial class MainWindows {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.préférenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.shellBoardUC1 = new SADCom.ShellBoardUC();
			this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.préférenceToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(610, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// préférenceToolStripMenuItem
			// 
			this.préférenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem});
			this.préférenceToolStripMenuItem.Name = "préférenceToolStripMenuItem";
			this.préférenceToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.préférenceToolStripMenuItem.Text = "Préférence";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 239);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(610, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// shellBoardUC1
			// 
			this.shellBoardUC1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shellBoardUC1.Location = new System.Drawing.Point(0, 24);
			this.shellBoardUC1.Name = "shellBoardUC1";
			this.shellBoardUC1.Size = new System.Drawing.Size(610, 215);
			this.shellBoardUC1.TabIndex = 2;
			// 
			// testeToolStripMenuItem
			// 
			this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
			this.testeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.testeToolStripMenuItem.Text = "teste";
			this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
			// 
			// MainWindows
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 261);
			this.Controls.Add(this.shellBoardUC1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "MainWindows";
			this.Text = "MainWindows";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem préférenceToolStripMenuItem;
		private ShellBoardUC shellBoardUC1;
		private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
	}
}