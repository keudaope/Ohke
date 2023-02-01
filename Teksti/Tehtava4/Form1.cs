namespace Tehtava4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = dateTimeDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Floor((nyt - synttari).TotalDays);
            paivatLB.Text = erotus.ToString();
            paivatLB.Visible = true;
        }
    }
}