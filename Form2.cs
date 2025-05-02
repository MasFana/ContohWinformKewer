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
            InitializeComponent();
            this.FormClosed += Form2_FormClosed;

            this.Username = Username;
            LabelNama1.Text = Username;
            LabelNama2.Text = Username;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
