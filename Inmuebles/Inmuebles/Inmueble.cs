using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    internal class Inmueble
    {
        private string nombre;

        private string tamaño;

        private double ValorMuebles;

        private string Tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public double ValorMuebles1 { get => ValorMuebles; set => ValorMuebles = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }

        public void tipoMuebles(string _nombres, string _tamaño, double _Valormuebles, string _tipo)
        {
            this.Nombre = _nombres;
            this.Tamaño = _tamaño;
            this.Tipo = _tipo;
            this.ValorMuebles1 = _Valormuebles;


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese datos de el inmueble");
  
            Console.WriteLine(" Nombre de mueble");
            Nombre = Console.ReadLine();
            Console.WriteLine(" Ingrese el tamaño deseado");
            Tamaño = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de mueble que desea");
            Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese el valor del mueble ");
            ValorMuebles = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
        }

        public String gettipoMuebles()
        {
            Console.WriteLine("-------------------------------------");
            return " \n Nombre: " + Nombre + " \n Tamaño: " + Tamaño + " \n Tipo: " + Tipo + "\n ValorMuebles: " + ValorMuebles ;
            Console.WriteLine("-------------------------------------");
        }

    }
}