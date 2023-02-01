namespace WinFormsApp1
{
    public partial class SalasanaFM : Form
    {
        public SalasanaFM()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (kayttajaTB.Text == "Jyri" && salasanaTB.Text == "salasana")
                {
                    panel2.Visible = true;
                    panel1.Visible = false;
         
                }
                else
                {
                    virheLB.Text = "K‰ytt‰j‰tunnus tai salasana v‰‰rin";
                    virheLB.Visible = true;
                    virheLB.ForeColor = Color.Red;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void naytaCB_CheckedChanged(object sender, EventArgs e)
        {
            if(naytaCB.Checked) {
                salasanaTB.PasswordChar = '\0';
            }
            else
            {
                salasanaTB.PasswordChar = '*';
            }
            
        }
    }
}