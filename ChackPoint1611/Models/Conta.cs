using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChackPoint1611.Models
{
    public class Conta
    {
        public string? Nome {get; set;}
        public int Numero {get; set;}
        public int Agencia {get; set;}
        private double Saldo {get; set;}
        public string? senha {get; set;}
        
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
            } 
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        public void ExibirResumoConta()
        {
            Console.WriteLine($"Cliente: {Nome}");
            Console.WriteLine($"Número Conta: {Numero}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Saldo: R${Saldo}");
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: R${Saldo}");
        }
    }
}