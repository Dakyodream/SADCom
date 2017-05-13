using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {

	[Serializable]
	class SerialPortConfigSave {
		private Parity mParity;
		public Parity parity {
			get {
				return this.mParity;
			}
			set {
				this.mParity = value;
			}
		}

		private Handshake mFlowCode;
		public Handshake flowCode {
			get {
				return this.mFlowCode;
			}
			set {
				this.mFlowCode = value;
			}
		}

		private StopBits mStopBit;
		public StopBits stopBit {
			get {
				return this.mStopBit;
			}
			set {
				this.mStopBit = value;
			}
		}

		private int mDataBits;
		public int dataBits {
			get {
				return this.mDataBits;
			}
			set {
				this.mDataBits = value;
			}
		}

		private int mBaudRate;
		public int baudRate {
			get {
				return this.mBaudRate;
			}
			set {
				this.mBaudRate = value;
			}
		}

		private string mSerialPortConfigName;
		public string serialPortConfigName {
			get {
				return this.mSerialPortConfigName;
			}
			set {
				this.mSerialPortConfigName = value;
			}
		}

		public SerialPortConfigSave(string sName, int baudRate, int dataBits, 
			Parity parity, StopBits stopBits, Handshake flowCode) {
			this.mSerialPortConfigName = sName;
			this.mBaudRate = baudRate;
			this.mDataBits = dataBits;
			this.mParity = parity;
			this.mStopBit = stopBits;
			this.mFlowCode = flowCode;
		}

		public override string ToString() {
			return this.mSerialPortConfigName;
		}

		public override bool Equals(object obj) {
			if (obj.GetType() == typeof(SerialPortConfigSave)) {
				if (((SerialPortConfigSave)obj).serialPortConfigName == (this.serialPortConfigName)) {
					return true;
				}
			}
			return false;
		}
	}
}
