using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj równanie matmatyczne");

            string rownanie = Console.ReadLine();

            rownanie= rownanie.Replace(" ", "");

            string[] tab1=  rownanie.Split('+');
            string[] tab2 = rownanie.Split('-');
            string[] tab3 = rownanie.Split('*');
            string[] tab4 = rownanie.Split('/');



            if(tab1.Length == 2)
                Console.WriteLine(Convert.ToInt32(tab1[0]) + Convert.ToInt32(tab1[1]));

            if (tab2.Length == 2)
                Console.WriteLine(Convert.ToInt32(tab2[0]) - Convert.ToInt32(tab2[1]));

            if (tab3.Length == 2)
                Console.WriteLine(Convert.ToInt32(tab3[0]) * Convert.ToInt32(tab3[1]));

            if (tab4.Length == 2)
                Console.WriteLine(Convert.ToInt32(tab4[0]) / Convert.ToInt32(tab4[1]));


            //if (rownanie.Contains("+"))
            //{

            //}
            //if (rownanie.Contains("-"))
            //{

            //}




            Console.ReadKey();
        }
    }
}
