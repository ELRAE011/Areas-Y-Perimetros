//ELRAE011
using System;

namespace AresyPerimetros
{
	public class PentagonoMetodos
	{
		public PentagonoMetodos()
		{
		}
		
		public float CalcularAreaPentagono(float lado,float apotema){
			return ((lado*5) * apotema)/2;
		}
		public float CalcularPerimetroPentagono(float lado){
			return lado * 5;
		}
		
	}
}
