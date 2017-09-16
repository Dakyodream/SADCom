using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom {
	public partial class SimpleShell : UserControl, ShellInterface {
		public SimpleShell() {
			InitializeComponent();
		}

		public void hideLogInformation() {
			throw new NotImplementedException();
		}

		public void hideTime() {
			throw new NotImplementedException();
		}

		public void newData(string sData) {
			throw new NotImplementedException();
		}

		public void newData(DateTime time, string sData) {
			throw new NotImplementedException();
		}

		public void newData(DateTime time, string sData, string sDataLog) {
			throw new NotImplementedException();
		}

		public void newData(DateTime time, string sData, string sDataLog, Font fDataLog, Color cDataLog) {
			throw new NotImplementedException();
		}

		public void setDefaultColor(Color cData) {
			throw new NotImplementedException();
		}

		public void setDefaultFont(Font fData) {
			throw new NotImplementedException();
		}

		public void showLogInformation() {
			throw new NotImplementedException();
		}

		public void showTime() {
			throw new NotImplementedException();
		}
	}
}
