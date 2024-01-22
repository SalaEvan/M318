using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.models
{
    internal class Triangolo: Figura
    {
		private float _latoA;

		public float LatoA
		{
			get { return _latoA; }
			set { _latoA = value; }
		}

		private float _latoB;

		public float LatoB
		{
			get { return _latoB; }
			set { _latoB = value; }
		}
		private float _latoC;

		public float LatoC
		{
			get { return _latoC; }
			set { _latoC = value; }
		}
        public Triangolo(float latoA, float latoB, float latoC)
		{
			LatoA = latoA;
			LatoB = latoB;
			LatoC = latoC;
		}

        public override float GetPerimetro()
        {
            return LatoA+LatoB+LatoC;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
