﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADCom {
	public partial class SerialPortConfiguration : Form {
		public SerialPortConfiguration() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {

		}

		//public fConfigConnexion() {
		//	InitializeComponent();
		//}

		//private void button1_Click(object sender, EventArgs e) {
		//	SerialPortConfiguration teste = new SerialPortConfiguration();
		//	teste.Show();
		//}

		//private void CongigConnexion_Load(object sender, EventArgs e) {
		//	getSerialPorts();
		//}

		//private void getSerialPorts() {
		//	this.pbStartConnexion.Enabled = true;
		//	//string[] sTabPortsName = null;
		//	//SerialPort serialPortTstConnexion = new SerialPort();
		//	//SerialPortState spState = new SerialPortState();

		//	//cbListOfPorts.Items.Clear();

		//	////mis à jours de l'interface utilisateur
		//	//this.gbConfigPort.Enabled = false;
		//	//this.pbStartConnexion.Enabled = false;
		//	////this.pbDeletConfig.Enabled = false;

		//	////this.pbSavConfig.Enabled = true;

		//	//try {
		//	//	sTabPortsName = SerialPort.GetPortNames();
		//	//} catch (Exception exception) {
		//	//	MessageBox.Show("Erreur détéctée lors de l'analyse des ports : " + exception.ToString(), "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		//	//}



		//	//if (sTabPortsName.Length > 0) {
		//	//	foreach (String sPortName in sTabPortsName) {

		//	//		spState = new SerialPortState(sPortName);
		//	//		try {
		//	//			serialPortTstConnexion = new SerialPort();
		//	//			serialPortTstConnexion.PortName = sPortName;
		//	//			serialPortTstConnexion.Open();
		//	//			serialPortTstConnexion.Close();
		//	//			serialPortTstConnexion.Dispose();
		//	//		} catch (UnauthorizedAccessException unauthorizedAccessException) {
		//	//			spState = new SerialPortState(sPortName, -1);
		//	//		} catch {
		//	//			spState = new SerialPortState(sPortName, -2);
		//	//		}

		//	//		try {
		//	//			//this.cbListOfPorts.Items.Add(spState.ToString());
		//	//			this.cbListOfPorts.Items.Add(spState);
		//	//		} catch (Exception exception) {
		//	//			MessageBox.Show("Erreur détécté lors de l'enregistrement des nouveaux ports : " + exception.ToString(), "Enregistrement des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		//	//		}
		//	//	}

		//	//	this.cbListOfPorts.SelectedIndex = 0;



		//	//} else {
		//	//	MessageBox.Show("Erreur lors de la détection des ports. Veuillez réitérer.", "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		//	//}

		//	//this.gbConfigPort.Enabled = true;
		//}

		//private void cbListOfPorts_SelectedIndexChanged(object sender, EventArgs e) {

		//}

		//private void pbRefreshPort_Click(object sender, EventArgs e) {
		//	this.getSerialPorts();
		//}

		//private void cbListOfPorts_SelectedIndexChanged_1(object sender, EventArgs e) {

		//}
	}
}
