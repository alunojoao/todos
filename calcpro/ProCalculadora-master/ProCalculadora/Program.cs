﻿using System;

namespace ProCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            c.addNumero(10.1);
            c.addNumero(2.9);

            System.Console.WriteLine(c.somar());

            c.addNumero(10);
            c.addNumero(5);
            System.Console.WriteLine(c.Subtrair());


            c.addNumero(10);
            c.addNumero(2);
            System.Console.WriteLine(c.Multiplicar());

            c.addNumero(10);
            c.addNumero(2);
            System.Console.WriteLine(c.Dividir());

            c.addNumero(64);
            System.Console.WriteLine(c.Raiz());


            Console.ReadKey();
        }
    }
}
