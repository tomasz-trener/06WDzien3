using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14TablicePostrzepione
{
    class Program
    {
        static void Main(string[] args)
        {

            // tablica postrzepiona (jagged array)
            // zwana też tablica tablica 

            string[] tab = new string[3];

            string[][] tab2 = new string[3][];

            tab2[0] = new string[2] { "01", "02" };
            tab2[1] = new string[] { "03", "04", "05" };
            tab2[2] = new string[] { "06" };

            int dlugoscTab = tab2.Length;// 3
            int dl = tab2[1].Length; //3

            Console.WriteLine(tab2[1][2]);

            for (int i = 0; i < tab2.Length; i++)
            {
                for (int j = 0; j < tab2[i].Length; j++)
                    Console.Write(tab2[i][j] + " " );
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
