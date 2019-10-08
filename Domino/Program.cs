using System;


namespace Domino
{
    class Dominoo
    {
        private readonly int ladoA=0;
        private readonly int ladoB=0;

        public Dominoo(int ladoarriba, int ladoabajo)

        {
            ladoA=ladoarriba;
            ladoB= ladoabajo;

        }

        public static int operator + (Dominoo a, Dominoo b)
        {
            return(a.ladoA + a.ladoB + b.ladoA +b.ladoB);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
           Dominoo a= new Dominoo(2,0);
           Dominoo b= new Dominoo(4,1);
           Console.WriteLine(a+b);
            
        }
    }
}
