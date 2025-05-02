namespace ContohWinform2
{
    public partial class Form1 : Form
    {
        private string Username;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            LabelAtas.Text = textBox1.Text;
            if (textBox1.Text.Length <= 0)
            {
                LabelAtas.Text = "Username Cuy";
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text.Trim();
            string Admin = "Fahmi";

            if (string.IsNullOrEmpty(Username))
            {
                Random random = new Random();
                int maxX = this.ClientSize.Width - Submit.Width;
                int maxY = this.ClientSize.Height - Submit.Height;
                Submit.Location = new Point(random.Next(0, maxX), random.Next(0, maxY));
            }
            else
            {
                if (Username == Admin)
                {
                    MessageBox.Show("Hai Fahmi si Admin");
                }
                else
                {
                    MessageBox.Show($"Hai {Username} si budak!", "Fahmi");
                }

                Form2 form2 = new Form2(Username);
                form2.Show();
                this.Hide();
            }
        }
    }
}
