using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace PhanGiaiTenMienVaDiaChiIP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnResolve_Click(object sender, EventArgs e)
		{
			string ip = txtIP.Text;
			IPHostEntry iphe = Dns.Resolve(ip); //Phan giai IP
			txtHostName.Text = iphe.HostName;
			foreach (string s in iphe.Aliases)
				listBoxIPAddress.Items.Add(s);
			foreach (IPAddress a in iphe.AddressList)
				listBoxAlias.Items.Add(a.ToString());
		}
	}
}
