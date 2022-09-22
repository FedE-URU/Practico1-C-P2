using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*2 - Realice el código usando diagrama de clases, para poder imprimir en pantalla el nombre de un
			alumno o el nombre y la edad, según se prefiera.
			Para esto debe crear una clase alumno que contenga los constructores adecuados y al menos un método 
			imprimirNombre y otro
			imprimirNombreEdad.
			Puede agregar métodos getters y setters si lo prefiere.*/
			bool salir = false;
			string opcion2;

            do
			{
				

				Console.WriteLine("Ingrese nombre del alumno: ");
				string nombre = Console.ReadLine();
				Console.WriteLine("Ingrese edad del alumno: ");
				int edad = Int32.Parse(Console.ReadLine());
				Alumno soloNombre = new Alumno(nombre);
				Alumno soloEdad = new Alumno(edad);


				int opcion = 0;
				Console.WriteLine("Elija una opcion:");
				Console.WriteLine("1) Ver unicamente el nombre del alumno.");
				Console.WriteLine("2) Ver nombre y edad del alumno.");
				Console.Write("Elija una opcion: ");

				opcion = Int32.Parse(Console.ReadLine());

				switch (opcion)
				{
					case 1:
						Console.WriteLine(soloNombre.getImprimirNombre());
						//Console.WriteLine("El nombre del alumno es: " + nombre ); 
						break;
					case 2:
						Console.WriteLine(soloNombre.getImprimirNombre());
						Console.WriteLine(soloEdad.getImprimirEdad());
						//Console.WriteLine("El nombre del alumno es: " + nombre + " y la edad es de: " + edad + " años.");
						break;
					default:
						Console.WriteLine("Numero Incorrecto, intente otra vez");
						break;
				}
				
				Console.WriteLine("¿Desea salir?");
				Console.WriteLine("1) no");
				Console.WriteLine("2) si");
				 opcion2 = "";
                 opcion2 = Console.ReadLine();
                Console.WriteLine(opcion2);
                if (opcion2 == "1") 
				{
					salir = false; 
				}
				else
				{
					salir = true;
				}
			} while (salir == false);
		}
	}
	class Alumno
	{
		private string nombre;
		private int edad;

		public Alumno(string nombreAL)
		{
			nombre = nombreAL;

		}
		public Alumno(int edadAl)
		{
			edad = edadAl;

		}
		public void setImprimirNombre(string nombreDeAlumno)
		{
			nombre = nombreDeAlumno;
		}
		public string getImprimirNombre()
		{
			return "El nombre del alumno es: " + nombre;
		}
		public void setImprimirEdad(int edadDeAlumno)
		{
			edad = edadDeAlumno;
		}
		public string getImprimirEdad()
		{
			return "La edad del alumno es: " + edad;
		}
	}


}