using System;

namespace Pase_de_Parametros
{
    class Valor
    {
        public void Alcuadrado(int a)
        {
            a = a * a;
        }
        public void AlcuadradoR(ref int a)
        {
            a = a * a;
        }
        public void Alcuadrado(in int a)
        {
            a = a * a;
            Console.WriteLine(a);
        }
        public void Suma(int a, int b, out int resultado)
        {
            resultado = a + b;
        }
    }
    class Empleado
    {
        public string Puesto;

        public Empleado()
        {
            Puesto = "Conserje";
        }
        
    }
    class Ascensos
    {
        static public void Mejorar_Puesto(Empleado x)
        {
            x.Puesto = "Maestro";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int z;
            
            
            Valor n = new Valor();
            n.Alcuadrado(x);
            Console.WriteLine(x);

            
            Empleado adolfo = new Empleado();
            Console.WriteLine(adolfo.Puesto);
            Ascensos.Mejorar_Puesto(adolfo);
            Console.WriteLine(adolfo.Puesto);

            
            n.AlcuadradoR(ref y);
            Console.WriteLine(y);

            
            n.Suma(x, y, out z);
            Console.WriteLine(z);

            
            n.Alcuadrado(in z);
            
        }
    }
}
