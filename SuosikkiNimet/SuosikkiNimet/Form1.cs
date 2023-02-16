using System.IO;
using System.Windows.Forms;

namespace SuosikkiNimet
{
    public partial class suosikkiFM : Form
    {
        public suosikkiFM()
        {
            InitializeComponent();
            vastausLB.Visible = false;
        }

        private void tarkastaBT_Click(object sender, EventArgs e)
        {
            string[] pojat = File.ReadAllLines("C:\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\tytot.txt");
            string nimi = nimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach(string joulupukki in pojat)
            {
                if(nimi.ToUpper() == joulupukki.ToUpper())
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ". suosituin pojannimi";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string joulupukki in tytot)
            {
                if (nimi == joulupukki)
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ". suosituin tytönimi";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }
            if(vastausLB.Visible == false)
            {
                vastausLB.Text = "Nimeäsi ei löytynyt suosituinpien nimien joukosta"; ;
                vastausLB.Visible = true;
            }
        }
    }
}