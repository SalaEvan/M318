using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.models
{
    internal class NonAlimentare : Prodotto
    {
		private string _materiale;

		public string Materiale
		{
			get { return _materiale; }
			set { _materiale = value; }
		}
        public NonAlimentare(int codice, string descrizione, float prezzo,string materiale): base(codice, descrizione, prezzo)
        {
           Codice = codice;
           Descrizione = descrizione;
           Prezzo = prezzo;
           Materiale = materiale;
        }
    }
}
