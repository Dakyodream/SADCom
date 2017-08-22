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

	/// <summary>
	/// Call when user whent to send the requset.
	/// </summary>
	/// <param name="sender">The object sending the event.</param>
	/// <param name="requset">requset to send</param>
	public delegate void SendRequestEventHandler(object sender, String requset);

	/// <summary>
	/// State returned by the conexion controler
	/// </summary>
	public enum SendCmdState{ ConnexionDisabled = 0, ConnexionEnabled,  TransmissionFailed, TransmissionSucces};

	public partial class CustomButtonUC : UserControl {

		/// <summary>
		/// See to indicate the this objet must be deleted. See <see cref="CustomButtonDeletedEventHandler"/>.
		/// </summary>
		public event CustomButtonDeletedEventHandler OnCustomButtonDeletedEvent;

		/// <summary>
		/// Call for creat a new empty object. See <see cref="NewCustomButtonEventHandler"/>.
		/// </summary>
		public event NewCustomButtonEventHandler OnNewCustomButtonEvent;

		/// <summary>
		/// Call when user whent to send the requset. See <see cref="SendRequestEventHandler"/>.
		/// </summary>
		public event SendRequestEventHandler OnSendRequestEvent;

		/// <summary>
		/// Timer for periodical request.
		/// </summary>
		private Timer mTimerForPeriodicalRequest;

		/// <summary>
		/// Use to update the state TransmissionFailed & TransmissionSucces of the system
		/// </summary>
		private Timer mTimerForCmdState;


		/// <summary>
		/// Use to inform to user if the data can be send, are send or not.
		/// </summary>
		private SendCmdState mCmdState;
		private SendCmdState mOldCmdState;
		public SendCmdState CmdState {
			get {
				return this.mCmdState;
			}
			set {
				if(this.mTimerForCmdState.Enabled) {
					this.mTimerForCmdState.Stop();
				}

				if(value > SendCmdState.ConnexionEnabled) {
					this.mTimerForCmdState.Interval = 1000;
					if(this.mCmdState <= SendCmdState.ConnexionEnabled) {
						this.mOldCmdState = this.mCmdState;
					}
					this.mTimerForCmdState.Start();
				}

				this.mCmdState = value;
				this.UpdateCmdStateLight();
			}
		}


		/// <summary>
		/// Use for detecte the first fill of name button.
		/// </summary>
		private bool bDescriptionNeverFill;

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
				this.pbCmd.Text = this.mButtonConfig.ButtonName;

				this.tbRequest.Text = this.mButtonConfig.Request;
				this.cbPeriodicRequest.Checked = this.mButtonConfig.IsPeriodicRequest;
				this.numUpDownPeriodOfRequest.Value = (decimal)this.mButtonConfig.PeriodicInterval;

				this.tbRequest.Enabled = true;
				this.cbPeriodicRequest.Enabled = true;
				this.numUpDownPeriodOfRequest.Enabled = this.cbPeriodicRequest.Checked;

				this.EnableTextBoxButtonName(false);
			}
		}

		/// <summary>
		/// Use to save the default background color of the send request button.
		/// </summary>
		private Color cButtonSendBackColor = SystemColors.ActiveCaption;


		/// <summary>
		/// Constructor.
		/// </summary>
		public CustomButtonUC() {
			InitializeComponent();

			//instantiate and initiat the object
			this.mButtonConfig = new ButtonConfigurations();

			mCmdState = SendCmdState.ConnexionDisabled;
			mOldCmdState = mCmdState;

			bDescriptionNeverFill = true;

			this.mTimerForPeriodicalRequest = new Timer();
			this.mTimerForPeriodicalRequest.Tick += MTimerForPeriodicalRequest_Tick;

			this.mTimerForCmdState = new Timer();
			this.mTimerForCmdState.Tick += MTimerForCmdState_Tick;

			//create one ToolTip
			ToolTip toolTip = new ToolTip();
			toolTip.AutoPopDelay = 5000;
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			toolTip.ShowAlways = true;

			// Set up the ToolTip text for the Button and Checkbox.
			toolTip.SetToolTip(this.pbDeletButton, "Supprimer le bouton.");
			toolTip.SetToolTip(this.pbCmd, "Envoyer la requête (click droit pour modifier le nom).");
			toolTip.SetToolTip(this.tbButtonName, "Nom du boutton généré");
			toolTip.SetToolTip(this.tbRequest, "Donnée à transmettre sur appuie du boutton.");
			toolTip.SetToolTip(this.cbPeriodicRequest, "A checker pour rendre la requête periodique.");
			toolTip.SetToolTip(this.numUpDownPeriodOfRequest, "Periode d'envoie des données en seconde (s).");
			toolTip.SetToolTip(this.pbConnexionStateLight, "Etat de la connexion.");


			//manage control accessibility 
			this.tbRequest.Enabled = false;
			this.cbPeriodicRequest.Enabled = false;
			this.numUpDownPeriodOfRequest.Enabled = false;
			this.pbDeletButton.Enabled = false;

			//Hide inused column (use to simply the design)
			this.tableLayoutPanel1.ColumnStyles[1].Width = 50f;
			this.tableLayoutPanel1.ColumnStyles[2].Width = 0f;
			this.tableLayoutPanel1.ColumnStyles[3].Width = 50f;

			//enable the text box use to rename the button
			this.EnableTextBoxButtonName(true);

			//update the current connexion state
			this.UpdateCmdStateLight();
		}


		

		/// <summary>
		/// Call when the user rename the button.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbButtonName_TextChanged(object sender, EventArgs e) {
			if(bDescriptionNeverFill) {
				bDescriptionNeverFill = false;
				OnNewCustomButtonEvent?.Invoke(this, null);


				this.pbDeletButton.Enabled = true;
				this.tbRequest.Enabled = true;
				this.cbPeriodicRequest.Enabled = true;
				this.numUpDownPeriodOfRequest.Enabled = this.cbPeriodicRequest.Checked;
			}
			if(this.tbButtonName.Text.Length <= 0 || this.tbButtonName.Text.Trim().Length <= 0) {
				this.mButtonConfig.ButtonName = "Button";
			} else {
				this.mButtonConfig.ButtonName = this.tbButtonName.Text;
			}

			this.tbButtonName.Text = this.mButtonConfig.ButtonName;
			this.pbCmd.Text = this.mButtonConfig.ButtonName; ;
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
		/// Call to delet the object. Send the event <see cref="OnCustomButtonDeletedEvent"/>.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbDeletButton_Click(object sender, EventArgs e) {
			OnCustomButtonDeletedEvent?.Invoke(this, null);
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

		/// <summary>
		/// Call by user when he want to rename the send request button
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">NNot used.</param>
		private void tlsiEditButtonName_Click(object sender, EventArgs e) {
			EnableTextBoxButtonName(true);
			this.tbButtonName.Focus();
		}

		/// <summary>
		/// Call when the user leave the text box use to rename the send request button.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbButtonName_ControlRemoved(object sender, ControlEventArgs e) {
			EnableTextBoxButtonName(false);
		}

		/// <summary>
		/// Call when the user leave the text box use to rename the send request button.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void tbButtonName_Validated(object sender, EventArgs e) {
			EnableTextBoxButtonName(false);
		}

		/// <summary>
		/// Use to know if the user push the enter button. So, we leave the edit mode of the send request button. 
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Key pressed</param>
		private void tbButtonName_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == (char)13) {
				EnableTextBoxButtonName(false);
			}
		}

		/// <summary>
		/// Use to hide or show the send request button or the text box that allows to rename the button.
		/// </summary>
		/// <param name="enable">If true, hide the button, else hide the text box.</param>
		private void EnableTextBoxButtonName(bool enable) {
			if(bDescriptionNeverFill || enable == true) {
				this.tableLayoutPanel1.Controls.Remove(this.pbCmd);
				this.tableLayoutPanel1.Controls.Add(this.tbButtonName, 1,0);
			} else {

				this.tableLayoutPanel1.Controls.Remove(this.tbButtonName);
				this.tableLayoutPanel1.Controls.Add(this.pbCmd, 1, 0);
			}
		}

		/// <summary>
		/// Call by the timer used to update the connexion state.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MTimerForCmdState_Tick(object sender, EventArgs e) {
			this.mTimerForCmdState.Stop();
			this.CmdState = this.mOldCmdState;
		}

		/// <summary>
		/// Update the picture box to load the picture that corresponding to the current connexion state.
		/// </summary>
		private void UpdateCmdStateLight() {
			switch(this.mCmdState) {
				case SendCmdState.ConnexionDisabled:
					this.pbConnexionStateLight.Image = global::SADCom.Properties.Resources.SilverLight;
					break;
				case SendCmdState.ConnexionEnabled:
					this.pbConnexionStateLight.Image = global::SADCom.Properties.Resources.YellowLight;
					break;
				case SendCmdState.TransmissionFailed:
					this.pbConnexionStateLight.Image = global::SADCom.Properties.Resources.RedLight;
					break;
				case SendCmdState.TransmissionSucces:
					this.pbConnexionStateLight.Image = global::SADCom.Properties.Resources.GreenLight;
					break;
			}			
		}
		
		/// <summary>
		/// Call when the user would send the request.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		private void pbCmd_Click(object sender, EventArgs e) {
			if(this.cbPeriodicRequest.Checked) {
				if(!this.mTimerForPeriodicalRequest.Enabled) {
					this.mTimerForPeriodicalRequest.Interval = (int)(this.numUpDownPeriodOfRequest.Value * 1000);					
					this.mTimerForPeriodicalRequest.Start();

					this.pbDeletButton.Enabled = false;
					this.tbButtonName.Enabled = false;
					this.tbRequest.Enabled = false;
					this.cbPeriodicRequest.Enabled = false;
					this.numUpDownPeriodOfRequest.Enabled = false;

					cButtonSendBackColor = this.pbCmd.BackColor;
					this.pbCmd.BackColor = SystemColors.ActiveCaption;
				} else {
					this.mTimerForPeriodicalRequest.Stop();

					this.pbDeletButton.Enabled = true;
					this.tbButtonName.Enabled = true;
					this.tbRequest.Enabled = true;
					this.cbPeriodicRequest.Enabled = true;
					this.numUpDownPeriodOfRequest.Enabled = true;

					this.pbCmd.BackColor = cButtonSendBackColor;
				}
			} else {
				SendRequest();
			}
		}

		/// <summary>
		/// Call by the timer that use to send periodical request.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not Used.</param>
		private void MTimerForPeriodicalRequest_Tick(object sender, EventArgs e) {
			this.mTimerForPeriodicalRequest.Stop();
			SendRequest();
			this.mTimerForPeriodicalRequest.Start();
		}

		/// <summary>
		/// Call to send the requst.
		/// </summary>
		private void SendRequest() {
			if(this.tbRequest.Text.Length > 0) {
				this.OnSendRequestEvent?.Invoke(this, this.tbRequest.Text);
				CmdState = SendCmdState.TransmissionSucces; //for tests
			}
		}


		public void ReduceTheForm(bool ReduceIt) {
			//manage control accessibility 
			this.tbRequest.Visible = !ReduceIt;
			this.cbPeriodicRequest.Visible = !ReduceIt;
			this.numUpDownPeriodOfRequest.Visible = !ReduceIt;
			this.pbDeletButton.Visible = !ReduceIt;

			if(ReduceIt) {
				this.tableLayoutPanel1.ColumnStyles[0].Width = 0f;
				this.tableLayoutPanel1.ColumnStyles[1].Width = 100f;
				this.tableLayoutPanel1.ColumnStyles[2].Width = 0f;
				this.tableLayoutPanel1.ColumnStyles[3].Width = 0f;
				this.tableLayoutPanel1.ColumnStyles[4].Width = 0f;
				this.tableLayoutPanel1.ColumnStyles[5].Width = 0f;
			} else {
				this.tableLayoutPanel1.ColumnStyles[0].Width = 20f;
				this.tableLayoutPanel1.ColumnStyles[1].Width = 50f;
				this.tableLayoutPanel1.ColumnStyles[2].Width = 0f;
				this.tableLayoutPanel1.ColumnStyles[3].Width = 50f;
				this.tableLayoutPanel1.ColumnStyles[4].Width = 17f;
				this.tableLayoutPanel1.ColumnStyles[5].Width = 93f;
			}
		}
	}
}
