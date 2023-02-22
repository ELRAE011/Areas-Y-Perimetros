//ELRAE011
using System;

namespace AresyPerimetros
{
	public class PentagonoPropiedades
	{
		private float lado;
		
		public float Lado {
			get { return lado; }
			set { lado = value; }
		}
		private float apotema;
		
		public float Apotema {
			get { return apotema; }
			set { apotema = value; }
		}
		private float area;
		
		public float Area {
			get { return ((lado*5)*apotema)/2; }
			set { area = value; }
		}
		private float perimetro;
		
		public float Perimetro {
			get { return lado*5; }
			set { perimetro = value; }
		}
		
		public PentagonoPropiedades()
		{
		}
	}
}
