using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SADCom.Configuration {

	/// <summary>
	/// Event handler use to transfered the opacity information to main form.
	/// </summary>
	/// <param name="sender">The object sending the event.</param>
	/// <param name="e">Not used.</param>
	/// <param name="opacity">The level opacity (0 to 100).</param>
	public delegate void OpacityDataChangedEventHandler(object sender, EventArgs e,int opacity);
	/// <summary>
	/// Event handler use to indicate that the user no longer configures the opacity form. 
	/// </summary>
	/// <param name="sender">The object sending the event.</param>
	/// <param name="e">Not used.</param>
	public delegate void OpacityLeaveEventHandler(object sender, EventArgs e);

	/// <summary>
	/// User interface that contain the terminal option like background color, font, file analyser rules, ...
	/// </summary>
	public partial class OptionTerminalDisplay : UserControl {

		/// <summary>
		/// Event send when the user move the trackbare managing the opacity.
		/// </summary>
		public event OpacityDataChangedEventHandler opacityEvent;
		/// <summary>
		/// Event send when the user leave the trackbar that manage the opacity windows (= leave the preview of opacity).
		/// </summary>
		public event OpacityLeaveEventHandler leaveOpacityConfigEvent;

		/// <summary>
		/// Return the opacity level configurate by the user.
		/// </summary>
		public int Opacity {
			get {
				return this.tbOpacity.Value;
			}
		}

		/// <summary>
		/// Contain the configuration of this session.
		/// </summary>
		private SessionConfigurations mSessionConfigurations = new SessionConfigurations();
		/// <summary>
		/// Contain the configuration of this session. See <see cref="mSessionConfigurations"/>.
		/// </summary>
		public SessionConfigurations SessionConfigurations {
			get => this.mSessionConfigurations;
			set {
				this.mSessionConfigurations = value;

				//TimeStamp
				double dOldValue = this.mSessionConfigurations.Timestamp;
				this.cbDataTimeStamp.Enabled = this.mSessionConfigurations.TimestampIsEnable;

				//génère l'événement indexChanged, ce qui modifie la valeur initial de this.mSessionConfigurations.Timestamp, d'où l'utilisation d'un buffer intermediaire
				if(!this.cbDataTimeStamp.Items.Contains(dOldValue)) {
					dOldValue = 1;
				}
				int iReturn = 0;

				try {
					iReturn = this.cbDataTimeStamp.Items.IndexOf(dOldValue);
					this.cbDataTimeStamp.SelectedIndex = iReturn;
				} catch {
					throw new Exception("OptionTerminalDisplay can't be buid due to cbDataTimeStamp.");
				}

				this.mSessionConfigurations.Timestamp = dOldValue;


				//DataAnalyser
				this.cbDataAnalyser.Checked = this.mSessionConfigurations.DataAnalyserEnable;
				this.tlbDataAnalyser.Visible = this.mSessionConfigurations.DataAnalyserEnable;

				//color
				this.rtbColorExample.Font = mSessionConfigurations.TerminalFont;
				this.rtbColorExample.ForeColor = mSessionConfigurations.TerminalForeColor;
				this.rtbColorExample.BackColor = mSessionConfigurations.TerminalBackground;
				this.tbOpacity.Value = mSessionConfigurations.TerminalOpacity;

				this.numMaxLengthBuffer.Value = this.mSessionConfigurations.MaxBufferLength;
			}
		}


		/// <summary>
		/// Constructor for disigner viewer
		/// </summary>
		public OptionTerminalDisplay() : this(new SessionConfigurations()) { }
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="sessionConfigurations">Session parameters</param>
		public OptionTerminalDisplay(SessionConfigurations sessionConfigurations) {
			InitializeComponent();
		
			//default value
			//TimeStamp
			List<double> listOfData = new List<double>();
			listOfData.Add(0.001);
			listOfData.Add(0.01);
			listOfData.Add(0.1);
			listOfData.Add(1);
			listOfData.Add(10);
			listOfData.Add(100);

			this.cbDataTimeStamp.DataSource = listOfData;

			//color
			this.lMinOpacity.Text = this.tbOpacity.Minimum + "%";
			this.lMaxOpacity.Text = this.tbOpacity.Maximum + "%";

			SessionConfigurations = sessionConfigurations;
		}

		//Timestamp
		/// <summary>
		/// Call when the checkbox enabling the timestamp is checked
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void cbTimeStamp_CheckedChanged(object sender, EventArgs e) {
			this.mSessionConfigurations.TimestampIsEnable = this.cbTimeStamp.Checked;
			this.mSessionConfigurations.Timestamp = (double)this.cbDataTimeStamp.SelectedValue;

			this.cbDataTimeStamp.Enabled = this.mSessionConfigurations.TimestampIsEnable;
		}
		
		/// <summary>
		/// Call when the combobox use to configure the timestamp had its selected index changed.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void cbDataTimeStamp_SelectedIndexChanged(object sender, EventArgs e) {
			this.mSessionConfigurations.Timestamp = (double)this.cbDataTimeStamp.SelectedValue;
		}

		//data analyser

		/// <summary>
		/// Call when cbDataAnalyser state changed
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void cbDataAnalyser_CheckedChanged(object sender, EventArgs e) {
			this.mSessionConfigurations.DataAnalyserEnable = this.cbDataAnalyser.Checked;
			this.tlbDataAnalyser.Visible = this.mSessionConfigurations.DataAnalyserEnable;
		}

		/// <summary>
		/// Call to select the path of our file analyser description.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbSelectFileAnalyser_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			FileAnalyserDescription fileAnalDescForTest = new FileAnalyserDescription();

			if(mSessionConfigurations.AddrFileAnalyserDescription.Length != 0) {
				openFileDialog.InitialDirectory = Path.GetDirectoryName(mSessionConfigurations.AddrFileAnalyserDescription);
				openFileDialog.FileName = Path.GetFileName(mSessionConfigurations.AddrFileAnalyserDescription);

			} else { //default path
				try {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles");
					}
					openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles";
				} catch {
					//if the user are not acces to directory returned by System.IO.Directory.GetCurrentDirectory()
					openFileDialog.InitialDirectory = "";
				}
			}

			try {
				openFileDialog.Filter = "binaire|*.bin";				
			} catch {
				throw new ArgumentException("The filter in pbSelectFileAnalyser_Click cause an argumentException.");
			}

			if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0) {
				if(openFileDialog.FileName.Length > 0) {
					if(File.Exists(openFileDialog.FileName)) {
						try {
							using(Stream stream = File.Open(openFileDialog.FileName, FileMode.Open)) {
								var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

								fileAnalDescForTest = (FileAnalyserDescription)bformatter.Deserialize(stream);
							}
							this.mSessionConfigurations.AddrFileAnalyserDescription = openFileDialog.FileName;
							this.tbLocationFileAnalyser.Text = this.mSessionConfigurations.AddrFileAnalyserDescription;
						} catch {
							MessageBox.Show("Le fichier séléctionné est n'est pas reconnu par le système. Veuilliez réitérer avec un nouveau fichier ou en crée un nouveau.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						}
					} else {
						DialogResult resultOfMessageBox = DialogResult.Cancel;
						resultOfMessageBox = MessageBox.Show("Le fichier à l'adresse suivante \"" + openFileDialog.FileName + "\" n'exist pas.\nDésirez vous crée un nouveau fichier ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if(resultOfMessageBox != DialogResult.Yes) {
							this.pbCreateNewFileAnalyser_Click(sender, e);
						}
					}
				}
				
			}
		}

		/// <summary>
		/// Call when pbFileAnalyser is cklicked. 
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbFileAnalyser_Click(object sender, EventArgs e) {
			AnalyserDescriptionForm analyserDescriptionForm;

			if(this.tbLocationFileAnalyser.Text.Length <= 0) {
				this.pbSelectFileAnalyser_Click(sender, e);
			} else {
				analyserDescriptionForm = new AnalyserDescriptionForm(mSessionConfigurations, this.tbLocationFileAnalyser.Text);

				if(!analyserDescriptionForm.IsDisposed) {
					try {
						if(analyserDescriptionForm.ShowDialog() == DialogResult.OK) {
							if(mSessionConfigurations.AddrFileAnalyserDescription.Length > 0) {
								this.tbLocationFileAnalyser.Text = mSessionConfigurations.AddrFileAnalyserDescription;
							}
						}
					} catch {
						throw new Exception("pbFileAnalyser_Click can't open analyserDescriptionForm.");
					}
				}
			}
		}

		/// <summary>
		/// Call to create a new File;
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbCreateNewFileAnalyser_Click(object sender, EventArgs e) {
			AnalyserDescriptionForm analyserDescriptionForm = new AnalyserDescriptionForm();

			try {
				if(analyserDescriptionForm.ShowDialog() == DialogResult.OK) {
					if(mSessionConfigurations.AddrFileAnalyserDescription.Length > 0) {
						this.tbLocationFileAnalyser.Text = mSessionConfigurations.AddrFileAnalyserDescription;
					}
				}
			} catch {
				throw new Exception("pbCreateNewFileAnalyser_Click can't open analyserDescriptionForm.");
			}
		}


		/// <summary>
		/// Call to select the file name of file that contain log data.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbOutputDataAnalyser_Click(object sender, EventArgs e) {
			SaveFileDialog openFileDialog = new SaveFileDialog();

			try {
				openFileDialog.Filter = "fichier de données|*.log";
			} catch {
				throw new ArgumentException("Le filtre du formulaire appelée par pbOutputDataAnalyser_Click est incorect.");
			}


			if(mSessionConfigurations.AddrLogFileAnalyser.Length != 0) {
				openFileDialog.InitialDirectory = Path.GetDirectoryName(mSessionConfigurations.AddrLogFileAnalyser);
				openFileDialog.FileName = Path.GetFileName(mSessionConfigurations.AddrLogFileAnalyser);

			} else { //default path
				try {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\LogFiles")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\LogFiles");
					}
					openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\LogFiles";
				} catch {
					//if the user are not acces to directory returned by System.IO.Directory.GetCurrentDirectory()
					openFileDialog.InitialDirectory = "";
				}
			}

			if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0) {
				this.mSessionConfigurations.AddrLogFileAnalyser = openFileDialog.FileName;
				this.tbOutputAnalyserLogFile.Text = this.mSessionConfigurations.AddrLogFileAnalyser;
			}
		}


		/// <summary>
		/// Call to delet the file using by the analyser data.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbClearFileAnalyser_Click(object sender, EventArgs e) {
			this.tbLocationFileAnalyser.Clear();
			this.mSessionConfigurations.AddrFileAnalyserDescription = "";
		}

		/// <summary>
		/// Call to delet the output log file.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbClearbOutputAnalyserLogFile_Click(object sender, EventArgs e) {
			this.tbOutputAnalyserLogFile.Clear();
			this.mSessionConfigurations.AddrLogFileAnalyser = "";
		}

		/// <summary>
		/// Call when the user configure the terminal opacity.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbOpacity_ValueChanged(object sender, EventArgs e) {
			this.lOpacityCurrentLvl.Text = this.tbOpacity.Value + "%";
			mSessionConfigurations.TerminalOpacity = this.tbOpacity.Value;
			opacityEvent?.Invoke(this, null, this.tbOpacity.Value);
		}

		/// <summary>
		/// Call when the user leave the trackbar managing the window's opacity.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbOpacity_MouseCaptureChanged(object sender, EventArgs e) {
			leaveOpacityConfigEvent?.Invoke(this, null);
		}


		/// <summary>
		/// Call to select the terminal default font.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbTeminalFont_Click(object sender, EventArgs e) {
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowColor = true;

			fontDialog.Font = mSessionConfigurations.TerminalFont;
			fontDialog.Color = mSessionConfigurations.TerminalForeColor;

			if(fontDialog.ShowDialog() == DialogResult.OK) {
				mSessionConfigurations.TerminalFont = fontDialog.Font; 
				mSessionConfigurations.TerminalForeColor = fontDialog.Color;

				this.rtbColorExample.Font = mSessionConfigurations.TerminalFont;
				this.rtbColorExample.ForeColor = mSessionConfigurations.TerminalForeColor;

				//save for futur sessions
				Properties.Settings.Default.terminalFont = this.rtbColorExample.Font;
				Properties.Settings.Default.terminalForeColor = this.rtbColorExample.ForeColor;
			}
		}

		/// <summary>
		/// Call to select the terminal background color.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbTerminalBackgroundColor_Click(object sender, EventArgs e) {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = mSessionConfigurations.TerminalBackground;  

			if(colorDialog.ShowDialog() != DialogResult.Cancel) {
				mSessionConfigurations.TerminalBackground = colorDialog.Color;
				this.rtbColorExample.BackColor = mSessionConfigurations.TerminalBackground;

				//save for another sessions
				Properties.Settings.Default.terminalBackground = this.rtbColorExample.BackColor;
			}
		}

		


		/// TODO: make a metode that call by the windows to check if all parameters ar OK
		//public void checkOtpionsTerminal
		// ==> verifie que les option sont bien remplie, sinon, entourer en rouge les zones vide
		public bool CheckOptionTerminal() {
			bool bReturn = true;

			if(this.cbDataAnalyser.Checked) {
				if(this.tbLocationFileAnalyser.Text.Length <= 0) {
					this.tbLocationFileAnalyser.BackColor = Color.Red;
					bReturn = false;
				} else {
					this.tbLocationFileAnalyser.BackColor = SystemColors.Control;
				}
			}

			return bReturn;
		}

		/// <summary>
		/// Restor default color.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbLocationFileAnalyser_TextChanged(object sender, EventArgs e) {
			if(this.tbLocationFileAnalyser.BackColor != SystemColors.Control) {
				this.tbLocationFileAnalyser.BackColor = SystemColors.Control;
			}
		}
	}
}
