namespace AutonKustannuslaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, muut, energia, pesu, huolto, renkaat, kilometrit, kustannukset;
            laina = double.Parse(lainaTB.Text);
            nesteet = double.Parse(nesteetTB.Text);
            vakuutus = double.Parse(vakuutusTB.Text);
            muut = double.Parse(muutTB.Text);
            energia = double.Parse(energiaTB.Text);
            pesu = double.Parse(pesuTB.Text);
            huolto = double.Parse(huoltoTB.Text);
            renkaat = double.Parse(renkaatTB.Text);
            kilometrit = double.Parse(kilometritCB.Text);
            kustannukset = (laina + nesteet + vakuutus + muut + energia + pesu + huolto + renkaat) / (kilometrit / 12);
            kustannuksetLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
        }
    }
}