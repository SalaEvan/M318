using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.models
{
    internal class Prodotto
    {
		private int _codice;

		public int Codice
		{
			get { return _codice; }
			set { _codice = value; }
		}
		private string _descrizione;

		public string Descrizione
		{
			get { return _descrizione; }
			set { _descrizione = value; }
		}
		private float _prezzo;

		public float Prezzo
		{
			get { return _prezzo; }
			set { _prezzo = value; }
		}
        public Prodotto(int codice, string descrizione, float prezzo)
        {
            Codice = codice;
			Descrizione = descrizione;
			Prezzo = prezzo;
        }

        public override string ToString()
        {
            return Codice +";" + Descrizione +";"+Prezzo;
        }
		public float ApplicaSconto()
		{
			return Prezzo + 0.95f;
		}
    }
}
