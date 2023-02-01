
using Pankki;
namespace PankkitiliTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ottotesti()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            Pankkitili tili = new Pankkitili("Jaakko Parantainen", alkusaldo);
            tili.Otto(ottoSumma);
            double todellinen = tili.Saldo;

            // Vertailu
            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei onnistunut");

        }
    }
}