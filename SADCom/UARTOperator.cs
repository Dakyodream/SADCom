using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {

	enum ConfigAutoSave {
		disabled, normal, critical
	};

	enum StateOfConnexion {
		unconnected, connected, pinChanged, receptionError, disposed
	};


	public class UARTOperationReceiveData : EventArgs {
		public string sData { get; set; }
		public DateTime receptionTime { get; set; }
	}

	class UARTOperator {
		private ConfigAutoSave mAutosave;
		private SerialPort mSerialPort;

		

		private StateOfConnexion mStateOfConnexion = StateOfConnexion.unconnected;
		public StateOfConnexion stateOfConnexion {
			get {
				return this.mStateOfConnexion;
			}
		}

		public EventHandler<UARTOperationReceiveData> UARTOperationReceiveDataHandler;

		private List<string> mListOfAutosaveFile;

		public UARTOperator(SerialPort serialPort) : this(serialPort, ConfigAutoSave.normal, 500) { }
		public UARTOperator(SerialPort serialPort, ConfigAutoSave autosave) : this(serialPort, autosave, 500) { }
		public UARTOperator(SerialPort serialPort, ConfigAutoSave autosave, int readWriteTimeout) {
			this.mAutosave = autosave;


			this.mListOfAutosaveFile = new List<string>();
			this.mListOfAutosaveFile.Add("saveShellData_" + serialPort.PortName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xml");

			if(serialPort == null) {
				throw new ArgumentException("serialPort incorrect.");
			}

			if(readWriteTimeout > 0) {
				throw new ArgumentException("readWriteTimeout invalid.");
			}

			this.mSerialPort = serialPort;

			try {
				this.mSerialPort.ReadTimeout = readWriteTimeout;
				this.mSerialPort.WriteTimeout = readWriteTimeout;
			} catch (Exception e){
				throw new ArgumentException("readWriteTimeout exception thrown.", e);
			}

			this.mSerialPort.DataReceived += MSerialPort_DataReceived;
			this.mSerialPort.Disposed += MSerialPort_Disposed;
			this.mSerialPort.ErrorReceived += MSerialPort_ErrorReceived;
			this.mSerialPort.PinChanged += MSerialPort_PinChanged;

			try {
				this.mSerialPort.Open();
				this.mStateOfConnexion = StateOfConnexion.connected;
			} catch(Exception e) {
				throw new Exception("L'ouverture du port à engendré une exception.", e);
			}
		}

		private void MSerialPort_PinChanged(object sender, SerialPinChangedEventArgs e) {
			if(this.mSerialPort != null) {
				if(this.mSerialPort.IsOpen) {
					try {
						this.mSerialPort.Close();
					} catch(IOException exception) {
						throw new Exception("Error to close serial port in MSerialPort_PinChanged.", exception);
					}
				}
				this.mStateOfConnexion = StateOfConnexion.pinChanged;
			} else {
				this.mStateOfConnexion = StateOfConnexion.unconnected;
			}
		}

		private void MSerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e) {
			this.mStateOfConnexion = StateOfConnexion.receptionError;
		}

		private void MSerialPort_Disposed(object sender, EventArgs e) {
			if(this.mSerialPort != null) {
				if(this.mSerialPort.IsOpen) {
					try {
						this.mSerialPort.Close();
					} catch(IOException exception) {
						throw new Exception("Error to close serial port in MSerialPort_Disposed.", exception);
					}
				}
				this.mStateOfConnexion = StateOfConnexion.pinChanged;
			} else {
				this.mStateOfConnexion = StateOfConnexion.unconnected;
			}
			throw new NotImplementedException();
		}

		private void MSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
			UARTOperationReceiveData dataSend = new UARTOperationReceiveData();
			EventHandler<UARTOperationReceiveData> handler = UARTOperationReceiveDataHandler;
			if(handler != null) {
				try {
					dataSend.sData = this.mSerialPort.ReadExisting();

					dataSend.receptionTime = DateTime.Now;
					handler(this, dataSend);
				}catch (InvalidOperationException invalidException) {
					throw new Exception("Erreur de lecture des données.", invalidException);
				}
			}
			throw new NotImplementedException();
		}


		public void SendData(string data) {
			if(this.mSerialPort != null) {
				try {
					if(this.mSerialPort.IsOpen) {
						this.mSerialPort.Write(data);
						
					} else {
						throw new InvalidOperationException("The current port isn't openned.");
					}
				} catch(Exception eSerialPortException) {
					throw new Exception("SendData has thrown an exception.", eSerialPortException);
				}
			}
		}


		

	}
}
