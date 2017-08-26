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

namespace SADCom.UserButton {

	/// <summary>
	/// This class is used to generate and edit the user custom request buttons.
	/// </summary>
	public partial class CustomButtonViewer : Form {

		/// <summary>
		/// Contain the configuration of this session.
		/// </summary>
		private SessionConfigurations mSessionConfigurations;

		/// <summary>
		/// Object manage the custom button list.
		/// </summary>
		private ButtonsConfigurations mButtonsConfigurations;

		/// <summary>
		/// Use to manage the size form for show an integer number of CustomButtonUC.
		/// </summary>
		private Size mSizeOfCstForms;

		/// <summary>
		/// Contain the address of file contain the description of custom button.
		/// </summary>
		private string msAddrOfCustomButtonFileDescription;

		/// <summary>
		/// Void constructor for the disigner viewer.
		/// </summary>
		public CustomButtonViewer() : this(new SessionConfigurations(), "") { }
		/// <summary>
		/// Constructor use to create a new list of custom button. 
		/// </summary>
		/// <param name="sessionConfigurations">Session configuration.</param>
		public CustomButtonViewer(SessionConfigurations sessionConfigurations) : this(sessionConfigurations, "") { }
		/// <summary>
		/// Constructor use to edit a custom button description file.
		/// </summary>
		/// <param name="sessionConfigurations">Session configuration.</param>
		/// <param name="AddrOfCustomButtonFileDescription">Path of the button description file.</param>
		/// <remarks>
		/// Don't forget !requestDesigner.IsDisposed befor requestDesigner.ShowDialog()
		/// </remarks>
		/// <example>
		/// <code>
		/// RequestDesigner requestDesigner = new RequestDesigner(mSessionConfigurations, this.tbLocationFile.Text);
		///	if(!requestDesigner.IsDisposed) {
		///		if(requestDesigner.ShowDialog() == DialogResult.OK) {
		///			...
		///		}
		///	}
		///	</code>
		/// </example>
		public CustomButtonViewer(SessionConfigurations sessionConfigurations, string AddrOfCustomButtonFileDescription) {
			InitializeComponent();
			
			//copy all params
			this.mSessionConfigurations = sessionConfigurations;
			this.msAddrOfCustomButtonFileDescription = AddrOfCustomButtonFileDescription;

			//instanciate the object
			this.mButtonsConfigurations = new ButtonsConfigurations();

			//Calcul la taille de la fenetre sans la partie affichant les analyserDescriptionUserControl (seule partie qui varira en hauteur).
			this.mSizeOfCstForms = new Size(this.Size.Width, this.Size.Height - this.pAutoscroll.Size.Height);

			//Detect if we are in edit mode.
			if(this.msAddrOfCustomButtonFileDescription.Length > 0) {
				if(File.Exists(this.msAddrOfCustomButtonFileDescription)) {

					try {
						using(Stream stream = File.Open(this.msAddrOfCustomButtonFileDescription, FileMode.Open)) {
							var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

							this.mButtonsConfigurations = (ButtonsConfigurations)bformatter.Deserialize(stream);
						}
					} catch {
						MessageBox.Show("Le fichier séléctionné est n'est pas reconnu par le système. Veuilliez réitérer avec un nouveau fichier ou en crée un nouveau.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						this.Close();
					}

					try {
						foreach(ButtonConfigurations buttonConfig in this.mButtonsConfigurations.ListOfUserButton) {
							if(buttonConfig.ButtonName.Length > 0) {

								CustomButtonUC customButtonDesignerUC = new CustomButtonUC();
								customButtonDesignerUC.AutoSize = true;
								customButtonDesignerUC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
								customButtonDesignerUC.Dock = System.Windows.Forms.DockStyle.Bottom;
								customButtonDesignerUC.Margin = new System.Windows.Forms.Padding(0);

								customButtonDesignerUC.ButtonConfig = buttonConfig;

								customButtonDesignerUC.OnCustomButtonDeletedEvent += CustomButtonDesignerUC_CustomButtonDeletedEvent;

								this.pCustomButtonDesigner.Controls.Add(customButtonDesignerUC);


								if(this.pCustomButtonDesigner.Size.Height > this.pAutoscroll.Size.Height) {
									this.pAutoscroll.AutoScrollPosition = new Point(this.pCustomButtonDesigner.Size);
								}
							}
						}
					} catch {
						MessageBox.Show("Une erreur est survenue lors de la reconstruction des régles. Si l'erreur persiste, crée un nouveau fichier.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						this.Close();
					}

				} else {
					DialogResult resultOfMessageBox = DialogResult.Cancel;
					resultOfMessageBox = MessageBox.Show("Le fichier à l'adresse suivante \"" + this.msAddrOfCustomButtonFileDescription + "\" n'exist pas.\nDésirez vous crée un nouveau fichier ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if(resultOfMessageBox != DialogResult.Yes) {
						this.Close();
					}
				}
			}
			this.NewCustomButton();
		}

		/// <summary>
		/// Use to create a new custom button. 
		/// </summary>
		private void NewCustomButton() {
			CustomButtonUC customButtonDesignerUC = new CustomButtonUC();
			customButtonDesignerUC.AutoSize = true;
			customButtonDesignerUC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			customButtonDesignerUC.Dock = System.Windows.Forms.DockStyle.Bottom;
			customButtonDesignerUC.Margin = new System.Windows.Forms.Padding(0);

			customButtonDesignerUC.OnNewCustomButtonEvent += CustomButtonDesignerUC_NewCustomButtonEvent;
			customButtonDesignerUC.OnCustomButtonDeletedEvent += CustomButtonDesignerUC_CustomButtonDeletedEvent;

			try {
				this.pCustomButtonDesigner.Controls.Add(customButtonDesignerUC);
			} catch {
				throw new Exception("Can't add customButtonDesignerUC in pCustomButtonDesigner.");
			}
			this.mButtonsConfigurations.AddButton(customButtonDesignerUC.ButtonConfig);

			if(this.pCustomButtonDesigner.Size.Height > this.pAutoscroll.Size.Height) {
				this.pAutoscroll.AutoScrollPosition = new Point(this.pCustomButtonDesigner.Size);
			}
		}

		/// <summary>
		/// Create a new CustomButtonUC. 
		/// </summary>
		/// <param name="sender">Object send the event, but not used.</param>
		/// <param name="e">Not used.</param>
		private void CustomButtonDesignerUC_NewCustomButtonEvent(object sender, EventArgs e) {
			this.NewCustomButton();
		}

		/// <summary>
		/// Remove from button list the button associate to customButtonDesignerUC that send this event.
		/// </summary>
		/// <param name="sender">Object <see cref="CustomButtonUC"/> send the event</param>
		/// <param name="e">Not used.</param>
		private void CustomButtonDesignerUC_CustomButtonDeletedEvent(object sender, EventArgs e) {
			if(sender.GetType() == typeof(CustomButtonUC)) {
				this.mButtonsConfigurations.RemoveButton(((CustomButtonUC)sender).ButtonConfig);
				this.pCustomButtonDesigner.Controls.Remove((CustomButtonUC)sender);
			}
		}

		/// <summary>
		/// Call to save the current custom button list.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbSaveAndExit_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "binaire|*.bin";
			saveFileDialog.Title = "Fichier décrivant les boutton personalisés.";

			if(this.msAddrOfCustomButtonFileDescription.Length != 0) {
				saveFileDialog.InitialDirectory = Path.GetDirectoryName(this.msAddrOfCustomButtonFileDescription);
				saveFileDialog.FileName = Path.GetFileName(this.msAddrOfCustomButtonFileDescription);
			} else {
				try {
					if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\CustomButtonDescriptionFiles")) {
						Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\CustomButtonDescriptionFiles");
					}
					saveFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\CustomButtonDescriptionFiles";
				} catch {
					saveFileDialog.InitialDirectory = "";
				}
			}

			if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog.FileName.Length > 0) {
				//serialize
				try {
					using(Stream stream = File.Open(saveFileDialog.FileName, FileMode.Create)) {
						var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
						bformatter.Serialize(stream, this.mButtonsConfigurations);
					}

					this.mSessionConfigurations.AddrOfCustomButtonFileDescription = saveFileDialog.FileName;
					this.DialogResult = DialogResult.OK;
					this.Close();
				} catch {
					MessageBox.Show("Erreur détéctée lors la sauvegarde des données de configuration. Réitéré la sauvegarde ou quitter sans sauvegarder.", this.Text, MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// Call to quit the windows without save.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbExitWithoutSave_Click(object sender, EventArgs e) {
			try {
				this.DialogResult = DialogResult.Ignore;
				this.Close();
			} catch {
				throw new Exception("Can't close the analyser description dialog.");
			}
		}

		/// <summary>
		/// Manage the size on order to have an integer number of visible CustomButtonUC (+- manage the autoscroll).
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not sed.</param>
		private void RequestDesigner_ResizeEnd(object sender, EventArgs e) {
			int iHeight = this.mSizeOfCstForms.Height + ((this.pAutoscroll.Size.Height / 23) * 23);

			if(!this.tlpColumnsLabels.Visible) {
				iHeight -= this.tlpColumnsLabels.Size.Height;
			}
			this.Size = new Size(this.Size.Width, iHeight);
		}

		private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e) {
			this.alwaysOnTopToolStripMenuItem.Checked = !this.alwaysOnTopToolStripMenuItem.Checked;
			this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
		}

		private void minimalInterfaceToolStripMenuItem_Click(object sender, EventArgs e) {
			this.minimalInterfaceToolStripMenuItem.Checked = !this.minimalInterfaceToolStripMenuItem.Checked;
			ReduceDisplay(this.minimalInterfaceToolStripMenuItem.Checked);
		}

		private void ReduceDisplay(bool reduceIt) {
			foreach(CustomButtonUC customButton in this.pCustomButtonDesigner.Controls) {
				customButton.ReduceTheForm(reduceIt);
			}
			if(this.pCustomButtonDesigner.Controls.Count > 0) {
				this.pCustomButtonDesigner.Controls[this.pCustomButtonDesigner.Controls.Count-1].Visible = !reduceIt;
			}
			this.tlpColumnsLabels.Visible = !reduceIt;

			if(reduceIt) {
				this.MinimumSize = new Size(215, 153);
			} else {
				this.MinimumSize = new Size(350, 153);
			}
		}

		
	}
}
