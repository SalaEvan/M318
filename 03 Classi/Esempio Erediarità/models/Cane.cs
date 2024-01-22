using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_Erediarità.models
{
    internal class Cane: Mammifero
    {
        private bool _isSegugio;
        public bool IsSegugio {
            get {return _isSegugio; }
            set {_isSegugio = value; } 
        }
        public Cane(bool isSegugio,string nome):base(nome)
        {
            this._isSegugio=isSegugio;
        }
        public string Abbaia()
        {
            return "BAU BAU BAU";
        }
        
        public override string EmettiVerso()
        {
            return "Bau Bau Bau";
        }
    }
}
