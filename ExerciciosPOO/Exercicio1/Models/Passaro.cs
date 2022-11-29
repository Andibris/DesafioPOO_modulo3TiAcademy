using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Models
{
    public class Passaro : Animal
    {
        public override void ExibirAnimal()
        {
            Console.WriteLine("Tipo de Animal: Pássaro");
            Console.WriteLine("Emite Som: Cantar");
            base.ExibirAnimal();
        }
    }
}