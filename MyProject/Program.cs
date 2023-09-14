// See https://aka.ms/new-console-template for more information

Console.WriteLine("Fazendo exercicios 2 ");

// 1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
// Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.

string name = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"Aluno {name} tem {idade} anos e nota {nota}");

// 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
//escapes.

Console.WriteLine($"Aluno {name} \ntem {idade} anos \ne nota {nota}");

decimal x = 100.0m;
x = (decimal)100.5f;

//5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
//a concatenação e também a interpolação de strings

string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

Console.WriteLine("a ordem reversa é: " + c + " e " + b + " e " + a );
Console.WriteLine($"melhor assim, {c} e {b} e {a}");

//8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
//a b e c .
//// Valores : a = 1 , b = 12 e c = -13

int a1 = 1;
int b2 = 12;
int c3 = -13;

var x1 = (-b2 + (Math.Sqrt(Math.Pow(b2, 2) - (4 * a1 * c3)))) / (2 * a1);  
var x2 = (-b2 - (Math.Sqrt(Math.Pow(b2, 2) - (4 * a1 * c3)))) / (2 * a1);  

Console.WriteLine($"o x1 é {x1} e de x2 é {x2}");

// 9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//     inválido’: (use o operador condicional ternário)

string? name9 = Console.ReadLine();
int senha9 = Convert.ToInt32(Console.ReadLine());

var result = (name9 == "Maria" || name9 == "admin") && senha9 == 123 ? "Login feito com sucesso" : "Login inválido"; 
Console.WriteLine(result);

// 11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//     console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
Console.WriteLine("verificando se é par ou impar5");
int x11 = Convert.ToInt32(Console.ReadLine());
int y11 = Convert.ToInt32(Console.ReadLine());

var result11 = x11 % 2 == 0 ? $"O numero {x11} é par" : $"o numero {x11} é impar";
var result12 = y11 % 2 == 0 ? $"O numero {y11} é par" : $"o numero {y11} é impar";
Console.WriteLine(result11);
Console.WriteLine(result12);

// 12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
//     console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)

// -6 + x * 5

Console.WriteLine("Fazendo as operações");

int x12 = Convert.ToInt32(Console.ReadLine());

var result13 = -6 + x12 * 5;
var result14 = (13-2) *  x12;
var result15 = (x12 + -2) * (20 / x12);
var result16 = (12 + x12) / (x12 - 4);
var result17 = 3 * Math.Pow(x12,2) + x12 + 10;
var result18 = Math.PI * Math.Pow(x12,2);

Console.WriteLine("os resultados são " + result13 + " e " + result14 + " e " + result15 + " e " + result16 + " e " +  result17 + " e " + result18);



int y13 = 5 ;
y13 = (y13++)+y13+(++y13); 
int y14 = y13++ + y13 + ++y13;
Console.WriteLine(y13 + " e " + y14);

// 14- Escreva um programa que solicite a temperatura em graus Celsius e converta para
// Kelvin e Farhenheit usando as fórmulas a seguir:
// - Converter para Kelvin => K = C + 273 ;
// - Converter para Farhenheit => F = (C * 9) / 5 + 32 ;

Console.WriteLine("Fazendo conversão de temperatura");

double tempCelsius = Convert.ToDouble(Console.ReadLine());
double tempkelvin = tempCelsius + 273;

double tempFarhenheit = (tempCelsius * 9) / 5 + 32;

Console.WriteLine(tempCelsius);
Console.WriteLine(tempkelvin);
Console.WriteLine(tempFarhenheit);

var numero = 5;
Console.WriteLine(numero++);
Console.WriteLine(++numero);
