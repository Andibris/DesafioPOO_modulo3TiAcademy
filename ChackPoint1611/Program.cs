//Herança
using ChackPoint1611.Models;

Console.WriteLine("\nConta Corrente:\n");
ContaCorrente cc = new ContaCorrente();
cc.Nome = "João";
cc.Numero = 123;
cc.Agencia = 999;
//cc.Saldo = 500;
//apenas a Tarifa veio da ContaCorrente.
cc.Tarifa = 13;
cc.senha = "abc123";
//cc.ExibirResumoConta();
cc.Depositar(50);
cc.ExibirSaldo();
cc.Depositar(500);
cc.ExibirSaldo();
cc.Sacar(1000);
cc.ExibirSaldo();

// Console.WriteLine("\nConta Poupança:\n");
// ContaPoupanca cp = new ContaPoupanca();
// cp.Nome = "André";
// cp.Numero = 321;
// cp.Agencia = 1234;
// cp.Depositar(120);
// cp.Saldo = 330;
// //somente juros veio de ContaPoupanca
// cp.Juros = 2;
// cp.senha = "senha123";
// cp.ExibirResumoConta();

//ENCAPSULAMENTO = Faz com que parâmetros sejam privados, e não possam ser alterados diretamente.
//exemplo: alterar o saldo da conta, somente mediante à saque ou depósito.
