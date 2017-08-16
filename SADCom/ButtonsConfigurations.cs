using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom.UserButton {

	/// <summary>
	/// Use to save the list of buttonConfigurations.
	/// </summary>
	[Serializable]
	public class ButtonsConfigurations {

		/// <summary>
		/// List of user button use to send custom request.
		/// </summary>
		private List<ButtonConfigurations> mListOfUserButton;
		/// <summary>
		/// List of user button use to send custom request.
		/// </summary>
		/// 
		public List<ButtonConfigurations> ListOfUserButton { get => this.mListOfUserButton; set => this.mListOfUserButton = value; }

		/// <summary>
		/// Constructor.
		/// </summary>
		public ButtonsConfigurations() : this(new List<ButtonConfigurations>()) { }
		public ButtonsConfigurations(List<ButtonConfigurations> listOfUserButton) {
			this.ListOfUserButton = listOfUserButton;
		}


		/// <summary>
		/// Use to add a button on list.
		/// </summary>
		/// <param name="button">Button to add on list/</param>
		public void AddDescription(ButtonConfigurations button) {
			if(this.mListOfUserButton == null) {
				this.mListOfUserButton = new List<ButtonConfigurations>();
			}

			if(!this.mListOfUserButton.Contains(button)) {
				this.mListOfUserButton.Add(button);
			}
		}

		/// <summary>
		/// Use to remove a button on list.
		/// </summary>
		/// <param name="button">Button to remove on list.</param>
		public void RemoveDescription(ButtonConfigurations button) {
			if(this.mListOfUserButton != null) {
				if(this.mListOfUserButton.Contains(button)) {
					this.mListOfUserButton.Remove(button);
				}
			}
		}


		// override object.Equals
		public override bool Equals(object obj) {
			if(obj == null || GetType() != obj.GetType()) {
				return false;
			} else {
				if(!this.ListOfUserButton.Equals(((ButtonsConfigurations)obj).ListOfUserButton)) {
					return false;
				}
			}
			return base.Equals(obj);	
		}

		// override object.GetHashCode
		public override int GetHashCode() {
			return base.GetHashCode() ^ this.mListOfUserButton.GetHashCode();
		}

	}
}
