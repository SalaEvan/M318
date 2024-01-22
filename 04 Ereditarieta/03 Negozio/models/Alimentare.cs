using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.models
{
    internal class Alimentare: Prodotto
    {
		private DateTime _data;

		public DateTime Data
		{
			get { return _data; }
			set { _data = value; }
		}
        public Alimentare(int codice, string descrizione, float prezzo, int giorno, int mese, int anno) : base(codice, descrizione, prezzo)
        {
            Codice = codice;
            Descrizione = descrizione; 
            Prezzo = prezzo;
            Data = new DateTime(giorno, mese, anno);
        }
    }
}
