using Aula3_Encapsulamento.Models;

//devido ao encapsulamento do saldo, somente métodos indiretos pondem alterá-lo após seu valor inicial atribuido.
ContaCorrente conta1 = new ContaCorrente(50); //0 é o valor atribuído ao saldo inicial que foi criado no construtor na classe.
conta1.NumConta = 03405;
Console.WriteLine("Digite o valor do saque:");
conta1.Sacar(decimal.Parse(Console.ReadLine()));
conta1.ExibirSaldo();
Console.WriteLine("Digite o valor do depósito:");
conta1.Depositar(decimal.Parse(Console.ReadLine()));
conta1.ExibirSaldo();