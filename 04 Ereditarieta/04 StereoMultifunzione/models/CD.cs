using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StereoMultifunzione.models
{
    internal class CD : Supporto
    {
		private int _dimensione;

		public int Dimensione
		{
			get { return _dimensione; }
			set { _dimensione = value; }
		}
        public CD(int dimensione, string marca, string modello, Brano[] tracce) : base(marca,modello, tracce)
        {
            Dimensione = dimensione;
        }
    }
}
