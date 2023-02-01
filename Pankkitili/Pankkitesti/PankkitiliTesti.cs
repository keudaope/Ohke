using Pankkitili;
namespace PankkitiliTesti
{
    [TestClass]
    public class PankkitiliTesti
    {
        [TestMethod]
        public void OttoOikeallaSummallaPaivitaSaldo()
        {
            // Alkuvalmistelut
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            Pankkitili.Pankkitili tili = new Pankkitili.Pankkitili("Jaakko Tarvainen", alkusaldo);
            // Toiminta
            tili.Otto(ottoSumma);
            // Oletettu lopputulos
            double todellinen = tili.Saldo;
            // Testaus
            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei onnistunut!");
        }
    }
}