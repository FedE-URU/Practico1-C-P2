using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz = new Matriz();
            Console.WriteLine(matriz.Suma_Matriz());
        }
    }
    class Matriz
    {
        Random rnd = new Random(); //Clase predefinida que permite crear numeros aleatorios
        private int A1;    
        private int B1;
        private int A2;
        private int B2;
        private int Resultado;
    
        int[,] Matrz1 = new int[,] { { 0, 0 }, { 0, 0 } };
        int[,] Matrz2 = new int[,] { { 0, 0 }, { 0, 0 } };
        int[,] MatrzFinal = new int[,] { { 0, 0 }, { 0, 0 } };
        public Matriz()
        {
            A1 = rnd.Next(101);    //Genera numeros Aleatorios 
            B1 = rnd.Next(101);   //Entre 0 y 100
            A2 = rnd.Next(101);
            B2 = rnd.Next(101);
            Matrz1[0, 0] = A1;
            Matrz1[0, 1] = A2;
            Matrz1[1, 0] = B1;
            Matrz1[1, 1] = B2;

            A1 = rnd.Next(101);    
            B1 = rnd.Next(101);   
            A2 = rnd.Next(101);
            B2 = rnd.Next(101);
            Matrz2[0, 0] = A1;
            Matrz2[0, 1] = A2;
            Matrz2[1, 0] = B1;
            Matrz2[1, 1] = B2;

        }
        public string Suma_Matriz()
        {
            Console.WriteLine("La matriz A esta compuesta por: {" + Matrz1[0, 0] + " " + Matrz1[0, 1]+ " " + Matrz1[1, 0] + " " + Matrz1[1, 1] + "}");
            Console.WriteLine("La matriz B esta compuesta por: {" + Matrz2[0, 0] + " " + Matrz2[0, 1]+ " " + Matrz2[1, 0] + " " + Matrz2[1, 1] + "}");

            //Resultado1 = Matrices[0,0] + Matrices[1,0];
            //Resultado2 = Matrices[0,1] + Matrices[1,1];

            Resultado = Matrz1[0, 0] + Matrz2[0, 0];
            MatrzFinal[0, 0] = Resultado;
            Resultado = Matrz1[0, 1] + Matrz2[0, 1];
            MatrzFinal[0, 1] = Resultado;
            Resultado = Matrz1[1, 0] + Matrz2[1, 0];
            MatrzFinal[1, 0] = Resultado;
            Resultado = Matrz1[1, 1] + Matrz2[1, 1];
            MatrzFinal[1, 1] = Resultado;
             
            return "La Suma de la matriz A.B es: {" + MatrzFinal[0,0] + " " + MatrzFinal[0, 1] + " " + MatrzFinal[1, 0]+ " " + MatrzFinal[1, 1] + "}";
        }
    }
}
