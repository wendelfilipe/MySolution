// See https://aka.ms/new-console-template for more information

using MyProject;

Console.WriteLine("LINQ");

IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };

//query syntax

var resultado = from f in frutas 
                where f.Contains('r')
                select f;
Console.WriteLine(String.Join(" - ", resultado)); 

//method syntax
var resultado2 = frutas.Where(f => f.Contains('r'));     
Console.WriteLine(String.Join(" - ", resultado2));   

Console.WriteLine("LINQ - Filtrando dados");

var numeros = FonteDados.GetNumeros();

var resultado3 = numeros.Where(n => n < 10);

Console.WriteLine(String.Join(" ", resultado3));