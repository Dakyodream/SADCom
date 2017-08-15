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


	public delegate void OpacityDataChangedEventHandler(object sender, EventArgs e,int opacity);
	public delegate void OpacityLeaveEventHandler(object sender, EventArgs e);

	public partial class OptionTerminalDisplay : UserControl {

		public event OpacityDataChangedEventHandler opacityEvent;
		public event OpacityLeaveEventHandler leaveOpacityConfigEvent;

		public int Opacity {
			get {
				return this.tbOpacity.Value;
			}
		}

		private SessionConfigurations mSessionConfigurations = new SessionConfigurations();
		public SessionConfigurations SessionConfigurations { get => this.mSessionConfigurations; set => this.mSessionConfigurations = value; }


		/// <summary>
		/// Constructor for disigner viewer
		/// </summary>
		public OptionTerminalDisplay() : this(new SessionConfigurations()) { }
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sessionConfigurations">Session parameters</param>
		public OptionTerminalDisplay(SessionConfigurations sessionConfigurations) {
			InitializeComponent();
		
			this.mSessionConfigurations = sessionConfigurations;

			//default value
			//TimeStamp
			List<double> listOfData = new List<double>();
			listOfData.Add(0.001);
			listOfData.Add(0.01);
			listOfData.Add(0.1);
			listOfData.Add(1);
			listOfData.Add(10);
			listOfData.Add(100);

			double dOldValue = this.mSessionConfigurations.Timestamp;
			this.cbDataTimeStamp.Enabled = this.mSessionConfigurations.TimestampIsEnable;

			//génère l'événement indexChanged, ce qui modifie la valeur initial de this.mSessionConfigurations.Timestamp, d'où l'utilisation d'un buffer intermediaire
			this.cbDataTimeStamp.DataSource = listOfData;
			if(!this.cbDataTimeStamp.Items.Contains(dOldValue)) {
				dOldValue = 1;
			}
			int iReturn = 0;

			try {
				iReturn = this.cbDataTimeStamp.Items.IndexOf(dOldValue);
				this.cbDataTimeStamp.SelectedIndex = iReturn;
			} catch {
				throw new Exception("OptionTerminalDisplay be buid due to cbDataTimeStamp.");
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

			this.lMinOpacity.Text = this.tbOpacity.Minimum + "%";
			this.lMaxOpacity.Text = this.tbOpacity.Maximum + "%";

			this.numMaxLengthBuffer.Value = this.mSessionConfigurations.MaxBufferLength;
		}

		//Timestamp
		/// <summary>
		/// Call when the checkbox enabling the timestamp is checked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbTimeStamp_CheckedChanged(object sender, EventArgs e) {
			this.mSessionConfigurations.TimestampIsEnable = this.cbTimeStamp.Checked;
			this.mSessionConfigurations.Timestamp = (double)this.cbDataTimeStamp.SelectedValue;

			this.cbDataTimeStamp.Enabled = this.mSessionConfigurations.TimestampIsEnable;
		}
		
		/// <summary>
		/// Call when the combobox use to configure the timestamp had its selected index changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbDataTimeStamp_SelectedIndexChanged(object sender, EventArgs e) {
			this.mSessionConfigurations.Timestamp = (double)this.cbDataTimeStamp.SelectedValue;
		}

		//data analyser

		/// <summary>
		/// Call when cbDataAnalyser state changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbDataAnalyser_CheckedChanged(object sender, EventArgs e) {
			this.mSessionConfigurations.DataAnalyserEnable = this.cbDataAnalyser.Checked;
			this.tlbDataAnalyser.Visible = this.mSessionConfigurations.DataAnalyserEnable;
		}

		/// <summary>
		/// Call to select the path of our file analyser description.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pbSelectFileAnalyser_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if(mSessionConfigurations.AddrFileAnalyserDescription.Length == 0) {
				try {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles");
					}
					openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles";
				}catch{
					//if the user are not acces to directory returned by System.IO.Directory.GetCurrentDirectory()
					openFileDialog.InitialDirectory = "";
				}
			} else {
				openFileDialog.InitialDirectory = mSessionConfigurations.AddrFileAnalyserDescription;
			}

			try {
				openFileDialog.Filter = "binaire|*.bin";

				if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0) {
					this.mSessionConfigurations.AddrFileAnalyserDescription = openFileDialog.FileName;
					this.tbLocationFileAnalyser.Text = openFileDialog.FileName;
				}
			} catch {
				throw new ArgumentException("The filter in pbSelectFileAnalyser_Click cause an argumentException.");
			}

		}

		/// <summary>
		/// Call when pbFileAnalyser is cklicked. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pbFileAnalyser_Click(object sender, EventArgs e) {
			if(this.tbLocationFileAnalyser.Text.Length > 0) {
				AnalyserDescriptionForm analyserDescriptionForm = new AnalyserDescriptionForm(mSessionConfigurations, this.tbLocationFileAnalyser.Text);

				if(!analyserDescriptionForm.IsDisposed) {
					if(analyserDescriptionForm.ShowDialog() == DialogResult.OK) {
						if(mSessionConfigurations.AddrFileAnalyserDescription.Length > 0) {
							this.tbLocationFileAnalyser.Text = mSessionConfigurations.AddrFileAnalyserDescription;
						}
					}
				}
			}
		}

		/// <summary>
		/// Call to create a new File;
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pbCreateNewFileAnalyser_Click(object sender, EventArgs e) {
			AnalyserDescriptionForm analyserDescriptionForm = new AnalyserDescriptionForm();

			if(analyserDescriptionForm.ShowDialog() == DialogResult.OK) {
				if(mSessionConfigurations.AddrFileAnalyserDescription.Length > 0) {
					this.tbLocationFileAnalyser.Text = mSessionConfigurations.AddrFileAnalyserDescription;
				}
			}
		}



		private void pbOutputDataAnalyser_Click(object sender, EventArgs e) {
			SaveFileDialog openFileDialog = new SaveFileDialog();

			openFileDialog.Filter = "fichier de données|*.log";

			if(this.mSessionConfigurations.AddrLogFileAnalyser.Length == 0) {
				if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\LogFiles")) {
					Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\LogFiles");
				}
				openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\LogFiles";
			} else {
				openFileDialog.InitialDirectory = this.mSessionConfigurations.AddrLogFileAnalyser;
			}

			if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0) {
				this.mSessionConfigurations.AddrLogFileAnalyser = openFileDialog.FileName;
				this.tbOutputAnalyserLogFile.Text = this.mSessionConfigurations.AddrLogFileAnalyser;
			}
		}



		private void pbClearFileAnalyser_Click(object sender, EventArgs e) {
			this.tbLocationFileAnalyser.Clear();
			this.mSessionConfigurations.AddrFileAnalyserDescription = "";
		}

		private void pbClearbOutputAnalyserLogFile_Click(object sender, EventArgs e) {
			this.tbOutputAnalyserLogFile.Clear();
			this.mSessionConfigurations.AddrLogFileAnalyser = "";
		}




		private void tbOpacity_ValueChanged(object sender, EventArgs e) {
			this.lOpacityCurrentLvl.Text = this.tbOpacity.Value + "%";
			mSessionConfigurations.TerminalOpacity = this.tbOpacity.Value;
			opacityEvent?.Invoke(this, e, this.tbOpacity.Value);
		}


		private void tbOpacity_MouseCaptureChanged(object sender, EventArgs e) {
			leaveOpacityConfigEvent?.Invoke(this, e);

		}

		private void pbTeminalFont_Click(object sender, EventArgs e) {
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowColor = true;

			fontDialog.Font = mSessionConfigurations.TerminalFont;
			fontDialog.Color = mSessionConfigurations.TerminalForeColor;

			if(fontDialog.ShowDialog() != DialogResult.Cancel) {
				mSessionConfigurations.TerminalFont = fontDialog.Font; 
				mSessionConfigurations.TerminalForeColor = fontDialog.Color;

				this.rtbColorExample.Font = mSessionConfigurations.TerminalFont;
				this.rtbColorExample.ForeColor = mSessionConfigurations.TerminalForeColor;

				//save for another sessions
				Properties.Settings.Default.terminalFont = this.rtbColorExample.Font;
				Properties.Settings.Default.terminalForeColor = this.rtbColorExample.ForeColor;
			}
		}

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

		





		//public void checkOtpionsTerminal
		// ==> verifie que les option sont bien remplie, sinon, entourer en rouge les zones vide
	}
}
