using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieListy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj imiona");

            // for, while , "do while" 

            List<string> imiona = new List<string>();


            do
            {
                string wczytaneImie = Console.ReadLine();
                if (wczytaneImie != "koniec")
                    imiona.Add(wczytaneImie);
                else // jezeli jednak zostało podane "koniec"  wtedy musze zakonczyc dzialanie petli 
                    break;
            } while (true);


            for (int i = 0; i < imiona.Count; i++)
            {
                string wynik = imiona[i] + " (" + imiona[i].Length + ")";
                Console.WriteLine(wynik);
            }

            Console.ReadKey();


        }
    }
}
