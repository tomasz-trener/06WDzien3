using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();

                //  string url = $"https://www.google.com/search?q=pogoda+{miasto}";
                string url = "https://www.google.com/search?q=pogoda+"+miasto;
                
                char znak = '°';

                string dane = new WebClient().DownloadString(url);

                // szuakmy pozycji tego znaku
                int idx = dane.IndexOf(znak);
                int aktualnyIdx = idx - 1;
                while (dane[aktualnyIdx] != '>')
                    aktualnyIdx--;

                string wynik = dane.Substring(aktualnyIdx + 1, idx - aktualnyIdx + 1);
                Console.WriteLine(wynik);
            }
           
             

        }
    }
}
