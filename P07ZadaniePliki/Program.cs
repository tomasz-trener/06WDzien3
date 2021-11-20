using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadaniePliki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj sciezke do pliku");
            string sciezka = Console.ReadLine();
            Console.WriteLine("Podaj szukany wyraz");
            string wyraz = Console.ReadLine().ToLower();

            string dane = File.ReadAllText(sciezka).ToLower();

            // preprocessin danych 
            dane = dane.Replace("\r", "");
            dane = dane.Replace("\n", "");

            string[] tablica= dane.Split(' ');

            List<string> znalezioneNapisy = new List<string>();

            for (int i = 0; i < tablica.Length; i++)
                if (tablica[i].Contains(wyraz)) //(tablica[i] == wyraz)
                    znalezioneNapisy.Add(tablica[i]);


            Console.WriteLine(string.Format("Napis {0} występuje {1} razy",wyraz, znalezioneNapisy.Count));

            Console.WriteLine("Znalezione wyrazy:");
            for (int i = 0; i < znalezioneNapisy.Count; i++)
            {
                Console.WriteLine(znalezioneNapisy[i]);
            }


            Console.ReadKey();



        }
    }
}
