using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Models
{
    public abstract class Animal
    {
        public string? raca { get; set; }
        public double tamanho {get; set;}

        public virtual void ExibirAnimal()
        {
            Console.WriteLine($"Raça: {raca}");
            Console.WriteLine($"Tamanho: {tamanho}");
        }
    }
}