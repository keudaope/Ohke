using System.Data;
namespace Pankkitili
{
    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;
        private Pankkitili() { } // Oletuskonstruktori
                                 // Ylikuormitettu konstructori:
        public Pankkitili(string asNimi, double saldo)
        {
            m_asiakkaanNimi = asNimi;
            m_saldo = saldo;
        }
        // Getterit
        public String AsiakkaanNimi 
        { 
            get 
            { 
                return m_asiakkaanNimi;
            } 
        }
        public double Saldo 
        { 
            get 
            { 
                return m_saldo; 
            } 
        }
        // Tehdään metodit otolle ja panolle
        public void Otto(double summa)
        {
            // Huom! Jos tulee vain 1 rivi if lauseen sisään, { } voi jättää pois
            if (summa > m_saldo || summa < 0)
                throw new ArgumentOutOfRangeException("summa");
            m_saldo -= summa; // tässä vaiheessa väärä koodi
        }
        public void Pano(double summa)
        {
            if (summa < 0)
                throw new ArgumentOutOfRangeException("summa");
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
