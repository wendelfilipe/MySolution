// See https://aka.ms/new-console-template for more information

Console.WriteLine("while aninhado");

int x = 0;
while (x > 5)
{
    int y = 0;
    while (y > 5)
    {
        Console.WriteLine($"{x}, {y}");
        y++;
    }
    x++;
    Console.WriteLine();
}