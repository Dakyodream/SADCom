using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom.Configuration {
	
	/// <summary>
	/// Event use by <see cref="AnalyserDescriptionUserControl"/> when a new analyser description is available.
	/// </summary>
	/// <param name="sender">The object sending the event.</param>
	/// <param name="e">not use (null)</param>
	public delegate void AnalyserDescriptionDeletedEventHandler(object sender, EventArgs e);
	/// <summary>
	/// Event call to indicate to the form to create a new object because it's still now.
	/// </summary>
	/// <param name="sender">the object sending the event</param>
	/// <param name="e">not use (null)</param>
	public delegate void NewDescriptionEventHandler(object sender, EventArgs e);

	/// <summary>
	/// This class represent an analyser description.
	/// </summary>
	public partial class AnalyserDescriptionUserControl : UserControl {

		/// <summary>
		/// Event send when an new description is available.
		/// See <see cref="NewDescriptionEventHandler"/>.
		/// </summary>
		public event NewDescriptionEventHandler NewDescriptionEvent;
		/// <summary>
		/// Send when the user want to delet this description.
		/// See <see cref="AnalyserDescriptionDeletedEventHandler"/>.
		/// </summary>
		public event AnalyserDescriptionDeletedEventHandler AnalyserDescriptionDeletedEvent;

		/// <summary>
		/// Contain the configuration of this session.
		/// </summary>
		private SessionConfigurations mSessionConfigurations;

		/// <summary>
		/// Use for detecte the first fill of this analyser description (which will send the event <see cref="NewDescriptionEvent"/>).
		/// </summary>
		private bool bDescriptionNeverFill = true;

		/// <summary>
		/// Contain information for the analyser data.
		/// </summary>
		private AnalyserKeyWord mAnalyserKeyWord = new AnalyserKeyWord();
		/// <summary>
		/// Output of this class. See <see cref="mAnalyserKeyWord"/>.
		/// </summary>
		public AnalyserKeyWord AnalyserKeyWord {
			get {
				return this.mAnalyserKeyWord;
			}
			set {
				this.mAnalyserKeyWord = value;

				if(this.mAnalyserKeyWord == null) {
					this.mAnalyserKeyWord = new AnalyserKeyWord();
				}

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


		/// <summary>
		/// Constructor use if <see cref="sessionConfigurations"/> isn't empty (need to know the application configuration for this session).
		/// </summary>
		/// <param name="sessionConfigurations">Session configuration.</param>
		//public AnalyserDescriptionUserControl(SessionConfigurations sessionConfigurations) {

		/// <summary>
		/// Constructor void for the disigner viewer or a new AnalyserDescriptionUserControl object.
		/// </summary>
		public AnalyserDescriptionUserControl() { 
			InitializeComponent();

			// Create the ToolTip and associate with the Form container.
			ToolTip toolTip = new ToolTip();

			// Set up the delays for the ToolTip.
			toolTip.AutoPopDelay = 5000;
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			toolTip.ShowAlways = true;

			// Set up the ToolTip text for the Button and Checkbox.
			toolTip.SetToolTip(this.cbOutputOnLogShell, "Affiché le text de remplacement dans un terminal dédié au \"log\".");
			toolTip.SetToolTip(this.tbKeyWord, "Mot clé.");
			toolTip.SetToolTip(this.tbSubstitutionWords, "Texte venant se substituer au mot clé. Si vide, le mots clé est recopier.");
			toolTip.SetToolTip(this.pbFontText, "Modifie la police de caractère en sortie de l'analyseur.");
			toolTip.SetToolTip(this.rtbResult, "Rendu final sur le terminal des données ou le terminal \"log\".");
			toolTip.SetToolTip(this.pbDelete, "Supprimer cette règle.");

			///this.mSessionConfigurations = sessionConfigurations;
			this.mSessionConfigurations = new SessionConfigurations(); ;


			this.mAnalyserKeyWord.KeyWordColor = this.mSessionConfigurations.TerminalForeColor;
			this.mAnalyserKeyWord.KeyWordFont = this.mSessionConfigurations.TerminalFont;

			this.rtbResult.BackColor = this.mSessionConfigurations.TerminalBackground;
			this.rtbResult.ForeColor = this.mAnalyserKeyWord.KeyWordColor;
			this.rtbResult.Font = this.mAnalyserKeyWord.KeyWordFont;

			this.tbSubstitutionWords.Enabled = false;
			this.pbFontText.Enabled = false;
			this.pbDelete.Enabled = false;
			this.cbOutputOnLogShell.Enabled = false;

			this.bDescriptionNeverFill = true;
		}

		/// <summary>
		/// Call when the user push the button managing the output font.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbFontText_Click(object sender, EventArgs e) {
			FontDialog fontDialog = new FontDialog() {
				ShowColor = true,

				Font = this.mAnalyserKeyWord.KeyWordFont,
				Color = this.mAnalyserKeyWord.KeyWordColor
			};

			if(fontDialog.ShowDialog() != DialogResult.Cancel) {
				this.mAnalyserKeyWord.KeyWordFont = fontDialog.Font;
				this.mAnalyserKeyWord.KeyWordColor = fontDialog.Color;				

				this.rtbResult.Font = this.mAnalyserKeyWord.KeyWordFont;
				this.rtbResult.ForeColor = this.mAnalyserKeyWord.KeyWordColor;
			}
		}

		/// <summary>
		/// Call when <see cref="tbKeyWord"/> changed.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbKeyWord_TextChanged(object sender, EventArgs e) {

			//Use to detect if its first fills. Then we send the <see cref="NewDescriptionEvent"/>.
			if(bDescriptionNeverFill == true) {
				bDescriptionNeverFill = false;
				NewDescriptionEvent?.Invoke(this, null);
				this.tbSubstitutionWords.Enabled = true;
				this.pbFontText.Enabled = true;
				this.pbDelete.Enabled = true;
				this.cbOutputOnLogShell.Enabled = true;
			}

			//If isn't any substitution key word, we copy the keyword.
			if(this.tbSubstitutionWords.Text.Length == 0) {
				this.rtbResult.Text = this.tbKeyWord.Text;
			}
			this.AnalyserKeyWord.KeyWord = this.tbKeyWord.Text;
		}

		/// <summary>
		/// Call when <see cref="tbSubstitutionWords"/> changed.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbSubstitutionWords_TextChanged(object sender, EventArgs e) {
			this.rtbResult.Text = this.tbSubstitutionWords.Text;
			this.AnalyserKeyWord.SubstitutionWords = this.tbSubstitutionWords.Text;

		}

		/// <summary>
		/// Call when the user want to delet this rule. Then, we send the event <see cref="AnalyserDescriptionDeletedEvent"/>.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void bDelete_Click(object sender, EventArgs e) {
			this.AnalyserDescriptionDeletedEvent?.Invoke(this, null);
		}

		/// <summary>
		/// Call when <see cref="cbOutputOnLogShell"/> state changed.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void cbOutputOnLogShell_CheckedChanged(object sender, EventArgs e) {
			this.AnalyserKeyWord.NotifiedLogTerminal = this.cbOutputOnLogShell.Checked;
		}
	}
}
