//ELRAE011
using System;

namespace AresyPerimetros
{
	public class CirculoMetodos
	{
		public CirculoMetodos()
		{
		}
		public double CalcularAreaCirculo(float radio){
			return (radio * radio) * Math.PI;
		}
		public double CalcularPerimetroCirculo(float radio){
			return (radio + radio) * Math.PI;
		}
	}
}
