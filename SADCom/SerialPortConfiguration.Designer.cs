namespace SADCom {
	partial class SerialPortConfiguration {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPortConfiguration));
			this.gbSerialPort = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pbRefreshScan = new System.Windows.Forms.Button();
			this.cbListOfPorts = new System.Windows.Forms.ComboBox();
			this.gbProfil = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pbSaveConfig = new System.Windows.Forms.Button();
			this.bDeletConfig = new System.Windows.Forms.Button();
			this.cbProfil = new System.Windows.Forms.ComboBox();
			this.gbConfigConnexion = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lBaudRate = new System.Windows.Forms.Label();
			this.lParity = new System.Windows.Forms.Label();
			this.lDataBits = new System.Windows.Forms.Label();
			this.lStopBits = new System.Windows.Forms.Label();
			this.lFlowControl = new System.Windows.Forms.Label();
			this.cbBaudRate = new System.Windows.Forms.ComboBox();
			this.cbDataBits = new System.Windows.Forms.ComboBox();
			this.cbStopBits = new System.Windows.Forms.ComboBox();
			this.cbFlowControl = new System.Windows.Forms.ComboBox();
			this.cbParity = new System.Windows.Forms.ComboBox();
			this.pbStartConnexion = new System.Windows.Forms.Button();
			this.gbSerialPort.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbProfil.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.gbConfigConnexion.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbSerialPort
			// 
			this.gbSerialPort.Controls.Add(this.tableLayoutPanel1);
			resources.ApplyResources(this.gbSerialPort, "gbSerialPort");
			this.gbSerialPort.Name = "gbSerialPort";
			this.gbSerialPort.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.pbRefreshScan, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbListOfPorts, 1, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// pbRefreshScan
			// 
			this.pbRefreshScan.BackgroundImage = global::SADCom.Properties.Resources.Refresh;
			resources.ApplyResources(this.pbRefreshScan, "pbRefreshScan");
			this.pbRefreshScan.Name = "pbRefreshScan";
			this.pbRefreshScan.UseVisualStyleBackColor = true;
			this.pbRefreshScan.Click += new System.EventHandler(this.pbRefreshScan_Click);
			// 
			// cbListOfPorts
			// 
			resources.ApplyResources(this.cbListOfPorts, "cbListOfPorts");
			this.cbListOfPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbListOfPorts.FormattingEnabled = true;
			this.cbListOfPorts.Name = "cbListOfPorts";
			this.cbListOfPorts.SelectedIndexChanged += new System.EventHandler(this.cbListOfPorts_SelectedIndexChanged);
			// 
			// gbProfil
			// 
			this.gbProfil.Controls.Add(this.tableLayoutPanel2);
			resources.ApplyResources(this.gbProfil, "gbProfil");
			this.gbProfil.Name = "gbProfil";
			this.gbProfil.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.pbSaveConfig, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.bDeletConfig, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbProfil, 2, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// pbSaveConfig
			// 
			this.pbSaveConfig.BackgroundImage = global::SADCom.Properties.Resources.SaveIcon;
			resources.ApplyResources(this.pbSaveConfig, "pbSaveConfig");
			this.pbSaveConfig.Name = "pbSaveConfig";
			this.pbSaveConfig.UseVisualStyleBackColor = true;
			this.pbSaveConfig.Click += new System.EventHandler(this.pbSaveConfig_Click);
			// 
			// bDeletConfig
			// 
			this.bDeletConfig.BackgroundImage = global::SADCom.Properties.Resources.DeletFileIcon;
			resources.ApplyResources(this.bDeletConfig, "bDeletConfig");
			this.bDeletConfig.Name = "bDeletConfig";
			this.bDeletConfig.UseVisualStyleBackColor = true;
			this.bDeletConfig.Click += new System.EventHandler(this.bDeletConfig_Click);
			// 
			// cbProfil
			// 
			resources.ApplyResources(this.cbProfil, "cbProfil");
			this.cbProfil.FormattingEnabled = true;
			this.cbProfil.Name = "cbProfil";
			this.cbProfil.SelectedIndexChanged += new System.EventHandler(this.cbProfil_SelectedIndexChanged);
			// 
			// gbConfigConnexion
			// 
			this.gbConfigConnexion.Controls.Add(this.tableLayoutPanel3);
			resources.ApplyResources(this.gbConfigConnexion, "gbConfigConnexion");
			this.gbConfigConnexion.Name = "gbConfigConnexion";
			this.gbConfigConnexion.TabStop = false;
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.lBaudRate, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.lParity, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.lDataBits, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.lStopBits, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.lFlowControl, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.cbBaudRate, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.cbDataBits, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.cbStopBits, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.cbFlowControl, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.cbParity, 1, 1);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// lBaudRate
			// 
			resources.ApplyResources(this.lBaudRate, "lBaudRate");
			this.lBaudRate.Name = "lBaudRate";
			// 
			// lParity
			// 
			resources.ApplyResources(this.lParity, "lParity");
			this.lParity.Name = "lParity";
			// 
			// lDataBits
			// 
			resources.ApplyResources(this.lDataBits, "lDataBits");
			this.lDataBits.Name = "lDataBits";
			// 
			// lStopBits
			// 
			resources.ApplyResources(this.lStopBits, "lStopBits");
			this.lStopBits.Name = "lStopBits";
			// 
			// lFlowControl
			// 
			resources.ApplyResources(this.lFlowControl, "lFlowControl");
			this.lFlowControl.Name = "lFlowControl";
			// 
			// cbBaudRate
			// 
			resources.ApplyResources(this.cbBaudRate, "cbBaudRate");
			this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBaudRate.FormattingEnabled = true;
			this.cbBaudRate.Name = "cbBaudRate";
			// 
			// cbDataBits
			// 
			resources.ApplyResources(this.cbDataBits, "cbDataBits");
			this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDataBits.FormattingEnabled = true;
			this.cbDataBits.Name = "cbDataBits";
			// 
			// cbStopBits
			// 
			resources.ApplyResources(this.cbStopBits, "cbStopBits");
			this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStopBits.FormattingEnabled = true;
			this.cbStopBits.Name = "cbStopBits";
			// 
			// cbFlowControl
			// 
			resources.ApplyResources(this.cbFlowControl, "cbFlowControl");
			this.cbFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFlowControl.FormattingEnabled = true;
			this.cbFlowControl.Name = "cbFlowControl";
			// 
			// cbParity
			// 
			resources.ApplyResources(this.cbParity, "cbParity");
			this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbParity.FormattingEnabled = true;
			this.cbParity.Name = "cbParity";
			// 
			// pbStartConnexion
			// 
			resources.ApplyResources(this.pbStartConnexion, "pbStartConnexion");
			this.pbStartConnexion.Name = "pbStartConnexion";
			this.pbStartConnexion.UseVisualStyleBackColor = true;
			this.pbStartConnexion.Click += new System.EventHandler(this.pbStartConnexion_Click);
			// 
			// SerialPortConfiguration
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pbStartConnexion);
			this.Controls.Add(this.gbConfigConnexion);
			this.Controls.Add(this.gbProfil);
			this.Controls.Add(this.gbSerialPort);
			this.Name = "SerialPortConfiguration";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialPortConfiguration_FormClosing);
			this.Load += new System.EventHandler(this.SerialPortConfiguration_Load);
			this.gbSerialPort.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.gbProfil.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.gbConfigConnexion.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbSerialPort;
		private System.Windows.Forms.GroupBox gbProfil;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button pbRefreshScan;
		private System.Windows.Forms.ComboBox cbListOfPorts;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button pbSaveConfig;
		private System.Windows.Forms.Button bDeletConfig;
		private System.Windows.Forms.ComboBox cbProfil;
		private System.Windows.Forms.GroupBox gbConfigConnexion;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lBaudRate;
		private System.Windows.Forms.Label lParity;
		private System.Windows.Forms.Label lDataBits;
		private System.Windows.Forms.Label lStopBits;
		private System.Windows.Forms.Label lFlowControl;
		private System.Windows.Forms.ComboBox cbBaudRate;
		private System.Windows.Forms.ComboBox cbDataBits;
		private System.Windows.Forms.ComboBox cbStopBits;
		private System.Windows.Forms.ComboBox cbFlowControl;
		private System.Windows.Forms.ComboBox cbParity;
		private System.Windows.Forms.Button pbStartConnexion;
	}
}