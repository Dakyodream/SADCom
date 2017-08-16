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

	/// <summary>
	/// This class manage the form use to select the output data file.
	/// </summary>
	public partial class SaveDataFileUC : UserControl {


		/// <summary>
		/// Contain the configuration of this session.
		/// </summary>
		private SessionConfigurations mSessionConfigurations = new SessionConfigurations();
		/// <summary>
		/// Contain the configuration of this session. See <see cref="mSessionConfigurations"/>.
		/// </summary>
		public SessionConfigurations SessionConfigurations { get => this.mSessionConfigurations;
			set {
				this.mSessionConfigurations = value;
				this.tbDataFileAddr.Text = this.mSessionConfigurations.AddrDataFile;
				this.cbSaveTimestampInDataFile.Checked = this.mSessionConfigurations.WriteTimestampOnDataFile;
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		public SaveDataFileUC() : this(new SessionConfigurations()) {}
		/// <summary>
		/// Constructor whith session configurations data.
		/// </summary>
		/// <param name="sessionConfigurations">Session configurations data</param>
		public SaveDataFileUC(SessionConfigurations sessionConfigurations) {
			InitializeComponent();
			SessionConfigurations = sessionConfigurations;

		}

		/// <summary>
		/// Call to select the output file.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbNewDataFile_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			try {
				saveFileDialog.Filter = "CSV (séparateur: point-virgule)|*.csv|RTF Files|*.rtf|TEXT Texte|*.txt";
			} catch {
				throw new ArgumentException("Le filtre du formulaire appelée par " + System.Reflection.MethodBase.GetCurrentMethod().Name + " est incorect.");
			}
			
			if(this.mSessionConfigurations.AddrDataFile.Length > 0) {
				saveFileDialog.InitialDirectory = Path.GetDirectoryName(this.mSessionConfigurations.AddrDataFile);
				saveFileDialog.FileName = Path.GetFileName(this.mSessionConfigurations.AddrDataFile);
			} else {
				try {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\OutputData")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\OutputData");
					}
					saveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\OutputData";
				} catch {
					saveFileDialog.InitialDirectory = "";
				}
			}

			if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0) {
				this.mSessionConfigurations.AddrDataFile = saveFileDialog.FileName;
				this.tbDataFileAddr.Text = this.mSessionConfigurations.AddrDataFile;
			}
		}

		/// <summary>
		/// Call to clear the file output addr.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbClearDataFileAddr_Click(object sender, EventArgs e) {
			this.mSessionConfigurations.AddrDataFile = "";
			this.tbDataFileAddr.Text = this.mSessionConfigurations.AddrDataFile;
		}

		/// <summary>
		/// Check if the user whent to write the timestamp information on output file.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void cbSaveTimestampInDataFile_CheckedChanged(object sender, EventArgs e) {
			this.mSessionConfigurations.WriteTimestampOnDataFile = this.cbSaveTimestampInDataFile.Checked;
		}
	}
}
