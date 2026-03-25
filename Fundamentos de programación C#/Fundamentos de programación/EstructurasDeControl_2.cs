using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentos_de_programación_C_
{
    internal class EstructurasDeControl_2
    {
        public void Run()
        {
            // Estructura de control if-else
            int age = 62;
            if (age >= 18)
            {
                Console.WriteLine("Mayor de edad");
            }
            else if (age >= 13)
            {
                Console.WriteLine("Es un adolescente");
            }
            else
            {
                Console.WriteLine("Es un niño");
            }

            // Operadores lógicos
            bool wannaDrink = true;
            int money = 0;

            if (money > 0 && wannaDrink)
            {
                Console.WriteLine("Se toma una cerveza");
            }

            bool isDead = false;
            if (!isDead)
            {
                Console.WriteLine("Esta vivo");
            }

            // Switch

            switch (age)
            {
                case < 3:
                    Console.WriteLine("Es un bebé");
                    break;
                case < 13:
                    Console.WriteLine("Es un niño");
                    break;
                case < 18:
                    Console.WriteLine("Es un adolescente");
                    break;
                case < 60:
                    Console.WriteLine("Es mayor de edad");
                    break;
                case < 120:
                    Console.WriteLine("Es de la tercera edad");
                    break;

                default:
                    Console.WriteLine("Valor no válido");
                    break;
            }

            // Bucle While
            int counter = 0;
            int times = 5;

            // Se repite hasta que counter llegue a 5
            while (counter < times)
            {
                Console.WriteLine($"Counter vale {counter}");
                counter++;
            }

            // Do While
            do
            {
                Console.WriteLine($"Counter vale {counter}");
                counter++;
            } while (counter < times);

            // Bucle For
            // se estructura en 3 partes: inicialización, condición y actualización
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"Counter vale {i}");
            }
        }
    }
}
