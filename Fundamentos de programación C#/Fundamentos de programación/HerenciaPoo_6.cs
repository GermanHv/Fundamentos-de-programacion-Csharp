using System.Runtime.InteropServices;

namespace Fundamentos_de_programación_C_.Fundamentos_de_programación
{
    // Clase padre
    class Water
    {
        public string Name;
        public int Mililitros;
        public Water(string name, int mililitros)
        {
            Name = name;
            Mililitros = mililitros;
        }
    }
    // Clase hija que hereda de Water
    // Para heredar se utiliza el símbolo ":" y el nombre de la clase padre
    class Beer : Water
    {
        public string Style;
        public Beer(string style, string name, int mililitros) : base(name, mililitros)
        {
                Style = style;
        }
    }

        internal class HerenciaPoo_6
        {
            public void Run()
            {
                // Creamos un objeto de la clase hija
                // Beer myBeer = new();
                Beer myBeer = new Beer("Lager", "Cerveza Modelo", 350);
                // Podemos acceder a los miembros de la clase padre
                // myBeer.Name = "Cerveza";
                // Podemos acceder a los miembros de la clase hija
                //myBeer.Style = "Lager";
                Console.WriteLine($"La {myBeer.Name} es del estilo {myBeer.Style} de {myBeer.Mililitros}ml.");

            }
        }
}
