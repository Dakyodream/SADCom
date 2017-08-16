using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {
	/// <summary>
	/// This class contain the list of <see cref="AnalyserKeyWord"/>. She use to save information throw an serialisation.
	/// This class must be serialisable.
	/// </summary>
	[Serializable]
	class FileAnalyserDescription {

		/// <summary>
		/// List of rules use by the analizer data.
		/// </summary>
		private List<AnalyserKeyWord> mListOfAnalyserDescriptionUC;
		/// <summary>
		/// List of rules use by the analizer data.
		/// See <see cref="mListOfAnalyserDescriptionUC"/>.
		/// </summary>
		public List<AnalyserKeyWord> ListOfKeyWords {
			get {
				return this.mListOfAnalyserDescriptionUC;
			}
			set {
				this.mListOfAnalyserDescriptionUC = value;
			}
		}


		/// <summary>
		/// Constructor.
		/// </summary>
		public FileAnalyserDescription() : this(new List<AnalyserKeyWord>()) {}
		public FileAnalyserDescription(List<AnalyserKeyWord> listOfKeyWords) {
			this.ListOfKeyWords = listOfKeyWords;
		}

		/// <summary>
		/// Use to add a descrition on list.
		/// </summary>
		/// <param name="description">Analyse rule to add on list.</param>
		public void AddDescription(AnalyserKeyWord description) {
			if(this.mListOfAnalyserDescriptionUC == null) {
				this.mListOfAnalyserDescriptionUC = new List<AnalyserKeyWord>();
			}

			if(!this.mListOfAnalyserDescriptionUC.Contains(description)) {
				this.mListOfAnalyserDescriptionUC.Add(description);
			}
		}

		/// <summary>
		/// Use to remove an rule on list.
		/// </summary>
		/// <param name="description">Rule to remove on list.</param>
		public void RemoveDescription(AnalyserKeyWord description) {
			if(this.mListOfAnalyserDescriptionUC != null) { 
				if(this.mListOfAnalyserDescriptionUC.Contains(description)) {
					this.mListOfAnalyserDescriptionUC.Remove(description);
				}
			}
		}

		// override object.Equals
		//need for serialisation
		public override bool Equals(object obj) {

			if(obj == null || GetType() != obj.GetType()) {
				return false;
			} else {
				if(!this.ListOfKeyWords.Equals( ((FileAnalyserDescription)obj).ListOfKeyWords)) {
					return false;
				}
			}
			return base.Equals(obj);
		}

		// override object.GetHashCode
		// need for serialisation
		public override int GetHashCode() {
			return base.GetHashCode() ^ this.mListOfAnalyserDescriptionUC.GetHashCode();
		}

	}
}
