// See https://aka.ms/new-console-template for more information

Console.WriteLine("Operadores incremento e decremento");

int x = 10;
x++;

Console.WriteLine(x);

// Operadores na forma de pre e pro incremento

int y = 0;
Console.WriteLine($"y = {y}");

//pos-incremento
int resultado1 = y++ + 10;
Console.WriteLine($"o pos incremento é {resultado1}");
Console.WriteLine($"O valor de y agora é {y}");

//pre-incremento
int z = 0;
Console.WriteLine($"z = {z}");
int result2 = ++z + 10;
Console.WriteLine($"o pre incremento é  {result2}");
Console.WriteLine($"o valor de z agora e {z}");

//pos-decremento
int a = 0;
int resultado3 = a-- + 10;
Console.WriteLine($"o pos incremento é {resultado3}");
Console.WriteLine($"O valor de a agora é {a}");

//pre-incremento
int b = 0;
Console.WriteLine($"b = {b}");
int resultado4 = --b + 10;
Console.WriteLine($"o pre incremento é  {resultado4}");
Console.WriteLine($"o valor de b agora e {b}");