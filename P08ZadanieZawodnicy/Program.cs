using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = @"c:\dane\";

            Console.WriteLine("Podaj kraj");

            string kraj = Console.ReadLine().ToLower();

            string[] wiersze= File.ReadAllLines(sciezka + "zawodnicy.txt");

            List<string> imionaINazwiska = new List<string>();

            for (int i = 0; i < wiersze.Length; i++)
            {
                string[] komorki= wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                    imionaINazwiska.Add(komorki[2] + " " + komorki[3]);
            }

            //string nazwaPliku = $"{sciezka}{kraj}.txt";
            string nazwaPliku = sciezka + kraj +".txt";
            File.WriteAllLines(nazwaPliku, imionaINazwiska);

        }
    }
}
