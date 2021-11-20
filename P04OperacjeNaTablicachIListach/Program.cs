using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04OperacjeNaTablicachIListach
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";

            string[] tablica = napis.Split(' '); // przekształcenie stringa na tablice 


            // teraz mamy tablice i chcemy z tej tablicy zrobić złoczny string (operacja odwrotna)

            string napis2= string.Join("*", tablica);


            // (prawie) dokładnie  tak samo działa z listami 

            //na szczeście istnieje bardzo wyodny sposób na przekształcenie tablicy na liste i odwrotnie ;

            List<string> lista= napis.Split(' ').ToList();

            string napis3 = string.Join("*", lista.ToArray());

            // zmiana tablicy na lite 

            List<string> innyPrzyklad = tablica.ToList();


        }
    }
}
