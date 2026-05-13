using System;

namespace Practicas
{
    // clase impuesto
    class Tax
    {
        // proiedad publica
        public decimal Amount;
        // propiedad privada: se pone un _ como convención para indicar que es privada
        private decimal _rate;

        // constructor
        public Tax (decimal amount, decimal rate)
        {
            Amount = amount;
            _rate = rate;
        }

        // método público que puede accederse por fuera de la clase
        public decimal GetTotal()
        {
            return Amount * _rate;
        }

    }


    internal class Encapsulamiento_7
    {
        public void Run()
        {
            Tax tax = new Tax(10.5m, 1.16m);
            Console.WriteLine(tax.GetTotal());
            Console.WriteLine(tax.Amount);
            //Console.WriteLine(tax._rate); error: no se puede acceder a una propiedad privada desde fuera de la clase
        }
    }
}
