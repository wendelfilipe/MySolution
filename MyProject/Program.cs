// See https://aka.ms/new-console-template for more information

Console.WriteLine("Entrada de dados");

Console.WriteLine("informe o seu nome: ");

string nome = Console.ReadLine();

Console.WriteLine($"\no seu no é {nome}");

// para um numero inteiro
Console.WriteLine("informe sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"voce tem {idade} anos");

Console.WriteLine($"{nome} você tem {idade} anos");

Console.ReadKey();