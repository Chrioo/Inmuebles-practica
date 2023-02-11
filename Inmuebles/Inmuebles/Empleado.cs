using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    internal class Empleado : Persona
    {
        private double salario;

        private string contrato;

        private string tiempo_Contrato;

        public double Salario { get => salario; set => salario = value; }
        public string Contrato { get => contrato; set => contrato = value; }
        public string Tiempo_Contrato { get => tiempo_Contrato; set => tiempo_Contrato = value; }

        public void Empleados(double _Salario, string _contrato, string _tiempo_Contrato)
        {
            this.Salario = _Salario;
            this.Contrato = _contrato;
            this.Tiempo_Contrato = _tiempo_Contrato;
            

            Console.WriteLine("Ingrese  Datos de Empleado");

             Console.WriteLine("Ingrese el Nombre del Empleado");
            Nombre = Console.ReadLine();
            Console.WriteLine(" Salario");
            Salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" Contrato");
            Contrato = Console.ReadLine();
            Console.WriteLine("Ingrese El Tiempo de Contrato");
            Tiempo_Contrato = Console.ReadLine();
           
        }

        public String getEmpleados()
        {
            Console.WriteLine("-------------------------------------");
            return " \n Nombre: " + Nombre + " \n Salario: " + Salario + " \n Apellido: " + Apellido + "\n Edad: " + Edad + "\n Dui: " + Dui;
            Console.WriteLine("-------------------------------------");
        }
    }
}
