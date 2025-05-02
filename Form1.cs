namespace ContohWinform2
{
	public partial class Form1 : Form
	{
		private string Username;
		private string Admin = "Pak Fahroby";
		public Form1()
		{
			InitializeComponent();
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Username = textBox1.Text;

			LabelAtas.Text = Username;
			if (textBox1.Text.Length <= 0)
			{
				LabelAtas.Text = "Username Harus Diisi Cuy";
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Username.Length > 0)
			{
				if (Username == Admin)
				{
					Form FormDashboard = new Form2(Username);
					FormDashboard.ShowDialog();
				}
				else
				{
					MessageBox.Show("Kamu Bukan Fana");
				}
			}
		}
	}
}
