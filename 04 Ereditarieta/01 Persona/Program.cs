using _01_Persona.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("0111", "Giuseppe", "Verdi");
            Studente s = new Studente("A100", "ETH", "Enrico", "Fermi", "1020");
            Docente d = new Docente("matematica","80000","Marco","Gregorio","A567");
            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
