using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom {
	public partial class MainWindows : Form {
		public MainWindows() {
			InitializeComponent();
		}

		private void testeToolStripMenuItem_Click(object sender, EventArgs e) {
			this.shellBoardUC1.newData("teste");
		}
	}
}
