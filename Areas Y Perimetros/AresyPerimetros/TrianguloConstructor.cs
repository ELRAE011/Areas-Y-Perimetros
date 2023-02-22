//ELRAE011
using System;

namespace AresyPerimetros
{
	public class TrianguloConstructor
	{
		private float base1;
		private float altura;
		
		public TrianguloConstructor()
		{
		}
		public TrianguloConstructor(float base1,float altura){
			this.base1 = base1;
			this.altura = altura;
		}
		public float CalcularArea{
			get {return (base1*altura)/2;}
		}
		public float CalcularPerimetro{
			get {return base1*3;}
		}
	}
}
