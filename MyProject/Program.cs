// See https://aka.ms/new-console-template for more information

Console.WriteLine("loop for");

Console.WriteLine("Digite um numero de 1 aé 10");
int y = Convert.ToInt32(Console.ReadLine());
while (y < 0 || y > 10)
{
    Console.WriteLine("digite um numero de 1 ate 10");
    y = Convert.ToInt32(Console.ReadLine());
}
for (int x = 1; x <= 10; x++)
{
    Console.WriteLine($"a tabuada de {y} x {x} = {y * x}");
}