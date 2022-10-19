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
            // array implícito

            // var datos = new[] { "Bruno", "Díaz", 40 };

            var valores = new[] { 15, 28, 35, 75.5, 50.0, 30.30, 90}; //todo a double

            //array de objetos

            Empleados Ana = new Empleados("Ana", 400);

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sara", 400);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Marco", 700);
            //array de tipos o clases anónimas

            var personas = new[]
            {
                new{Nombre="Juan", Dinero=19},

                new{Nombre="Marcos", Dinero=500},

                new{Nombre="Jorge", Dinero=900}
            };

            /*for (int i = 0; i <arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }*/

            foreach (var variable in personas)
            {
                Console.WriteLine(variable);

            }

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