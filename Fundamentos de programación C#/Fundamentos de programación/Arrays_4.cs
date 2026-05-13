using System;
using System.Collections.Generic;
using System.Text;

namespace Practicas
{
    internal class Arrays_4
    {
        public void Run()
        {
            string[] names = new string[3]; // se declara un array de strings con capacidad para 3 elementos
            names[0] = "Germán";
            names[1] = "Horta";
            names[2] = "Venegas";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            // Funcion con array como parámetro
            int[] Generate(int lenght)
            {
                int[] numbers = new int[lenght];
                for (int i = 0; i < lenght; i++)
                {
                    numbers[i] = i + 1;
                }
                return numbers;
            }

            int[] myNumbers = Generate(5);

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            // Alternativa a switch con arrays
            string[] messages = new string[]
            {
                "Es un bebé",
                "Es un niño",
                "Es un adolescente",
                "Es mayor de edad",
                "Es de la tercera edad"
            };

            int age = 62;
            if (age < 3)
            {
                Console.WriteLine(messages[0]);
            }
            else if (age < 13)
            {
                Console.WriteLine(messages[1]);
            }
            else if (age < 18)
            {
                Console.WriteLine(messages[2]);
            }
            else if (age < 60)
            {
                Console.WriteLine(messages[3]);
            }
            else if (age < 120)
            {
                Console.WriteLine(messages[4]);
            }
            else
            {
                Console.WriteLine("Valor no válido");
            }
        }
    }
}
