//ELRAE011
using System;

namespace AresyPerimetros
{
	public class TrianguloPropiedades
	{
		private float base1;
		
		public float Base1 {
			get { return base1; }
			set { base1 = value; }
		}
		private float altura;
		
		public float Altura {
			get { return altura; }
			set { altura = value; }
		}
		private float area;
		
		public float Area {
			get { return (base1*altura)/2; }
			set { area = value; }
		}
		private float perimetro;
		
		public float Perimetro {
			get { return base1*3; }
			set { perimetro = value; }
		}
		
		public TrianguloPropiedades()
		{
		}
	}
}
