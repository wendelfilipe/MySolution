// See https://aka.ms/new-console-template for more information

Console.WriteLine("Definindo Identificandores");

//identificadores válidos

string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//idenficadores inválidos
// int 5idade;
// int $valor;
// int valor#total;
// string nome Completo;

// para nome de variaveis : camel case

string descontoTotal;
string desconto_Total;

//constantes : maiúculas

double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";

Console.ReadLine();

//para nomes de classes e metodos: pascal case

class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Wendel");
    }
}