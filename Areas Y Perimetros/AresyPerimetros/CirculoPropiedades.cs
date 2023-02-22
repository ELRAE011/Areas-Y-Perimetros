//ELRAE011
using System;

namespace AresyPerimetros
{
	public class CirculoPropiedades
	{
		private float radio;
		
		public float Radio {
			get { return radio; }
			set { radio = value; }
		}
		private double area;
		
		public double Area {
			get { return (radio*radio)*Math.PI; }
			set { area = value; }
		}
		private double perimetro;		
		
		public double Perimetro {
			get { return (radio+radio)*Math.PI; }
			set { perimetro = value; }
		}
		public CirculoPropiedades()
		{
		}
	}
}
