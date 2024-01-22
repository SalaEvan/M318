using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Navigatore.models;

namespace _01_Navigatore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Navigatore tomTom = new Navigatore();
            Navigatore garmin = new Navigatore("garmin",30,"X2M");
            tomTom.Marca = "Tom Tom";


            Console.WriteLine(tomTom.TrovaPercorso("Lugano"));
            Console.WriteLine(tomTom.TrovaPercorso("Mendrisio"));
            Console.WriteLine(tomTom.TrovaPercorso("Polo Nord"));


            Console.WriteLine(garmin.StampaInformazione());
            Console.WriteLine(tomTom.StampaInformazione());


            Console.ReadKey();
        }
    }

}
