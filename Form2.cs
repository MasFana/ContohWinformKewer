using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohWinform2
{
	public partial class Form2 : Form
	{
		string Username;
		public Form2(string Username)
		{	
			this.Username = Username;
			InitializeComponent();
			LabelUsername.Text = Username;
		}
		
	}
}
