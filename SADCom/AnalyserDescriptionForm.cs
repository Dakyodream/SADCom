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

namespace SADCom {

	public delegate void NewFileCreateHandler(object sender, EventArgs e);


	public partial class AnalyserDescriptionForm : Form {

		public event NewFileCreateHandler NewFileCreateEvent;

		private FileAnalyserDescription mFileOfAnalyserDescription;

		private Size mSizeOfCstForms;


		public AnalyserDescriptionForm() : this("") { }
		public AnalyserDescriptionForm(string addrFileAnalyserDescription) {
			InitializeComponent();

			this.mFileOfAnalyserDescription = new FileAnalyserDescription();


			this.mSizeOfCstForms = new Size(this.Size.Width - this.pAutoscrollPanel.Size.Width,
			this.Size.Height - this.pAutoscrollPanel.Size.Height);

			


			if(addrFileAnalyserDescription.Length > 0) {
				if(File.Exists(addrFileAnalyserDescription)){
					Resources.TerminalConfiguration.Default.addrFileAnalyserDescription = addrFileAnalyserDescription;

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
						MessageBox.Show("Erreur critique à l'initialisation2", "Configuration", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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


			this.pannelOfDescription.Controls.Add(analyserDescriptionUserControl);			
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

			if(Resources.TerminalConfiguration.Default.addrFileAnalyserDescription.Length == 0) {
				if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles")) {
					Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles");
				}
				saveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles";
			} else {
				saveFileDialog.InitialDirectory = Resources.TerminalConfiguration.Default.addrFileAnalyserDescription;
			}


			if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0) {

				Resources.TerminalConfiguration.Default.addrFileAnalyserDescription = saveFileDialog.FileName;

				//serialize
				try {
					using(Stream stream = File.Open(saveFileDialog.FileName, FileMode.Create)) {
						var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

						bformatter.Serialize(stream, this.mFileOfAnalyserDescription);
					}
				} catch(Exception exception) {
					MessageBox.Show("Erreur détéctée lors la sauvegarde des données de configuration : \n" + exception.ToString(), "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				}

				NewFileCreateEvent?.Invoke(this, null);
			}

			this.Close();
		}

		private void pbExit_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
