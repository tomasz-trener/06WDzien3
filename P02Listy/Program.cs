using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listy działaja podobnie jak tablice tylko nie mają ograniczeń, wcześniej wskazanych.

            // kiedy tworze listę:

            string[] tabStringow = new string[4];

            List<string> listaStringow = new List<string>();

            int dlugoscListy = listaStringow.Count; // teraz jest 0 


            listaStringow.Add("adam");
            listaStringow.Add("ala");
            listaStringow.Add("Jan");


            // metoda add dodaje na koniec listy 

            listaStringow.Insert(0, "ola");
            listaStringow.Insert(2, "tomasz");


        }
    }
}
