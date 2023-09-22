// See https://aka.ms/new-console-template for more information

Console.WriteLine("instrução switch");

Console.WriteLine("Valor da Compra R$ 600,00\n");
Console.WriteLine("Informe o numero de parcelas (1 a 3)\t");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());
double compra = 600;

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine(compra / numeroParcelas);
        break;
    case 2:
        Console.WriteLine(compra/numeroParcelas);
        break;
    case 3:
        Console.WriteLine(compra/numeroParcelas);
        break;
    default:
        Console.WriteLine("Parcelas erradas");
        break;
        
}

Console.WriteLine("Executar o mesmo codigo para valores diferetes");

var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "feveiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}
Console.WriteLine("\nFim do processamento");
Console.ReadKey();





