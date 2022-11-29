using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckPoint1111.Models
{
    public class ContaPoupanca
    {
        public string? Nome {get; set;}
        public int Numero {get; set;}
        public int Agencia {get; set;}
        public double Saldo {get; set;}
        public double Juros {get; set;}

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void ExibirResumoConta()
        {
            Console.WriteLine($"Cliente: {Nome}");
            Console.WriteLine($"Número Conta: {Numero}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Juros(%): {Juros}");
        }
    }
}