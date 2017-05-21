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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom {
	public partial class SerialPortShell : Form {
		private SerialPort mSerialPort;

		private string saveShellData;

		private Timer mTimerForUpdateStatus;
		delegate void SetTextCallback(string text);

		private List<SerialDataToSave> mlistOfData;
		

		public SerialPortShell(SerialPort serialPort ) {
			string saveDirectory;
			string sNameOfSaveFile = "saveShellData_" + serialPort.PortName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + "_.bin" ;

			InitializeComponent();

			mTimerForUpdateStatus = new Timer();
			mTimerForUpdateStatus.Tick += MTimerForUpdateStatus_Tick;
			mTimerForUpdateStatus.Interval = 1000;
			mTimerForUpdateStatus.Start();

			mlistOfData = new List<SerialDataToSave>();

			saveDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			this.saveShellData = Path.Combine(saveDirectory, sNameOfSaveFile);


			this.mSerialPort = serialPort;
			this.mSerialPort.ReadTimeout = 200;
			this.mSerialPort.WriteTimeout = 200;

			this.lStatus.ForeColor = Color.Green;
			this.lStatus.Text = this.mSerialPort.PortName + " [connected]";

			//this.pbLevelBuffer.Maximum = this.rtbSerialPort.MaxLength;
		
			this.pbLevelBuffer.Maximum = 500;

			this.mSerialPort.DataReceived += MSerialPort_DataReceived;
			this.mSerialPort.Disposed += MSerialPort_Disposed;
			this.mSerialPort.ErrorReceived += MSerialPort_ErrorReceived;
			this.mSerialPort.PinChanged += MSerialPort_PinChanged;


			this.mSerialPort.Open();
		}

		private void MTimerForUpdateStatus_Tick(object sender, EventArgs e) {
			//this.pbLevelBuffer.Value = this.rtbSerialPort.TextLength;

			if(mlistOfData.Count < 500) {
				this.pbLevelBuffer.Value = mlistOfData.Count;
			}
			if(this.mSerialPort.IsOpen){
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
		//génère garbage collector
		public void writeTxtOnForm(string sTextToWrite) {
			SerialDataToSave data;
			if(this.rtbSerialPort.InvokeRequired) {
				SetTextCallback d = new SetTextCallback(writeTxtOnForm);
				this.Invoke(d, new object[] { sTextToWrite });
			} else {
				data = new SerialDataToSave(sTextToWrite);
				this.mlistOfData.Add(data);
				if(bEnebleTimeData) {
					this.rtbSerialPort.Text += data.sDateOfData + "\t";
				}
				this.rtbSerialPort.Text +=  data.data;
				if(!data.data.Contains("\n")) {
					this.rtbSerialPort.Text += "\n";
				}

				if(this.mlistOfData.Count > 450) {
					this.saveShell();
				}
				//this.rtbSerialPort.Text += sTextToWrite;


				this.rtbSerialPort.SelectionStart = rtbSerialPort.Text.Length;
				// scroll it automatically
				this.rtbSerialPort.ScrollToCaret();
				//this.rtbSerialPort.AutoScrollOffset = new Point(this.rtbSerialPort.AutoScrollOffset.Y, this.rtbSerialPort.AutoScrollOffset.X);
				//this.rtbSerialPort.ScrollToCaret();
			
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
			this.rtbSerialPort.Clear();

			foreach(SerialDataToSave data in this.mlistOfData) {
				if(bEnebleTimeData) {
					this.rtbSerialPort.Text += data.sDateOfData + "\t";
				}
				this.rtbSerialPort.Text += data.data;
				if(!data.data.Contains("\n")) {
					this.rtbSerialPort.Text += "\n";
				}
			}
		}

		private void rtbSerialPort_SizeChanged(object sender, EventArgs e) {
			//Size sizeTest = TextRenderer.MeasureText("Hello world\nteste", this.rtbSerialPort.Font);
			//int iLength = (int)(this.rtbSerialPort.Size.Height / sizeTest.Height);
			
			//this.rtbSerialPort.Size = new Size(this.rtbSerialPort.Size.Width, (int) (iLength * sizeTest.Height));
		}

		//genère garbage collector
		private void saveShell(){
			List<SerialDataToSave> listeOfDataToSave;

			//if(this.mlistOfData.Count > 100) {
			//	try {

			//		listeOfDataToSave = this.mlistOfData.GetRange(0, 100);

			//		using(Stream stream = File.Open(saveShellData, FileMode.OpenOrCreate)) {
			//			var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

			//			bformatter.Serialize(stream, listeOfDataToSave);
			//		}

			//		this.mlistOfData.RemoveRange(0, 100);
			//		this.updateShell();
			//	} catch(Exception exception) {
			//		MessageBox.Show("Erreur détéctée lors la sauvegarde des données de configuration : \n" + exception.ToString(), "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			//	}
			//}			
		}

		//todo a affiner
		private void exporterToolStripMenuItem_Click(object sender, EventArgs e) {
			//RichTextBox rtbBoxToExport = new RichTextBox();
			//List<SerialDataToSave> listeOfDataToSave = new List<SerialDataToSave>();

			//SaveFileDialog saveFile = new SaveFileDialog();
			//DateTime ExportDate = DateTime.Now;

			//saveFile.DefaultExt = "*.csv";
			//saveFile.FileName = "Export_"  + ExportDate.ToString("yyyyMMdd_HHmmss") + ".csv";

			//try {

			//	if(File.Exists(saveShellData)) {

			//		using(Stream stream = File.Open(saveShellData, FileMode.Open)) {
			//			var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

			//			listeOfDataToSave = (List<SerialDataToSave>)bformatter.Deserialize(stream);
			//		}

			//	}
			//} catch {
			//	MessageBox.Show("Erreur critique à l'initialisation", "Configuration", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			//}
			
			//foreach(SerialDataToSave data in this.mlistOfData) {
			//	listeOfDataToSave.Add(data);
			//}

			

			//try {
			//	saveFile.Filter = "CSV (séparateur: point-virgule)|*.csv|RTF Files|*.rtf|TEXT Texte|*.txt";
			//	saveFile.Title = "Save file";
			//	if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Backup")) {
			//		Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Backup");
			//	}
			//	saveFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Backup";

			//	if(saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
			//	   saveFile.FileName.Length > 0) {

			//		// Save the contents of the RichTextBox into the file.
			//		if(saveFile.FileName.EndsWith(".csv")) {
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
			//		} else {
			//			rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
			//			rtbBoxToExport.AppendText("Configuration du port : \n");
			//			rtbBoxToExport.AppendText("\t- Nom : " + this.mSerialPort.PortName + " \n");
			//			rtbBoxToExport.AppendText("\t- Vitesse : " + this.mSerialPort.BaudRate + " \n");
			//			rtbBoxToExport.AppendText("\t- Bite de parité : " + this.mSerialPort.Parity + " \n");
			//			rtbBoxToExport.AppendText("\t- Nombre de bits : " + this.mSerialPort.DataBits + " \n");
			//			rtbBoxToExport.AppendText("\t- Bit de stop : " + this.mSerialPort.StopBits + " \n");
			//			rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");
			//			foreach(SerialDataToSave data in listeOfDataToSave) {
			//				rtbBoxToExport.Text += data.sDateOfData + "\t" + data.data;
			//				if(!data.data.Contains("\n")) {
			//					rtbBoxToExport.Text += "\n";
			//				}
			//			}
			//			rtbBoxToExport.SaveFile(saveFile.FileName);
			//		}

			//	}
			//} catch(Exception saveException) {
			//	MessageBox.Show("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString(), "Sauvegarde des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	//throw new Exception("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString());
			//}


		}
	}
}
