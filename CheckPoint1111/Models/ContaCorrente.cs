using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckPoint1111.Models
{
    public class ContaCorrente
    {
        //Propriedades
        public string? Nome {get; set;}
        public int Numero {get; set;}
        public int Agencia {get; set;}
        public double Saldo {get; set;}
        public double Tarifa {get; set;}

        //Método = normalmente é um verbo.
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void ExibirResumoConta()
        {
            Console.WriteLine($"Correntista: {Nome}");
            Console.WriteLine($"Número CC: {Numero}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Tarifa(%): {Tarifa}");
        }
    }
}