using System;  
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Atividade_Herança
{

    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor("Marlon", "Elói Mendes", "(35) 3264-1111");
            f.ValorCredito = 1000.00;
            f.ValorDivida = 316.12;
            Console.WriteLine("Fornecedor, saldo de :" + f.obterSaldo());

            Colaborador c = new Colaborador("Jonny", "Belém do para", "(91) 3205-9000");
            c.CodSetor = 30;
            c.SalarioBase = 818.13;
            c.Impostos = 2;
            Console.WriteLine("Colaborador, salário :" + c.calcularSalario());

            Administrador a = new Administrador("Huga", "Varginha", "(35) 3222-92e4");
            a.CodSetor = 30;
            a.SalarioBase= 818.13;
            a.Impostos = 2;
            a.AjudaDeCusto =314.07;
            Console.WriteLine("Administrador, salário :" + a.calcularSalario());

            Operario o = new Operario("Marcio", "Varginha", "(35) 3212-2019");
            o.CodSetor = 30;
            o.SalarioBase = 818.13;
            o.Impostos = 2; 
            o.ValorProducao = 117.09;
            o.Comissao = 3; 
            Console.WriteLine("Operário, salário :" + o.calcularSalario());

            Vendedor v = new Vendedor("Rodrigo", "Elói Mendes", "(35) 3264-2119");
            v.CodSetor = 30;
            v.SalarioBase = 818.13;
            v.Impostos = 2;
            v.ValorVendas = 518.22;
            v.Comissao = 5; 
            Console.WriteLine("Vendedor, salario :" + v.calcularSalario());


            Console.ReadKey();
        }

    }

}
