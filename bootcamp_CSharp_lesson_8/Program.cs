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

            var valores = new[] { 15, 28, 35, 75.5, 50.0, 90}; //todo a double

            //array de objetos

            Empleados Ana = new Empleados("Ana", 400);

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Sara", 400);

            arrayEmpleados[1] = Ana;

            //array de tipos o clases anónimas

            var personas = new[]
            {
                new{Nombre="Juan", Dinero=19},

                new{Nombre="Marcos", Dinero=500},

                new{Nombre="Jorge", Dinero=900}
            };

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine(valores[i]);
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

        string nombre;
        int dinero;
    }

}