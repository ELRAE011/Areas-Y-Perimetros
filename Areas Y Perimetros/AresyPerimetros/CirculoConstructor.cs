//ELRAE011
using System;

namespace AresyPerimetros
{
	public class CirculoConstructor
	{
		
		private float radio;
		
		public CirculoConstructor()
		{
		}
		public CirculoConstructor(float radio){
			this.radio = radio;
		}
		public double CalcularArea{
			get { return (radio*radio)* Math.PI ;}
		}
		public double CalcularPerimetro{
			get { return Math.PI * (radio*2);}
		}
	}
}
