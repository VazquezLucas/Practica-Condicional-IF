using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {

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

            }
            else
            {
                Console.WriteLine("No puedes comprar porque eres menor de edad");
            }



        }
    }
}