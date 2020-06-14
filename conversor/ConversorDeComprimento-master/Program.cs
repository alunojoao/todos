using System;

namespace ConversorDeComprimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Comprimento comp = new Comprimento();
            comp.Metro = 10.5;
            Console.WriteLine(comp.Centimetro);

        


            System.Console.ReadKey();


        }
    }
}
