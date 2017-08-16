using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom.UserButton {

	/// <summary>
	/// Call when the user want to delet an custom request button
	/// </summary>
	/// <param name="sender">The object sending the event.</param>
	/// <param name="e">Not used (null).</param>
	public delegate void CustomButtonDeletedEventHandler(object sender, EventArgs e);
	/// <summary>
	/// Call when this user control are still. Call to create a new user control.
	/// </summary>
	/// <param name="sender">The object sending the event.</param>
	/// <param name="e">Not used (null).</param>
	public delegate void NewCustomButtonEventHandler(object sender, EventArgs e);

	public partial class CustomButtonDesignerUC : UserControl {

		/// <summary>
		/// See to indicate the this objet must be deleted. See <see cref="CustomButtonDeletedEvent"/>.
		/// </summary>
		public event CustomButtonDeletedEventHandler CustomButtonDeletedEvent;
		/// <summary>
		/// Call for creat a new empty object. See <see cref="NewCustomButtonEvent"/>.
		/// </summary>
		public event NewCustomButtonEventHandler NewCustomButtonEvent;

		/// <summary>
		/// Use for detecte the first fill of name button.
		/// </summary>
		private bool bDescriptionNeverFill = true;

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

				this.tbButtonName.Text = this.mButtonConfig.ButtonName;
				this.tbRequest.Text = this.mButtonConfig.Request;
				this.cbPeriodicRequest.Checked = this.mButtonConfig.IsPeriodicRequest;
				this.numUpDownPeriodOfRequest.Value = (decimal)this.mButtonConfig.PeriodicInterval;

				this.tbRequest.Enabled = true;
				this.cbPeriodicRequest.Enabled = true;
				this.numUpDownPeriodOfRequest.Enabled = this.cbPeriodicRequest.Checked;

			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		public CustomButtonDesignerUC() {
			InitializeComponent();

			this.mButtonConfig = new ButtonConfigurations();

			ToolTip toolTip = new ToolTip();
			toolTip.AutoPopDelay = 5000;
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			toolTip.ShowAlways = true;

			// Set up the ToolTip text for the Button and Checkbox.
			toolTip.SetToolTip(this.pbDeletButton, "Supprimer le bouton.");
			toolTip.SetToolTip(this.tbButtonName, "Nom du boutton généré");
			toolTip.SetToolTip(this.tbRequest, "Donnée à transmettre sur appuie du boutton.");
			toolTip.SetToolTip(this.cbPeriodicRequest, "A checker pour rendre la requête periodique.");
			toolTip.SetToolTip(this.numUpDownPeriodOfRequest, "Periode d'envoie des données en seconde.");


			this.tbRequest.Enabled = false;
			this.cbPeriodicRequest.Enabled = false;
			this.numUpDownPeriodOfRequest.Enabled = false;
		}

		/// <summary>
		/// Call when the user rename the button.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbButtonName_TextChanged(object sender, EventArgs e) {
			if(bDescriptionNeverFill) {
				bDescriptionNeverFill = false;
				NewCustomButtonEvent?.Invoke(this, null);
			}
			if(this.tbButtonName.Text.Length <= 0 || this.tbButtonName.Text.Trim().Length <= 0) {
				this.mButtonConfig.ButtonName = "Button";
				this.tbButtonName.Text = this.mButtonConfig.ButtonName;

			} else {
				this.mButtonConfig.ButtonName = this.tbButtonName.Text;
				this.tbButtonName.Text = this.mButtonConfig.ButtonName;
			}
		}

		/// <summary>
		/// Call when the user write the request.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbRequest_TextChanged(object sender, EventArgs e) {
			this.mButtonConfig.Request = this.tbRequest.Text;
		}

		/// <summary>
		/// Call to delet the object. Send the event <see cref="CustomButtonDeletedEvent"/>.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbDeletButton_Click(object sender, EventArgs e) {
			CustomButtonDeletedEvent?.Invoke(this, null);
		}

		/// <summary>
		/// Call when the user define the request like an periodical request.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void cbPeriodicRequest_CheckedChanged(object sender, EventArgs e) {
			this.mButtonConfig.IsPeriodicRequest = this.cbPeriodicRequest.Checked;
			this.numUpDownPeriodOfRequest.Enabled = this.mButtonConfig.IsPeriodicRequest;
		}

		/// <summary>
		/// Call to define the request period (in second).
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void numUpDownPeriodOfRequest_ValueChanged(object sender, EventArgs e) {
			if(this.mButtonConfig.IsPeriodicRequest) {
				this.mButtonConfig.PeriodicInterval = (double)this.numUpDownPeriodOfRequest.Value;
			}
		}
	}
}
