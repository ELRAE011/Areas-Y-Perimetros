//ELRAE011
using System;

namespace AresyPerimetros
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("PROGRAMA DE AREAS Y PERIMETROS POR PROPIEDADES,METODOS Y CONSTRUCTOR");
			Console.WriteLine("Escriba la figura y el metodo por el cual quiere realizar su consulta:\n\n" +
			                  "CUADRADO\n" +
			                  "1 - CUADRADO POR CONSTRUCTOR\n" +
			                  "2 - CUADRADO POR METODO\n" +
			                  "3 - CUADRADO POR PROPIEDADES\n" +
			                  "\nRECTANGULO\n" +
			                  "4 - RECTANGULO POR CONSTRUCTOR\n" +
			                  "5 - RECTANGULO POR METODOS\n" +
			                  "6 - RECTANGULO POR PROPIEDADES\n" +
			                  "\nTRIANGULO\n" +
			                  "7 - TRIANGULO POR CONSTRUCTOR\n" +
			                  "8 - TRIANGULO POR METODOS\n" +
			                  "9 - TRIANGULO POR PROPIEDADES\n" +
			                  "\nCIRCULO\n" +
			                  "10 - CIRCULO POR CONSTRUCTOR\n" +
			                  "11 - CIRCULO POR METODOS\n" +
			                  "12 - CIRCULO POR PROPIEDADES\n" +
			                  "\nPENTAGONO\n" +
			                  "13 - PENTAGONO POR CONSTRUCTOR\n" +
			                  "14 - PENTAGONO POR METODOS\n" +
			                  "15 - PENTAGONO POR PROPIEDADES");
			int x = int.Parse(Console.ReadLine());
			switch(x){
				case 1: CuadradoConstructor();
				break;
				case 2: CuadradoMetodos();
				break;
				case 3: CuadradoPropiedades();
				break;
				case 4: RectanguloConstructor();
				break;
				case 5: RectanguloMetodos();
				break;
				case 6: RectanguloPropiedades();
				break;
				case 7: TrianguloConstructor();
				break;
				case 8: TrianguloMetodos();
				break;
				case 9: TrianguloPropiedades();
				break;
				case 10:CirculoConstructor();
				break;
				case 11: CirculoMetodos();
				break;
				case 12: CirculoPropiedades();
				break;
				case 13: PentagonoConstructor();
				break;
				case 14: PentagonoMetodos();
				break;
				case 15: PentagonoPropiedades();
				break;
				default: Console.WriteLine("Ingrese un valor invalido por favor.");
				break;
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void CuadradoConstructor(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Cuadrado por Constructor:\n");
			Console.WriteLine("Escribe el lado del Cuadrado:\n");
			float lado = float.Parse(Console.ReadLine());
			CuadradoConstructor cuadradoConstructor = new CuadradoConstructor(lado);
			Console.WriteLine("\nEl Area del cuadrado es: {0} y el perimetro es: {1}\n",cuadradoConstructor.Area,cuadradoConstructor.Perimetro);
		}
		public static void CuadradoMetodos(){
			CuadradoMetodo cuadradoMetodo = new CuadradoMetodo();
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Cuadrado por Metodos:\n");
			Console.WriteLine("Escribe el lado del Cuadrado:\n");
			float lado = float.Parse(Console.ReadLine());
			Console.WriteLine("\nEl Area del cuadrado es: {0} y el perimetro es: {1}\n",cuadradoMetodo.CalcularAreaCuadrado(lado),cuadradoMetodo.CalcularPerimetroCuadrado(lado));
		}
		public static void CuadradoPropiedades(){
			CuadradoPropiedades cuadradoPropiedades = new CuadradoPropiedades();
			Console.WriteLine("Programa que calcula el Area y Perimetro del Cuadrado por Propiedades:\n");
			Console.WriteLine("Escribe el lado del Cuadrado:\n");
			float lado = float.Parse(Console.ReadLine());
			cuadradoPropiedades.Lado = lado;
			Console.WriteLine("\nEl Area del cuadrado es: {0} y el perimetro es: {1}\n",cuadradoPropiedades.Area,cuadradoPropiedades.Perimetro);
		}
		public static void RectanguloConstructor(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Rectangulo por Constructor:\n");
			Console.WriteLine("Escribe el lado 1 del Rectangulo:\n");
			float lado1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe el lado 2 del Rectangulo:\n");
			float lado2 = float.Parse(Console.ReadLine());
			RectanguloConstructor rectanguloConstructor = new RectanguloConstructor(lado1,lado2);
			Console.WriteLine("\nEl Area del Rectangulo es: {0} y el perimetro es: {1}\n",rectanguloConstructor.Area,rectanguloConstructor.Perimetro);
		}
		public static void RectanguloMetodos(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Rectangulo por Metodos:\n");
			Console.WriteLine("Escribe el lado 1 del Rectangulo:\n");
			float lado1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe el lado 2 del Rectangulo:\n");
			float lado2 = float.Parse(Console.ReadLine());
			RectanguloMetodos rectanguloMetodos = new RectanguloMetodos();
			Console.WriteLine("\nEl Area del Rectangulo es: {0} y el perimetro es: {1}\n",rectanguloMetodos.CalcularArea(lado1,lado2),rectanguloMetodos.CalcularPerimetro(lado1,lado2));
		}
		public static void RectanguloPropiedades(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Rectangulo por Propiedades:\n");
			Console.WriteLine("Escribe el lado 1 del Rectangulo:\n");
			float lado1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe el lado 2 del Rectangulo:\n");
			float lado2 = float.Parse(Console.ReadLine());
			RectanguloPropiedades rectanguloPropiedades = new RectanguloPropiedades();
			rectanguloPropiedades.Lado1 = lado1;
			rectanguloPropiedades.Lado2 = lado2;
			Console.WriteLine("\nEl Area del Rectangulo es: {0} y el perimetro es: {1}\n",rectanguloPropiedades.Area,rectanguloPropiedades.Perimetro);
		}
		public static void TrianguloConstructor(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Triangulo por Constructor:\n");
			Console.WriteLine("Escribe la base del Triangulo:\n");
			float base1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe la altura del Triangulo:\n");
			float altura = float.Parse(Console.ReadLine());
			TrianguloConstructor trianguloConstructor = new TrianguloConstructor(base1,altura);
			Console.WriteLine("\nEl Area del Triangulo es: {0} y el perimetro es: {1}\n",trianguloConstructor.CalcularArea,trianguloConstructor.CalcularPerimetro);
		}
		public static void TrianguloMetodos(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Triangulo por Metodos:\n");
			Console.WriteLine("Escribe la base del Triangulo:\n");
			float base1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe la altura del Triangulo:\n");
			float altura = float.Parse(Console.ReadLine());
			TrianguloMetodos trianguloMetodos = new TrianguloMetodos();
			Console.WriteLine("\nEl Area del Triangulo es: {0} y el perimetro es: {1}\n",trianguloMetodos.CalcularArea(base1,altura),trianguloMetodos.CalcularPerimetro(base1));
		}
		public static void TrianguloPropiedades(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Triangulo por Propiedades:\n");
			Console.WriteLine("Escribe la base del Triangulo:\n");
			float base1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe la altura del Triangulo:\n");
			float altura = float.Parse(Console.ReadLine());
			TrianguloPropiedades trianguloPropiedades = new TrianguloPropiedades();
			trianguloPropiedades.Base1 = base1;
			trianguloPropiedades.Altura = altura;
			Console.WriteLine("\nEl Area del Triangulo es: {0} y el perimetro es: {1}\n",trianguloPropiedades.Area,trianguloPropiedades.Perimetro);
		}		
		public static void CirculoConstructor(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Circulo por Constructor:\n");
			Console.WriteLine("Escribe el radio del circulo:\n");
			float radio = float.Parse(Console.ReadLine());
			CirculoConstructor circuloConstructor = new CirculoConstructor(radio);
			Console.WriteLine("\nEl Area del Circulo es: {0} y el perimetro es: {1}\n",circuloConstructor.CalcularArea,circuloConstructor.CalcularPerimetro);
		}
		public static void CirculoMetodos(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Circulo por Metodos:\n");
			Console.WriteLine("Escribe el radio del circulo:\n");
			float radio = float.Parse(Console.ReadLine());
			CirculoMetodos circuloMetodos = new CirculoMetodos();
			Console.WriteLine("\nEl Area del Circulo es: {0} y el perimetro es: {1}\n",circuloMetodos.CalcularAreaCirculo(radio),circuloMetodos.CalcularPerimetroCirculo(radio));
		}
		public static void CirculoPropiedades(){
			Console.WriteLine("Programa que calcula el Area y el Perimetro del Circulo por Propiedades:\n");
			Console.WriteLine("Escribe el radio del circulo:\n");
			float radio = float.Parse(Console.ReadLine());
			CirculoPropiedades circuloPropiedades = new CirculoPropiedades();
			circuloPropiedades.Radio = radio;
			Console.WriteLine("\nEl Area del Circulo es: {0} y el perimetro es: {1}\n",circuloPropiedades.Area,circuloPropiedades.Perimetro);
		}
		public static void PentagonoConstructor(){
			Console.WriteLine("Programa que calcula el Area Y el Perimetro del Pentagono por Constructor:\n");
			Console.WriteLine("Escribe el lado del pentagono:\n");
			float lado = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe el apotema del pentagono:\n");
			float apotema = float.Parse(Console.ReadLine());
			PentagonoConstructor pentagonoConstructor = new PentagonoConstructor(lado,apotema);
			Console.WriteLine("\nEl Area del Pentagono es: {0} y el Perimetro es: {1}\n",pentagonoConstructor.Area,pentagonoConstructor.Perimetro);
		}
		public static void PentagonoMetodos(){
			Console.WriteLine("Programa que calcula el Area Y el Perimetro del Pentagono por Metodos:\n");
			Console.WriteLine("Escribe el lado del pentagono:\n");
			float lado = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe el apotema del pentagono:\n");
			float apotema = float.Parse(Console.ReadLine());
			PentagonoMetodos pentagonoMetodos = new PentagonoMetodos();
			Console.WriteLine("\nEl Area del Pentagono es: {0} y el Perimetro es: {1}\n",pentagonoMetodos.CalcularAreaPentagono(lado,apotema),pentagonoMetodos.CalcularPerimetroPentagono(lado));
		}
		public static void PentagonoPropiedades(){
			Console.WriteLine("Programa que calcula el Area Y el Perimetro del Pentagono por Propiedaes:\n");
			Console.WriteLine("Escribe el lado del pentagono:\n");
			float lado = float.Parse(Console.ReadLine());
			Console.WriteLine("Escribe el apotema del pentagono:\n");
			float apotema = float.Parse(Console.ReadLine());
			PentagonoPropiedades pentagonoPropiedades = new PentagonoPropiedades();
			pentagonoPropiedades.Lado=lado;
			pentagonoPropiedades.Apotema=apotema;
			Console.WriteLine("\nEl Area del Pentagono es: {0} y el Perimetro es: {1}\n",pentagonoPropiedades.Area,pentagonoPropiedades.Perimetro);
		}
		
	}
}