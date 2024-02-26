using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StereoMultifunzione.models
{
    internal class Stereo
    {
		private string _modello;

		public string Modello
		{
			get { return _modello; }
			set { _modello = value; }
		}
        public Stereo(string modello)
        {
            Modello = modello;
        }
        public void inserisciSupportoCassetta()
        {

        }
        public void inserisciSupportoVinile()
        {

        }
        public void inserisciCD()
        {

        }
        public void rimuoviCassetta()
        {

        }
        public void rimuoviVinile()
        {

        }
        public void rimuoviSupportoCD()
        {

        }
        public void playCassetta()
        {

        }
        public void playVinile()
        {

        }
        public void playCD()
        {

        }
        public void stop()
        {

        }
    }
}
