using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj ile osób chcesz przechowywać");
            int ileOsob = Convert.ToInt32(Console.ReadLine());

            string imie1 = "Adam";
            string imie2 = "Ala";
            string imie3 = "Jan";


            string[] tabStringow = new string[ileOsob];

            tabStringow[0] = "Adam";
            tabStringow[1] = imie2;
             

            Console.WriteLine(tabStringow[0]);
            Console.WriteLine(tabStringow[1]);
            Console.WriteLine(tabStringow[2]);

            int dlugoscTablicy = tabStringow.Length;


            int[] tabIntow = new int[4];
            tabIntow[0] = 4;
            //  tabIntow[1] = "ala"; tak zrobić nie mogę ! nie mogę mieszać typów !!

            tabIntow[dlugoscTablicy-1] = 5; // numeracja od 0 

            // sytaucje , kiedy tablice nam się nie przydadza:
            // 1) gdy nie chcamy aby po uruchomieniu programu ktoś wprost okreslał długośc tablicy 
            // 2) gdy w trakcie działania programu chcemy zmienić długość zbioru danych 

            // rozwiązanie tych probemów to listy .


            Console.ReadKey();

        }
    }
}
