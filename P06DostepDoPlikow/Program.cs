using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06DostepDoPlikow
{
    class Program
    {
        static void Main(string[] args)
        {
            // do tej pory console to była jedyna opcja wczytwania danych 

            // od tego momentu bedziemy potrafili wczytywac dane z pliku

           // Console.WriteLine("c:\\nane\\napis.txt");

            string napis=  File.ReadAllText(@"c:\dane\napis.txt");

            Console.WriteLine(napis);

            //string[] tab = napis.Split('\n');

            string[] tabPomocnicza = new string[1];
            tabPomocnicza[0] = "\r\n";


            string[] tab = napis.Split(tabPomocnicza,StringSplitOptions.RemoveEmptyEntries);

            Console.ReadKey();
        }
    }
}
