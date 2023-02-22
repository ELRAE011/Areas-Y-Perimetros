//ELRAE011
using System;

namespace AresyPerimetros
{
	public class PentagonoConstructor
	{
		private float lado;
		private float apotema;
		public PentagonoConstructor()
		{
		}
		public PentagonoConstructor(float lado,float apotema){
			this.lado = lado;
			this.apotema = apotema;
		}
		public float Area{
			get {return ((lado*5)*apotema)/2;}
		}
		public float Perimetro{
			get {return lado*5;}
		}
	}
}
