//Explicação de abstração na orientação a objetos

//Instanciar objetos das Contas
using CheckPoint1111.Models;

Console.WriteLine("Conta Corrente:\n");
ContaCorrente contaC = new ContaCorrente();
contaC.Nome = "Anderson";
contaC.Agencia = 123;
contaC.Numero = 9999;
contaC.Saldo = 500;
contaC.Tarifa = 15;
contaC.Depositar(100);
contaC.ExibirResumoConta();

//Instanciando conta poupança
Console.WriteLine("Conta Poupança:\n");
ContaPoupanca contaP = new ContaPoupanca();
contaP.Nome = "Elaine";
contaP.Agencia = 111;
contaP.Numero = 1234;
contaP.Saldo = 700;
contaP.Juros = 0.6;
contaP.Depositar(50);
contaP.ExibirResumoConta();