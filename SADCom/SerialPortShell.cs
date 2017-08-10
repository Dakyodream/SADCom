using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom {
	public partial class SerialPortShell : Form {
		private SerialPort mSerialPort;

		private string saveShellData = "";

		private System.Windows.Forms.Timer mTimerForUpdateStatus;
		delegate void SetTextCallback(string text);

		private List<SerialDataToSave> mlistOfData;

		//sauvegarde des données
		private List<string> mlistOfNameForTimeFile;
		private List<string> mlistOfNameForDataFile;
		private List<string> mlistOfNameForDataModifFile;

		private uint muiLengthOfNbOfLineOnShell = 100;

		private RichTextBox rtbSaveFile = new RichTextBox();

		private Mutex mMutexData = new Mutex();
		private Mutex mMutexAffichage = new Mutex();

		/**
		 * TODO : Objectif futur proche :
		 *	- sauvegarder le texte en brut
		 *	- un mode qui ajoute une nouvelle ligne (si non existance) à chaque reçu
		 *	- l'horodatage n'horodate que les lignes (en permanance) (et donc à relier à un troisième fichier qui sera modifier en fonction de l'option précédente)
		 *	- limiter la precision de l'horodatage (???)
		 *	- sécuriser le code
		 * 
		 **/

		//TODO try/catch
		public SerialPortShell(SerialPort serialPort) {
			string saveDirectory = "";
			string sNameOfSaveFile = "saveShellData_" + serialPort.PortName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bin";

			InitializeComponent();

			mTimerForUpdateStatus = new System.Windows.Forms.Timer();
			mTimerForUpdateStatus.Tick += MTimerForUpdateStatus_Tick;
			mTimerForUpdateStatus.Interval = 1000;
			mTimerForUpdateStatus.Start();

			mlistOfData = new List<SerialDataToSave>();


			if(!Directory.Exists(Path.GetTempPath() + "SADCom")) {
				Directory.CreateDirectory(Path.GetTempPath() + "SADCom");
			}

			mlistOfNameForTimeFile = new List<string>();
			mlistOfNameForDataFile = new List<string>();
			mlistOfNameForDataModifFile = new List<string>();

			this.mlistOfNameForTimeFile.Add(Path.GetTempPath() + @"SADCom\timeFile_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bin");
			this.mlistOfNameForDataFile.Add(Path.GetTempPath() + @"SADCom\dataFile_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bin");
			this.mlistOfNameForDataModifFile.Add(Path.GetTempPath() + @"SADCom\dataModifFile_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bin");

			this.mSerialPort = serialPort;
			this.mSerialPort.ReadTimeout = 200;
			this.mSerialPort.WriteTimeout = 200;

			this.lStatus.ForeColor = Color.Green;
			this.lStatus.Text = this.mSerialPort.PortName + " [connected]";

			//this.pbLevelBuffer.Maximum = this.rtbSerialPort.MaxLength;

			//this.pbLevelBuffer.Maximum = (int)muiLengthOfNbOfLineOnShell;

			this.mSerialPort.DataReceived += MSerialPort_DataReceived;
			this.mSerialPort.Disposed += MSerialPort_Disposed;
			this.mSerialPort.ErrorReceived += MSerialPort_ErrorReceived;
			this.mSerialPort.PinChanged += MSerialPort_PinChanged;

			this.mSerialPort.Open();
		}

		private void MTimerForUpdateStatus_Tick(object sender, EventArgs e) {
			//this.pbLevelBuffer.Value = this.rtbSerialPort.TextLength;


			//private String msDataOnly = "";
			//private String msDate = "";
			//private String msDataOnHexa = "";
			//private String msDataWithAnalyse = "";

			if(this.rtbSerialPort.Lines.Length < muiLengthOfNbOfLineOnShell) {
				//this.pbLevelBuffer.Value = this.rtbSerialPort.Lines.Length;
			} else {
				//this.pbLevelBuffer.Value = ((int)muiLengthOfNbOfLineOnShell);
			}
			if(this.mSerialPort.IsOpen) {
				this.lStatus.ForeColor = Color.Green;
				this.lStatus.Text = this.mSerialPort.PortName + " [connected]";
			} else {
				this.lStatus.ForeColor = Color.Red;
				this.lStatus.Text = this.mSerialPort.PortName + " [unconnected]";
			}
		}

		private void MSerialPort_PinChanged(object sender, SerialPinChangedEventArgs e) {
			this.lStatus.ForeColor = Color.Red;
			this.lStatus.Text = this.mSerialPort.PortName + " [pin changed]";
		}

		private void MSerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e) {
			this.lStatus.ForeColor = Color.Orange;
			this.lStatus.Text = this.mSerialPort.PortName + " [error received]";
		}

		private void MSerialPort_Disposed(object sender, EventArgs e) {
			this.lStatus.ForeColor = Color.Red;
			this.lStatus.Text = this.mSerialPort.PortName + " [disposed]";
		}

		private void MSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
			writeTxtOnForm(this.mSerialPort.ReadExisting());

		}

		//warning génère garbage collector

		public void writeTxtOnForm(string sTextToWrite) {
			string[] lgRtbRead;
			string[] lgRtbWrite = new string[muiLengthOfNbOfLineOnShell];

			List<SerialDataToSave> listeOfDataToSave;

			RichTextBox rtbBoxToExport = new RichTextBox();
			SaveFileDialog saveFile = new SaveFileDialog();
			DateTime ExportDate = DateTime.Now;

			saveFile.DefaultExt = "*.csv";


			FileInfo infoOnFile;

			if(this.rtbSerialPort.InvokeRequired && (sTextToWrite != null)) {
				SetTextCallback d = new SetTextCallback(writeTxtOnForm);
				this.Invoke(d, new object[] { sTextToWrite });
			} else {

				try {


					if(File.Exists(this.mlistOfNameForDataFile[this.mlistOfNameForDataFile.Count - 1])) {
						infoOnFile = new FileInfo(this.mlistOfNameForDataFile[this.mlistOfNameForDataFile.Count - 1]);
						if(infoOnFile.Length > 10485760) { //10Mo
							this.mlistOfNameForDataFile.Add(Path.GetTempPath() + @"SADCom\dataFile_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bin");
						}
					}

					if(File.Exists(this.mlistOfNameForDataModifFile[this.mlistOfNameForDataModifFile.Count - 1])) {
						infoOnFile = new FileInfo(this.mlistOfNameForDataModifFile[this.mlistOfNameForDataModifFile.Count - 1]);
						if(infoOnFile.Length > 10485760) { //10Mo
							this.mlistOfNameForDataModifFile.Add(Path.GetTempPath() + @"SADCom\dataModifFile_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bin");
						}
					}

					if(File.Exists(this.mlistOfNameForTimeFile[this.mlistOfNameForTimeFile.Count - 1])) {
						infoOnFile = new FileInfo(this.mlistOfNameForTimeFile[this.mlistOfNameForTimeFile.Count - 1]);
						if(infoOnFile.Length > 10485760) { //10Mo
							this.mlistOfNameForTimeFile.Add(Path.GetTempPath() + @"SADCom\timeFile_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bin");
						}
					}

					File.AppendAllText(this.mlistOfNameForDataFile[this.mlistOfNameForDataFile.Count - 1], sTextToWrite);
					File.AppendAllText(this.mlistOfNameForDataModifFile[this.mlistOfNameForDataModifFile.Count - 1], sTextToWrite);
					File.AppendAllText(this.mlistOfNameForTimeFile[this.mlistOfNameForTimeFile.Count - 1], DateTime.Now.ToString("HH:mm:ss.fffffff\n"));

					if(this.enableAutoSave.Enabled) {

						if(rtbSaveFile.TextLength < 4096) {
							rtbSaveFile.AppendText(sTextToWrite);
						} else {
							if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Backup")) {
								Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Backup");
							}
							saveFile.FileName = System.IO.Directory.GetCurrentDirectory() + "\\Backup" + "\\Export_" + ExportDate.ToString("yyyyMMdd_HHmmss") + ".csv";
							

							rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
							rtbBoxToExport.AppendText("Configuration du port : \n");
							rtbBoxToExport.AppendText("Nom : ;" + this.mSerialPort.PortName + ";\n");
							rtbBoxToExport.AppendText("Vitesse : ;" + this.mSerialPort.BaudRate + ";\n");
							rtbBoxToExport.AppendText("Bite de parité : ;" + this.mSerialPort.Parity + ";\n");
							rtbBoxToExport.AppendText("Nombre de bits : ;" + this.mSerialPort.DataBits + ";\n");
							rtbBoxToExport.AppendText("Bit de stop : ;" + this.mSerialPort.StopBits + ";\n");
							rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");

							rtbBoxToExport.Text += rtbSaveFile.Text;
							rtbBoxToExport.SaveFile(saveFile.FileName, RichTextBoxStreamType.UnicodePlainText);

							rtbSaveFile.Clear();
						}

					}


					this.rtbSerialPort.Text += sTextToWrite;
					lgRtbRead = this.rtbSerialPort.Lines;
					if(lgRtbRead.Length > muiLengthOfNbOfLineOnShell) {

						Array.Copy(lgRtbRead, lgRtbRead.Length - muiLengthOfNbOfLineOnShell, lgRtbWrite, 0, muiLengthOfNbOfLineOnShell);
						this.rtbSerialPort.Lines = lgRtbWrite;
					}

					this.rtbSerialPort.SelectionStart = rtbSerialPort.Text.Length;
					// scroll it automatically
					this.rtbSerialPort.ScrollToCaret();
					//this.rtbSerialPort.AutoScrollOffset = new Point(this.rtbSerialPort.AutoScrollOffset.Y, this.rtbSerialPort.AutoScrollOffset.X);
					//this.rtbSerialPort.ScrollToCaret();
				} catch(Exception e) {
					MessageBox.Show("Erreur lors la reception de données : " + e.ToString(), "Read sata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void pbSendDimpleMessage_Click(object sender, EventArgs e) {
			if(this.mSerialPort != null) {
				try {
					if(this.mSerialPort.IsOpen) {
						this.mSerialPort.Write(this.tbSendSimpleMessage.Text + '\n');
						this.rtbSerialPort.Text += this.tbSendSimpleMessage.Text + '\n'; //a le faire d'une autre couleur
					} else {
						MessageBox.Show("Le port de communication est inaccessible.", "Port déconnecté", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				} catch(Exception eSerialPortException) {
					MessageBox.Show("Erreur lors de l'émission de données sur le port : " + eSerialPortException.ToString(), "Start connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private bool bEnebleTimeData = false;
		private void pbEnableTime_Click(object sender, EventArgs e) {
			if(bEnebleTimeData) {
				//this.pbEnableTime.
			} else {

			}
			bEnebleTimeData = !bEnebleTimeData;
			this.updateShell();
		}

		private void updateShell() {
			List<SerialDataToSave> listForUpdate = new List<SerialDataToSave>();

			this.mMutexData.WaitOne();
			listForUpdate.AddRange(this.mlistOfData);
			this.mMutexData.ReleaseMutex();

			this.mMutexAffichage.WaitOne();
			this.rtbSerialPort.Clear();
			foreach(SerialDataToSave data in listForUpdate) {
				if(bEnebleTimeData) {
					this.rtbSerialPort.Text += data.sDateOfData + "\t";
				}
				this.rtbSerialPort.Text += data.data;
				if(!data.data.Contains("\n")) {
					this.rtbSerialPort.Text += "\n";
				}
			}
			this.mMutexAffichage.ReleaseMutex();
		}

		private void rtbSerialPort_SizeChanged(object sender, EventArgs e) {
			//Size sizeTest = TextRenderer.MeasureText("Hello world\nteste", this.rtbSerialPort.Font);
			//int iLength = (int)(this.rtbSerialPort.Size.Height / sizeTest.Height);

			//this.rtbSerialPort.Size = new Size(this.rtbSerialPort.Size.Width, (int) (iLength * sizeTest.Height));
		}

		//genère garbage collector
		//ne fonctionne pas, pert les données. Le mieux, c'est la création d'un processus dedier qui irra sauvegarder
		//10000 de ligne d'un coup sans gener l'afficheur
		private void saveShell() {
			//List<SerialDataToSave> listeOfDataToSave;

			//RichTextBox rtbBoxToExport = new RichTextBox();
			//SaveFileDialog saveFile = new SaveFileDialog();
			//DateTime ExportDate = DateTime.Now;

			//saveFile.DefaultExt = "*.csv";
			//saveFile.FileName = "Export_" + ExportDate.ToString("yyyyMMdd_HHmmss") + ".csv";

			//if(this.mlistOfData.Count > 250) {
			//	try {

			//		this.mMutexData.WaitOne();
			//		listeOfDataToSave = this.mlistOfData.GetRange(0, 249);
			//		this.mMutexData.ReleaseMutex();

			//		using(Stream stream = File.Open(saveShellData, FileMode.Append, FileAccess.Write)) {
			//			var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

			//			bformatter.Serialize(stream, listeOfDataToSave);
			//		}


			//		if(this.enableAutoSave.Enabled) {
			//			if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Backup")) {
			//				Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Backup");
			//			}
			//			saveFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Backup";


			//			rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
			//			rtbBoxToExport.AppendText("Configuration du port : \n");
			//			rtbBoxToExport.AppendText("Nom : ;" + this.mSerialPort.PortName + ";\n");
			//			rtbBoxToExport.AppendText("Vitesse : ;" + this.mSerialPort.BaudRate + ";\n");
			//			rtbBoxToExport.AppendText("Bite de parité : ;" + this.mSerialPort.Parity + ";\n");
			//			rtbBoxToExport.AppendText("Nombre de bits : ;" + this.mSerialPort.DataBits + ";\n");
			//			rtbBoxToExport.AppendText("Bit de stop : ;" + this.mSerialPort.StopBits + ";\n");
			//			rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");
			//			foreach(SerialDataToSave data in listeOfDataToSave) {
			//				rtbBoxToExport.Text += data.sDateOfData + ";" + data.data;
			//				if(!data.data.Contains("\n")) {
			//					rtbBoxToExport.Text += "\n";
			//				}
			//			}
			//			rtbBoxToExport.SaveFile(saveFile.FileName, RichTextBoxStreamType.UnicodePlainText);

			//		}

			//		this.mMutexData.WaitOne();
			//		this.mlistOfData.RemoveRange(0, 249);
			//		this.mMutexData.ReleaseMutex();

			//		listeOfDataToSave.Clear();
			//		listeOfDataToSave = null;

			//		this.updateShell();
			//	} catch(Exception exception) {
			//		MessageBox.Show("Erreur détéctée lors la sauvegarde des données de configuration : \n" + exception.ToString(), "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			//	}
			//}
		}

		//TODO a affiner
		private void exporterToolStripMenuItem_Click(object sender, EventArgs e) {
			RichTextBox rtbBoxToExport = new RichTextBox();
			List<SerialDataToSave> listeOfDataToSave = new List<SerialDataToSave>();

			SaveFileDialog saveFile = new SaveFileDialog();
			DateTime ExportDate = DateTime.Now;

			saveFile.DefaultExt = "*.csv";
			saveFile.FileName = "Export_" + ExportDate.ToString("yyyyMMdd_HHmmss") + ".csv";

			try {

				if(File.Exists(saveShellData)) {

					using(Stream stream = File.Open(saveShellData, FileMode.Open)) {
						var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

						listeOfDataToSave = (List<SerialDataToSave>)bformatter.Deserialize(stream);
					}

				}
			} catch {
				MessageBox.Show("Erreur critique à l'initialisation", "Configuration", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}

			this.mMutexData.WaitOne();
			listeOfDataToSave.AddRange(this.mlistOfData);
			this.mMutexData.ReleaseMutex();



			try {
				saveFile.Filter = "CSV (séparateur: point-virgule)|*.csv|RTF Files|*.rtf|TEXT Texte|*.txt";
				saveFile.Title = "Save file";
				if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Backup")) {
					Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Backup");
				}
				saveFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Backup";

				if(saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
				   saveFile.FileName.Length > 0) {

					// Save the contents of the RichTextBox into the file.
					if(saveFile.FileName.EndsWith(".csv")) {
						rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
						rtbBoxToExport.AppendText("Configuration du port : \n");
						rtbBoxToExport.AppendText("Nom : ;" + this.mSerialPort.PortName + ";\n");
						rtbBoxToExport.AppendText("Vitesse : ;" + this.mSerialPort.BaudRate + ";\n");
						rtbBoxToExport.AppendText("Bite de parité : ;" + this.mSerialPort.Parity + ";\n");
						rtbBoxToExport.AppendText("Nombre de bits : ;" + this.mSerialPort.DataBits + ";\n");
						rtbBoxToExport.AppendText("Bit de stop : ;" + this.mSerialPort.StopBits + ";\n");
						rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");
						foreach(SerialDataToSave data in listeOfDataToSave) {
							rtbBoxToExport.Text += data.sDateOfData + ";" + data.data;
							if(!data.data.Contains("\n")) {
								rtbBoxToExport.Text += "\n";
							}
						}
						rtbBoxToExport.SaveFile(saveFile.FileName, RichTextBoxStreamType.UnicodePlainText);
					} else {
						rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
						rtbBoxToExport.AppendText("Configuration du port : \n");
						rtbBoxToExport.AppendText("\t- Nom : " + this.mSerialPort.PortName + " \n");
						rtbBoxToExport.AppendText("\t- Vitesse : " + this.mSerialPort.BaudRate + " \n");
						rtbBoxToExport.AppendText("\t- Bite de parité : " + this.mSerialPort.Parity + " \n");
						rtbBoxToExport.AppendText("\t- Nombre de bits : " + this.mSerialPort.DataBits + " \n");
						rtbBoxToExport.AppendText("\t- Bit de stop : " + this.mSerialPort.StopBits + " \n");
						rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");
						foreach(SerialDataToSave data in listeOfDataToSave) {
							rtbBoxToExport.Text += data.sDateOfData + "\t" + data.data;
							if(!data.data.Contains("\n")) {
								rtbBoxToExport.Text += "\n";
							}
						}
						rtbBoxToExport.SaveFile(saveFile.FileName);
					}

				}
			} catch(Exception saveException) {
				MessageBox.Show("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString(), "Sauvegarde des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw new Exception("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString());
			}


		}

		private void SerialPortShell_FormClosing(object sender, FormClosingEventArgs e) {
			foreach(string sTemporarFile in this.mlistOfNameForDataFile) {
				if(File.Exists(sTemporarFile)) {
					try {
						File.Delete(sTemporarFile);
					} catch(Exception exception) {
						MessageBox.Show("Le ficher temporaire \"" + sTemporarFile + "\" ne peut être détruit.", "Netoyage des données temporaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			foreach(string sTemporarFile in this.mlistOfNameForDataModifFile) {
				if(File.Exists(sTemporarFile)) {
					try {
						File.Delete(sTemporarFile);
					} catch(Exception exception) {
						MessageBox.Show("Le ficher temporaire \"" + sTemporarFile + "\" ne peut être détruit.", "Netoyage des données temporaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			foreach(string sTemporarFile in this.mlistOfNameForTimeFile) {
				if(File.Exists(sTemporarFile)) {
					try {
						File.Delete(sTemporarFile);
					} catch(Exception exception) {
						MessageBox.Show("Le ficher temporaire \"" + sTemporarFile + "\" ne peut être détruit.", "Netoyage des données temporaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void enableAutoSave_Click(object sender, EventArgs e) {
			this.enableAutoSave.Checked = !this.enableAutoSave.Checked;
		}
	}
}
