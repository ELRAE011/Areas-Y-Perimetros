//ELRAE011
using System;

namespace AresyPerimetros
{
	public class CuadradoPropiedades
	{
		private float lado;
		private float area;
		private float perimetro;
		
		public CuadradoPropiedades()
		{
		}
		public float Lado{
			get {return lado;}
			set {lado = value;}
		}
		public float Area{
			get{return lado * lado;}
			set{area = value;}
		}	
		public float Perimetro{
			get{return lado*4;}
			set{perimetro = value;}
		}
	}
}
