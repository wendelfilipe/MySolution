// See https://aka.ms/new-console-template for more information

Console.WriteLine("Saida de dados ");

// Formatação 

int idade = 25;
string nome = "Maria";

Console.Write(nome);
Console.Write(idade);
Console.WriteLine();
// Escreve na mesma linha "Maria tem 25 anos"

Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");

// usar a concatenação : usando o operador +

Console.WriteLine(nome + " tem " + idade + " anos ");
Console.Write(nome + " tem " + idade + " anos ");
Console.WriteLine();
Console.WriteLine("---------");

//usa a interpolação de string : $ -> a interpolação de {}

Console.WriteLine($"{nome} tem {idade} anos");

//usar place holders : usa {} com numeração com inicio zero

Console.WriteLine("----- place holders ---");
Console.WriteLine("{0} tem {1} anos", nome, idade);


Console.ReadLine();