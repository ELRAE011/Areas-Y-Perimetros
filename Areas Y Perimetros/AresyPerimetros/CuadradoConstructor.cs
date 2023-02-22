//ELRAE011
using System;

namespace AresyPerimetros
{
	public class CuadradoConstructor
	{
		private float lado; //<-- Este de aca
		/*Constructor
		* El constructor solo se utiliza para inicializar valores
		* El constructor siempre tiene el nombre de la clase
		* El constructor nunca retorna valores (No tiene tipo de datos en retorno)
		* Pueden existir varios constructores con Sobrecarga 
		*/
		
		public CuadradoConstructor()
		{
		}
		
		public CuadradoConstructor(float lado)
		{	
			//this hace referencia a la clase, no a los campos
			this.lado = lado;
		}	
		
		public float Area{
			get {return lado * lado;}
		}
		public float Perimetro{
			get {return lado * 4;}
		}
	}
}
