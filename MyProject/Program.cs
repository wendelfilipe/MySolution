﻿// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Declarando tipos numericos de ponto flutuante");
Console.WriteLine();

double n1 = 1.234;

float n2 = 1.234f;

decimal n3 = 1.234m;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.ReadLine();

Console.WriteLine("Comparando a precisao de float, double e decimal");

float x = 1f/ 3f;

double y = 1d/ 3d;

decimal z = 1m/ 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.ReadLine();