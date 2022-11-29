using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Models
{
    public class Cachorro : Animal
    {
        public override void ExibirAnimal()
        {
            Console.WriteLine("Tipo de Animal: Cachorro");
            Console.WriteLine("Emite Som: Latir");
            base.ExibirAnimal();
        }
    }
}