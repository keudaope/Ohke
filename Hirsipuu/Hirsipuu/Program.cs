internal class Program
{
    private static void Main(string[] args)
    {
        


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // valitaan sana metodin avulla
            string sana = ValitseSana();
            // Luodaan pelialusta, eli tyhjien kirjaimien tilalle _
            string vihjesana = TeeTyhjaSana(sana);
            /* Varsinainen pelilogiikka, jolle annetaan
               - arvottu sana
               - vihjesana (tähän asti)
               - arvotun sanan ensimmäinen kirjain
               - arvausten lukumäärä */
            HirsipuuSana(sana, vihjesana, sana[0], 5);
       
        // Metodi, joka arpoo peliin arvattavan sanan
        
        // Kopio loppuu

    }
    static string ValitseSana()
    {
        List<string> lista = new List<string>();
        string jatko;
        int arvonta;
        foreach (string sana in System.IO.File.ReadLines(@"c:\sanalista.txt"))
        {
            lista.Add(sana);
        }
    alusta:
        Random satluku = new Random();
        arvonta = satluku.Next(0, lista.Count - 1);
        string arvottuSana = lista[arvonta];
        Console.WriteLine(arvottuSana);
        Console.Write("Haluatko jatkaa (k/e)? ");
        jatko = Console.ReadLine();
        if (jatko == "k")
        {
            goto alusta;
        }
    }
    // Metodi, joka tekee hirsipuuvihjeen, eli esim. h_ _ _ _ _ _ _ (hirsipuu)
    static string TeeTyhjaSana(string sana)
    {
        return new string('_', sana.Length);
    }
    // Varsinainen pelilogiikkametodi
    static void HirsipuuSana(string sana, string vihjeTahanAsti, char kirjain, int arvauksiaJaljella)
    {
        bool vaaraArvaus = true; // Määritetään oletukseksi, että arvaus on väärä
                                 // Käydään läpi sana ja verrataan sitä annettuun kirjaimeen (kts. lopusta)
        for (int i = 0; i < sana.Length; i++)
        {
            // Jos annettu kirjain löydetään sanasta
            if (sana[i] == kirjain)
            {
                // Luodaan taulukko, johon muutetaan tähän asti oleva vihje Chariksi
                char[] taulukkoTahanAsti = vihjeTahanAsti.ToCharArray();
                // Lisätään arvattu kirjain oikeaan paikkaan
                taulukkoTahanAsti[i] = kirjain;
                // Muunnetaan takaisin stringiksi
                vihjeTahanAsti = new string(taulukkoTahanAsti);
                // Määritetään oletukseksi, että arvaus oli oikein
                vaaraArvaus = false;
            }
        }
        // Jos arvaus oli väärin
        if (vaaraArvaus)
        {
            arvauksiaJaljella--;
            Console.WriteLine("Väärin! Arvauksia jäljellä: " + arvauksiaJaljella);
        }
        Console.WriteLine("Tähän asti olet saanut selville: " + vihjeTahanAsti);
        // Jos arvattava sana on arvattu
        if (sana == vihjeTahanAsti)
        {
            Console.WriteLine("Mahtavaa! Löysit kaikki kirjaimet");
        }
        // Jos arvauksia ei ole enää jäljellä
        else if (arvauksiaJaljella == 0)
        {
            Console.WriteLine("Voi ei, hävisit ja jouduit hirteen");
        }
        // Muussa tapauksessa peli jatkuu
        else
        {
            Console.Write("Arvaa kirjain: ");
            // Luetaan char-muuttujaan käyttäjän arvaus
            char seuraavaKirjain = Console.ReadLine()[0];
            // Käynnistetään pelimoottori
            HirsipuuSana(sana, vihjeTahanAsti, seuraavaKirjain, arvauksiaJaljella);
        }
    }
}