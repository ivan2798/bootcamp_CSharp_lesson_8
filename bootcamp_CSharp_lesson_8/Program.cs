using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;



// Hello World! program
namespace bootcamp_CSharp_lesson_8
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arrayElementos)
            {
                Console.WriteLine(i);

            }

        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuántos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i=0; i<numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }

            return datos;   
        }

       


    }

    class Empleados
    {
        public Empleados(String nombre, int dinero)
        {
            this.nombre = nombre;   
            
            this.dinero = dinero;   
        }

        public string getInfo()
        {
            return "Nombre del empleado:" + nombre + "Salario:" + dinero;
        }
        private string nombre;

        private int dinero;
    }

}