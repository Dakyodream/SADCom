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
		private List<AnalyserKeyWord> mlistOfAnalyserDescriptionUC;
		/// <summary>
		/// List of rules use by the analizer data.
		/// See <see cref="mlistOfAnalyserDescriptionUC"/>.
		/// </summary>
		public List<AnalyserKeyWord> listOfKeyWords {
			get {
				return this.mlistOfAnalyserDescriptionUC;
			}
			set {
				this.mlistOfAnalyserDescriptionUC = value;
			}
		}


		/// <summary>
		/// Constructor.
		/// </summary>
		public FileAnalyserDescription() : this(new List<AnalyserKeyWord>()) {}
		public FileAnalyserDescription(List<AnalyserKeyWord> listOfKeyWords) {
			this.mlistOfAnalyserDescriptionUC = listOfKeyWords;
		}

		/// <summary>
		/// Use to add a descrition on list.
		/// </summary>
		/// <param name="description">Analyse rule to add on list.</param>
		public void AddDescription(AnalyserKeyWord description) {
			if(this.mlistOfAnalyserDescriptionUC == null) {
				this.mlistOfAnalyserDescriptionUC = new List<AnalyserKeyWord>();
			}

			if(!this.mlistOfAnalyserDescriptionUC.Contains(description)) {
				this.mlistOfAnalyserDescriptionUC.Add(description);
			}
		}

		/// <summary>
		/// Use to remove an rule on list.
		/// </summary>
		/// <param name="description">Rule to remove on list.</param>
		public void RemoveDescription(AnalyserKeyWord description) {
			if(this.mlistOfAnalyserDescriptionUC != null) { 
				if(this.mlistOfAnalyserDescriptionUC.Contains(description)) {
					this.mlistOfAnalyserDescriptionUC.Remove(description);
				}
			}
		}

		// override object.Equals
		//need for serialisation
		public override bool Equals(object obj) {

			if(obj == null || GetType() != obj.GetType()) {
				return false;
			} else {
				if(!this.mlistOfAnalyserDescriptionUC.Equals( ((FileAnalyserDescription)obj).listOfKeyWords)) {
					return false;
				}
			}
			return base.Equals(obj);
		}

		// override object.GetHashCode
		// need for serialisation
		public override int GetHashCode() {
			return base.GetHashCode() ^ this.mlistOfAnalyserDescriptionUC.GetHashCode();
		}

	}
}
