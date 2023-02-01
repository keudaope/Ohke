using System.Data;

namespace Pankki
{
    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        public Pankkitili() { }
        public Pankkitili(string nimi, double summa)
        {
            m_asiakkaanNimi = nimi;
            m_saldo = summa;
        }
        public double Saldo { get { return m_saldo; } }
        public string Nimi { get { return m_asiakkaanNimi; } }      

        public void Otto(float summa)
        {
            if (summa > m_saldo || summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo -= summa;
        }
        public void Pano(float summa)
        {
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }


        private static void Main(string[] args)
        {
            Pankkitili pankkitili = new Pankkitili("Jyri Lindroos", 1023.55);
            pankkitili.Pano(300);
            pankkitili.Otto(55.44f);
            Console.WriteLine(pankkitili.Saldo);
        }
    }
}
