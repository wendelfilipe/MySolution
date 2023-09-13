// See https://aka.ms/new-console-template for more information

Console.WriteLine("Operadores uniarioss, binários e operador condicional ternário");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

Console.WriteLine("informe o numero: ");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("operador condicional ternário");

Console.WriteLine("Informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

var resultadoTemp = temp > 27 ? "Quente" : "frio";

Console.WriteLine(resultadoTemp);

Console.WriteLine("aninhando operações");

Console.WriteLine("informe o valor de x :");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o valor de y :");
var y = Convert.ToInt32(Console.ReadLine());

var resultado2 = x > y ? $"{x} é maior que {y}" :
    x < y ? $"{x} é menor que {y}" :
x == y ? $"{x} é igual a {y}" : "Sem resultado";
Console.WriteLine(resultado2);
        
Console.ReadKey();