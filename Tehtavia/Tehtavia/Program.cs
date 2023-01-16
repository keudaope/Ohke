using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 1
            Console.WriteLine("Hei maailma!");

            // Tehtävä 2
            int a2 = 1, b2 = 2, c2;
            c2 = a2 + b2;
            Console.WriteLine(c2);

            //Tehtävä 3
            int a3 = 1, b3 = 2, c3;
            c3 = a3 - b3;
            Console.WriteLine(c3);

            //Tehtävä 4
            int a4 = 1, b4 = 2, c4;
            c4 = a4 * b4;
            Console.WriteLine(c4);

            //Tehtävä 5
            float a5 = 9, b5 = 2, c5;
            c5 = a5 / b5;
            Console.WriteLine(c5);

            // Celsiukset Fahrenheiteiksi Tehtävä 6
            float cel = 27, fah;
            fah = cel * 9 / 5 + 32;
            Console.WriteLine(fah);

            // Fahrenheitit Celsiuksiksi Tehtävä 7
            float cel7, fah7 = 80.6F;
            cel7 = (fah7 - 32) * 5 / 9;
            Console.WriteLine(cel7);

            // Mailit kilometreiksi Tehtävä 8
            float maili = 100, km;
            km = maili * 1.609F;
            Console.WriteLine(km);

            // Kilometrit maileiksi Tehtävä 9
            float km9 = 160, maili9;
            maili9 = km9 / 1.609F;
            Console.WriteLine(maili9);

            // Tuumat senteiksi Tehtävä 10
            float inch10 = 3, sen10;
            sen10 = inch10 * 2.54F;
            Console.WriteLine(sen10);

            // Sentit tuumiksi Tehtävä 11
            float inch11, sen11 = 8;
            inch11 = sen11 / 2.54F;
            Console.WriteLine(inch11);

            // Yardit metreiksi Tehtävä 12
            float yard12 = 50, m12;
            m12 = yard12 * 0.9144F;
            Console.WriteLine(m12);

            // Metrit yardeiksi Tehtävä 13
            float yard13, m13 = 50;
            yard13 = 50 / 0.9144F;
            Console.WriteLine(yard13);

            // Tehtävät 2-5 uusiksi kysymyksillä Tehtävä 14
            int a14, b14, c14; // Yhteenlaskua varten
            int a15, b15, c15; // Vähennyslaskua varten
            int a16, b16, c16; // Kertolaskua varten
            float a17, b17, c17; // Jakolaskua varten

            // Yhteenlasku
            Console.Write("Anna ensimmäinen yhteenlaskettava: ");
            a14 = Int32.Parse(Console.ReadLine());
            Console.Write("Anna toinen yhteenlaskettava: ");
            b14 = Int32.Parse(Console.ReadLine());
            c14 = a14 + b14;
            Console.WriteLine(c14);

            // Vähennyslasku
            Console.Write("Anna vähennettävä: ");
            a15 = Int32.Parse(Console.ReadLine());
            Console.Write("Anna vähentäjä: ");
            b15 = Int32.Parse(Console.ReadLine());
            c15 = a15 - b15;
            Console.WriteLine(c15);

            // Kertolasku
            Console.Write("Anna kerrottava: ");
            a16 = Int32.Parse(Console.ReadLine());
            Console.Write("Anna kertoja: ");
            b16 = Int32.Parse(Console.ReadLine());
            c16 = a16 * b16;
            Console.WriteLine(c16);

            // Jakolasku
            Console.Write("Anna jaettava: ");
            a17 = Int32.Parse(Console.ReadLine());
            Console.Write("Anna toinen yhteenlaskettava: ");
            b17 = Int32.Parse(Console.ReadLine());
            c17= a17 / b17;
            Console.WriteLine(c17);

        }
    }
}
