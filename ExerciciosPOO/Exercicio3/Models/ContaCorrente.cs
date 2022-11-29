using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio3.Models
{
    public class ContaCorrente
    {
        public string NomeCorrentista {get; set;}
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        //adicionado método private abaixo no lugar do public para corrigir o princípio de encapsulamento.
        private double Saldo { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: R${Saldo}");
        }
    }
}