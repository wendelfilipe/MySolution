// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Exercicio 3.1");
//
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// int z = Convert.ToInt32(Console.ReadLine());
//
// if (x > y && x > z)
// {
//     Console.WriteLine($"O primeiro numero : {x} é o maior");
// } else if (y > z)
// {
//     Console.WriteLine($"O segundo numero : {y} é o maior");
// }
// else
// {
//     Console.WriteLine($"O terceiro numero : {z} é o maior");
// }
//
// Console.WriteLine("Exercicio 3.2 com while");
//
// int a = 1;
// int b = 0;
// while (a <= 10)
// {
//     b += a;
//     Console.WriteLine(a);
//     a++;
// }
// Console.WriteLine($"A soma dos numeros é {b}");
//
// Console.WriteLine("Exercicio 3.2 com do-while");
//
// int c = 1;
// int d = 0;
//
// do
// {
//     d += c;
//     Console.WriteLine($"{c}");
//     c++;
// }
// while(c <= 10);
// Console.WriteLine($"A soma dos numeros é {d}\n");
//
// Console.WriteLine("Exercicio 3.2 com for");
//
// int f = 0;
// for (int e = 1; e <= 10; e++)
// {
//     f += e;
//     Console.WriteLine($"{e}");
// }
// Console.WriteLine($"A soma dos numeros é {f}\n");
//
// Console.WriteLine("Exercicio 3.3");
//
// int g = Convert.ToInt32(Console.ReadLine());
// int h = 1;
// string i = "";
//
// while (g < 0 || g > 10)
// {
//     Console.WriteLine("Digite um numero de 1 ate 10");
//     g = Convert.ToInt32(Console.ReadLine());
// }
// while (i != "sair")
// {
//     while (h > 0 && h < 11)
//     {
//         Console.WriteLine($"A tabuada do numero {g} x {h} é {g * h}");
//         h++;
//     }
//     g = Convert.ToInt32(Console.ReadLine());
//     h = 1;
//     i = Console.ReadLine().ToLower();
// }

Console.WriteLine("Exercicio 3.4\n");
Console.WriteLine("Qual a instrução para sair de um loop ?\n");
Console.WriteLine("a.quit\n");
Console.WriteLine("b.continue\n");
Console.WriteLine("c.break\n");
Console.WriteLine("d.exit\n");

Console.WriteLine("Qual a opção correta ? (tecle x para sair)\n");
string? j = Console.ReadLine();

while (j != "c" && j != "x")
{
    Console.WriteLine("Resposta incorreta\n");
    Console.WriteLine("Qual a instrução para sair de um loop ?\n");
    Console.WriteLine("a.quit\n");
    Console.WriteLine("b.continue\n");
    Console.WriteLine("c.break\n");
    Console.WriteLine("d.exit\n");
    j = Console.ReadLine();
}

if (j == "c")
{
    Console.WriteLine("Resposta correta");
}
else
{
    Console.WriteLine("\nSaindo");
}



