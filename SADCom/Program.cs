using System;
using System.Windows.Forms;

namespace SADCom {
	static class Program {
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			

			//SerialPortConfiguration configForm = new SerialPortConfiguration();
			SerialPortShell shellForm = new SerialPortShell();

			//if(!shellForm.IsDisposed) {
			//	Application.Run(shellForm);
			//}

			MainWindows mainWindows = new MainWindows();
			if(!mainWindows.IsDisposed) {
				Application.Run(mainWindows);
			}

			//if(configForm.serialPort != null) {
			//	Application.Run(new SerialPortShell(configForm.serialPort));
			//}

		}
	}
}
