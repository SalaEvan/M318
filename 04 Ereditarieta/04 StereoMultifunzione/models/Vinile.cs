using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StereoMultifunzione.models
{
    internal class Vinile:Supporto
    {
		private double _giriMinuti;

		public double GiriMinuti
		{
			get { return _giriMinuti; }
			set { _giriMinuti = value; }
		}
        public Vinile(double giriMinuti, string marca, string modello, Brano[] tracce) : base(marca, modello, tracce)
        {
            GiriMinuti = giriMinuti;
        }
    }
}
