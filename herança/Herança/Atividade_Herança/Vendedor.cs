﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herança
{
    class Vendedor : Colaborador
    {
        private double valorVendas; 
        private int comissao;

        public Vendedor(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }
        public double ValorVendas
        {
            get { return valorVendas; }
            set { valorVendas = value; }
        }

        public int Comissao
        {
            get { return comissao; }
            set { comissao = value; }
         
        }

        public override double calcularSalario()
        {
            double valorComissao = valorVendas - (valorVendas * ((double) comissao / 100));
            return base.calcularSalario () + valorComissao;
        }
    }
}
