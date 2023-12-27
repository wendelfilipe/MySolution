// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("exemplos de metodos");

public class Cliente
{
    public string? Name;
    public int Idade;
    public decimal Renda;

    public Cliente(string? name, int idade, decimal renda)
    {
        Name = name;
        Idade = idade;
        Renda = renda;
    }
}