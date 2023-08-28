// See https://aka.ms/new-console-template for more information

Console.WriteLine("Operadores Aritméticos");

Console.WriteLine("informe o valor de x :");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o valor de y :");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A soma de {x} e {y} = {x + y}");
Console.WriteLine($"A diferença de {x} e {y} = {x - y}");
Console.WriteLine($"A multiplicação de {x} e {y} = {(double)x * y}");
Console.WriteLine($"A divisão de {x} e {y} = {Math.Round((double)x / y, 2)}");
Console.WriteLine($"A modulo de {x} e {y} = {x % y}");
Console.ReadKey();