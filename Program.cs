using System;
using System.Runtime.Serialization.Formatters;

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

            var valores = new[] {15, 28, 35, 75.5, 30.3, 90, 85.2}; //Todo es double internamente.


            //Arrays de objetos

            Empleados Ana = new Empleados("Ana", 27);

            Empleados[] arraysEmpleados = new Empleados[3];

            arraysEmpleados[0] = new Empleados("Sara", 37);

            arraysEmpleados[1] = Ana;

            arraysEmpleados[2] = new Empleados("Manuel", 51);

            //Arrays de tipos o clases anónimas

            var personas = new[]
            {
                new{Nombre="Juan", Edad=19},

                new{Nombre="María",Edad=49},

                new{Nombre="Diana",Edad=35}
            };
            
            //Recoridos de un arrays con bucle for
            for (int i=0; i <=4; i++)
            {

                Console.WriteLine(valores[i]);

            }

            //Otra forma de hacer lo de arriba pero mas complejo y menos productivo.

            int contador = 0;

            for (int i = 15; i >=11; i--)
            {

                Console.WriteLine(valores[contador]);
                contador++;

            }

            //Metodo LENGTH

            for (int i=0; i < valores.Length; i++)
            {

                Console.WriteLine(valores[i]);

            }
            
            //Metodo LENGTH de objetos

            for (int i=0; i <arraysEmpleados.Length; i++)
            {

                Console.WriteLine(arraysEmpleados[i].getInfo());

            }

            //Recorer arrays implicitas con Foreach

            foreach(Empleados variable in arraysEmpleados)
            {

                Console.WriteLine(variable.getInfo());

            }

            //Recorrer con foreach implicitos

            foreach(double variable in valores)
            {

                Console.WriteLine(variable);

            }

            //Recorrer con foreach un arrray anonima

            foreach (var variable in personas)
            {

                Console.WriteLine(variable);
            
            }
            //pasar arrays por parametros
            int[] numeros=new int[4];

            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            ProcesaDatos(numeros);

            //Imprime los numeros del arrays sumandole 10
            foreach (int i in numeros)
            {

                Console.WriteLine(i);

            }
            
            int[] arraysElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arraysElementos) Console.WriteLine(i);
        }
        
        static void ProcesaDatos(int[] datos)
        {

            foreach(int i in datos)
            {

                Console.WriteLine(i);

            }

            //Recorrer un arrays y modificar los datos

            for(int i=0; i<4; i++)
            {

                datos[i] += 10;

            }

        }
        
        //Crear un arrays por consola
        static int[] LeerDatos() 
        {

            Console.WriteLine("¿Cuantos elementos quieres que tenga el Array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i=0; i<numElementos; i++)
            {

                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElementos = int.Parse(respuesta);

                datos[i] = datosElementos;

            }

            return datos;

        }
    }
    class Empleados
    {

        public Empleados(String nombre, int edad) 
        {
            this.nombre = nombre;

            this.edad = edad;

        }

        public String getInfo()
        {

            return "Nombre del empleado: " + nombre + " Edad: " + edad;

        }

        private String nombre;

        private int edad;

    }
}