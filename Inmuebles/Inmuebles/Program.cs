using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inmuebles
{
    internal class Program : Persona
    {
        static void Main(string[] args)
        {
            int id;

          
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("----------  BIENVEDIDO/A  ----------");
                    Console.WriteLine("------------- MENU:------------------");
                    Console.WriteLine("Ingrese el numero de su consulta");
                    Console.WriteLine("\n1 - Lista de inmuebles");
                    Console.WriteLine("\n2 - Comprar");
                    Console.WriteLine("\n3 - Salir");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("-------------------------------------"); 

            Console.WriteLine("\nIngrese el numero de su consulta");
            id = int.Parse(Console.ReadLine());
            if (id == 1)
            {

                
            }
            if (id == 2)
            {
                Persona persona = new Persona();

                Empleado empleado = new Empleado();

                Inmueble inmueble = new Inmueble();

                persona.Personas(persona.Nombre,persona.Apellido,persona.Edad,persona.Dui);

                empleado.Empleados(empleado.Salario, empleado.Contrato, empleado.Tiempo_Contrato);

                inmueble.tipoMuebles(inmueble.Nombre, inmueble.Tamaño, inmueble.ValorMuebles1, inmueble.Tipo1);
   
                
                Console.WriteLine(persona.Cliente());

                Console.WriteLine(empleado.getEmpleados());

                Console.WriteLine(inmueble.gettipoMuebles());
                Console.ReadLine();                                                                




            }
            if (id == 3)
            {
                Environment.Exit(0);
            }


            else
            {
                Console.WriteLine("El numero de consulta que usted eligio es incorrecto");
            }

            
        }


    }              
    
}
