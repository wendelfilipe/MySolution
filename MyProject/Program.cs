// See https://aka.ms/new-console-template for more information

Console.WriteLine("Estrutura de Repetição while");


var x = Console.ReadLine();

while (x != null && x != "s" && x != "n")
{
  Console.WriteLine("Digite o valor correto de s/n");
  x = Console.ReadLine();
}
Console.WriteLine("valor digitado corretamente");

var i = 1;
while (i <= 10)
{
  Console.WriteLine(i);
  i++;
}
Console.WriteLine("tabuada do numero");

var y = 1;
var z = Convert.ToInt32(Console.ReadLine());

while (z <= 0 || z > 10)
{
  Console.WriteLine("Digite um valor de 1 ate 10");
  z = Convert.ToInt32(Console.ReadLine());
}

while (y <= 10)
{
  Console.WriteLine($"O numero da tabuada de {z} x {y} = {y * z}");
  y++;
}



