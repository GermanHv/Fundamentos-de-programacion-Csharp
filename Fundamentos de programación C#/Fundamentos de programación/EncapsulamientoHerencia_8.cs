using System;

namespace Practicas
{
    class People
    {
        // campo protegido, solo accesible dentro de la clase y sus clases derivadas
        protected string name;

        public People(string name)
        {
            this.name = name;
        }
        protected string GetDescription()
        {
            return $"El nombre de la persona es: {name}";
        }
    }
    class Engineer : People
    {
        private string _profession;

        public Engineer(string name, string profession) : base(name)
        {
            _profession = profession;
        }

        public string GetInfo()
        {
            return $"La profesión es {_profession} " + GetDescription();
        }
        public string GetName()
        {
            return name;
        }
    }

    internal class EncapsulamientoHerencia_8
    {
        public void Run()
        {
            Engineer german = new Engineer("Germán", "Programación");
            Console.WriteLine(german.GetInfo());

            // No es publico
            // Console.WriteLine(german.name);
            Console.WriteLine(german.GetName());
            //Console.WriteLine(german._profession);

        }
    }
}
