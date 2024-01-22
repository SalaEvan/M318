using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fumetto.models
{
    internal class Fumetto
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==

        private string _titolo;
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("Titolo inserito non valido"); ;
                }
                else
                {
                    _titolo = value;
                }
            }
        }

        private string _autore;
        public string Autore
        {
            get { return _autore; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("Autore inserito non valido"); ;
                }
                else
                {
                    _autore = value;
                }
            }
        }

        private string _annoPubblicazione;
        public string AnnoPubblicazione
        {
            get { return _annoPubblicazione; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("Anno di pubblicazione inserito non valido"); ;
                }
                else
                {
                    _annoPubblicazione = value;
                }
            }
        }

        private double _prezzo;
        public double Prezzo
        {
            get { return _prezzo; }
            set
            {
                if (value < 0.0)
                {
                    Console.WriteLine("Prezzo inserito non valido"); ;
                }
                else
                {
                    _prezzo = value;
                }
            }
        }

        private string _breveDescrizione;
        public string BreveDescrizione
        {
            get { return _breveDescrizione; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("Breve descrizione inserita non valido"); ;
                }
                else
                {
                    _breveDescrizione = value;
                }
            }
        }

        private string _isbn;
        public string Isbn
        {
            get { return _isbn; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("Isbn inserito non valido"); ;
                }
                else
                {
                    _isbn = value;
                }
            }
        }

        private string _stato;
        public string Stato
        {
            get { return _stato; }
            set
            {
                if (value.Equals(""))
                {
                    Console.WriteLine("stato inserito non valido"); ;
                }
                else
                {
                    _stato = value;
                }
            }
        }

        #endregion

        #region =03=== costruttori =======================ctor==
        public Fumetto()
        {
            _titolo = "";
            _autore = "";
            _annoPubblicazione = "";
            _prezzo = 0.0;
            _breveDescrizione = "";
            _isbn = "";
            _stato = "";
        }
        public Fumetto(string titolo, string autore, string annoPubblicazione, double prezzo, string breveDescrizione, string isbn, string stato)
        {
            Titolo = titolo;
            Autore = autore;
            AnnoPubblicazione = annoPubblicazione;
            Prezzo = prezzo;
            BreveDescrizione = breveDescrizione;
            Isbn = isbn;
            Stato = stato;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        private string checkString(string stringa)
        {
            if(stringa.Length > 15)
            {
                return stringa.Substring(0,13) + "..";
            }
            return stringa;
        }
        #endregion

        #region =05=== metodi public ===========================

        public override string ToString()
        {
            //
            string desc = string.Format("{0,-15} | {1,-15}|{2,-7} | {3,-7} | {4,-7}", checkString(Titolo), checkString(Autore), AnnoPubblicazione, Prezzo, Stato);
            return desc;
        }
        #endregion
    }
}
