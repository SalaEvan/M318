using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_01.models
{
    internal class Pietanza
    {
        #region =01=== costanti & statici ======================
        #endregion
        #region =02=== membri & proprietà ============propfull==
        private string _nomePiatto;
        private string _genere;
        private string _descrizione;
        private double _prezzo;

        public string NomePiatto
        {
            get { return _nomePiatto; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("Nome del piatto inserito non valido"); ;
                }
                else
                {
                    _nomePiatto = value;
                }
            }
        }
        public string Genere
        {
            get { return _genere; }
            set
            {
                if (value.Equals("Primo") || value.Equals("Secondo"))
                {
                    _genere = value;

                }
                else
                {
                    Console.WriteLine("descrizione inserito non valida");
                    _genere = "Sconosciuto"; 
                }
            }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("descrizione inserito non valida"); ;
                }
                else
                {
                    _descrizione = value;
                }
            }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set
            {
                if (value <= 9.0)
                {
                    Console.WriteLine("Attenzione!!, prezzo inserito iînferiore o uguale a 9.");
                    _prezzo = 9.0;
                }
                else
                {
                    _prezzo = value;
                }
            }
        }



        #endregion
        #region =03=== costruttori =======================ctor==
        public Pietanza()
        {
            _nomePiatto = "Sconosciuto";
            _genere = "Sconosciuto";
            _descrizione = "Sconosciuto";
            _prezzo = 9.0;
        }
        public Pietanza(string nomePiatto, string genere, string descrizione, double prezzo)
        {
            NomePiatto = nomePiatto;
            Genere = genere;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }
        #endregion
        #region =04=== metodi private e aiuto ==================
        
        // 
        // verifica quale cibo
        // stampare
        // @param genere verifica il genere del piatto
        private string scegliePiatto(string genere)
        {
            string cibo = "";
            if(!genere.Equals("Sconosciuto") && !NomePiatto.Equals("Sconosciuto") && !Descrizione.Equals("Sconosciuto"))
            {
                if (genere.Equals("Primo"))
                {
                    cibo = string.Format("{0,1} {1,-30} {2,-30} " +
                        "{3,-10} {4,1}", "*", checkString(NomePiatto),
                        checkString(Descrizione), Prezzo + "Fr.-", "*") + "\r\n";
                }
                else
                {
                    cibo = string.Format("{0,1} {1,-30} {2,-30} " +
                        "{3,-10} {4,1}", "*", checkString(NomePiatto),
                        checkString(Descrizione), Prezzo + "Fr.-", "*") + "\r\n";
                }
            }
            return cibo;
        }
        //
        // controlla le sringhe
        private string checkString(string stringa)
        {
            if (stringa.Length > 30)
            {
                return stringa.Substring(0,38) + "..";
            }
            return stringa;
        }
        //
        // viene disegnato il conortno del menu
        private string contornoMenu(int tipo)
        {
            string menu = "";
            for(int i = 0; i < 54; i++)
            {
                if(i == 54/ 2-2 && tipo == 1)
                {
                    menu += "menu";
                    i += 4;
                }
                else
                {
                    menu += "*";
                }
            }
            return menu;
        }
        // 
        // metodo che ritorna una stringa contenete 
        // una scritta e successivamente *
        // @param tipo capire se è primo o secondo
        private string contornoPrimoSecondo(string tipo)
        {
            string genere = "";
            for (int i = 0; i < 54; i++)
            {
                if (i == 0)
                {
                    genere += tipo;
                    i += tipo.Length;
                }
                else
                {
                    genere += "*";
                }
            }
            return genere;
        }
        #endregion
        #region =05=== metodi public ===========================
        //
        // ritorna se il contenuto inserito è coretto
        //
        public string CheckValue()
        {
            string checkStringa = "";
            if (!NomePiatto.Equals("") && !Genere.Equals("") && !Descrizione.Equals("") && Prezzo != 0.0)
            {
                checkStringa = "Pietanza inserita correttamente";
            }
            else
            {
                checkStringa = "Pietanza inserita non correttamente";
            }
            return checkStringa;
        }
        //
        // formatta la stringa che deve stampare
        // e fa l'ovverride del metodo toString
        //
        public override string ToString()
        {
            string InizioMenu = contornoMenu(1)+ "\r\n";
            string Primo = contornoPrimoSecondo(Genere) + "\r\n";
            string Secondo = contornoPrimoSecondo(Genere) + "\r\n";
            string FineMenu = contornoMenu(1) + "\r\n";
            string Menu = InizioMenu+Primo+scegliePiatto(Genere)+Secondo+scegliePiatto(Genere)+FineMenu;
            return Menu;
        }
        #endregion
    }
}
