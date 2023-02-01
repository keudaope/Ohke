namespace LukujenJarjestys
{
    public partial class LuvutFM : Form
    {
        public LuvutFM()
        {
            InitializeComponent();
        }

        List<int> jono = new List<int>();
        private void lukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == (char)Keys.Enter)
            { 
                if(lukuTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);

                    foreach(var jasen in taulukko)
                    {
                        vastausLB.Text += jasen + " ";
                    }
                    vastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(lukuTB.Text));
                    lukuTB.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            lukuTB.Text = "";
        }
    }
}