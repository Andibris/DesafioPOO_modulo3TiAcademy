using Exercicio2.Models;

Autor autor1 = new Autor();
autor1.nome = "Machado de Assis";
autor1.email = "machado@assis.com.br";
Autor autor2 = new Autor();
autor2.nome = "Douglas Adams";
autor2.email = "douglas@adams.com";
Autor autor3 = new Autor();
autor3.nome = "Stephen Hawking";
autor3.email = "stephen@hawking.com";
Autor autor4 = new Autor();
autor4.nome = "Dan Brown";
autor4.email = "dan@brown.com";

Livro livro1 = new Livro();
livro1.nomeLivro = "Memórias póstumas de Brás Cubas";
List<string> ListaAutores = new List<string>();

ListaAutores.Add(autor1.nome);
ListaAutores.Add(autor2.nome);
ListaAutores.Add(autor3.nome);
ListaAutores.Add(autor4.nome);

foreach(string name in ListaAutores)
{
    Console.WriteLine($"Autor: {name}");
}

livro1.autor = ListaAutores[0];
//Console.WriteLine($"Livro: {livro1.nomeLivro}");
//Console.WriteLine($"Autor: {livro1.autor}");