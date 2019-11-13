using System;

public class Pila<T>
{
    readonly int tamano;
     int apuntador=0;
     T [] elementos;

    public Pila (int size)
    {
        tamano=size;
        elementos=new T[tamano];
    }

    public void Push (T elementos)
{
    if(apuntador<tamano)
    {
    elementos [apuntador]=elementos;
    apuntador ++;
    }
    else
    {
        //error
    }

    public T pop()
    {
        apuntador --;
        return elementos[apuntador];
        
    }
}
}



namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
