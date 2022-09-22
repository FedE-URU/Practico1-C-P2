using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace Ejercicio6
{
    internal class Program

    {

        public static void Main()
        {
            Console.WriteLine("Escribir hora: ");

            int Hora = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribir minutos: ");

            int minutos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribir segundos: ");

            int segundos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribir milisegundos: ");

            int milisegundos = Int32.Parse(Console.ReadLine());

            DateTime HoraActual1 = new DateTime(2022, 09, 17, Hora, minutos, segundos, milisegundos);

            Console.WriteLine(HoraActual1.ToString("yyyy/MM/dd/-HH:mm:ss:fff"));

            Console.Write("Si Desea agregarle una hora ingrese s sino ingrese cualquier tecla ");

            string Confirmacion = Console.ReadLine();

            if (Confirmacion ==  "s")
            {

                int opcion;

                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("1) sumar 1 hora");
                Console.WriteLine("2) sumar 1 minuto");
                Console.WriteLine("3) sumar 10 segundos");
                Console.WriteLine("4) sumar 100 milisegundos");

                opcion = Int32.Parse(Console.ReadLine());

                AgregarHora(opcion);


            }
            Console.WriteLine("Agregar un nuevo horario ");

            Console.WriteLine("Escribir hora: ");

            int Hora2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribir minutos: ");

            int minutos2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribir segundos: ");

            int segundos2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribir milisegundos: ");

            int milisegundos2 = Int32.Parse(Console.ReadLine());



            DateTime HoraActual2 = new DateTime(2022, 09, 17, Hora2, minutos2, segundos2, milisegundos2);

            Console.WriteLine(HoraActual2.ToString("yyyy/MM/dd/-HH:mm:ss:fff"));

            void sumaDeHoras()
            {

                Console.WriteLine("la suma de las horas es :" + HoraActual1.AddHours(Hora2).AddMinutes(minutos2).AddSeconds(segundos2).AddMilliseconds(milisegundos2).ToString("yyyy/MM/dd/-HH:mm:ss:fff"));

            }

            void DiferenciasEntreHoras()
            {

                Console.WriteLine("la diferencia de horas es :" + HoraActual1.Subtract(HoraActual2).Hours);
                Console.WriteLine("la diferencia de minutos es :" + HoraActual1.Subtract(HoraActual2).Minutes);
                Console.WriteLine("la diferencia de segundos es :" + HoraActual1.Subtract(HoraActual2).Seconds);
                Console.WriteLine("la diferencia de milisegundos es :" + HoraActual1.Subtract(HoraActual2).Milliseconds);

            }
            DiferenciasEntreHoras();
            sumaDeHoras();

            string AgregarHora(int opcion)
            {

                switch (opcion)
                {

                    case 1:
                        Console.WriteLine(HoraActual1.AddHours(1).ToString("yyyy/MM/dd/-HH:mm:ss:fff"));
                        break;
                    case 2:
                        Console.WriteLine(HoraActual1.AddMinutes(1).ToString("yyyy/MM/dd/-HH:mm:ss:fff"));

                        break;
                    case 3:
                        Console.WriteLine(HoraActual1.AddSeconds(10).ToString("yyyy/MM/dd/-HH:mm:ss:fff"));
                        break;

                    case 4:
                        Console.WriteLine(HoraActual1.AddMilliseconds(100).ToString("yyyy/MM/dd/-HH:mm:ss:fff"));
                        break;
                }
                return HoraActual1.ToString("yyyy/MM/dd/-hh:mm:ss:fff");

                
            }

            Console.ReadKey();
        }

    }

}




