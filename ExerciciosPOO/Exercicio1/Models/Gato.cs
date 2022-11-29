using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Models
{
    public class Gato : Animal
    {
        public override void ExibirAnimal()
        {
            Console.WriteLine("Tipo de Animal: Gato");
            Console.WriteLine("Emite Som: Miar");
            base.ExibirAnimal();
        }
    }
}