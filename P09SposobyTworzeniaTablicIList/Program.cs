using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09SposobyTworzeniaTablicIList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab1 = new string[2];
            tab1[0] = "ala";
            tab1[1] = "jan";

            string[] tab2 = new string[2] { "ala", "jan" };

            string[] tab3 = new string[] { "ala", "jan" };


            List<string> lista1 = new List<string>();
            lista1.Add("ala");
            lista1.Add("jan");

            List<string> lista2 = new List<string>() { "ala", "jan" };




        }
    }
}
