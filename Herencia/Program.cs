using System;

namespace Herencia
{
    class Persona
    {
        protected string _nombre;
        public string Nombre;
        {
            get
            {
                return_nombre;
            }
        }

        public Persona (string n)
        {
            nombre=n;
        }
        public void print ()
        {
            Console.WriteLine("mi nombre es {0}", nombre);
        }
    }

    class Alumno:Persona
    {
        protected String num_control;
        public Alumno(string nombre, string num_control):base(nombre)
        {
            this.num_control;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
