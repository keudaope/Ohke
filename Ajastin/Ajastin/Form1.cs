namespace Ajastin
{
    public partial class Form1 : Form
    {
        private int kokonaisaika;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            stopBT.Enabled = true;
            if (aikaLB.Text != "00:00")
            {
                string[] aika = aikaLB.Text.Split(':');
                //MessageBox.Show(aika[0] + ":" + aika[1]);
                int min = int.Parse(aika[0]);
                int sek = int.Parse(aika[1]);
                kokonaisaika = (min * 60) + sek;
                //timer1.Enabled = true;
            }
            else
            {
                int minuutit = int.Parse(minCB.SelectedItem.ToString());
                int sekunnit = int.Parse(SekCB.SelectedItem.ToString());
                kokonaisaika = (minuutit * 60) + sekunnit;
            }
            timer1.Enabled = true;
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            stopBT.Enabled = false;
            kokonaisaika = 0;
            timer1.Enabled = false;
            //aikaLB.Text = "00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopBT.Enabled = false;
            for(int i = 0; i < 60; i++)
            {
                minCB.Items.Add(i); 
                SekCB.Items.Add(i);
            }
            minCB.SelectedIndex = 0;
            SekCB.SelectedIndex = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Aikasi loppui");
            }
        }
    }
}