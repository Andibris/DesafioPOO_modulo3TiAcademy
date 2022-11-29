//POLIMORFISMO = muitas formas para descrever classes filhas
using ChackPoint1811.Models;

//classe abstrata, muito genérica, serve apenas como molde, não deverá ser instanciada.
//Conta c = new Conta(); 
//Após inserir o termo abstract na classe, esse código obviamente deixou de compilar devido a esse trecho.


//os métodos são iguais aqui, mas a sobrescrição nas classes cria o polimorfismo.
//eu posso sobrescrever o método totalmente ou apenas o extender com o base.Método()
ContaCorrente c1 = new ContaCorrente();
c1.Nome = "Alex";
c1.Numero = 123;
c1.Agencia = 0000;
c1.Tarifa = 15;
c1.ExibirTipoDeConta();
c1.ExibirResumoConta();
Console.WriteLine("\n");

ContaPoupanca c2 = new ContaPoupanca();
c2.Nome = "Maria";
c2.Numero = 0001;
c2.Agencia = 9999;
c2.Juros = 2;
c2.ExibirTipoDeConta();
c2.ExibirResumoConta();