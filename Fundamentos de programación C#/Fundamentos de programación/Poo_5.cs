using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Fundamentos_de_programación_C_.Fundamentos_de_programación
{
    class Sale
    {
        public decimal Total;
        public string Customer;

        // Comportamiento del objeto
        public string GetInfo()
        {
            string info = "El total es: $ " + Total;
            info += " y el cliente es: " + Customer;
            return info;

        }

        // Constructor
        public Sale(decimal total, string customer)
        {
            Total = total;
            Customer = customer;
        }

    }

    internal class Poo_5
    {
        public void Run()
        {
            Console.WriteLine("Programación Orientada a Objetos en C#");
            //La programación orientada a objetos(POO) es un paradigma de programación que se basa en el concepto de "objetos",

            // Si no tuviera constructor se haria de esta forma
            //Sale sale = new Sale();
            //sale.Total = 100.50m;
            //sale.Customer = "Germán";

            Sale sale = new Sale(100.50m, "Germán");
            string info = sale.GetInfo();
            Console.WriteLine(info);
        }
    }
}