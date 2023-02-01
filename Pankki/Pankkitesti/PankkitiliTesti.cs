using Pankki;
namespace Pankki
{
    
    [TestClass]
    public class PankkitiliTesti
    {

        [TestMethod]
        public void Otto_OikeallaSummalla_PaivitaSalda()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            PankkitiliTesti tili = Pankki.Pankkitili("Jaakko Tarvainen", alkusaldo);
        }
    }
}