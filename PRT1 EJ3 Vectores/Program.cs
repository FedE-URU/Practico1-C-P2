using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT1_EJ3_vectores
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*3- Realice el código usando diagrama de clases, para poder imprimir en pantalla
				la resta y la suma de dos vectores.
				-----------------------------------------------------------------------------------------------------------------
				
				SUMAR: 
				Para conocer el vector suma A+B→ sólo tenemos que sumar, respectivamente, las componentes X y las componentes Y:
				A= (4, 3) , B= (2, 5) -SERIA- A+B→  = (4+2, 3+5) = (6, 8)
				-----------------------------------------------------------------------------------------------------------------
				RESTA:Para restar dos vectores A y B se suma A con el opuesto de vector B, es decir:
				A – B = A + (- B)
				A = (5, 2, 4) y B = (-3, 5, 9) -SERIA- A – B = ( 5-(-3), 2-5, 4-9) = (8,-3,-5)
	
				*/
			PruebaVector VectoresDatos = new PruebaVector();
			VectoresDatos.datosVectores();
			VectoresDatos.sumaYRestaVectores();
		}
		class PruebaVector
		{
			private int[] A;
			private int[] B;
			private int[] sumaV;
			private int[] restaV;

			public void datosVectores()
			{
				Console.Write("Ingrese cantidad de componentes a sumar y restar: ");
				string datosV;
				datosV = Console.ReadLine();
				int n = int.Parse(datosV);
				A = new int[n];
				B = new int[n];
				sumaV = new int[n];
				restaV = new int[n];
				Console.WriteLine("Ingrese valores de los componentes vector A");
				for (int i = 0; i < A.Length; i++)
				{
					Console.Write("Ingrese valor del componente N°" + (i + 1) + " del vector A: ");
					datosV = Console.ReadLine();
					A[i] = int.Parse(datosV);
				}
				Console.WriteLine("Ingrese valores de los componentes vector B");
				for (int j = 0; j < B.Length; j++)
				{
					Console.Write("Ingrese valor del componente N°" + (j + 1) + " del vector B: ");
					datosV = Console.ReadLine();
					B[j] = int.Parse(datosV);
				}
				for (int i = 0; i < A.Length; i++)
				{
					sumaV[i] = A[i] + B[i];

				}
				for (int i = 0; i < A.Length; i++)
				{
					restaV[i] = A[i] - B[i];

				}
			}
			public void sumaYRestaVectores()
			{
				Console.WriteLine("La suma de los vectores es: ");
				for (int i = 0; i < A.Length; i++)
				{
					Console.Write("[" + sumaV[i] + "] ");
				}
				Console.ReadLine();
				Console.WriteLine("La resta de los vectores es: ");
				for (int i = 0; i < A.Length; i++)
				{
					Console.Write("[" + restaV[i] + "] ");
				}
				Console.ReadLine();
			}


		}


	}
}