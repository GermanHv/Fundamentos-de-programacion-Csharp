using System;

namespace Practicas

{
    // Aqui se agregan clases, enums, interfaces...
    internal class Static_10
    {
        class Beer
        {
            // El operador static puede ir en una propiedad
            public static int Quantity = 0;
            public Beer()
            {
                // Cuando se crea un nuevo objeto se incrementa Quantity
                Quantity++;
            }
            // También podemos aplicar que un método sea estático
            public static void Show()
            {
                Console.WriteLine(Quantity);
            }
        }
        public void Run()
        {
            // Al crear un objeto la propiedad Quantity se incrementa
            var myBeer = new Beer();

            // En este punto tendríamos en la pantalla un 1 impreso
            // Accedemos a Quantity directamente de la clase y no del objeto
            Console.WriteLine(Beer.Quantity);

            // Al crear 2 nuevos objetos Quantity se incrementa nuevamente
            var myBeer1 = new Beer();
            var myBeer2 = new Beer();

            // En este punto Quantity nos daría un 3
            Console.WriteLine(Beer.Quantity);

            // Para acceder a un método estático, solo escribo la clase y el método sin crear un objeto
            Beer.Show();
        }

    }
}