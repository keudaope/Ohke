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
<<<<<<< HEAD
            if(naytaCB.Checked) {
=======
            if(naytaCB.Checked)
            {
>>>>>>> 061cb6d1642fc0b8cdfafaced434cc047cad4a85
                salasanaTB.PasswordChar = '\0';
            }
            else
            {
                salasanaTB.PasswordChar = '*';
            }
<<<<<<< HEAD
            
=======

>>>>>>> 061cb6d1642fc0b8cdfafaced434cc047cad4a85
        }
    }
}