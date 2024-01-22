using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_Erediarità.models
{
    internal class Mammifero
    {
        #region =01=== costanti & statici ======================
        #endregion
        #region =02=== membri & proprietà ============propfull==
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        #endregion
        #region =03=== costruttori =======================ctor==
        public Mammifero(string nome)
        {
            this.Nome = nome;
        }
        #endregion
        #region =04=== metodi private e aiuto ==================
        #endregion
        #region =05=== metodi public ===========================
        public void Dormire ()
        {
            Console.WriteLine("Ronf Ronf Dormo!");
        }
        public virtual string EmettiVerso()
        {
            return "emetto un verso: ";
        }
        #endregion
    }
}
