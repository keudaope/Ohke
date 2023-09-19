using Microsoft.VisualBasic.ApplicationServices;
using NopanHeitto.Properties;

namespace NopanHeitto
{
    public partial class NopanHeittoFM : Form
    {
        int noppaArvo01, noppaArvo02;
        public NopanHeittoFM()
        {
            InitializeComponent();
            
        }

        private void heitaBT_Click(object sender, EventArgs e)
        {
            noppaArvo01 = piirraNoppa(Noppa01PB);
            Thread.Sleep(50);
            noppaArvo02 = piirraNoppa(Noppa02PB);
            MessageBox.Show(noppaArvo01 + " " + noppaArvo02);
        }
        private int piirraNoppa(PictureBox NoppaBox)
        {
            Random satu = new Random();
            int noppa = satu.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    NoppaBox.Image = Image.FromFile("..\\Resources\\dice01.png");
                    return 1;
                    break;
                case 2:
                    NoppaBox.Image = Image.FromFile("..\\Resources\\dice02.png");
                    return 2;
                    break;
                case 3:
                    NoppaBox.Image = Image.FromFile("..\\Resources\\dice03.png");

                    return 3;
                    break;
                case 4:
                    NoppaBox.Image = Image.FromFile("..\\Resources\\dice04.png");
                    return 4;
                    break;
                case 5:
                    NoppaBox.Image = Image.FromFile("..\\Resources\\dice05.png");
                    return 5;
                    break;
                case 6:
                    NoppaBox.Image = Image.FromFile("..\\Resources\\dice06.png");
                    return 6;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}