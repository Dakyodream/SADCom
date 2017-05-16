using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom {
	public partial class SerialPortShell : Form {
		private SerialPort mSerialPort;

		private Timer mTimerForUpdateStatus;
		delegate void SetTextCallback(string text);

		private List<SerialDataToSave> mlistOfData;
		

		public SerialPortShell(SerialPort serialPort ) {
			InitializeComponent();

			mTimerForUpdateStatus = new Timer();
			mTimerForUpdateStatus.Tick += MTimerForUpdateStatus_Tick;
			mTimerForUpdateStatus.Interval = 1000;
			mTimerForUpdateStatus.Start();

			mlistOfData = new List<SerialDataToSave>();

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

		public void writeTxtOnForm(string sTextToWrite) {
			SerialDataToSave data;
			if(this.rtbSerialPort.InvokeRequired) {
				SetTextCallback d = new SetTextCallback(writeTxtOnForm);
				this.Invoke(d, new object[] { sTextToWrite });
			} else {
				data = new SerialDataToSave(sTextToWrite);
				mlistOfData.Add(data);
				if(bEnebleTimeData) {
					this.rtbSerialPort.Text += data.sDateOfData + "\t";
				}
				this.rtbSerialPort.Text +=  data.data;
				if(!data.data.Contains("\n")) {
					this.rtbSerialPort.Text += "\n";
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
	}
}
