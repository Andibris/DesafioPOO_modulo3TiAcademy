using CheckPoint2511;
//LISTAS - ARRAYS - COLEÇÕES - VETOR
//Agrupamento de coisas do mesmo tipo, pilha. Acessa pelo índice (index) que inicia do 0.

//declarar um array
int[] numerosInteiros = new int[3]; //declarei um array com 3 espaços de capacidade, e só vai aceitar valores int.
string[] nome = new string[5]; //posso criar um array de strings e até mesmo de classes.
Pessoa[] pessoas = new Pessoa[10];
 
//passar valores para o array
numerosInteiros[0] = 15;
numerosInteiros[1] = 99;
numerosInteiros[2] = 13;

//exibir a capacidade do array
Console.WriteLine($"Capacidade do array: {numerosInteiros.Length}");

//imprimir o array: foreach ou for
//for(int i = 0; i < numerosInteiros.Length; i++)
//{
//    Console.WriteLine($"Posição: {i} - Valor: {numerosInteiros[i]}");
//}

//Acessando array com foreach
int contador = 0; //é preciso declarar o contador por fora, antes do foreach
foreach(int numero in numerosInteiros) //para cada iteração, jogo o valor de numerosInteiros na variável numero que criei aqui.
{
    Console.WriteLine($"Posição: {contador} - Valor: {numero}");
    contador++;
}

//-------------------------------------------------------------------------------------------------------------------------------------//

//LISTA - um pouco menos complexa que o array por abstrair as complexidades do array.
//Não tem limite definido como o array, adaptação dinâmica.

//declarar uma lista do tipo string:
List<string> ListaNomes = new List<string>();

//inserir elementos na lista:
ListaNomes.Add("Anderson");
ListaNomes.Add("Elaine");
ListaNomes.Add("João");
ListaNomes.Add("Maria");

foreach(string name in ListaNomes)
{
    Console.WriteLine(name);
}
//imprime a posição 0 da lista igual a um array.
Console.WriteLine(ListaNomes[0]);
Console.WriteLine("\n");
ListaNomes.Remove("João");

foreach(string name in ListaNomes)
{
    Console.WriteLine(name);
}