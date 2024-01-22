using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persona.models
{
    internal class Studente : Persona
    {
        private string _matricola;
        
        public string Matricola
        {
            get { return _matricola; }
            set { _matricola = value;}
        }
        private string _universita;

        public string Universita
        {

            get { return _universita; }
            set { _universita = value;}
        }
        public Studente(string matricola, string universita, string nome, string cognome, string codiceFiscale): base(codiceFiscale, nome, cognome)
        {
            Matricola = matricola;
            Universita = universita;
        }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", CodiceFiscale, Nome, Cognome, Universita,Matricola); ;
        }
    }
}
