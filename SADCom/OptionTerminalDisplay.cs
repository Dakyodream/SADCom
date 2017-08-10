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


	public partial class OptionTerminalDisplay : UserControl {
		public OptionTerminalDisplay() {
			InitializeComponent();

			//this.ttInfo.Show("teste", this.pbFileAnalyser);
		}

		private void pbTeminaColor_Click(object sender, EventArgs e) {

			FontDialog fontDialog = new FontDialog();


			fontDialog.ShowColor = true;

			fontDialog.Font = rtbColorExample.Font;
			fontDialog.Color = rtbColorExample.ForeColor;

			if(fontDialog.ShowDialog() != DialogResult.Cancel) {
				this.rtbColorExample.Font = fontDialog.Font;
				this.rtbColorExample.ForeColor = fontDialog.Color;
			}
		}
	}
}
