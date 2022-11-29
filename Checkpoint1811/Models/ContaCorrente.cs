using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChackPoint1811.Models
{
    public class ContaCorrente : Conta //ContaCorrente herda Conta
    {
        public double Tarifa { get; set; }
        public override void ExibirTipoDeConta() //override para sobrescrever o metodo da classe pai.
        {
        Console.WriteLine("Conta Corrente.");
        }
        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta(); //base. traz todas as informações do método pai.
            Console.WriteLine($"Tarifa: {Tarifa}");
        }
    }
}