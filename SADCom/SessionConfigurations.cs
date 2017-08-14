using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SADCom {
	public class SessionConfigurations {

		//make event
		private static Mutex mutSessionConfig = new Mutex(true);

		// Timestamp
		private bool mbTimestampIsEnable;
		public bool TimestampIsEnable {
			get {
				mutSessionConfig.WaitOne();
				bool bReturn = this.mbTimestampIsEnable;
				mutSessionConfig.ReleaseMutex();

				return bReturn;
			}
			set {
				mutSessionConfig.WaitOne();
				this.mbTimestampIsEnable = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		private double mdTimestamp;
		public double Timestamp {
			get {
				mutSessionConfig.WaitOne();
				double bReturn = this.mdTimestamp;
				if(bReturn == 0) {
					bReturn = 1;
				}
				mutSessionConfig.ReleaseMutex();

				return bReturn;
			}
			set {
				mutSessionConfig.WaitOne();
				this.mdTimestamp = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		//data analyser
		private bool mbDataAnalyserEnable;
		public bool DataAnalyserEnable {
			get {
				mutSessionConfig.WaitOne();
				bool bReturn = this.mbDataAnalyserEnable;
				mutSessionConfig.ReleaseMutex();

				return bReturn;
			}
			set {
				mutSessionConfig.WaitOne();
				this.mbDataAnalyserEnable = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		private String msAddrLogFileAnalyser;
		public String AddrLogFileAnalyser {
			get {
				mutSessionConfig.WaitOne();
				String sData = this.msAddrLogFileAnalyser;
				mutSessionConfig.ReleaseMutex();
				return sData;
			}
			set {
				mutSessionConfig.WaitOne();
				this.msAddrLogFileAnalyser = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		private String msAddrFileAnalyserDescription;
		public String AddrFileAnalyserDescription {
			get {
				mutSessionConfig.WaitOne();
				String sData = this.msAddrFileAnalyserDescription;
				mutSessionConfig.ReleaseMutex();
				return sData;
			}
			set {
				mutSessionConfig.WaitOne();
				this.msAddrFileAnalyserDescription = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		//terminal font
		private Font mTerminalFont;
		public Font TerminalFont {
			get {
				mutSessionConfig.WaitOne();
				Font valueReturn = (Font)this.mTerminalFont.Clone();
				mutSessionConfig.ReleaseMutex();
				return this.mTerminalFont;
			}
			set {
				mutSessionConfig.WaitOne();
				this.mTerminalFont = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		private Color mTerminalBackground;
		public Color TerminalBackground {
			get {
				mutSessionConfig.WaitOne();
				Color valueReturn = this.mTerminalBackground;
				mutSessionConfig.ReleaseMutex();
				return valueReturn;
			}
			set {
				mutSessionConfig.WaitOne();
				this.mTerminalBackground = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		private Color mTerminalForeColor;
		public Color TerminalForeColor {
			get {
				mutSessionConfig.WaitOne();
				Color valueReturn = this.mTerminalForeColor;
				mutSessionConfig.ReleaseMutex();
				return this.mTerminalForeColor;
			}
			set {
				mutSessionConfig.WaitOne();
				this.mTerminalForeColor = value;
				mutSessionConfig.ReleaseMutex();
			}
		}

		//opacity
		private int miTerminalOpacity;
		public int TerminalOpacity {
			get {
				int iData = 0;
				mutSessionConfig.WaitOne();
				iData = this.miTerminalOpacity;
				mutSessionConfig.ReleaseMutex();

				return iData;
			}
			set {
				mutSessionConfig.WaitOne();
				if((value >= 30) && (value <= 100)) {
					this.miTerminalOpacity = value;
				}
				mutSessionConfig.ReleaseMutex();
			}
		}
		public double TerminalOpacityFloat {
			get {
				return (this.TerminalOpacity / 100.0);
			}
			set {
				mutSessionConfig.WaitOne();
				this.TerminalOpacity = ((int)(value * 100)) % 100;
				mutSessionConfig.ReleaseMutex();
			}
		}

		private Int32 miMaxBufferLength;
		public Int32 MaxBufferLength {
			get {
				Int32 iData = 0;
				mutSessionConfig.WaitOne();
				iData = this.miMaxBufferLength;
				mutSessionConfig.ReleaseMutex();

				return iData;
			}
			set {
				mutSessionConfig.WaitOne();
				if(value > 0) {
					this.miMaxBufferLength = value;
				}
				mutSessionConfig.ReleaseMutex();
			}
		}

		public SessionConfigurations() {
			//timestamp
			TimestampIsEnable = false;
			Timestamp = 1;

			//data analyser
			DataAnalyserEnable = false;
			AddrFileAnalyserDescription = "";
			AddrLogFileAnalyser = "";

			//terminal font
			TerminalFont = Properties.Settings.Default.terminalFont;
			TerminalBackground = Properties.Settings.Default.terminalBackground;
			TerminalForeColor = Properties.Settings.Default.terminalForeColor;

			//opacity
			TerminalOpacity = Properties.Settings.Default.terminalOpacity;

			//buffer length
			MaxBufferLength = Int32.MaxValue;

		}



	}
}
