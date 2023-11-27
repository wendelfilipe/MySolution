// See https://aka.ms/new-console-template for more information

Console.WriteLine("Array com lop for");

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] names = { "ana", "kaka", "wendel" };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
}

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {names[i]}");
}