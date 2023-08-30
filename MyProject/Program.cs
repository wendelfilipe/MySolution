// See https://aka.ms/new-console-template for more information

Console.WriteLine("Operadores de atribuição");

//Usando operadoes atribuição com tipos numericos

var x = 10;
x = 20;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x+=5 --> {x+=5}");
Console.WriteLine($"x+=5 --> {x-=3}");
Console.WriteLine($"x+=5 --> {x*=4}");
Console.WriteLine($"x+=5 --> {x/=5}");
Console.WriteLine($"x+=5 --> {x%=5}");

//usando operadores atribuição com tipo string

var y = "123";

Console.WriteLine($"Valor inicial de y = {y}");
Console.WriteLine($"y+= \"456\" --> {y += "456"}");