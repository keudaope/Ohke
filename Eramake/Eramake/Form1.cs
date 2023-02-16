namespace Eramake
{
    public partial class SalausFM : Form
    {
        public SalausFM()
        {
            InitializeComponent();
        }

        private void ECBT_Click(object sender, EventArgs e)
        {
            ECTB.Text = Eramake.eCryptography.Encrypt(merkkijonoTB.Text);
        }

        private void DCBT_Click(object sender, EventArgs e)
        {
            DCTB.Text = Eramake.eCryptography.Decrypt(ECTB.Text);
        }
    }
}