// See https://aka.ms/new-console-template for more information

Console.WriteLine("Operadores logicos");

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resuldado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

// operador AND

resuldado = c1 && c2;
Console.WriteLine($"O operador AND(&&) : {resuldado}");

// Operador or -> ||

resuldado = c1 || c2;
Console.WriteLine($"Operador OR(||): {resuldado}");

// operador not -> !=

resuldado = c1 != c2;
Console.WriteLine($"Operador NOT(!=): {resuldado}");