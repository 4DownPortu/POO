using System;

namespace Duracion
{
    class Duracion
    {
        public int horas;
        public int minutos;
        public int segundos;

        public Duracion(int h, int m, int s)
        {
            this.horas=h;
            this.minutos=m;
            this.segundos=s;
        }

        public void print ()
        {
            Console.WriteLine(" Horas:"+horas+ " Minutos:"+minutos+" Segundos:"+segundos);       
        }

        public void conversiones()
        {
            minutos=(horas*60)+minutos;
            segundos=(minutos*60)+(horas*60*60)+segundos;

            Console.WriteLine("Los minutos son:"+minutos);
            Console.WriteLine("Los segundos son:"+segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion a= new Duracion(2,15,12);
            Duracion b= new Duracion(00,02,15);
            Duracion c= new Duracion(2,00,10);

            a.print();
            a.conversiones();
            Console.WriteLine("\t");

            b.print();
            b.conversiones();
            Console.WriteLine("\t");

            c.print();
            c.conversiones();

            
           
           
        }
    }
}
