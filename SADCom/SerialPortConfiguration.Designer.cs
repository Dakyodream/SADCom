namespace SADCom.Configuration {
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
			SADCom.SessionConfigurations sessionConfigurations1 = new SADCom.SessionConfigurations();
			this.gbSerialPort = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pbRefreshScan = new System.Windows.Forms.Button();
			this.cbListOfPorts = new System.Windows.Forms.ComboBox();
			this.gbProfil = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pbSaveConfig = new System.Windows.Forms.Button();
			this.pbDeletConfig = new System.Windows.Forms.Button();
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pbOptionalConfiguration = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.optionTerminalDisplay = new SADCom.Configuration.OptionTerminalDisplay();
			this.gbSerialPort.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbProfil.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.gbConfigConnexion.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.tableLayoutPanel2.Controls.Add(this.pbDeletConfig, 1, 0);
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
			// pbDeletConfig
			// 
			this.pbDeletConfig.BackgroundImage = global::SADCom.Properties.Resources.DeletFileIcon;
			resources.ApplyResources(this.pbDeletConfig, "pbDeletConfig");
			this.pbDeletConfig.Name = "pbDeletConfig";
			this.pbDeletConfig.UseVisualStyleBackColor = true;
			this.pbDeletConfig.Click += new System.EventHandler(this.bDeletConfig_Click);
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
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pbStartConnexion);
			this.splitContainer1.Panel1.Controls.Add(this.pbOptionalConfiguration);
			this.splitContainer1.Panel1.Controls.Add(this.gbConfigConnexion);
			this.splitContainer1.Panel1.Controls.Add(this.gbProfil);
			this.splitContainer1.Panel1.Controls.Add(this.gbSerialPort);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			// 
			// pbOptionalConfiguration
			// 
			resources.ApplyResources(this.pbOptionalConfiguration, "pbOptionalConfiguration");
			this.pbOptionalConfiguration.Name = "pbOptionalConfiguration";
			this.pbOptionalConfiguration.UseVisualStyleBackColor = true;
			this.pbOptionalConfiguration.Click += new System.EventHandler(this.pbOptionalConfiguration_Click);
			// 
			// groupBox3
			// 
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.optionTerminalDisplay);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// optionTerminalDisplay
			// 
			resources.ApplyResources(this.optionTerminalDisplay, "optionTerminalDisplay");
			this.optionTerminalDisplay.Name = "optionTerminalDisplay";
			sessionConfigurations1.AddrFileAnalyserDescription = "";
			sessionConfigurations1.AddrLogFileAnalyser = "";
			sessionConfigurations1.DataAnalyserEnable = false;
			sessionConfigurations1.MaxBufferLength = 2147483647;
			sessionConfigurations1.TerminalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
			sessionConfigurations1.TerminalFont = new System.Drawing.Font("Lucida Console", 10F);
			sessionConfigurations1.TerminalForeColor = System.Drawing.Color.White;
			sessionConfigurations1.TerminalOpacity = 90;
			sessionConfigurations1.TerminalOpacityFloat = 0.9D;
			sessionConfigurations1.Timestamp = 1D;
			sessionConfigurations1.TimestampIsEnable = false;
			this.optionTerminalDisplay.SessionConfigurations = sessionConfigurations1;
			// 
			// SerialPortConfiguration
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
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
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.Button pbDeletConfig;
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
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button pbOptionalConfiguration;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private OptionTerminalDisplay optionTerminalDisplay;
	}
}