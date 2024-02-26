using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StereoMultifunzione.models
{
    internal class Supporto
    {
		private string _marca;

		public string Marca
		{
			get { return _marca; }
			set { _marca = value; }
		}
		private string _modello;

		public string Modello
		{
			get { return _modello; }
			set { _modello = value; }
		}
		private Brano[] _tracce;
		public Brano[] Tracce
		{
			get { return _tracce; }
			set { _tracce = value; }
		}
        public Supporto(string marca, string modello, Brano[] tracce)
        {
			Marca = marca;
			Modello = modello;
			Tracce = tracce;
        }
    }
}
