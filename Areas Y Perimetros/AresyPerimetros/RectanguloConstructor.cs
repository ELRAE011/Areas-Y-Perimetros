//ELRAE011
using System;

namespace AresyPerimetros
{
	public class RectanguloConstructor
	{
		private float lado1;
		private float lado2;
		
		public RectanguloConstructor()
		{
		}
		
		public RectanguloConstructor(float lado1,float lado2)
		{	
			this.lado1 = lado1;
			this.lado2 = lado2;
		}	
		
		public float Area{
			get {return lado1 * lado2;}
		}
		public float Perimetro{
			get {return lado1*2+lado2*2;}
		}
	}
}
