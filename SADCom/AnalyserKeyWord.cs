using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {
	[Serializable]
	public class AnalyserKeyWord {
		
		private String msKeyWord = "";
		public String KeyWord {
			get {
				return msKeyWord;
			}
			set {
				this.msKeyWord = value;
			}
		}

		private String msSubstitutionWords = "";
		public String SubstitutionWords { get => msSubstitutionWords; set => msSubstitutionWords = value; }

		private Font mfKeyWordFont = Properties.Settings.Default.terminalFont;
		public Font KeyWordFont {
			get {
				return mfKeyWordFont;
			}
			set {
				this.mfKeyWordFont = value;
			}
		}

		private Color mcKeyWordColor = Properties.Settings.Default.terminalForeColor;
		public Color KeyWordColor {
			get {
				return mcKeyWordColor;
			}
			set {
				this.mcKeyWordColor = value;
			}
		}

		private Boolean mbNotifiedLogTerminal = false;
		public Boolean NotifiedLogTerminal { get => mbNotifiedLogTerminal; set => mbNotifiedLogTerminal = value; }

		public AnalyserKeyWord() : this("", Properties.Settings.Default.terminalFont, Properties.Settings.Default.terminalForeColor, false) { }
		public AnalyserKeyWord(String keyWord) : this( keyWord, Properties.Settings.Default.terminalFont, Properties.Settings.Default.terminalForeColor, false) { }
		public AnalyserKeyWord(String keyWord, Font font) : this( keyWord, font, Properties.Settings.Default.terminalForeColor, false) { }
		public AnalyserKeyWord(String keyWord, Font font, Color color) : this( keyWord, font, color, false) { }

		public AnalyserKeyWord(String keyWord, Font font, Color color, Boolean NotifiedLogTerminal) {
			this.KeyWord = keyWord;
			this.KeyWordFont = font;
			this.KeyWordColor = color;
		}

		

	}
}
