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

namespace SADCom {
	public partial class OptionCustomButtonUC : UserControl {

		/// <summary>
		/// Contain the configuration of this session.
		/// </summary>
		private SessionConfigurations mSessionConfigurations = new SessionConfigurations();
		/// <summary>
		/// Contain the configuration of this session. See <see cref="mSessionConfigurations"/>.
		/// </summary>
		public SessionConfigurations SessionConfigurations {
			get => this.mSessionConfigurations;
			set {
				this.mSessionConfigurations = value;

				if(this.mSessionConfigurations == null) {
					this.mSessionConfigurations = new SessionConfigurations();
				}//if disposed ?
			}
		}




		/// <summary>
		/// Constructor for disigner viewer
		/// </summary>
		public OptionCustomButtonUC() : this(new SessionConfigurations()) { }
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="sessionConfigurations">Session parameters</param>
		public OptionCustomButtonUC(SessionConfigurations sessionConfigurations) {
			InitializeComponent();
			SessionConfigurations = sessionConfigurations;
		}
	

		
		private void pbClearAddrCustomButtonFile_Click(object sender, EventArgs e) {
			this.tbAddrCustomButtonFile.Clear();
			this.mSessionConfigurations.AddrOfCustomButtonFileDescription = "";
		}

		private void pbSearchCustomButtonFile_Click(object sender, EventArgs e) {

		}

		private void pbNewCustomButtonFile_Click(object sender, EventArgs e) {
			RequestDesigner requestDesigner = new RequestDesigner();

			try {
				if(requestDesigner.ShowDialog() == DialogResult.OK) {
					if(mSessionConfigurations.AddrOfCustomButtonFileDescription.Length > 0) {
						this.tbAddrCustomButtonFile.Text = mSessionConfigurations.AddrOfCustomButtonFileDescription;
					}
				}
			} catch {
				throw new Exception("pbNewCustomButtonFile_Click can't open RequestDesigner.");
			}
		}

		private void pbNormalViewer_Click(object sender, EventArgs e) {

		}

		private void pbSmallViewer_Click(object sender, EventArgs e) {

		}
	}
}
