using Bank;
namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            BankAccount tili = new BankAccount("Jaakko Tarvainen", alkusaldo);
            tili.Otto(ottoSumma);
            double todellinen = tili.Saldo;
            Assert.AreEqual(oletettu, todellinen, 0.001, "Jotain m‰t‰‰ Tanskan maalla");
        }
    }
}