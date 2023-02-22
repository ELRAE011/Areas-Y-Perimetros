//ELRAE011
using System;

namespace AresyPerimetros
{
	public class RectanguloPropiedades
	{
		private float lado1;
		private float lado2;
		private float area;
		private float perimetro;
		
		public RectanguloPropiedades()
		{
		}
		
		public float Lado1{
			get{ return lado1; }
			set{ lado1 = value; }
		}
		public float Lado2 {
			get { return lado2; }
			set { lado2 = value; }
		}
		public float Area{
			get { return lado1*lado2;}
			set { area = value; }
		}
		public float Perimetro{
			get { return lado1*2 + lado2*2; }
			set { perimetro = value; }
		}
	}
}
