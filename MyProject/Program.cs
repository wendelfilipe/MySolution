// See https://aka.ms/new-console-template for more information

Console.WriteLine("Classes e metodos");

int x = 100;

Pessoa p1 = new Pessoa();

p1.name = "Maria";
p1.idade = 25;
p1.sexo = "Feminino";

Console.WriteLine($"{p1.idade} {p1.name} {p1.sexo}");

Pessoa p2 = new Pessoa();
p2.name = "Manuel";
p2.idade = 25;
p2.sexo = "Masculino";

Console.WriteLine($"{p2.idade} {p2.name} {p2.sexo}");

class Pessoa
{
    public string? name;
    public int idade;
    public string? sexo;
}