using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.models
{
    // la classe abstract non può essere istanziata e f ada modello
    // per tutte le classi derivate
    internal abstract class Figura 
    {
        public abstract float GetPerimetro();
    }
}
