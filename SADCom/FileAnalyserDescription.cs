using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom {

	[Serializable]
	class FileAnalyserDescription {

		private List<AnalyserKeyWord> mlistOfAnalyserDescriptionUC;
		public List<AnalyserKeyWord> listOfKeyWords {
			get {
				return this.mlistOfAnalyserDescriptionUC;
			}
			set {
				this.mlistOfAnalyserDescriptionUC = value;
			}
		}

		public FileAnalyserDescription() : this(new List<AnalyserKeyWord>()) {}
		public FileAnalyserDescription(List<AnalyserKeyWord> listOfKeyWords) {
			this.mlistOfAnalyserDescriptionUC = listOfKeyWords;
		}


		public void AddDescription(AnalyserKeyWord description) {
			if(this.mlistOfAnalyserDescriptionUC == null) {
				this.mlistOfAnalyserDescriptionUC = new List<AnalyserKeyWord>();
			}

			if(!this.mlistOfAnalyserDescriptionUC.Contains(description)) {
				this.mlistOfAnalyserDescriptionUC.Add(description);
			}
		}

		public void RemoveDescription(AnalyserKeyWord description) {
			if(this.mlistOfAnalyserDescriptionUC != null) { 
				if(this.mlistOfAnalyserDescriptionUC.Contains(description)) {
					this.mlistOfAnalyserDescriptionUC.Remove(description);
				}
			}
		}

		// override object.Equals
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
		public override int GetHashCode() {
			int iReturn = 0;

			iReturn = base.GetHashCode() + this.mlistOfAnalyserDescriptionUC.GetHashCode();

			return iReturn;
		}


	}
}
