using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADCom.UserButton;
using System.IO;

namespace SADCom {
	public partial class OptionCustomButtonUC : UserControl {

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

				if(this.mSessionConfigurations == null) {
					this.mSessionConfigurations = new SessionConfigurations();
				}//if disposed ?
			}
		}

		/// <summary>
		/// Constructor for disigner viewer
		/// </summary>
		public OptionCustomButtonUC() : this(new SessionConfigurations()) { }
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="sessionConfigurations">Session parameters</param>
		public OptionCustomButtonUC(SessionConfigurations sessionConfigurations) {
			InitializeComponent();
			SessionConfigurations = sessionConfigurations;
		}
	

		/// <summary>
		/// Clear the text box that contain the add of the description file button. 
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbClearAddrCustomButtonFile_Click(object sender, EventArgs e) {
			this.tbAddrCustomButtonFile.Clear();
			this.mSessionConfigurations.AddrOfCustomButtonFileDescription = "";
		}

		/// <summary>
		/// Call to search 
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbSearchCustomButtonFile_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			ButtonsConfigurations buttonsConfigurations = new ButtonsConfigurations();

			if(mSessionConfigurations.AddrOfCustomButtonFileDescription.Length != 0) {
				openFileDialog.InitialDirectory = Path.GetDirectoryName(mSessionConfigurations.AddrOfCustomButtonFileDescription);
				openFileDialog.FileName = Path.GetFileName(mSessionConfigurations.AddrOfCustomButtonFileDescription);

			} else { //default path
				try {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\CustomButtonDescriptionFiles")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\CustomButtonDescriptionFiles");
					}
					openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\CustomButtonDescriptionFiles";
				} catch {
					//if the user are not acces to directory returned by System.IO.Directory.GetCurrentDirectory()
					openFileDialog.InitialDirectory = "";
				}
			}

			try {
				openFileDialog.Filter = "binaire|*.bin";
			} catch {
				throw new ArgumentException("The filter in pbSearchCustomButtonFile_Click cause an argumentException.");
			}

			if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0) {
				if(openFileDialog.FileName.Length > 0) {
					if(File.Exists(openFileDialog.FileName)) {
						try {
							using(Stream stream = File.Open(openFileDialog.FileName, FileMode.Open)) {
								var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

								buttonsConfigurations = (ButtonsConfigurations)bformatter.Deserialize(stream);
							}
							this.mSessionConfigurations.AddrOfCustomButtonFileDescription = openFileDialog.FileName;
							this.tbAddrCustomButtonFile.Text = this.mSessionConfigurations.AddrOfCustomButtonFileDescription;
						} catch {
							MessageBox.Show("Le fichier séléctionné est n'est pas reconnu par le système. Veuilliez réitérer avec un nouveau fichier ou en crée un nouveau.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						}
					} else {
						DialogResult resultOfMessageBox = DialogResult.Cancel;
						resultOfMessageBox = MessageBox.Show("Le fichier à l'adresse suivante \"" + openFileDialog.FileName + "\" n'exist pas.\nDésirez vous crée un nouveau fichier ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

						if(resultOfMessageBox != DialogResult.Yes) {
							this.tbAddrCustomButtonFile.Text = "";
							this.pbNewCustomButtonFile_Click(sender, e);
						}
					}
				}

			}
		}

		/// <summary>
		/// Call to create or edite a custom button file.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbNewCustomButtonFile_Click(object sender, EventArgs e) {
			CustomButtonViewer requestDesigner = new CustomButtonViewer(this.mSessionConfigurations);

			if(this.tbAddrCustomButtonFile.Text.Length > 0) {
				requestDesigner = new CustomButtonViewer(this.mSessionConfigurations, this.tbAddrCustomButtonFile.Text);
			}

			try {
				if(requestDesigner.ShowDialog() == DialogResult.OK) {
					if(mSessionConfigurations.AddrOfCustomButtonFileDescription.Length > 0) {
						this.tbAddrCustomButtonFile.Text = mSessionConfigurations.AddrOfCustomButtonFileDescription;
					}
				}
			} catch {
				throw new Exception("pbNewCustomButtonFile_Click can't open RequestDesigner.");
			}
		}
	}
}
