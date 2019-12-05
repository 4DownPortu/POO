using System;
using System.IO;
namespace Proyecto
{
    class Producto
    {
        public string codigo 
        {
            get;
            set;
        }
        public string descripcion
        {
            get;
            set;
        }
        public double precio
        {
            get;
            set;
        }
        public int departamento
        {
            get;
            set;
        }

        public int likes
        {
            get;
            set;
        }


        public Producto(string cod, string des, double pre, int depa, int lik)
        {
            codigo = cod;
            descripcion = des;
            precio= pre;
            departamento =depa;
            likes = lik;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
