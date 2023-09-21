// See https://aka.ms/new-console-template for more information

using System.Net;

Console.WriteLine("Intrução if else-if");

Console.WriteLine("Digite a nota:");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 6)
{
    Console.WriteLine("Aluno Aprovado");
}else if (x < 4)
{
    Console.WriteLine("Aluno reprovado");
}
else
{
    Console.WriteLine("Aluno em recuperação");
}