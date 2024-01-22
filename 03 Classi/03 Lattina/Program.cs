using _03_Lattina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lattina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raggio;
            double altezza;
            Console.Write("Inserisci raggio per la lattina: ");
            raggio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci altezza per la lattina: ");
            altezza = Convert.ToDouble(Console.ReadLine());
            Lattina lattina = new Lattina(raggio,altezza);
            Console.WriteLine("Volume: " + lattina.Volume() + " Superficie: " + lattina.Superficie());
            Console.ReadKey();
        }
    }
}
