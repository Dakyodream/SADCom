namespace SADCom {
	partial class SerialPortShell {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPortShell));
			this.rtbSerialPort = new System.Windows.Forms.RichTextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lLevelBuffer = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.tbSendSimpleMessage = new System.Windows.Forms.ToolStripTextBox();
			this.pbSendDimpleMessage = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.pbEnableTime = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hexaItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enableAutoSave = new System.Windows.Forms.ToolStripMenuItem();
			this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.statusStrip1.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbSerialPort
			// 
			this.rtbSerialPort.BackColor = System.Drawing.SystemColors.HotTrack;
			this.rtbSerialPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbSerialPort.ForeColor = System.Drawing.SystemColors.Window;
			this.rtbSerialPort.Location = new System.Drawing.Point(0, 0);
			this.rtbSerialPort.Name = "rtbSerialPort";
			this.rtbSerialPort.ReadOnly = true;
			this.rtbSerialPort.Size = new System.Drawing.Size(379, 227);
			this.rtbSerialPort.TabIndex = 0;
			this.rtbSerialPort.Text = "teste";
			this.rtbSerialPort.SizeChanged += new System.EventHandler(this.rtbSerialPort_SizeChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus,
            this.lLevelBuffer});
			this.statusStrip1.Location = new System.Drawing.Point(0, 276);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(403, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lStatus
			// 
			this.lStatus.Name = "lStatus";
			this.lStatus.Size = new System.Drawing.Size(63, 17);
			this.lStatus.Text = "status port";
			// 
			// lLevelBuffer
			// 
			this.lLevelBuffer.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
			this.lLevelBuffer.Name = "lLevelBuffer";
			this.lLevelBuffer.Size = new System.Drawing.Size(39, 17);
			this.lLevelBuffer.Text = "Buffer";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip2);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbSerialPort);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(379, 227);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			// 
			// toolStripContainer1.RightToolStripPanel
			// 
			this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.toolStrip1);
			this.toolStripContainer1.Size = new System.Drawing.Size(403, 276);
			this.toolStripContainer1.TabIndex = 2;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSendSimpleMessage,
            this.pbSendDimpleMessage});
			this.toolStrip2.Location = new System.Drawing.Point(3, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(168, 25);
			this.toolStrip2.TabIndex = 0;
			// 
			// tbSendSimpleMessage
			// 
			this.tbSendSimpleMessage.Name = "tbSendSimpleMessage";
			this.tbSendSimpleMessage.Size = new System.Drawing.Size(100, 25);
			// 
			// pbSendDimpleMessage
			// 
			this.pbSendDimpleMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pbSendDimpleMessage.Image = global::SADCom.Properties.Resources.SendData;
			this.pbSendDimpleMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pbSendDimpleMessage.Name = "pbSendDimpleMessage";
			this.pbSendDimpleMessage.Size = new System.Drawing.Size(23, 22);
			this.pbSendDimpleMessage.Text = "Send data";
			this.pbSendDimpleMessage.Click += new System.EventHandler(this.pbSendDimpleMessage_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.pbEnableTime});
			this.toolStrip1.Location = new System.Drawing.Point(0, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(24, 57);
			this.toolStrip1.TabIndex = 0;
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(22, 20);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// pbEnableTime
			// 
			this.pbEnableTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pbEnableTime.Image = global::SADCom.Properties.Resources.Data;
			this.pbEnableTime.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pbEnableTime.Name = "pbEnableTime";
			this.pbEnableTime.Size = new System.Drawing.Size(22, 20);
			this.pbEnableTime.Text = "Enable time";
			this.pbEnableTime.Click += new System.EventHandler(this.pbEnableTime_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.aideToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(403, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// exporterToolStripMenuItem
			// 
			this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
			this.exporterToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.exporterToolStripMenuItem.Text = "exporter";
			this.exporterToolStripMenuItem.Click += new System.EventHandler(this.exporterToolStripMenuItem_Click);
			// 
			// editionToolStripMenuItem
			// 
			this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
			this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.editionToolStripMenuItem.Text = "Edition";
			// 
			// affichageToolStripMenuItem
			// 
			this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexaItem});
			this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
			this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.affichageToolStripMenuItem.Text = "Affichage";
			// 
			// hexaItem
			// 
			this.hexaItem.CheckOnClick = true;
			this.hexaItem.Name = "hexaItem";
			this.hexaItem.Size = new System.Drawing.Size(98, 22);
			this.hexaItem.Text = "hexa";
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableAutoSave});
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
			this.configurationToolStripMenuItem.Text = "Configuration";
			// 
			// enableAutoSave
			// 
			this.enableAutoSave.Name = "enableAutoSave";
			this.enableAutoSave.Size = new System.Drawing.Size(147, 22);
			this.enableAutoSave.Text = "autosave data";
			this.enableAutoSave.Click += new System.EventHandler(this.enableAutoSave_Click);
			// 
			// aideToolStripMenuItem
			// 
			this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
			this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.aideToolStripMenuItem.Text = "Aide";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// SerialPortShell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 298);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SerialPortShell";
			this.Text = "SerialPortShell";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialPortShell_FormClosing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.RightToolStripPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbSerialPort;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lStatus;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton pbEnableTime;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel lLevelBuffer;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripTextBox tbSendSimpleMessage;
		private System.Windows.Forms.ToolStripButton pbSendDimpleMessage;
		private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hexaItem;
		private System.Windows.Forms.ToolStripMenuItem enableAutoSave;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}