using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula4_Heranca.Models
{
    public class Aluno : Pessoa //aluno herda de pessoa.
    {
        public double Nota { get; set; }

        public override void Apresentar() //override para sobrescrever o método apresentar herdado da classe pessoa.
        {
            //aqui está o novo código do método apresentar para a classe aluno.
            Console.WriteLine($"Olá, sou um aluno, me chamo {Nome}, tenho {Idade} anos e minha nota é {Nota}.");
        }
    }
}