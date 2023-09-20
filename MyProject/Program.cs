// See https://aka.ms/new-console-template for more information


Console.WriteLine("Instrução if");

Console.WriteLine("Cliente é especial y/n");
string response = Console.ReadLine();

if (response == "s")
{
    Console.WriteLine("Cliente tem 10% de desconto");
}
if (response != "y" || response != "n")
{
    Console.WriteLine("Responda com (y) para sim, e (n) para não");
}
