// See https://aka.ms/new-console-template for more information

// Conversão do tipo inclicita

Console.WriteLine("## Conversão de tipos ##\n");

int numeroInteiro = 100;

double numeroDoble = 100;


Console.WriteLine(numeroDoble);

int numeroInt = 123456;
long numeroLog = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble2 = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLog);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDecimal);
Console.WriteLine(numeroDouble2);
Console.ReadLine();

// Conversão do tipo explicita.

double varDouble = 12.456;
int varInt = (int)varDouble; // conversão do tipo cast

Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado =(float)num1 / num2;
Console.WriteLine(resultado);
