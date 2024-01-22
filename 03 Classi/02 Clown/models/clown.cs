using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clown.models
{
    internal class clown
    {
        #region =01=== costanti & statici ======================
        #endregion
        #region =02=== membri & proprietà ============propfull==
        private string _nome;
        private double _altezza;
        private double _peso;
        public string Nome
        {
            get { return _nome; }
            set { 
                if(value == "")
                {
                    _nome = "Sconosciuto";
                }
                else
                {
                    _nome = value; 
                }
            }
        }
        public double Altezza
        {
            get { return _altezza; }
            set
            {
                if (value < 100.0)
                {
                    Console.WriteLine("altezza troppo bassa!");
                }
                else
                {
                    _altezza = value;
                }
            }
        }
        public double Peso
        {
            get { return _peso; }
            set
            {
                if (value <30.0)
                {
                    Console.WriteLine("Peso troppo poco!");
                }
                else
                {
                    _peso = value;
                }
            }
        }
        #endregion
        #region =03=== costruttori =======================ctor==
        public clown() {
            _nome = "Sconosciuto";
            _altezza = 0.0;
            _peso = 0.0;
        }
        public clown(string nome, double altezza, double peso)
        {
            _nome = nome;
            _altezza = altezza;
            _peso = peso;
        }

        #endregion
        #region =04=== metodi private e aiuto ==================
        public string RaccontaColmo()
        {
            return "Qual è il tuo colmo per un gatto? . . . . Fare una vita da cani";
        } 

        #endregion
        #region =05=== metodi public ===========================
        public string Saluta()
        {
            return "Ciao sono " + _nome+ "\n"+ RaccontaColmo();
        }
        #endregion
        public override string ToString()
        {
            return "Nome " + Nome + " " + "Peso " + Peso + " " + "Altezza " + Altezza;
        }
    }
}
