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

            
            
            //IF Con operadores logicos

            string carnet2="no";

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduce tu edad, por favor");

            int edad2 = Int32.Parse(Console.ReadLine());

            if (edad2 >= 18)
            {

                Console.WriteLine("¿Tienes carnet?");

                carnet2 = Console.ReadLine();

            }

            if (edad2 >= 18 && carnet2 == "si")
            { 
                
                Console.WriteLine("Puedes conducir vehiculos");

            }

            else
            {   

                Console.WriteLine("No puedes conducir vehiculos");

            }
            
            //Otra forma de hacer el codigo de arriba


            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduce tu edad, por favor");

            int edad2 = Int32.Parse(Console.ReadLine());

            if (edad2 < 18) Console.WriteLine("No puedes conducir vehiculos");

            else
            {

                Console.WriteLine("¿Tiene cartnet?");

                string cartnet = Console.ReadLine();

                int compara = String.Compare(cartnet, "si", true);

                    if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

                        else Console.WriteLine("Lo siento mucho no puedes conducir");

            }

            

            //Programa para calcular una nota media de un alumno de 3 trimestres

            Console.WriteLine("Introduce el primer trimestre");

            int trimestre1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo trimestre");

            int trimestre2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer trimestre");

            int trimestre3 = Int32.Parse(Console.ReadLine());

            if(trimestre1 >= 7 && trimestre2 >= 7 && trimestre3 >= 7)
            {
                Console.WriteLine("La nota media es " + (trimestre1 + trimestre2 + trimestre3) /3);
            }
            else
            {
                Console.WriteLine("Vuelve en diciembre");
            }

            

            //Mismo programa de arriba pero esta vez aprobando 1 de los 3 trimestres

            Console.WriteLine("Introduce el primer trimestre");

            float trimestre1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo trimestre");

            float trimestre2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer trimestre");

            float trimestre3 = Int32.Parse(Console.ReadLine());

            if (trimestre1 >= 7 || trimestre2 >= 7 || trimestre3 >= 7)
            {
                Console.WriteLine("La nota media es " + (trimestre1 + trimestre2 + trimestre3) / 3);
            }
            else
            {
                Console.WriteLine("Vuelve en diciembre");
            }

            */

            //Uso de else if o comparacion de varias condiciones encadenadas

            Console.WriteLine("Introduce tu edad");

            int edad=Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño");

                else if (edad >= 18 && edad < 30) Console.WriteLine("Eren joven");

                    else if (edad >= 30 && edad<60) Console.WriteLine("Eres maduro");

                        else Console.WriteLine("Debes cuidiarte ya");

        }
    }
}