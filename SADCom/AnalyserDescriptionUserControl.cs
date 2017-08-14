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
	
	public delegate void AnalyserDescriptionDeletedEventHandler(object sender, EventArgs e);
	public delegate void NewDescriptionEventHandler(object sender, EventArgs e);

	public partial class AnalyserDescriptionUserControl : UserControl {

		public event NewDescriptionEventHandler NewDescriptionEvent;
		public event AnalyserDescriptionDeletedEventHandler AnalyserDescriptionDeletedEvent;

		private SessionConfigurations sessionConfigurations;

		private bool bDescriptionNeverFill = true;

		private AnalyserKeyWord mAnalyserKeyWord = new AnalyserKeyWord();
		public AnalyserKeyWord AnalyserKeyWord {
			get {
				return this.mAnalyserKeyWord;
			}
			set {
				this.mAnalyserKeyWord = value;

				//this.rtbResult.BackColor = Resources.TerminalConfiguration.Default.terminalBackground;
				this.rtbResult.ForeColor = this.mAnalyserKeyWord.KeyWordColor;
				this.rtbResult.Font = this.mAnalyserKeyWord.KeyWordFont;
				this.tbKeyWord.Text = this.mAnalyserKeyWord.KeyWord;
				this.tbSubstitutionWords.Text = this.mAnalyserKeyWord.SubstitutionWords;
				this.cbOutputOnLogShell.Checked = this.mAnalyserKeyWord.NotifiedLogTerminal;

				this.tbSubstitutionWords.Enabled = true;
				this.pbFontText.Enabled = true;
				this.pbDelete.Enabled = true;
				this.cbOutputOnLogShell.Enabled = true;
			}
		}


		public AnalyserDescriptionUserControl() : this(new SessionConfigurations()) { }
		public AnalyserDescriptionUserControl(SessionConfigurations sessionConfigurations) {
			InitializeComponent();

			this.sessionConfigurations = sessionConfigurations;

			this.rtbResult.BackColor = Resources.TerminalConfiguration.Default.terminalBackground;
			this.rtbResult.ForeColor = this.mAnalyserKeyWord.KeyWordColor;
			this.rtbResult.Font = this.mAnalyserKeyWord.KeyWordFont;

			this.tbSubstitutionWords.Enabled = false;
			this.pbFontText.Enabled = false;
			this.pbDelete.Enabled = false;
			this.cbOutputOnLogShell.Enabled = false;

			bDescriptionNeverFill = true;
		}

		private void pbFontText_Click(object sender, EventArgs e) {
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowColor = true;

			fontDialog.Font = this.mAnalyserKeyWord.KeyWordFont;
			fontDialog.Color = this.mAnalyserKeyWord.KeyWordColor;

			if(fontDialog.ShowDialog() != DialogResult.Cancel) {
				Resources.TerminalConfiguration.Default.terminalFont = fontDialog.Font;
				Resources.TerminalConfiguration.Default.terminalForeColor = fontDialog.Color;


				this.mAnalyserKeyWord.KeyWordFont = Resources.TerminalConfiguration.Default.terminalFont;
				this.mAnalyserKeyWord.KeyWordColor = Resources.TerminalConfiguration.Default.terminalForeColor;

				this.rtbResult.Font = this.mAnalyserKeyWord.KeyWordFont;
				this.rtbResult.ForeColor = this.mAnalyserKeyWord.KeyWordColor;
			}
		}


		private void tbKeyWord_TextChanged(object sender, EventArgs e) {
			if(bDescriptionNeverFill == true) {
				bDescriptionNeverFill = false;
				NewDescriptionEvent?.Invoke(this, null);
				this.tbSubstitutionWords.Enabled = true;
				this.pbFontText.Enabled = true;
				this.pbDelete.Enabled = true;
				this.cbOutputOnLogShell.Enabled = true;

			}

			if(this.tbSubstitutionWords.Text.Length == 0) {
				this.rtbResult.Text = this.tbKeyWord.Text;
			}
			this.AnalyserKeyWord.KeyWord = this.tbKeyWord.Text;
		}

		private void tbSubstitutionWords_TextChanged(object sender, EventArgs e) {
			this.rtbResult.Text = this.tbSubstitutionWords.Text;
			this.AnalyserKeyWord.SubstitutionWords = this.tbSubstitutionWords.Text;

		}

		private void bDelete_Click(object sender, EventArgs e) {
			this.AnalyserDescriptionDeletedEvent?.Invoke(this, null);
		}

		private void cbOutputOnLogShell_CheckedChanged(object sender, EventArgs e) {
			this.AnalyserKeyWord.NotifiedLogTerminal = this.cbOutputOnLogShell.Checked;
		}
	}
}
