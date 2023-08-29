// See https://aka.ms/new-console-template for more information

Console.WriteLine("Inferencia tipos (var)");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

//var limitações 

// var salario1 = null;
// var titulo;
// var salario, imposto, total;

//não posso mudar o tipo apos inicializar

// var num = 10;
// num = num + 20;
// num = "teste";

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("meu metodo");
    }
}