using Exercicio1.Models;

//A instância abaixo não compila pois a classe animal é abstrata.
//Animal animal = new Animal();

Cachorro cao1 = new Cachorro();
cao1.raca = "São Bernardo";
cao1.tamanho = 0.75;
cao1.ExibirAnimal();

Console.WriteLine("\n");

Gato gato1 = new Gato();
gato1.raca = "Siamês";
gato1.tamanho = 0.25;
gato1.ExibirAnimal();

Console.WriteLine("\n");

Passaro passaro1 = new Passaro();
passaro1.raca = "Canário";
passaro1.tamanho = 0.10;
passaro1.ExibirAnimal();
