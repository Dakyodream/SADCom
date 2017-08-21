using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADCom.UserButton;

namespace SADCom.UserButton {
	public partial class CustomButtonFull_UC : UserControl {

		/// <summary>
		/// Contain configurations of the user custom button.
		/// </summary>
		private ButtonConfigurations mButtonConfig;
		/// <summary>
		/// Contain configurations of the user custom button. See <see cref="mButtonConfig"/>.
		/// Update the user control when is set.
		/// </summary>
		public ButtonConfigurations ButtonConfig {
			get {
				return this.mButtonConfig;
			}
			set {
				this.mButtonConfig = value;

				//Protection du système contre un objet null (non géré dans la suite du code).
				if(value == null) {
					this.mButtonConfig = new ButtonConfigurations();
				}
				UpdateUserControl();
			}
		}



		public CustomButtonFull_UC() {
			InitializeComponent();
			InitializeComponent();

			this.mButtonConfig = new ButtonConfigurations();

			ToolTip toolTip = new ToolTip();
			toolTip.AutoPopDelay = 5000;
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			toolTip.ShowAlways = true;

			// Set up the ToolTip text for the Button and Checkbox.
			toolTip.SetToolTip(this.pbSendCmd, "Envoyer la commande.");
			toolTip.SetToolTip(this.tbCmd, "Commande à transmettre.");
			toolTip.SetToolTip(this.numUpDownPeriodOfRequest, "Interval de temps");

			
			this.numUpDownPeriodOfRequest.Visible = false;
		}


		public void UpdateUserControl() {
			if(this.mButtonConfig.ButtonName.Length < 0) {
				this.pbSendCmd.Name = this.mButtonConfig.ButtonName;
			} else {
				this.pbSendCmd.Name = "Button";
			}

			this.tbCmd.Text = this.mButtonConfig.Request;
			if(this.mButtonConfig.IsPeriodicRequest) {
				this.numUpDownPeriodOfRequest.Visible = true;
				this.numUpDownPeriodOfRequest.Value = (decimal)this.mButtonConfig.PeriodicInterval;
			} else {
				this.numUpDownPeriodOfRequest.Visible = false;
			}


		}


		private void pbSendCmd_Click(object sender, EventArgs e) {

		}

		private void tbCmd_TextChanged(object sender, EventArgs e) {

		}

		private void numUpDownPeriodOfRequest_ValueChanged(object sender, EventArgs e) {

		}

		///// <summary>
		///// Call when the user rename the button.
		///// </summary>
		///// <param name="sender">Not used.</param>
		///// <param name="e">Not used.</param>
		//private void tbButtonName_TextChanged(object sender, EventArgs e) {
		//	if(bDescriptionNeverFill) {
		//		bDescriptionNeverFill = false;
		//		NewCustomButtonEvent?.Invoke(this, null);

		//		this.tbRequest.Enabled = true;
		//		this.cbPeriodicRequest.Enabled = true;
		//		this.numUpDownPeriodOfRequest.Enabled = this.cbPeriodicRequest.Checked;
		//	}
		//	if(this.tbButtonName.Text.Length <= 0 || this.tbButtonName.Text.Trim().Length <= 0) {
		//		this.mButtonConfig.ButtonName = "Button";
		//		this.tbButtonName.Text = this.mButtonConfig.ButtonName;

		//	} else {
		//		this.mButtonConfig.ButtonName = this.tbButtonName.Text;
		//		this.tbButtonName.Text = this.mButtonConfig.ButtonName;
		//	}
		//}

		///// <summary>
		///// Call when the user write the request.
		///// </summary>
		///// <param name="sender">Not used.</param>
		///// <param name="e">Not used.</param>
		//private void tbRequest_TextChanged(object sender, EventArgs e) {
		//	this.mButtonConfig.Request = this.tbRequest.Text;
		//}

		///// <summary>
		///// Call to delet the object. Send the event <see cref="CustomButtonDeletedEvent"/>.
		///// </summary>
		///// <param name="sender">Not used.</param>
		///// <param name="e">Not used.</param>
		//private void pbDeletButton_Click(object sender, EventArgs e) {
		//	CustomButtonDeletedEvent?.Invoke(this, null);
		//}

		///// <summary>
		///// Call when the user define the request like an periodical request.
		///// </summary>
		///// <param name="sender">Not used.</param>
		///// <param name="e">Not used.</param>
		//private void cbPeriodicRequest_CheckedChanged(object sender, EventArgs e) {
		//	this.mButtonConfig.IsPeriodicRequest = this.cbPeriodicRequest.Checked;
		//	this.numUpDownPeriodOfRequest.Enabled = this.mButtonConfig.IsPeriodicRequest;
		//}

		//		/// <summary>
		//		/// Call to define the request period (in second).
		//		/// </summary>
		//		/// <param name="sender">Not used.</param>
		//		/// <param name="e">Not used.</param>
		//		private void numUpDownPeriodOfRequest_ValueChanged(object sender, EventArgs e) {
		//			if(this.mButtonConfig.IsPeriodicRequest) {
		//				this.mButtonConfig.PeriodicInterval = (double)this.numUpDownPeriodOfRequest.Value;
		//			}
		//		}
		//	}
	}
}
