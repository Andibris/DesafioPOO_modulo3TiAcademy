using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula3_Encapsulamento.Models
{
    //classe
    public class ContaCorrente
    {   
        //propriedades da classe - prop+tab
        public int NumConta { get; set; }
        private decimal Saldo { get; set; }

        //construtor - ctor+tab
        public ContaCorrente(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        //métodos
        public void Sacar(decimal valor)
        {
            if(valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            } 
            else
            Console.WriteLine("Saldo insuficiente.");
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo da conta {NumConta} é de R${Saldo}.");
        }
    }
}