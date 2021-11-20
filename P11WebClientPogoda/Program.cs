using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P11WebClientPogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.google.com/search?q=pogoda+berlin";

         
            string dane = new WebClient().DownloadString(url);

            Console.WriteLine(dane);
            File.WriteAllText(@"c:\dane\pogoda.html", dane);


            string napis = "ala ma kota";
                            
            int idx= napis.IndexOf('m');

            string podciag = napis.Substring(4, 2);

            Console.ReadKey();
        }
    }
}
