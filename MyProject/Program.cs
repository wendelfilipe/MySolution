// See https://aka.ms/new-console-template for more information

Console.WriteLine("Nullable Types");

int? valor = null;
bool? valor1 = null;
double? valor2 = null;

Console.WriteLine(valor);
Console.WriteLine(valor1);
Console.WriteLine(valor2);

// expressão ??

int? a = null;

int b = a ?? 0;

Console.WriteLine(b);
Console.ReadLine();

// expressões - para resolver essa expressão precisa passar todas as variaveis como nullable

int? x = 4 ;

int? y = 3;

int? z = x * y;

Console.WriteLine(z);

// usando o HasValue e Value

int? f = null;

if (f.HasValue)
{
    Console.WriteLine($"f = {f.Value}");
}
else
{
    Console.WriteLine("f não possui um valor(null)");
}
