using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13TabiceWielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // najczęściej 1-dymiarowe tablice 
            // rzadko korzystamy z tab 2-wym
            // z tab 3-wym praktycznie wcale (w przypadkach typowych aplikacji bizesnowych) 
            //  w wyjątkiem badań naukowych ....

            string[] tabJednoWym = new string[3];

            string[,] tabDwuWym = new string[3, 4];

            string[,,] tabTrzyWym = new string[3, 4, 2];

            tabDwuWym[0, 0] = "01";
            tabDwuWym[1, 0] = "02";
            tabDwuWym[2, 0] = "03";

            tabDwuWym[0, 1] = "04";
            tabDwuWym[1, 1] = "05";
            tabDwuWym[2, 1] = "06";

            tabDwuWym[0, 2] = "07";
            tabDwuWym[1, 2] = "08";
            tabDwuWym[2, 2] = "09";

            tabDwuWym[0, 3] = "10";
            tabDwuWym[1, 3] = "11";
            tabDwuWym[2, 3] = "12";


            int dlugosc = tabDwuWym.Length; // 12 
            int dlWym1 = tabDwuWym.GetLength(0); //3 
            int dlWym2 = tabDwuWym.GetLength(1); //4

            for (int i = 0; i < dlWym2; i++)
            {
                for (int j = 0; j < dlWym1; j++)
                    Console.Write(tabDwuWym[j,i] +  " ");
                
                Console.WriteLine();
            }

            Console.WriteLine("-------" );
            for (int i = 0; i < dlWym1; i++)
            {
                for (int j = 0; j < dlWym2; j++)
                    Console.Write(tabDwuWym[i, j] + " ");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
