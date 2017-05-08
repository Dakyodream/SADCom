namespace SADCom {
	partial class fConfigConnexion {
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConfigConnexion));
			this.lPortCom = new System.Windows.Forms.Label();
			this.cbBitStop = new System.Windows.Forms.ComboBox();
			this.cbNbBit = new System.Windows.Forms.ComboBox();
			this.lParity = new System.Windows.Forms.Label();
			this.lBaudeRate = new System.Windows.Forms.Label();
			this.cbParite = new System.Windows.Forms.ComboBox();
			this.cbListOfPorts = new System.Windows.Forms.ComboBox();
			this.cbVitesse = new System.Windows.Forms.ComboBox();
			this.lConfigProfile = new System.Windows.Forms.Label();
			this.lData = new System.Windows.Forms.Label();
			this.cbProfile = new System.Windows.Forms.ComboBox();
			this.pbSavConfig = new System.Windows.Forms.Button();
			this.pbDeletConfig = new System.Windows.Forms.Button();
			this.lStateCoLabel = new System.Windows.Forms.Label();
			this.lTextStateCo = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lStop = new System.Windows.Forms.Label();
			this.gbConfigPort = new System.Windows.Forms.GroupBox();
			this.pbStartConnexion = new System.Windows.Forms.Button();
			this.pbAnalysPorts = new System.Windows.Forms.Button();
			this.tableLayoutPanel2.SuspendLayout();
			this.gbConfigPort.SuspendLayout();
			this.SuspendLayout();
			// 
			// lPortCom
			// 
			resources.ApplyResources(this.lPortCom, "lPortCom");
			this.lPortCom.Name = "lPortCom";
			// 
			// cbBitStop
			// 
			resources.ApplyResources(this.cbBitStop, "cbBitStop");
			this.cbBitStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBitStop.FormattingEnabled = true;
			this.cbBitStop.Name = "cbBitStop";
			// 
			// cbNbBit
			// 
			resources.ApplyResources(this.cbNbBit, "cbNbBit");
			this.cbNbBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNbBit.FormattingEnabled = true;
			this.cbNbBit.Name = "cbNbBit";
			// 
			// lParity
			// 
			resources.ApplyResources(this.lParity, "lParity");
			this.lParity.Name = "lParity";
			// 
			// lBaudeRate
			// 
			resources.ApplyResources(this.lBaudeRate, "lBaudeRate");
			this.lBaudeRate.Name = "lBaudeRate";
			// 
			// cbParite
			// 
			resources.ApplyResources(this.cbParite, "cbParite");
			this.cbParite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbParite.FormattingEnabled = true;
			this.cbParite.Name = "cbParite";
			// 
			// cbListOfPorts
			// 
			resources.ApplyResources(this.cbListOfPorts, "cbListOfPorts");
			this.cbListOfPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbListOfPorts.FormattingEnabled = true;
			this.cbListOfPorts.Name = "cbListOfPorts";
			// 
			// cbVitesse
			// 
			resources.ApplyResources(this.cbVitesse, "cbVitesse");
			this.cbVitesse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbVitesse.FormattingEnabled = true;
			this.cbVitesse.Name = "cbVitesse";
			// 
			// lConfigProfile
			// 
			resources.ApplyResources(this.lConfigProfile, "lConfigProfile");
			this.lConfigProfile.Name = "lConfigProfile";
			// 
			// lData
			// 
			resources.ApplyResources(this.lData, "lData");
			this.lData.Name = "lData";
			// 
			// cbProfile
			// 
			resources.ApplyResources(this.cbProfile, "cbProfile");
			this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProfile.FormattingEnabled = true;
			this.cbProfile.Name = "cbProfile";
			// 
			// pbSavConfig
			// 
			resources.ApplyResources(this.pbSavConfig, "pbSavConfig");
			this.pbSavConfig.Name = "pbSavConfig";
			this.pbSavConfig.UseVisualStyleBackColor = true;
			// 
			// pbDeletConfig
			// 
			resources.ApplyResources(this.pbDeletConfig, "pbDeletConfig");
			this.pbDeletConfig.Name = "pbDeletConfig";
			this.pbDeletConfig.UseVisualStyleBackColor = true;
			// 
			// lStateCoLabel
			// 
			resources.ApplyResources(this.lStateCoLabel, "lStateCoLabel");
			this.lStateCoLabel.Name = "lStateCoLabel";
			// 
			// lTextStateCo
			// 
			resources.ApplyResources(this.lTextStateCo, "lTextStateCo");
			this.lTextStateCo.Name = "lTextStateCo";
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.lPortCom, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbBitStop, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.cbNbBit, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.lParity, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.lBaudeRate, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.cbParite, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.cbListOfPorts, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbVitesse, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.lConfigProfile, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.lStop, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.lData, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.cbProfile, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.pbSavConfig, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.pbDeletConfig, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.lStateCoLabel, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.lTextStateCo, 1, 1);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// lStop
			// 
			resources.ApplyResources(this.lStop, "lStop");
			this.lStop.Name = "lStop";
			// 
			// gbConfigPort
			// 
			resources.ApplyResources(this.gbConfigPort, "gbConfigPort");
			this.gbConfigPort.Controls.Add(this.tableLayoutPanel2);
			this.gbConfigPort.Name = "gbConfigPort";
			this.gbConfigPort.TabStop = false;
			// 
			// pbStartConnexion
			// 
			resources.ApplyResources(this.pbStartConnexion, "pbStartConnexion");
			this.pbStartConnexion.Name = "pbStartConnexion";
			this.pbStartConnexion.UseVisualStyleBackColor = true;
			this.pbStartConnexion.Click += new System.EventHandler(this.button1_Click);
			// 
			// pbAnalysPorts
			// 
			resources.ApplyResources(this.pbAnalysPorts, "pbAnalysPorts");
			this.pbAnalysPorts.Name = "pbAnalysPorts";
			this.pbAnalysPorts.UseVisualStyleBackColor = true;
			this.pbAnalysPorts.Click += new System.EventHandler(this.pbAnalysPorts_Click);
			// 
			// fConfigConnexion
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pbAnalysPorts);
			this.Controls.Add(this.pbStartConnexion);
			this.Controls.Add(this.gbConfigPort);
			this.Name = "fConfigConnexion";
			this.Load += new System.EventHandler(this.CongigConnexion_Load);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.gbConfigPort.ResumeLayout(false);
			this.gbConfigPort.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lPortCom;
		private System.Windows.Forms.ComboBox cbBitStop;
		private System.Windows.Forms.ComboBox cbNbBit;
		private System.Windows.Forms.Label lParity;
		private System.Windows.Forms.Label lBaudeRate;
		private System.Windows.Forms.ComboBox cbParite;
		private System.Windows.Forms.ComboBox cbListOfPorts;
		private System.Windows.Forms.ComboBox cbVitesse;
		private System.Windows.Forms.Label lConfigProfile;
		private System.Windows.Forms.Label lData;
		private System.Windows.Forms.ComboBox cbProfile;
		private System.Windows.Forms.Button pbSavConfig;
		private System.Windows.Forms.Button pbDeletConfig;
		private System.Windows.Forms.Label lStateCoLabel;
		private System.Windows.Forms.Label lTextStateCo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lStop;
		private System.Windows.Forms.GroupBox gbConfigPort;
		private System.Windows.Forms.Button pbStartConnexion;
		private System.Windows.Forms.Button pbAnalysPorts;
	}
}

