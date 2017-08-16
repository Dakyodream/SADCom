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

	/// <summary>
	/// This class is used to generate the rule used by the analyser data. This is an for can create or edit an analyser data rules file.
	/// </summary>
	public partial class AnalyserDescriptionForm : Form {

		/// <summary>
		/// Contain the configuration of this session.
		/// </summary>
		private SessionConfigurations mSessionConfigurations;

		/// <summary>
		/// Object contain the list of rules use by the analyser data.
		/// </summary>
		private FileAnalyserDescription mFileOfAnalyserDescription;

		/// <summary>
		/// Use to manage the size form for show an integer number of analyserDescriptionUserControl.
		/// </summary>
		private Size mSizeOfCstForms;

		/// <summary>
		/// Contain the address of file rule (if we are in edit mode).
		/// </summary>
		private string msAddrOfFileRule;


		/// <summary>
		/// Void constructor for the disigner viewer.
		/// </summary>
		public AnalyserDescriptionForm() : this(new SessionConfigurations(), "") { }
		/// <summary>
		/// Constructor use to create a new rule file.
		/// </summary>
		/// <param name="sessionConfigurations">Session configuration.</param>
		public AnalyserDescriptionForm(SessionConfigurations sessionConfigurations) : this(sessionConfigurations, "") { }
		/// <summary>
		/// Constructor use to edit a rule file.
		/// </summary>
		/// <param name="sessionConfigurations">Session configuration.</param>
		/// <param name="addrFileAnalyserDescription">Path of the rule file.</param>
		/// <remarks>
		/// Don't forget !analyserDescriptionForm.IsDisposed befor analyserDescriptionForm.ShowDialog()
		/// </remarks>
		/// <example>
		/// <code>
		/// AnalyserDescriptionForm analyserDescriptionForm = new AnalyserDescriptionForm(mSessionConfigurations, this.tbLocationFileAnalyser.Text);
		///	if(!analyserDescriptionForm.IsDisposed) {
		///		if(analyserDescriptionForm.ShowDialog() == DialogResult.OK) {
		///			if(mSessionConfigurations.AddrFileAnalyserDescription.Length > 0) {
		///				this.tbLocationFileAnalyser.Text = mSessionConfigurations.AddrFileAnalyserDescription;
		///			}
		///		}
		///	}
		///	</code>
		/// </example>
		public AnalyserDescriptionForm(SessionConfigurations sessionConfigurations, string addrFileAnalyserDescription) {
			InitializeComponent();

			//copy all params
			this.mSessionConfigurations = sessionConfigurations;
			this.msAddrOfFileRule = addrFileAnalyserDescription;

			//instantiate the object
			this.mFileOfAnalyserDescription = new FileAnalyserDescription();

			//Calcul la taille de la fenetre sans la partie affichant les analyserDescriptionUserControl (seule partie qui varira en hauteur).
			this.mSizeOfCstForms = new Size(this.Size.Width, this.Size.Height - this.pAutoscrollPanel.Size.Height);

			//Detect if we are in edit mode.
			if(this.msAddrOfFileRule.Length > 0) {
				if(File.Exists(this.msAddrOfFileRule)) {

					try {
						using(Stream stream = File.Open(this.msAddrOfFileRule, FileMode.Open)) {
							var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

							this.mFileOfAnalyserDescription = (FileAnalyserDescription)bformatter.Deserialize(stream);
						}
					} catch {
						MessageBox.Show("Le fichier séléctionné est n'est pas reconnu par le système. Veuilliez réitérer avec un nouveau fichier ou en crée un nouveau.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						this.Close();
					}

					try {					
						foreach(AnalyserKeyWord keyWord in this.mFileOfAnalyserDescription.ListOfKeyWords) {
							if(keyWord.KeyWord.Length > 0) {
								AnalyserDescriptionUserControl analyserDescriptionUserControl = new AnalyserDescriptionUserControl();
								analyserDescriptionUserControl.AutoSize = true;
								analyserDescriptionUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
								analyserDescriptionUserControl.Dock = System.Windows.Forms.DockStyle.Bottom;
								analyserDescriptionUserControl.Margin = new System.Windows.Forms.Padding(0);

								analyserDescriptionUserControl.AnalyserKeyWord = keyWord;
								analyserDescriptionUserControl.AnalyserDescriptionDeletedEvent += AnalyserDescriptionUserControl_AnalyserDescriptionDeletedEvent;

								this.pannelOfDescription.Controls.Add(analyserDescriptionUserControl);

								if(this.pannelOfDescription.Size.Height > this.pAutoscrollPanel.Size.Height) {
									this.pAutoscrollPanel.AutoScrollPosition = new Point(this.pannelOfDescription.Size);
								}
							}
						}
					} catch {
						MessageBox.Show("Une erreur est survenue lors de la reconstruction des régles. Si l'erreur persiste, crée un nouveau fichier.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						this.Close();
					}

				} else {
					DialogResult resultOfMessageBox = DialogResult.Cancel;
					resultOfMessageBox = MessageBox.Show("Le fichier à l'adresse suivante \"" + this.msAddrOfFileRule + "\" n'exist pas.\nDésirez vous crée un nouveau fichier ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if(resultOfMessageBox != DialogResult.Yes) {
						this.Close();
					}
				}
			}

			this.NewAnalyserDescription();
		}

		/// <summary>
		/// Use to create a new analyser description at the button of the panel and manage the autoscroll if useful.
		/// </summary>
		private void NewAnalyserDescription() {
			AnalyserDescriptionUserControl analyserDescriptionUserControl = new AnalyserDescriptionUserControl();
			analyserDescriptionUserControl.AutoSize = true;
			analyserDescriptionUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			analyserDescriptionUserControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			analyserDescriptionUserControl.Margin = new System.Windows.Forms.Padding(0);

			//event need for know if an analyser description is create or deleted.
			analyserDescriptionUserControl.NewDescriptionEvent += AnalyserDescriptionUserControl_NewDescriptionEvent;
			analyserDescriptionUserControl.AnalyserDescriptionDeletedEvent += AnalyserDescriptionUserControl_AnalyserDescriptionDeletedEvent;

			try {
				this.pannelOfDescription.Controls.Add(analyserDescriptionUserControl);
			} catch {
				throw new Exception("Can't add analyserDescriptionUserControl in pannelOfDescription.");
			}
			this.mFileOfAnalyserDescription.AddDescription(analyserDescriptionUserControl.AnalyserKeyWord);

			if(this.pannelOfDescription.Size.Height > this.pAutoscrollPanel.Size.Height) {
				this.pAutoscrollPanel.AutoScrollPosition = new Point(this.pannelOfDescription.Size);
			}
		}

		/// <summary>
		/// Remove from the rule file and the pannel the AnalyserDescriptionUserControl that has send the event. 
		/// </summary>
		/// <param name="sender">Object send the event \"analyser description delete\""</param>
		/// <param name="e">Not used.</param>
		private void AnalyserDescriptionUserControl_AnalyserDescriptionDeletedEvent(object sender, EventArgs e) {
			if(sender.GetType() == typeof(AnalyserDescriptionUserControl)) {
				this.mFileOfAnalyserDescription.RemoveDescription(((AnalyserDescriptionUserControl)sender).AnalyserKeyWord);
				this.pannelOfDescription.Controls.Remove((AnalyserDescriptionUserControl)sender);
			}
		}

		/// <summary>
		/// Create a new AnalyserDescriptionUserControl.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void AnalyserDescriptionUserControl_NewDescriptionEvent(object sender, EventArgs e) {
			this.NewAnalyserDescription();
		}

		/// <summary>
		/// Manage the size on order to have an integer number of visible AnalyserDescriptionUserControl (+- manage the autoscroll).
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not sed.</param>
		private void AnalyserDescriptionForm_ResizeEnd(object sender, EventArgs e) {
			int iHeight = this.mSizeOfCstForms.Height + ((this.pAutoscrollPanel.Size.Height / 20) * 20);
			this.Size = new Size(this.Size.Width, iHeight);
		}

		/// <summary>
		/// Call to save current analyser rules.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbSave_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "binaire|*.bin";
			saveFileDialog.Title = "Fichier de description";

			if(this.msAddrOfFileRule.Length != 0) {
				saveFileDialog.InitialDirectory = Path.GetDirectoryName(this.msAddrOfFileRule);
				saveFileDialog.FileName = Path.GetFileName(this.msAddrOfFileRule);
			} else {
				try {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles");
					}
					saveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles";
				} catch {
					saveFileDialog.InitialDirectory = "";
				}
			}

			if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0) {
				//serialize
				try {
					using(Stream stream = File.Open(saveFileDialog.FileName, FileMode.Create)) {
						var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
						bformatter.Serialize(stream, this.mFileOfAnalyserDescription);
					}

					this.mSessionConfigurations.AddrFileAnalyserDescription = saveFileDialog.FileName;
					this.DialogResult = DialogResult.OK;
					this.Close();
				} catch {
					MessageBox.Show("Erreur détéctée lors la sauvegarde des données de configuration. Réitéré la sauvegarde ou quitter sans sauvegarder.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// Call when the user want to exit without save.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
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
