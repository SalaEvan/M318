using Esercizio_01.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci quante Pietanze inserire: ");
            int NumeroPietanze = Convert.ToInt32(Console.ReadLine());
            Pietanza[] pietanze = new Pietanza[NumeroPietanze];
            string nomePiattoInput;
            string genereInput;
            string descrizioneInput;
            double prezzoInput;
            for (int i = 0; i < pietanze.Length; i++)
            {
                string menu = "";
                string scritta = "MenuCreator Creator";
                for (int count = 0; count < 54; count++)
                {
                    if(count == 54/ 2 - scritta.Length/2)
                    {
                        menu += scritta;
                        count += 4;
                    }
                    else
                    {
                        menu += "*";
                    }
                }
                Console.Write(menu+"\r\n"+"\r\n");
                Console.Write("Inserisci nome del piatto: ");
                nomePiattoInput = Console.ReadLine();

                Console.Write("Inserisci il genere: ");
                genereInput = Console.ReadLine();

                Console.Write("Inserisci la descrizione del piatto: ");
                descrizioneInput = Console.ReadLine();

                Console.Write("Inserisci prezzo: ");
                prezzoInput = Convert.ToDouble(Console.ReadLine());

                pietanze[i] = new Pietanza(nomePiattoInput, genereInput, descrizioneInput, prezzoInput);
                Console.Write(pietanze[i].CheckValue());
            }
            Console.WriteLine(pietanze);
            Console.Write("premi un tasto qualsiasi per uscire");
            Console.ReadKey();
        }
    }
}
