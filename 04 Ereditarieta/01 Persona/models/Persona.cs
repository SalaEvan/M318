using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persona.models
{
    internal class Persona
    {
        private string _codiceFiscale;
        private string _nome;
        private string _cognome;

        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value;}
        }
        public string Nome
        {
            get { return _nome; }  
            set { _nome = value; }
        }
        public string Cognome
        {
            get { return _cognome; }   
            set { _cognome = value; }
        }

        public Persona()
        {
            _nome = "";
            _codiceFiscale = "";
            _cognome = "";
        }

        public Persona(string codiceFiscale, string nome, string cognome)
        {
            CodiceFiscale = codiceFiscale;
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20}",CodiceFiscale,Nome,Cognome);
        }
    }
}
