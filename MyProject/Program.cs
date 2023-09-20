// See https://aka.ms/new-console-template for more information

Console.WriteLine("Instrução if-else");

Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}

Console.WriteLine("Fim do processamento");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"{x} é maior que {y}");
}
else
{
    Console.WriteLine($"{x} é menor que {y}");
}

