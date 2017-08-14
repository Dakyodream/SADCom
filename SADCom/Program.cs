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

			if(!shellForm.IsDisposed) {
				Application.Run(shellForm);
			}
			

			//if(configForm.serialPort != null) {
			//	Application.Run(new SerialPortShell(configForm.serialPort));
			//}

		}
	}
}
