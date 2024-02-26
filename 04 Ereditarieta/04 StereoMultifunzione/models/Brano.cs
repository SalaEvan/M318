using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StereoMultifunzione.models
{
    internal class Brano
    {
        private string _titolo;

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }
        private string _artista;

        public string Artista
        {
            get { return _artista; }
            set { _artista = value; }
        }
        private float _durata;

        public float Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }
        public Brano(string titolo, string artista, float durata)
        {
            Titolo = titolo;
            Artista = artista;
            Durata = durata;
        }
    }
}
