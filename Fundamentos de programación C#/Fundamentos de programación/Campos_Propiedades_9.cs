using System;

namespace Practicas

{
    // Aqui se agregan clases, enums, interfaces...
    internal class Campos_Propiedades_9
    {
        class Sale
        {
            // El campo total es privado
            private decimal total;

            // La propiedad Total actúa como medio de acceso al campo
            // privado total
            public decimal Total
            {
                // Con la palabra get especificamos lo que se regresará
                get {  return total; }

                // Con la palabra set especificamos que pasará al darle un valor a la propiedad
                set
                {
                    total = value;
                    // Validamos y asignamos en caso de número negativo
                    if(total < 0)
                    {
                        total = 0; 
                    }

                }
            }
        }

        public void Run()
        {
            Sale sale = new Sale();

            sale.Total = -1;

            // Obtenemos el valor por defecto 0 al obtenerlo de la propiedad pública Total
            Console.WriteLine(sale.Total);
            
        }

    }
}