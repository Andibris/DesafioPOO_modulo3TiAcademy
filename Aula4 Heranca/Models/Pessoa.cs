using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula4_Heranca.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //acrescentei o virtual para poder usar o override nas classes que herdarem o método apresentar.
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}