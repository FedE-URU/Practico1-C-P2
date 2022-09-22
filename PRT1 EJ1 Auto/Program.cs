using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTO
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Auto auto1 = new Auto();
			Auto auto2 = new Auto(3.5, 2.5);
			auto2.setExtras(true, "Cuero");
			Console.WriteLine(auto1.getInfoAuto());
			Console.WriteLine("  ");
			Console.WriteLine(auto1.getExtras());
			Console.WriteLine("  ");
			Console.WriteLine(auto2.getInfoAuto());
			Console.WriteLine("  ");
			Console.WriteLine(auto2.getExtras());

		}
	}

	class Auto
	{
		private int ruedas;
		private double largo;
		private double ancho;
		private bool climatizador;
		private string tapiceria;

		public Auto()
		{
			ruedas = 4;
			largo = 3;
			ancho = 2;
			climatizador = false;
			tapiceria = "Tela";
		}
		public Auto(double largoAuto, double anchoAuto)
		{
			ruedas = 4;
			largo = largoAuto;
			ancho = anchoAuto;
			climatizador = false;
			tapiceria = "tela";
		}

		public string getInfoAuto()
		{
			return "El auto tiene:\n" + "Ruedas: " + ruedas + "\n" + "Largo: " + largo + "\n" + "Ancho: " + ancho;

		}
		public void setThisExtras(bool climatizador, string tapiceria)
		{
			this.climatizador = climatizador;
			this.tapiceria = tapiceria;
		}
		public void setExtras(bool climatizadorAuto, string tapiceriaAuto)
		{
			climatizador = climatizadorAuto;
			tapiceria = tapiceriaAuto;
		}
		public string getExtras()
		{
			return "El auto tiene: \n" + "Climatizador: " + climatizador + "\n" + "Tapicería: " + tapiceria + "\n";
		}
	}

}

