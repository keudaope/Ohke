namespace Muistio
{
    public partial class muistioFM : Form
    {
        public muistioFM()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\paivakirja.txt");
            tekstiTB.Text = teksti;
        }

        private void tallennaBT_Enter(object sender, EventArgs e)
        {

        }

        private void tekstiTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string teksti = "";
                teksti += tekstiTB.Text;
                teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
                TextWriter text = new StreamWriter("C:\\paivakirja.txt");
                text.WriteLine(teksti);
                text.Close();
                Application.Exit();

            }
        }
    }
}