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
	public partial class AnalyserDescriptionUserControl : UserControl {

		private AnalyserKeyWord mAnalyserKeyWord = new AnalyserKeyWord();
		public AnalyserKeyWord AnalyserKeyWord {
			get {
				return this.mAnalyserKeyWord;
			}
			set {
				this.mAnalyserKeyWord = value;
			}
		}

		public AnalyserDescriptionUserControl() {
			InitializeComponent();

			this.rtbResult.BackColor = Properties.TerminalConfiguration.Default.terminalBackground;
			this.rtbResult.ForeColor = this.mAnalyserKeyWord.KeyWordColor;
			this.rtbResult.Font = this.mAnalyserKeyWord.KeyWordFont;
			
		}

		private void pbFontText_Click(object sender, EventArgs e) {
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowColor = true;

			fontDialog.Font = this.mAnalyserKeyWord.KeyWordFont;
			fontDialog.Color = this.mAnalyserKeyWord.KeyWordColor;

			if(fontDialog.ShowDialog() != DialogResult.Cancel) {
				Properties.TerminalConfiguration.Default.terminalFont = fontDialog.Font;
				Properties.TerminalConfiguration.Default.terminalForeColor = fontDialog.Color;


				this.mAnalyserKeyWord.KeyWordFont = Properties.TerminalConfiguration.Default.terminalFont;
				this.mAnalyserKeyWord.KeyWordColor = Properties.TerminalConfiguration.Default.terminalForeColor;

				this.rtbResult.Font = this.mAnalyserKeyWord.KeyWordFont;
				this.rtbResult.ForeColor = this.mAnalyserKeyWord.KeyWordColor;
			}
		}


		private void tbKeyWord_TextChanged(object sender, EventArgs e) {
			if(this.tbSubstitutionWords.Text.Length == 0) {
				this.rtbResult.Text = this.tbKeyWord.Text;
			}
		}

		private void tbSubstitutionWords_TextChanged(object sender, EventArgs e) {
			this.rtbResult.Text = this.tbSubstitutionWords.Text;
		}
	}
}
