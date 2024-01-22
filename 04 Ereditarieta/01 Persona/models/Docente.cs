using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persona.models
{
    internal class Docente:Persona
    {
        private string _materia;

        public string Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }
        private string _salario;

        public string Salario
        {

            get { return _salario; }
            set { _salario = value; }
        }
        public Docente(string materia, string salario, string nome, string cognome, string codiceFiscale) : base(codiceFiscale, nome, cognome)
        {
            Materia = materia;
            Salario = salario;
        }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", CodiceFiscale, Nome, Cognome, Salario, Materia); ;
        }
    }
}
