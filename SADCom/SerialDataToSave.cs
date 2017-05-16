using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {
	class SerialDataToSave {
		private string msData = "";
		private DateTime mDateOfData;

		public string data {
			get {
				return this.msData;
			}
		}

		public string sDateOfData {
			get {
				return this.mDateOfData.ToString("hh:mm:ss.fffffff");
			}
		}

		public DateTime dateOfData {
			get {
				return this.mDateOfData;
			}
		}

		public SerialDataToSave(string data) {
			this.msData = data;
			this.mDateOfData = DateTime.Now;
		}

		public override string ToString() {
			string sDataReturn = this.data;
			sDataReturn += this.mDateOfData.ToString(";hh:mm:ss.fffffff;\n");
			return sDataReturn;
		}

	}
}
