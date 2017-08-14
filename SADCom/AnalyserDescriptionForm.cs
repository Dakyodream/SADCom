using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom.Configuration {

	public partial class AnalyserDescriptionForm : Form {

		private SessionConfigurations mSessionConfigurations;

		private FileAnalyserDescription mFileOfAnalyserDescription;

		private Size mSizeOfCstForms;


		public AnalyserDescriptionForm() : this(new SessionConfigurations(), "") { }
		public AnalyserDescriptionForm(SessionConfigurations sessionConfigurations) : this(sessionConfigurations, "") { }
		public AnalyserDescriptionForm(SessionConfigurations sessionConfigurations, string addrFileAnalyserDescription) {
			InitializeComponent();

			this.mSessionConfigurations = sessionConfigurations;

			this.mFileOfAnalyserDescription = new FileAnalyserDescription();


			this.mSizeOfCstForms = new Size(this.Size.Width, this.Size.Height - this.pAutoscrollPanel.Size.Height);

			


			if(addrFileAnalyserDescription.Length > 0) {
				if(File.Exists(addrFileAnalyserDescription)){
					this.mSessionConfigurations.AddrFileAnalyserDescription = addrFileAnalyserDescription;

					try {

						if(File.Exists(addrFileAnalyserDescription)) {

							using(Stream stream = File.Open(addrFileAnalyserDescription, FileMode.Open)) {
								var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

								this.mFileOfAnalyserDescription = (FileAnalyserDescription)bformatter.Deserialize(stream);
							}

							foreach(AnalyserKeyWord keyWord in this.mFileOfAnalyserDescription.listOfKeyWords) {

								if(keyWord.KeyWord.Length > 0) {
									AnalyserDescriptionUserControl analyserDescriptionUserControl = new AnalyserDescriptionUserControl();
									analyserDescriptionUserControl.AutoSize = true;
									analyserDescriptionUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
									analyserDescriptionUserControl.Dock = System.Windows.Forms.DockStyle.Bottom;
									analyserDescriptionUserControl.Margin = new System.Windows.Forms.Padding(0);

									analyserDescriptionUserControl.AnalyserKeyWord = keyWord;

									this.pannelOfDescription.Controls.Add(analyserDescriptionUserControl);

									if(this.pannelOfDescription.Size.Height > this.pAutoscrollPanel.Size.Height) {
										this.pAutoscrollPanel.AutoScrollPosition = new Point(this.pannelOfDescription.Size);
									}
								}

							}
						}
					} catch {
						MessageBox.Show("Desérialisation du fichier d'analyse des données impossible.", "Configuration", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						this.Close();
					}
				}
			}
			this.NewAnalyserDescription();
		}




		private void NewAnalyserDescription() {
			AnalyserDescriptionUserControl analyserDescriptionUserControl = new AnalyserDescriptionUserControl();
			analyserDescriptionUserControl.AutoSize = true;
			analyserDescriptionUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			analyserDescriptionUserControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			analyserDescriptionUserControl.Margin = new System.Windows.Forms.Padding(0);

			analyserDescriptionUserControl.NewDescriptionEvent += AnalyserDescriptionUserControl_NewDescriptionEvent;

			analyserDescriptionUserControl.AnalyserDescriptionDeletedEvent += AnalyserDescriptionUserControl_AnalyserDescriptionDeletedEvent;

			try {
				this.pannelOfDescription.Controls.Add(analyserDescriptionUserControl);
			} catch {
				throw new Exception("Cant add analyserDescriptionUserControl in pannelOfDescription.");
			}
			this.mFileOfAnalyserDescription.AddDescription(analyserDescriptionUserControl.AnalyserKeyWord);
			
			if(this.pannelOfDescription.Size.Height > this.pAutoscrollPanel.Size.Height) {
				this.pAutoscrollPanel.AutoScrollPosition = new Point(this.pannelOfDescription.Size);	
			} 
		}

		private void AnalyserDescriptionUserControl_AnalyserDescriptionDeletedEvent(object sender, EventArgs e) {
			if(sender.GetType() == typeof(AnalyserDescriptionUserControl)) {
				this.mFileOfAnalyserDescription.RemoveDescription( ((AnalyserDescriptionUserControl)sender).AnalyserKeyWord);
				this.pannelOfDescription.Controls.Remove((AnalyserDescriptionUserControl)sender);
			}
		}

		private void AnalyserDescriptionUserControl_NewDescriptionEvent(object sender, EventArgs e) {
			this.NewAnalyserDescription();
		}


		private void AnalyserDescriptionForm_ResizeEnd(object sender, EventArgs e) {

			int iHeight = this.mSizeOfCstForms.Height + ((this.pAutoscrollPanel.Size.Height / 20)*20);
			this.Size = new Size(this.Size.Width, iHeight);
			
		}

		private void pbSave_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			//saveFileDialog.Filter = "*"

			saveFileDialog.Filter = "binaire|*.bin";
			saveFileDialog.Title = "Fichier de description";

			try {
				if(Resources.TerminalConfiguration.Default.addrFileAnalyserDescription.Length == 0) {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles");
					}
					saveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles";
				} else {
					saveFileDialog.InitialDirectory = Resources.TerminalConfiguration.Default.addrFileAnalyserDescription;
				}


				if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0) {

					//serialize
					try {
						using(Stream stream = File.Open(saveFileDialog.FileName, FileMode.Create)) {
							var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

							bformatter.Serialize(stream, this.mFileOfAnalyserDescription);
						}
					} catch(Exception exception) {
						MessageBox.Show("Erreur détéctée lors la sauvegarde des données de configuration : \n" + exception.ToString(), "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
					}

					this.mSessionConfigurations.AddrFileAnalyserDescription = saveFileDialog.FileName;
					this.DialogResult = DialogResult.OK; ;
				}

				this.Close();
			} catch {
				throw new Exception("Can't save the file use by the analyser data.");
			}
		}

		private void pbExit_Click(object sender, EventArgs e) {
			try { 
				this.DialogResult = DialogResult.Ignore;
				this.Close();
			} catch {
				throw new Exception("Can't close the analyser description dialog.");
			}
		}
	}
}
