using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lattina.models
{
    internal class Lattina
    {


        #region =01=== costanti & statici ======================
        private double _raggio;
        private double _altezza;
        #endregion
        #region =02=== membri & proprietà ============propfull==
        private double Raggio
        {
            get { return _raggio; }
            set
            {
                if (value < 0.0)
                {
                    Console.WriteLine("raggio troppo basso!"); ;
                }
                else
                {
                    _raggio = value;
                }
            }
        }
        private double Altezza
        {
            get { return _altezza; }
            set
            {
                if (value < 0.0)
                {
                    Console.WriteLine("altezza troppo bassa!");
                }
                else
                {
                    _altezza = value;
                }
            }
        }
        #endregion
        #region =03=== costruttori =======================ctor==
        public Lattina()
        {
             _raggio = 0.0;
             _altezza = 0.0;
        }
        public Lattina(double raggio, double altezza)
        {
             _raggio = raggio;
             _altezza = altezza;
        }
        #endregion
        #region =04=== metodi private e aiuto ==================
        #endregion
        #region =05=== metodi public ===========================
        public double Volume()
        {
            return Math.Pow(_raggio, 2)*Math.PI * _altezza;
        }
        public double AreaBase()
        {
            return Math.Pow(_raggio,2)*Math.PI;
        }
        public double Circonferenza()
        {
            return _raggio * 2 * Math.PI;
        }
        public double Superficie()
        {
            return AreaBase() * 2 + Circonferenza() * Altezza;
        }
        #endregion

    }
}
