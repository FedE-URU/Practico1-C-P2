using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_Ejercico7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Remito Recibo1 = new Remito();
            Factura Factura1 = new Factura();
            FacturaLuz FacturaLuz = new FacturaLuz();
            Municipal Municipal1 = new Municipal();
            ReciboSueldo reciboSueldo1 =new ReciboSueldo();


            
              int opcion;

                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("1) Ingresar y mostrar Remito");
                Console.WriteLine("2) Ingresar y mostrar Factura");
                Console.WriteLine("3) Ingresar y mostrar Factura de luz");
                Console.WriteLine("4) Ingresar y mostrar Municipal");
                Console.WriteLine("5) Ingresar y mostrar Recibo de sueldo");
               
               opcion = Int32.Parse(Console.ReadLine()); 
           
            switch (opcion)
            { 
          
            case 1: 
            Console.WriteLine("Ingrese la cantidad de bultos");
            int bulto = Int32.Parse(Console.ReadLine());
            Recibo1.SetCantbultos(bulto);

            Console.WriteLine("Ingrese la Fecha");
            int Fecha = Int32.Parse(Console.ReadLine());
            Recibo1.SetFecha(Fecha);


            Console.WriteLine("Ingrese el numero de remito");
            int Numero = Int32.Parse(Console.ReadLine());
            Recibo1.SetNumero(Numero);

            Console.WriteLine("Remito");
            Recibo1.GetRemito();
                    break;
            case 2:
                 
            Console.WriteLine("Ingrese la Fecha de factura");
            int FechaFactura = Int32.Parse(Console.ReadLine());
            Factura1.SetfechaFactura(FechaFactura);

            Console.WriteLine("Ingrese el importe");
            int importe = Int32.Parse(Console.ReadLine());
            Factura1.SetImporteFactura(importe);

            Console.WriteLine("Factura");
            Factura1.GetFactura();
                    break;
              case 3:
            Console.WriteLine("Ingrese el codigo de pago");
            int CodigoDePago = Int32.Parse(Console.ReadLine());
            FacturaLuz.SetCodigoPago(CodigoDePago);

            Console.WriteLine("Ingrese el importe de factura de luz ");
            int importeDeLuz = Int32.Parse(Console.ReadLine());
            FacturaLuz.SetimporteFacturaLuz(importeDeLuz);
                   
            Console.WriteLine("Factura de luz ");
            FacturaLuz.GetFacturaLuz();
 
                    break;
              case 4:
            Console.WriteLine("Ingrese partida de municipal ");
            int PartidaMunicipal = Int32.Parse(Console.ReadLine());
            Municipal1.SetPartidaMunicipal(PartidaMunicipal);

            Console.WriteLine("Ingrese el importe municipal ");
            int importemunicipal = Int32.Parse(Console.ReadLine());
            Municipal1.SetimporteMunicipal(importemunicipal);

            Console.WriteLine("Municipal ");
            Municipal1.GetMunicipal();
                    break;
                   case 5:    
            Console.WriteLine("Ingrese el legajo ");
            int LegajoReciboDeSueldo = Int32.Parse(Console.ReadLine());
            reciboSueldo1.SetLegajo(LegajoReciboDeSueldo);



            Console.WriteLine("Ingrese el total : ");
            int Total = Int32.Parse(Console.ReadLine());
            reciboSueldo1.SetTotal(Total);

            

            Console.WriteLine("Recibo De Sueldo ");
            reciboSueldo1.GetReciboSueldo();
               break;
            }
                    
                   

         }
        }
    

    class Remito
    {
        private int cantBultos;
        private int Fecha;
        private int Numero;


        public void GetRemito()
        {
            Console.WriteLine("la cantidad de bultos son: " +cantBultos);
            Console.WriteLine("la Fecha del remito es: " + Fecha);
            Console.WriteLine("El numero del remito es: " + Numero);
        }
        public void SetCantbultos(int cantBultos)
        {
            this.cantBultos = cantBultos;

        }
        public void SetFecha(int Fecha)
        {
            this.Fecha = Fecha;

        }

        public void SetNumero(int Numero)
        {
            this.Numero = Numero;

        }

    }

    class Factura
    {
        private int fecha;
        private int importe;


        public void GetFactura()
        {
            Console.WriteLine("la fecha de la factura es: " + fecha);
            Console.WriteLine("el importe de la factura es: " + importe);


        }
        public void SetfechaFactura(int fecha)
        {
            this.fecha = fecha;

        }
        public void SetImporteFactura(int importe)
        {
            this.importe = importe;

        }

    }

    class FacturaLuz
    {
        private int CodigoPago;
        private int importe;


        public void GetFacturaLuz()
        {
            Console.WriteLine("el codigo de la factura de la luz es: " + CodigoPago);
            Console.WriteLine("el importe de la factura de la luz es: " + importe);


        }
        public void SetCodigoPago(int CodigoPago)
        {
            this.CodigoPago = CodigoPago;

        }

        public void SetimporteFacturaLuz(int importe)
        {
            this.importe = importe;

        }


    }


    class Municipal
    {
        private int Partida;
        private int importe;


        public void GetMunicipal()
        {
            Console.WriteLine("La partida municipal es: " + Partida);
            Console.WriteLine("El importe municipal es: " + importe);


        }

        public void SetPartidaMunicipal(int Partida)
        {
            this.Partida = Partida;

        }
        public void SetimporteMunicipal(int importe)
        {
            this.importe = importe;

        }
    }

    class ReciboSueldo
    {
        private int Legajo;
        private int Total;


        public void GetReciboSueldo()
        {
            Console.WriteLine("El legajo del sueldo es: " + Legajo);
            Console.WriteLine("El total es: " + Total);


        }

        public void SetLegajo(int Legajo)
        {
            this.Legajo = Legajo;

        }

        public void SetTotal(int Total)
        {
            this.Total = Total;

        }


    }
}