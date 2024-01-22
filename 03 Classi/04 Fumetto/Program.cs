using _04_Fumetto.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fumetto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci quanti fumetti inserire: ");
            int numeroFumetti = Convert.ToInt32(Console.ReadLine());
            Fumetto[] fumetti = new Fumetto[numeroFumetti];
            string titoloInput;
            string autoreInput;
            string annoPubblicazioneInput;
            double prezzoInput;
            string breveDescrizioneInput;
            string isbnInput;
            string statoInuput;
            for(int i = 0; i < fumetti.Length; i++)
            {
                Console.Write("Inserisci titolo: ");
                titoloInput = Console.ReadLine();

                Console.Write("Inserisci autore: ");
                autoreInput = Console.ReadLine();

                Console.Write("Inserisci anno di pubblicazione: ");
                annoPubblicazioneInput = Console.ReadLine();

                Console.Write("Inserisci prezzo: ");
                prezzoInput = Convert.ToDouble(Console.ReadLine());

                Console.Write("Inserisci breve descrizione: ");
                breveDescrizioneInput = Console.ReadLine();

                Console.Write("Inserisci isbn: ");
                isbnInput = Console.ReadLine();

                Console.Write("Inserisci stato: ");
                statoInuput = Console.ReadLine();
                fumetti[i] = new Fumetto(titoloInput,autoreInput,annoPubblicazioneInput,prezzoInput,breveDescrizioneInput,isbnInput,statoInuput);
            }
            Console.ReadKey();
        }
    }
}
