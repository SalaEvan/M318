using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StereoMultifunzione.models
{
    internal class AudioCassetta:Supporto
    {
		private double _lunghezzanastro;

		public double LunghezzaNastro
		{
			get { return _lunghezzanastro; }
			set { _lunghezzanastro = value; }
		}
        public AudioCassetta(double lunghezzaNastro, string marca, string modello, Brano[] tracce) : base(marca, modello, tracce)
        {
            LunghezzaNastro = lunghezzaNastro;
        }
    }
}
