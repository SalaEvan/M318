using _02_Clown.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clown[] clowns = new clown[2];
            string nome;
            double peso;
            double altezza;
            for(int i = 0; i < clowns.Length; i++) {
                Console.Write("Inserisci il nome del clown: ");
                nome = Console.ReadLine();
                Console.Write("Inserisci il peso del clown: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Inserisci l'altezza del clown: ");
                altezza = Convert.ToDouble(Console.ReadLine());
                clowns[i] = new clown (nome,peso,altezza);
            }
            foreach(clown clown in clowns) {
                Console.WriteLine(clown);
            }
            Console.ReadKey();
        }
    }
}
