using Pankki;
namespace Pankkitilitesti
{
    [TestClass]
    public class Pankkitilitesti
    {
        [TestMethod]
        public void TestMethod1()
        {
            float alkusaldo = 11.99f;
            float ottoSumma = 4.55f;
            float oletettu = 7.44f;

            Pankkitili pt = new Pankki.Pankkitili("Jaakko Tarvainen", alkusaldo);
            pt.Otto(ottoSumma);
            Assert.AreEqual(oletettu, pt.Saldo, 0.001, "Jotain m‰t‰‰ Tanskanmaalla");
        }
    }
}