using System.Xml.Serialization;
namespace Bank
{
    public class BankAccount
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;
        private BankAccount() { }
        public BankAccount(string asiakkaanNimi, double saldo)
        {
            m_asiakkaanNimi = asiakkaanNimi;
            m_saldo = saldo;
        }
        public string AsiakkaanNimi
        {
            get { return m_asiakkaanNimi; }
        }
        public double Saldo
        {
            get { return m_saldo; }
        }
        public void Otto(double summa)
        {
            if (summa > m_saldo)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }
        public void Pano(double summa)
        {
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }
        private static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Jyri Lindroos", 1205.53);
            ba.Pano(300);
            ba.Otto(52.44);
            Console.WriteLine("Kykyinen saldo on {0} euroa", ba.Saldo);
        }
    }
}
