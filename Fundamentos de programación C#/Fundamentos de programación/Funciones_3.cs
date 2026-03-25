using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentos_de_programación_C_
{
    internal class Funciones_3
    {
        public void Run() {

            //void Hi()
            //{  // indica que no regresa ningun valor
            //    Console.WriteLine("Hola");
            //}

            //Hi();

            void Hi(string name, string lastName)
            {
                Console.WriteLine($"Hola {name} {lastName}");
            }

            Hi("Germán", "Horta");

            int Add(int a, int b)
            {
                return a + b; // regresa la suma de a y b
            }
            int result = Add(5, 3);
            Console.WriteLine(result);
        }
    }
}
