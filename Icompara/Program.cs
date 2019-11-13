using System;
using System.Collections.Generic;

namespace Icompara
{
    class Persona
    {
        int id;
        string nombre;

        public Persona (int id, string n)
        {
            this.id=id;
            nombre= n;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", id, nombre);
        }

        public int CompareTo(Object o)
        {
            return this.id.CompareTo(((Persona)o).id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> pers=new List<Persona>();
            pers.Add(new Persona(2,"Pamela"));
            pers.Add(new Persona(6,"Luis"));
            pers.Add(new Persona(5,"Adolfo"));

            foreach(Persona p in pers)
            Console.WriteLine(p);
        }
    }
}
