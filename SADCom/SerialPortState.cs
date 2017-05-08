using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {
	class SerialPortState {
		private string sNameOfPort = "";
		private int iStateOfPort;

		public string PortName {
			get {
				return this.sNameOfPort;
			}
			set {
				this.sNameOfPort = value;
			}
		}

		public int PortState {
			get {
				return this.iStateOfPort;
			}
			set {
				this.iStateOfPort = value;
			}
		}

		public SerialPortState() : this("", 0) { }
		public SerialPortState(string sName) : this(sName, 0) { }
		public SerialPortState(string sName, int iValue) {
			sNameOfPort = sName;
			iStateOfPort = iValue;
		}

		public override string ToString() {
			string sReturn = this.PortName;
			if (iStateOfPort == -1) {
				sReturn += " [already connected]";
			} else if (iStateOfPort < -1) {
				sReturn += " [can't connect]";
			}
			return sReturn;
		}

	}
}
