namespace Tehtava3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double luku1 = 0;
            double luku2 = 0;
            alku:
            try
            {
                 luku1= double.Parse(luku1TB.Text);
                 luku2 = double.Parse(luku2TB.Text);
            }
            catch (Exception ex)
            {
                vastausLB.Text = ex.ToString();
                vastausLB.Visible = false;  
                luku1TB.Text = "";
                luku2TB.Text = "";
                luku1TB.Focus();
                goto alku;
            }
            
            
            string merkki = laskuCB.Text;
            double vastaus = 0;
            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastausLB.Text = "Virheelliset syötöt";
                    break;
            }
            vastausLB.Text = vastaus.ToString();
            vastausLB.Visible = true;
        }
    }
}