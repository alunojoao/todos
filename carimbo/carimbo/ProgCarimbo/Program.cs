using System;

namespace ProgCarimbo
{
    class Program
    {
        static void Main(string[] args)
        {
			Carimbo C = new Carimbo("Aprovado");
			C.carregar("Preto", 2);
			C.usar();

			C.trocarCor("Azul");
			C.usar();


			C.carregar("Vermelho", 2);
			C.trocarTexto("Recuperação");
			C.usar();
		}
    }
}
