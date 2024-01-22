using Esempio_Erediarità.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_Erediarità
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane pluto = new Cane(true,"pluto");
            Console.WriteLine(pluto.Abbaia());
            pluto.Dormire();
            Console.WriteLine(pluto.EmettiVerso());
            Console.ReadKey();
            
        }
    }
}
