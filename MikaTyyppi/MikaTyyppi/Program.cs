internal class Program
{
    private static void Main(string[] args)
    {
        hyppy:
        Console.WriteLine("Millaisen arvon haluat syöttää (double = d; int = i; string = s)? ");
        string arvo = Console.ReadLine();
        arvo = arvo.ToLower();
        switch(arvo)
        {
            case "d":
                Console.Write("Anna doubleluku: ");
                double tupla = double.Parse(Console.ReadLine());
                tupla += 1;
                Console.WriteLine(tupla);
                break;
            case "i":
                Console.Write("Anna kokonaisluku: ");
                int kluku = int.Parse(Console.ReadLine());
                kluku += 1;
                Console.WriteLine(kluku);
                break;
            case "s":
                Console.Write("Anna merkkijono: ");
                string mjono = Console.ReadLine();
                mjono += "*";
                Console.WriteLine(mjono);
                break;
            default:
                Console.WriteLine("Antamasi arvo ei ollut d / i tai s");
                goto hyppy;
                break;
        }
        Console.Write("Haluatko jatkaa (k / e)?");
        string jatko = Console.ReadLine();
        jatko = jatko.ToLower();
        if(jatko == "k")
        {
            goto hyppy;
        }
    }
}