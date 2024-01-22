using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Navigatore.models
{
    public class Navigatore
    {
        #region =02=== membri & proprietà ============propfull==
        
        public string Marca;
        public int Dimensioni;
        public string Modello;
        #endregion

        #region =03=== costruttori =======================ctor==


        /// <summary>
        /// Metedo che da dei valori di default alle variabili
        /// </summary>
        /// <returns>>defualt della variabile</returns>
        public Navigatore()
        {
            Marca = "Sconosciuta";
            Dimensioni = 0;
            Modello = "Sconosciuta";
        }

        /// <summary>
        /// Metedo da dei valori di default alle variabili
        /// </summary>
        /// <param name="marca">marca del navigatore</param>
        /// <param name="dimensioni">dimensione del navigatore</param>
        /// <param name="modello">modello di navigatore</param>
        /// <returns>tempo di percorrenza</returns>
        public Navigatore(string marca, int dimensioni,string modello)
        {
            Marca = marca;
            Dimensioni = dimensioni;
            Modello = modello;
        }
        #endregion

        #region =05=== metodi public ===========================

        /// <summary>
        /// Metodo che restituisce il percorso migliore
        /// </summary>
        /// <param name="destinazione">destinazione da raggiungere</param>
        /// <returns>restituisce percorso</returns>
        public string TrovaPercorso(string destinazione)
        {
            if (destinazione.Equals("Lugano"))
            {
                return "Bellinzona --> Giubiasco --> Lugano";
            }else if (destinazione.Equals("Mendrisio"))
            {
                return "Bellinzona --> Giubbiasco --> Lugano --> Mendrisio";
            }
            return "Destinazione non valida!!";

        }

        /// <summary>
        /// Metedo che ti ritorna il percorso che devia il paese inserito
        /// </summary>
        /// <param name="evita">pease che deve evitare</param>
        /// <returns>indica il percorso che evita il paese inserito</returns>
        public void InserireDeviazione(string evita)
        {
            //Implementare metodo
        }

        /// <summary>
        /// Metedo che restituisce la distanza totale
        /// </summary>
        /// <returns>distanza totale</returns>
        public void DistanzaTotale()
        {
            //Implementare metodo
        }

        /// <summary>
        /// Metedo che calcola il tempo totale di percorrenza
        /// </summary>
        /// <param name="destinazione">destinazione da raggiungere</param>
        /// <returns>tempo di percorrenza</returns>
        public void TempoTotale(string destinazione)
        {
            //Implementare metodo
        }

        /// <summary>
        /// Metedo che viene inserito la destinazione
        /// </summary>
        /// <returns>destinazione</returns>
        public void InserireDestinazione()
        {
            //Implementare metodo
        }

        /// <summary>
        /// Metedo che stampa  le informazioni
        /// </summary>
        /// <returns>stampa marca, dimensioni e modello</returns>
        public string StampaInformazione()
        {
            
            return "Marca: " + Marca + " ; " + "Dimensioni: " +
                Dimensioni + " ; " + "Modello: " + Modello;
        }
        #endregion
    }
}
