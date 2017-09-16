using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom {
	public partial class ShellBoardUC : UserControl, ShellInterface {

		private int iLastRowSelectionned = -1;
		private Color defaultColorShell;
		private Font dafaultFontShell;

		public ShellBoardUC() {
			InitializeComponent();
		}

		public void hideLogInformation() {
			throw new NotImplementedException();
		}

		public void hideTime() {
			throw new NotImplementedException();
		}

		public void newData(string sData){
			this.newData(DateTime.Now, sData);
		}

		public void newData(DateTime time, string sData) {
			this.newData(time, sData, null);
		}

		public void newData(DateTime time, string sData, string sDataLog) {
			this.newData(time, sData, sDataLog, null, defaultColorShell);
		}

		public void newData(DateTime time, string sData, string sDataLog, Font fDataLog, Color cDataLog) {
			TextBox tbNewTime = new TextBox();
			TextBox tbNewData = new TextBox();
			TextBox tbNewDataLog = new TextBox();
			int iRowCount = 0;

			if(time == null) {
				time = DateTime.Now;
			} else {
				if(time.Ticks == 0) {
					throw new Exception("Time parameter are impossible : time.Ticks = " + time.Ticks + ".\n");
				}
			}

			if(sData == null) {
				if(sDataLog == null) {
					return;
				}
				sData = "";
			}

			if(this.defaultColorShell == null) {
				this.defaultColorShell = Properties.Settings.Default.terminalForeColor;
			}
			if(this.dafaultFontShell == null) {
				this.dafaultFontShell = Properties.Settings.Default.terminalFont;
			}

			///create new ligne
			tbNewTime.BorderStyle = BorderStyle.None;
			tbNewTime.Dock = DockStyle.Top;
			tbNewTime.Margin = new Padding(0);
			tbNewTime.MouseClick += new MouseEventHandler(this.tb_MouseClick);
			tbNewTime.BackColor = this.defaultColorShell;
			tbNewTime.Font = this.dafaultFontShell;

			tbNewData.BorderStyle = BorderStyle.None;
			tbNewData.Dock = DockStyle.Top;
			tbNewData.Margin = new Padding(0);
			tbNewData.MouseClick += new MouseEventHandler(this.tb_MouseClick);
			tbNewData.BackColor = this.defaultColorShell;
			tbNewData.Font = this.dafaultFontShell;

			tbNewDataLog.BorderStyle = BorderStyle.None;
			tbNewDataLog.Dock = DockStyle.Top;
			tbNewDataLog.Margin = new Padding(0);
			tbNewDataLog.MouseClick += new MouseEventHandler(this.tb_MouseClick);
			tbNewDataLog.BackColor = this.defaultColorShell;
			tbNewDataLog.Font = this.dafaultFontShell;

			iRowCount = tableLayoutPanel1.RowCount;
			tableLayoutPanel1.RowCount = iRowCount + 1;
			tableLayoutPanel1.RowStyles[iRowCount-1] = new RowStyle();
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

			tableLayoutPanel1.Controls.Add(tbNewTime, 0, iRowCount-1);
			tableLayoutPanel1.Controls.Add(tbNewData, 1, iRowCount-1);
			tableLayoutPanel1.Controls.Add(tbNewDataLog, 2, iRowCount-1);

			tbNewTime.Text = time.ToString("HH:mm:ss.ffff");
			tbNewData.Text = sData;

			if(sDataLog != null) {
				if(fDataLog != null) {
					tbNewDataLog.Font = fDataLog;
				}
				if(cDataLog != null) {
					tbNewDataLog.BackColor = cDataLog;
				}
				tbNewDataLog.Text = sDataLog;
			}
			

		}




		public void setDefaultColor(Color cData) {
			throw new NotImplementedException();
		}

		public void setDefaultFont(Font fData) {
			throw new NotImplementedException();
		}

		public void showLogInformation() {
			throw new NotImplementedException();
		}

		public void showTime() {
			throw new NotImplementedException();
		}

		private void tb_MouseClick(object sender, MouseEventArgs e) {
			int iIndexOfRow = 0;
			Color colorOfSelection = defaultColorShell;
			if(sender is Control) {
				if(tableLayoutPanel1.Controls.Contains((Control)sender)) {
					
					iIndexOfRow = tableLayoutPanel1.GetRow((Control)sender);

					if(iIndexOfRow != iLastRowSelectionned) {
						if(iLastRowSelectionned != -1) {
							tableLayoutPanel1.GetControlFromPosition(0, iLastRowSelectionned).BackColor = defaultColorShell;
							tableLayoutPanel1.GetControlFromPosition(1, iLastRowSelectionned).BackColor = defaultColorShell;
							tableLayoutPanel1.GetControlFromPosition(2, iLastRowSelectionned).BackColor = defaultColorShell;
						}
						//colorOfSelection = Color.FromArgb(((colorOfSelection.R + 128) % 255),
						//	((colorOfSelection.G + 128) % 255),
						//	((colorOfSelection.G + 128) % 255));
						colorOfSelection = Color.Aqua;

						tableLayoutPanel1.GetControlFromPosition(0, iIndexOfRow).BackColor = colorOfSelection;
						tableLayoutPanel1.GetControlFromPosition(1, iIndexOfRow).BackColor = colorOfSelection;
						tableLayoutPanel1.GetControlFromPosition(2, iIndexOfRow).BackColor = colorOfSelection;
						iLastRowSelectionned = iIndexOfRow;
					}
				}
			}
		}
	}
}
