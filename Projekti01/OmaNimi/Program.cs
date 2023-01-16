internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.Write("Anna etunimesi: ");
        string enimi = Console.ReadLine();
        Console.Write("Anna sukunimesi: ");
        string snimi = Console.ReadLine();
        Console.WriteLine("Heippa," + enimi + " " + snimi);
        Console.WriteLine("Heippa {0} {1}", enimi, snimi);*/
        var suomi = new System.Globalization.CultureInfo("fi-FI");
        DateTime nyt = DateTime.Now;
        suomi.DateTimeFormat.Calendar = new System.Globalization.GregorianCalendar();
        Console.WriteLine(nyt.ToString(suomi));

        string aika = nyt.ToString("hh:mm tt");
        string paiva = nyt.ToString("dd.MM.yyyy");
        Console.WriteLine(paiva.ToString() + " " + aika.ToString());

        // Laske neliöjuuri luvusta 50
        int luku = 50;
        float neliojuuri = (float)Math.Sqrt(luku);
        Console.WriteLine("Neliöjuuri luvusta {0} on {1}", luku, neliojuuri.ToString());

    }

}