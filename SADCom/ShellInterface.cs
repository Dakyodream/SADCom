using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {
	interface ShellInterface {

		void showTime();
		void hideTime();

		void showLogInformation();
		void hideLogInformation();

		void setDefaultFont(Font fData);
		void setDefaultColor(Color cData);

		void newData(string sData);
		void newData(DateTime time, string sData);
		void newData(DateTime time, string sData, string sDataLog);
		void newData(DateTime time, string sData, string sDataLog, Font fDataLog, Color cDataLog);


	}
}
