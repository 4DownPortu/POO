using System;
using System.IO;
using System.Collections.Generic;

namespace creadir
{
    class Producto
    {
        public string codigo, descripcion;
        public double precio;

        public Producto (string c, string d, double p)
        {
            codigo=c;
            descripcion=d;
            precio=p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW","Lapiz Azul w2",12.23d));
            productos.Add(new Producto("AQW","Lapiz Verde w2",23.13d));
            productos.Add(new Producto("AQW","Pluma Negra w2",26.43d));
            productos.Add(new Producto("AQW","Borrador w2",17.56d));

            FileStream fs= new FileStream(@"productos.txt",FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.Write(p.descripcion + " ");
                txtOut.WriteLine(p.precio);
            }
            fs.Close();
        }
    }
}
