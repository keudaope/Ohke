using System.Diagnostics;
namespace Sekkari
{
    public partial class sekkariFM : Form
    {
        /* Tässä korjattu osuus, alustettu sekkari */
        private Stopwatch sekkari = new Stopwatch();
        /* Tähän loppuu korjattu osuus */
        public sekkariFM()
        {
            InitializeComponent();
        }

        private void kaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void pysaytaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void nollaaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            kelloLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}