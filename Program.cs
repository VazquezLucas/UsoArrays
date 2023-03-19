using System;

namespace UsoArrays
{
    class program
    {
        static void Main(string[] args)
        {

            
            int[] edades;

            edades = new int[4];

            edades[0] = 15;

            edades[1] = 27;

            edades[2] = 19;

            edades[3] = 80;
            

            //Sintaxis simplificada

            int[] edades2 = {15, 27, 19, 80 };

            int[] edades3 =new int[5] { 15, 27, 19, 80, 21};

            Console.WriteLine(edades[2]);
            

            //Arrays implicito

            var datos = new[] {"Juan", "Díaz", "España"};

            var valores = new[] {15, 28, 35, 75.5, 30.30};


            //Arrays de objetos

            Empleados Ana = new Empleados("Ana", 27);

            Empleados[] arraysEmpleados = new Empleados[2];

            arraysEmpleados[0] = new Empleados("Sara", 37);

            arraysEmpleados[1] = Ana;

            //Arrays de tipos o clases anónimas

            var personas = new[]
            {
                new{Nombre="Juan", Edad=19},

                new{Nombre="María",Edad=49},

                new{Nombre="Diana",Edad=35}
            };

            Console.WriteLine(personas[1]);

        }
    }
    class Empleados
    {

        public Empleados(String nombre, int edad) 
        {
            this.nombre = nombre;

            this.edad = edad;

        }

        String nombre;

        int edad;

    }
}