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

namespace SADCom {


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


		public OptionTerminalDisplay() {
			InitializeComponent();
			InitInterface();
			//this.ttInfo.Show("teste", this.pbFileAnalyser);
		}

		


		private void pbTeminalFont_Click(object sender, EventArgs e) {
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowColor = true;
			
			fontDialog.Font = Resources.TerminalConfiguration.Default.terminalFont;
			fontDialog.Color = Resources.TerminalConfiguration.Default.terminalForeColor;

			if(fontDialog.ShowDialog() != DialogResult.Cancel) {
				Resources.TerminalConfiguration.Default.terminalFont = fontDialog.Font; 
				Resources.TerminalConfiguration.Default.terminalForeColor = fontDialog.Color;

				this.rtbColorExample.Font = Resources.TerminalConfiguration.Default.terminalFont;
				this.rtbColorExample.ForeColor = Resources.TerminalConfiguration.Default.terminalForeColor;
			}
		}

		private void pbTerminalBackgroundColor_Click(object sender, EventArgs e) {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = Resources.TerminalConfiguration.Default.terminalBackground;

			if(colorDialog.ShowDialog() != DialogResult.Cancel) {
				Resources.TerminalConfiguration.Default.terminalBackground = colorDialog.Color;
			}
		}

		private void cbDataAnalyser_CheckedChanged(object sender, EventArgs e) {
			this.tlbDataAnalyser.Visible = this.cbDataAnalyser.Checked;
		}

		private void cbTimeStamp_CheckedChanged(object sender, EventArgs e) {
			this.cbDataTimeStamp.Enabled = this.cbTimeStamp.Checked;
		}

		private void InitInterface() {
			//default value
			//TimeStamp
			List<double> listOfData = new List<double>();
			listOfData.Add(0.001);
			listOfData.Add(0.01);
			listOfData.Add(0.1);
			listOfData.Add(1);
			listOfData.Add(10);
			listOfData.Add(100);

			this.cbDataTimeStamp.Enabled = this.cbTimeStamp.Checked;
			this.cbDataTimeStamp.DataSource = listOfData;
			this.cbDataTimeStamp.SelectedIndex = 3;
			

			//DataAnalyser
			this.tlbDataAnalyser.Visible = this.cbDataAnalyser.Checked;


			//color
			Resources.TerminalConfiguration.Default.terminalFont = Properties.Settings.Default.terminalFont;
			Resources.TerminalConfiguration.Default.terminalForeColor = Properties.Settings.Default.terminalForeColor;
			Resources.TerminalConfiguration.Default.terminalBackground = Properties.Settings.Default.terminalBackground;
			Resources.TerminalConfiguration.Default.terminalOpacity = Properties.Settings.Default.terminalOpacity;

			this.rtbColorExample.Font = Resources.TerminalConfiguration.Default.terminalFont;
			this.rtbColorExample.ForeColor = Resources.TerminalConfiguration.Default.terminalForeColor;
			this.rtbColorExample.BackColor = Resources.TerminalConfiguration.Default.terminalBackground;
			this.tbOpacity.Value = Resources.TerminalConfiguration.Default.terminalOpacity;

			this.lMinOpacity.Text = this.tbOpacity.Minimum + "%";
			this.lMaxOpacity.Text = this.tbOpacity.Maximum + "%";



		}


		private void tbOpacity_ValueChanged(object sender, EventArgs e) {
			this.lOpacityCurrentLvl.Text = this.tbOpacity.Value + "%";
			Resources.TerminalConfiguration.Default.terminalOpacity = this.tbOpacity.Value;
			opacityEvent?.Invoke(this, e, this.tbOpacity.Value);
		}

		private void tbOpacity_MouseCaptureChanged(object sender, EventArgs e) {
			leaveOpacityConfigEvent?.Invoke(this, e);

		}

		private void pbFileAnalyser_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "binaire|*.bin";

			if(Resources.TerminalConfiguration.Default.addrFileAnalyserDescription.Length == 0) {
				if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles")) {
					Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles");
				}
				openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\AnalyserDescriptionFiles";
			} else {
				openFileDialog.InitialDirectory = Resources.TerminalConfiguration.Default.addrFileAnalyserDescription;
			}

			if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0) {
				this.tbLocationFileAnalyser.Text = openFileDialog.FileName;
			}

			if(this.tbLocationFileAnalyser.Text.Length > 0) {
				AnalyserDescriptionForm analyserDescriptionForm = new AnalyserDescriptionForm(this.tbLocationFileAnalyser.Text);

				analyserDescriptionForm.Show();
				analyserDescriptionForm.NewFileCreateEvent += AnalyserDescriptionForm_NewFileCreateEvent;
			}
		}

		private void pbCreateNewFileAnalyser_Click(object sender, EventArgs e) {
			AnalyserDescriptionForm analyserDescriptionForm = new AnalyserDescriptionForm();

			analyserDescriptionForm.Show();
			analyserDescriptionForm.NewFileCreateEvent += AnalyserDescriptionForm_NewFileCreateEvent;
		
		}

		private void AnalyserDescriptionForm_NewFileCreateEvent(object sender, EventArgs e) {

			if(Resources.TerminalConfiguration.Default.addrFileAnalyserDescription.Length > 0) {
				this.tbLocationFileAnalyser.Text = Resources.TerminalConfiguration.Default.addrFileAnalyserDescription;
				this.Update();
			}
		}

		private void pbOutputDataAnalyser_Click(object sender, EventArgs e) {

		}


		//public void checkOtpionsTerminal
		// ==> verifie que les option sont bien remplie, sinon, entourer en rouge les zones vide
	}
}
