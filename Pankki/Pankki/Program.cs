
using System.Xml.Serialization;
namespace Pankki
{
        public class Pankkitili
        {
            private readonly string m_asiakkaanNimi;
            private double m_saldo;
            private Pankkitili() { }
            public Pankkitili(string asiakkaanNimi, double saldo)
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
                m_saldo -= summa;
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
            Pankkitili pt = new Pankkitili("Jyri Lindroos", 1205.53);
            pt.Pano(300);
            pt.Otto(52.44);
            Console.WriteLine("Nykyinen saldo on {0} euroa", pt.Saldo);
        }
    } 
    
}
