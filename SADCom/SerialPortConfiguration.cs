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

namespace SADCom.Configuration {
	public partial class SerialPortConfiguration : Form {

		private List<SerialPortConfigSave> mListConfig;

		private SessionConfigurations mSessionConfigurations = new SessionConfigurations();

		private string saveDirectory;
		private string configFileSystem;

		private SerialPort mSerialPort = null;
		public SerialPort serialPort {
			get {
				return mSerialPort;
			}
		}

		/// <summary>
		/// For the vew disigner only. With it, parameter are not transfered to serial port shell. 
		/// </summary>
		public SerialPortConfiguration() : this(new SessionConfigurations()) { }
		
		/// <summary>
		/// True constructor. 
		/// </summary>
		/// <param name="sessionConfigurations">Object use for transfered the configutation and global parametter</param>
		public SerialPortConfiguration(SessionConfigurations sessionConfigurations) {
			this.mSessionConfigurations = sessionConfigurations;

			InitializeComponent();

			this.optionTerminalDisplay.SessionConfigurations = this.mSessionConfigurations;


			try {
				saveDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
				configFileSystem = Path.Combine(saveDirectory, "saveConfiguration.bin");
			} catch (PathTooLongException exceptionLength) {
				MessageBox.Show("L'emplacement du programme pose problème, l'adresse de l'emplacement est trop grande : \n" + exceptionLength.ToString(), "Configuration des port", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			} catch {
				MessageBox.Show("Erreur critique à l'initialisation", "Configuration", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}


			//set combo box parity
			this.cbParity.Items.Add(Parity.None);
			this.cbParity.Items.Add(Parity.Even);
			this.cbParity.Items.Add(Parity.Mark);
			this.cbParity.Items.Add(Parity.Odd);
			this.cbParity.Items.Add(Parity.Space);
			this.cbParity.SelectedIndex = 0;

			//set combo box Flox control
			this.cbFlowControl.Items.Add(Handshake.None);
			this.cbFlowControl.Items.Add(Handshake.RequestToSend);
			this.cbFlowControl.Items.Add(Handshake.RequestToSendXOnXOff);
			this.cbFlowControl.Items.Add(Handshake.XOnXOff);
			this.cbFlowControl.SelectedIndex = 0;

			//set combo box stop bit
			this.cbStopBits.Items.Add(StopBits.None);
			this.cbStopBits.Items.Add(StopBits.One);
			this.cbStopBits.Items.Add(StopBits.OnePointFive);
			this.cbStopBits.Items.Add(StopBits.Two);
			this.cbStopBits.SelectedIndex = 1;

			//set combo box databits
			this.cbDataBits.Items.Add(4);
			this.cbDataBits.Items.Add(5);
			this.cbDataBits.Items.Add(6);
			this.cbDataBits.Items.Add(7);
			this.cbDataBits.Items.Add(8);
			this.cbDataBits.SelectedIndex = 4;

			//set combo box baud rate
			this.cbBaudRate.Items.Add(75);
			this.cbBaudRate.Items.Add(110);
			this.cbBaudRate.Items.Add(134);
			this.cbBaudRate.Items.Add(150);
			this.cbBaudRate.Items.Add(300);
			this.cbBaudRate.Items.Add(600);
			this.cbBaudRate.Items.Add(1200);
			this.cbBaudRate.Items.Add(1800);
			this.cbBaudRate.Items.Add(2400);
			this.cbBaudRate.Items.Add(4800);
			this.cbBaudRate.Items.Add(7200);
			this.cbBaudRate.Items.Add(9600);
			this.cbBaudRate.Items.Add(14400);
			this.cbBaudRate.Items.Add(19200);
			this.cbBaudRate.Items.Add(38400);
			this.cbBaudRate.Items.Add(57600);
			this.cbBaudRate.Items.Add(115200);
			this.cbBaudRate.Items.Add(128000);
			this.cbBaudRate.SelectedIndex = 11;

			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(this.pbRefreshScan, "Rescan serial port");
			toolTip.SetToolTip(this.pbSaveConfig, "Save current configuration");
			toolTip.SetToolTip(this.pbDeletConfig, "Delet the curent selected configuration");

			//list
			mListConfig = new List<SerialPortConfigSave>();

			//deserialize
			try {
				if(File.Exists(configFileSystem)) {
					using(Stream stream = File.Open(configFileSystem, FileMode.Open)) {
						var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

						this.mListConfig = (List<SerialPortConfigSave>)bformatter.Deserialize(stream);
					}

					this.cbProfil.Items.Clear();
					this.cbProfil.Text = "";
					foreach(SerialPortConfigSave spData in this.mListConfig) {
						this.cbProfil.Items.Add(spData);
					}
				}
			} catch {
				MessageBox.Show("Erreur critique à l'initialisation2", "Configuration", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}

			this.optionTerminalDisplay.opacityEvent += OptionTerminalDisplay1_opacityEvent;
			this.optionTerminalDisplay.leaveOpacityConfigEvent += OptionTerminalDisplay1_leaveOpacityConfigEvent;

		}

		private void OptionTerminalDisplay1_leaveOpacityConfigEvent(object sender, EventArgs e) {
			this.Opacity = 1.0;
		}

		private void OptionTerminalDisplay1_opacityEvent(object sender, EventArgs e, int opacity) {
			this.Opacity = opacity/100.0;
		}

		private void pbRefreshScan_Click(object sender, EventArgs e) {
			this.getSerialPorts();
		}
		private void SerialPortConfiguration_Load(object sender, EventArgs e) {
			this.getSerialPorts();
			cbListOfPorts_SelectedIndexChanged(sender, e);
		}

		private void getSerialPorts() {
			this.pbStartConnexion.Enabled = true;
			string[] sTabPortsName = null;
			SerialPort serialPortTstConnexion = new SerialPort();
			SerialPortState spState = new SerialPortState();

			this.cbListOfPorts.Items.Clear();
			
			this.gbConfigConnexion.Enabled = false;
			this.pbStartConnexion.Enabled = false;

			try {
				sTabPortsName = SerialPort.GetPortNames();
			} catch (Exception exception) {
				MessageBox.Show("Erreur détéctée lors de l'analyse des ports : " + exception.ToString(), "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}



			if (sTabPortsName.Length > 0) {
				foreach (String sPortName in sTabPortsName) {

					spState = new SerialPortState(sPortName);
					try {
						serialPortTstConnexion = new SerialPort();
						serialPortTstConnexion.PortName = sPortName;
						serialPortTstConnexion.Open();
						serialPortTstConnexion.Close();
						serialPortTstConnexion.Dispose();
					} catch (UnauthorizedAccessException unauthorizedAccessException) {
						spState = new SerialPortState(sPortName, -1);
					} catch {
						spState = new SerialPortState(sPortName, -2);
					}

					try {
						//this.cbListOfPorts.Items.Add(spState.ToString());
						this.cbListOfPorts.Items.Add(spState);
					} catch (Exception exception) {
						MessageBox.Show("Erreur détécté lors de l'enregistrement des nouveaux ports : " + exception.ToString(), "Enregistrement des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
					}
				}

				this.cbListOfPorts.SelectedIndex = 0;



			} else {
				MessageBox.Show("Erreur lors de la détection des ports. Veuillez réitérer.", "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}

			this.gbConfigConnexion.Enabled = true;
		}

		private void cbListOfPorts_SelectedIndexChanged(object sender, EventArgs e) {
			object objectSelected = this.cbListOfPorts.SelectedItem;
			if (objectSelected.GetType() == typeof(SerialPortState)) {
				if(((SerialPortState)objectSelected).PortState == 0) {
					this.gbProfil.Enabled = true;
					this.gbConfigConnexion.Enabled = true;
					this.pbStartConnexion.Enabled = true;
				} else {
					this.gbProfil.Enabled = false;
					this.gbConfigConnexion.Enabled = false;
					this.pbStartConnexion.Enabled = false;
				}
			}
		}

		private void pbSaveConfig_Click(object sender, EventArgs e) {
			SerialPortConfigSave spConfig = new SerialPortConfigSave(this.cbProfil.Text,
				(int)this.cbBaudRate.SelectedItem, (int)this.cbDataBits.SelectedItem,
				(Parity)this.cbParity.SelectedItem, (StopBits)this.cbStopBits.SelectedItem,
				(Handshake)this.cbFlowControl.SelectedItem);

			if (this.cbProfil.Text.Length > 0) {
				if (this.mListConfig.Contains(spConfig)) {
					spConfig = this.mListConfig[this.mListConfig.IndexOf(spConfig)];
					
					spConfig.baudRate = (int)this.cbBaudRate.SelectedItem;
					spConfig.dataBits = (int)this.cbDataBits.SelectedItem;
					spConfig.parity = (Parity)this.cbParity.SelectedItem;
					spConfig.stopBit = (StopBits)this.cbStopBits.SelectedItem;
					spConfig.flowCode = (Handshake)this.cbFlowControl.SelectedItem;

				} else {
					this.mListConfig.Add(spConfig);
				}

				this.cbProfil.Items.Clear();
				foreach (SerialPortConfigSave spData in this.mListConfig) {
					this.cbProfil.Items.Add(spData);
				}
			}
		}

		private void bDeletConfig_Click(object sender, EventArgs e) {
			SerialPortConfigSave spConfig = new SerialPortConfigSave(this.cbProfil.Text,
				(int)this.cbBaudRate.SelectedItem, (int)this.cbDataBits.SelectedItem,
				(Parity)this.cbParity.SelectedItem, (StopBits)this.cbStopBits.SelectedItem,
				(Handshake)this.cbFlowControl.SelectedItem);

			if (this.cbProfil.Text.Length > 0) {
				if (this.mListConfig.Contains(spConfig)) {
					this.mListConfig.Remove(spConfig);
				} else {
					this.mListConfig.Add(spConfig);
				}

				this.cbProfil.Items.Clear();
				this.cbProfil.Text = "";
				foreach (SerialPortConfigSave spData in this.mListConfig) {
					this.cbProfil.Items.Add(spData);
				}
			}
		}

		private void cbProfil_SelectedIndexChanged(object sender, EventArgs e) {
			SerialPortConfigSave spConfig;
			if (this.cbProfil.SelectedItem.GetType() == typeof(SerialPortConfigSave)) {
				spConfig = (SerialPortConfigSave)this.cbProfil.SelectedItem;

				this.cbBaudRate.SelectedIndex = this.cbBaudRate.Items.IndexOf(spConfig.baudRate);
				this.cbParity.SelectedIndex = this.cbParity.Items.IndexOf(spConfig.parity);
				this.cbDataBits.SelectedIndex = this.cbDataBits.Items.IndexOf(spConfig.dataBits);
				this.cbStopBits.SelectedIndex = this.cbStopBits.Items.IndexOf(spConfig.stopBit);
				this.cbFlowControl.SelectedIndex = this.cbFlowControl.Items.IndexOf(spConfig.flowCode);

			}
		}

		private void SerialPortConfiguration_FormClosing(object sender, FormClosingEventArgs e) {
			//serialize
			try {
				using (Stream stream = File.Open(configFileSystem, FileMode.Create)) {
					var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

					bformatter.Serialize(stream, this.mListConfig);
				}
			} catch (Exception exception) {
				MessageBox.Show("Erreur détéctée lors la sauvegarde des données de configuration : \n" + exception.ToString(), "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
				
		}

		private void pbStartConnexion_Click(object sender, EventArgs e) {
			this.pbStartConnexion.Enabled = true;
			SerialPort serialPortConnexion = new SerialPort();
			this.mSerialPort = null;

			try {
				serialPortConnexion = new SerialPort();
				serialPortConnexion.PortName = ((SerialPortState)this.cbListOfPorts.SelectedItem).PortName;
				serialPortConnexion.BaudRate = ((int)this.cbBaudRate.SelectedItem);
				serialPortConnexion.Parity = ((Parity)this.cbParity.SelectedItem);
				serialPortConnexion.DataBits = ((int)this.cbDataBits.SelectedItem);
				serialPortConnexion.StopBits = ((StopBits)this.cbStopBits.SelectedItem);
				serialPortConnexion.Handshake = ((Handshake)this.cbFlowControl.SelectedItem);

				serialPortConnexion.Open();
				serialPortConnexion.Close();
				serialPortConnexion.Dispose();

				this.mSerialPort = serialPortConnexion;

				this.DialogResult = DialogResult.OK;
				this.Close();
			} catch(UnauthorizedAccessException unauthorizedAccessException) {
				MessageBox.Show("Connexion non authorisé, veuillez réitérer ultérieurement.", "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			} catch {
				MessageBox.Show("Erreur de connexion. Une modification des paramètre peuvent être nécéssaire.", "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pbOptionalConfiguration_Click(object sender, EventArgs e) {
			this.splitContainer1.Panel2Collapsed = !this.splitContainer1.Panel2Collapsed;

			if(this.splitContainer1.Panel2Collapsed) {
				this.pbOptionalConfiguration.BackColor = SystemColors.ControlLight;
			} else {
				this.pbOptionalConfiguration.BackColor = SystemColors.ControlDark;
			}
			
		}
	}
}
