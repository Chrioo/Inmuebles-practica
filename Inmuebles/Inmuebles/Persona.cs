using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    internal class Persona
    {

        private string nombre;

        private string apellido;

        private int edad;

        private int dui;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dui { get => dui; set => dui = value; }



        public void Personas(string _nombre, string _Apellido, int _edad, int _dui)
        {
            this.Nombre = _nombre;
            this.Apellido = _Apellido;
            this.Edad = _edad;
            this.Dui = _dui;

            

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Ingrese  Sus Datos");

            Console.WriteLine(" Nombre ");
            Nombre = Console.ReadLine();
            Console.WriteLine(" Ingrese Su Apellido");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Su edad ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su N_Dui ");
            Dui = int .Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
        }

        public String Cliente()
        {
            Console.WriteLine("-------------------------------------");
            return " \n Nombre: " + Nombre + " \n Apellido: " + Apellido + "\n Edad: " + Edad + "\n Dui: " + Dui;
            Console.WriteLine("-------------------------------------");
        }
    }
}
