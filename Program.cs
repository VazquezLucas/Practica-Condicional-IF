using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaracion de variables booleanas
            bool haceFrio;

            haceFrio= true;

            Console.WriteLine(haceFrio);

            //Negar una variable con el operador !
            bool haceCalor;

            haceCalor=true;

            Console.WriteLine(!haceCalor);

            //Condicional IF
            
            int edad = 15;

            Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if (edad >= 18)
            {

                Console.WriteLine("Adelante puedes comprar porque eres mayor de edad");

                Console.WriteLine("Disfruta de tu bebida");

            }

            //IF con booleanos //Mas primer ELSE

            Console.WriteLine("Vamos a evaluar si puedes manejar el vehiculo");

            bool carnet = false;

            if (carnet == true) Console.WriteLine("Puede manejar");

                else Console.WriteLine("No puedes manejar");

            */

            //IF Con operadores logicos

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduce tu edad, por favor");

            int edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("¿Tienes carnet?");

            string carnet = Console.ReadLine();

            if(edad>=18&&carnet=="si") Console.WriteLine("Puedes conducir vehiculos");
            else Console.WriteLine("No puedes conducir vehiculos");




        }
    }
}