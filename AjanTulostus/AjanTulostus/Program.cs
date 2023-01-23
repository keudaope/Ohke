using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //AjanLaskenta();
        Console.Write("Anna kortin numeerinen arvo: ");
        int arvo = int.Parse(Console.ReadLine());
        string tulostus = Korttipakka(arvo);
        Console.WriteLine(tulostus);    
    }
    static void AjanLaskenta()
    {
        for (int tunnit = 0; tunnit < 24; tunnit++)
        {
            for (int minuutit = 0; minuutit < 60; minuutit++)
            {
                for (int sekunnit = 0; sekunnit < 60; sekunnit++)
                {
                    Console.WriteLine("{0}:{1}:{2}", tunnit, minuutit, sekunnit);
                }

            }
        }
    }
    static string Korttipakka(int luku)
    {
        switch(luku)
        {
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return luku.ToString();
                break;
            case 1:
                return "A";
                break;
            case 11:
                return "J";
                break;
            case 12:
                return "Q";
                break;
            case 13:
                return "K";
                break;
            default:
                return "Annoit luvun, jota ei ole korttipakassa";
                break;
        }
    }
}