// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("Constantes");

const int ANO = 12;

const int MES = 30, SEMANA = 7, QUIZENA = 15;

const int MESES_ANO = 12;

// calculo da area e perimetro do circulo

double raio, perimetro, area;

const double PI = 3.14;

Console.WriteLine("Informe o raio do circulo");

raio = Convert.ToDouble(Console.ReadLine());
perimetro = 2 * raio * Math.PI;
area = Math.PI * Math.Pow(raio,2);

Console.WriteLine($"Radio é {raio}");
Console.WriteLine($"Perimetro é {perimetro}");
Console.WriteLine($"Area é {area}");