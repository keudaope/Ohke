using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //AjanLaskenta();
        /*Console.Write("Anna kortin numeerinen arvo: ");
         int arvo = int.Parse(Console.ReadLine());
         string tulostus = Korttipakka(arvo);
         Console.WriteLine(tulostus);    */
        LuvunToisto();
    }

    static void LuvunToisto()
    {
    hyppy:
        int luku;
        Console.Write("Anna toistettava luku: ");
        try
        {
            luku = int.Parse(Console.ReadLine());
        }
        catch (Exception joulupukki)
        {
            Console.WriteLine(joulupukki.Message);
            Console.WriteLine("Antamasi numero ei ole kokonaisluku!");
            goto hyppy;
        }
        for(int i = 0; i < luku; i++)
        {
            for(int j = 0; j < luku; j++)
            {
                Console.Write(luku + " ");
            }
            Console.WriteLine();
            for(int k = 0; k < luku; k++)
            {
                Console.Write(luku);
            }
            Console.WriteLine();
        }
        


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