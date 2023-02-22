//ELRAE011
using System;

namespace AresyPerimetros
{
	public class RectanguloMetodos
	{

		public RectanguloMetodos()
		{
		}
		
		public float CalcularArea(float lado1,float lado2){
			return lado1*lado2;
		}
		public float CalcularPerimetro(float lado1,float lado2){
			return lado1*2+lado2*2;
		}
	}
}
