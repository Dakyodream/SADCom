using System;
using System.Drawing;


namespace SADCom {

	/// <summary>
	/// This class is use to generate and save informations which used by the data analyser. 
	/// The software use the serialisation to save this information. This class must be serialisable.
	/// </summary>
	[Serializable]
	public class AnalyserKeyWord {

		/// <summary>
		/// Contain the keyword that enable the rules inclued in this object. 
		/// </summary>
		/// <remarks>
		///		TODO : the analyser data can use the wildcard character like *, ?, ., %, ... []
		/// </remarks>	
		private String msKeyWord = "";
		/// <summary>
		/// Contain the keyword that enable the rules inclued in this object.
		/// See <see cref="msKeyWord"/>.
		/// </summary>
		public String KeyWord {
			get {
				return msKeyWord;
			}
			set {
				this.msKeyWord = value;
			}
		}

		/// <summary>
		/// If isn't empty, replace the keyword in data output or, if <see cref="NotifiedLogTerminal"/> is true, in log output. 
		/// </summary>
		/// <remarks>
		///		TODO : the analyser data can use the wildcard character like *, ?, ., %, ... []
		/// </remarks>
		private String msSubstitutionWords = "";
		/// <summary>
		/// If isn't empty, replace the keyword in data output or, if <see cref="NotifiedLogTerminal"/> is true, in log output. 
		/// See <see cref="msSubstitutionWords"/>.
		/// </summary>
		public String SubstitutionWords { get => msSubstitutionWords; set => msSubstitutionWords = value; }

		/// <summary>
		/// Rule on font of the keyword or the supstitution keyword if <see cref="SubstitutionWords"/> isn't empty.
		/// </summary>
		private Font mfKeyWordFont = Properties.Settings.Default.terminalFont;
		/// <summary>
		/// Rule on font of the keyword or the supstitution keyword if <see cref="SubstitutionWords"/> isn't empty.
		/// See <see cref="mfKeyWordFont"/>.
		/// </summary>
		public Font KeyWordFont {
			get {
				return mfKeyWordFont;
			}
			set {
				this.mfKeyWordFont = value;
			}
		}

		/// <summary>
		/// Rule on word color of the keyword or the supstitution keyword if <see cref="SubstitutionWords"/> isn't empty.
		/// </summary>
		private Color mcKeyWordColor = Properties.Settings.Default.terminalForeColor;
		/// <summary>
		/// Rule on  word color of the keyword or the supstitution keyword if <see cref="SubstitutionWords"/> isn't empty.
		/// See <see cref="mcKeyWordColor"/>.
		/// </summary>
		public Color KeyWordColor {
			get {
				return mcKeyWordColor;
			}
			set {
				this.mcKeyWordColor = value;
			}
		}

		/// <summary>
		/// If true, the data will not be modified but tkeyword our substitution keyword will be write on log terminal.
		/// </summary>
		private Boolean mbNotifiedLogTerminal = false;
		/// <summary>
		/// If true, the data will not be modified but tkeyword our substitution keyword will be write on log terminal.
		/// See <see cref="mbNotifiedLogTerminal"/>.
		/// </summary>
		public Boolean NotifiedLogTerminal { get => mbNotifiedLogTerminal; set => mbNotifiedLogTerminal = value; }

		/// <summary>
		/// Constructor.
		/// </summary>
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
