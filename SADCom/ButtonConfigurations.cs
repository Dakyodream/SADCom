using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADCom.UserButton {

	/// <summary>
	/// Use to save the user request button.
	/// </summary>
	[Serializable]
	public class ButtonConfigurations {

		/// <summary>
		/// Contain the button name.
		/// </summary>
		private String msButtonName;
		/// <summary>
		/// Contain the button name.
		/// </summary>
		public String ButtonName {get => this.msButtonName; set => this.msButtonName = value;}

		/// <summary>
		/// Contain the request to send
		/// </summary>
		private String msRequest;
		/// <summary>
		/// Contain the request to send
		/// </summary>
		public String Request { get => this.msRequest; set => this.msRequest = value; }

		/// <summary>
		/// Define the type of button (periodic request or not).
		/// </summary>
		private Boolean mbIsPeriodicRequest;
		/// <summary>
		/// Define the type of button (periodic request or not).
		/// </summary>
		public Boolean IsPeriodicRequest { get => this.mbIsPeriodicRequest; set => this.mbIsPeriodicRequest = value; }

		/// <summary>
		/// Contain the interval value of periodic request.
		/// </summary>
		private double mdPeriodicInterval;
		/// <summary>
		/// Contain the interval value of periodic request.
		/// </summary>
		public double PeriodicInterval {
			get => this.mdPeriodicInterval;
			set {
				if(value > 0) {
					this.mdPeriodicInterval = value;
				}
			}
		}

		/// <summary>
		/// Constructeur
		/// </summary>
		public ButtonConfigurations() {
			ButtonName = "";
			Request = "";
			IsPeriodicRequest = false;
			PeriodicInterval = 1;
		}

		// override object.Equals
		public override bool Equals(object obj) {
			bool bReturn = true;
			ButtonConfigurations buttonConfiguration;

			if(obj == null || GetType() != obj.GetType()) {
				return false;
			} else {
				buttonConfiguration = (ButtonConfigurations)obj;

				bReturn &= this.ButtonName.Equals(buttonConfiguration.ButtonName);
				bReturn &= this.Request.Equals(buttonConfiguration.Request);
				bReturn &= this.IsPeriodicRequest.Equals(buttonConfiguration.IsPeriodicRequest);
				bReturn &= this.PeriodicInterval.Equals(buttonConfiguration.PeriodicInterval);
			}

			bReturn &= base.Equals(obj);

			return bReturn;	
		}

		// override object.GetHashCode
		public override int GetHashCode() {
			int iRetuenValue = 0;
			iRetuenValue = base.GetHashCode();

			iRetuenValue ^= this.ButtonName.GetHashCode(); 
			iRetuenValue ^= this.Request.GetHashCode(); 
			iRetuenValue ^= this.IsPeriodicRequest.GetHashCode(); 
			iRetuenValue ^= this.PeriodicInterval.GetHashCode();
			
			return iRetuenValue;
		}

	}
}
