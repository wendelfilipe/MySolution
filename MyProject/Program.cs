// See https://aka.ms/new-console-template for more information

using System.Reflection;

Console.WriteLine("Assinatura de metodo - Sobrecarga");

Email email = new();

email.Enviar("wendel@hotmal", "email");

public class Email
{
    public void Enviar(string endereço)
    {
        Console.WriteLine($"{endereço}");
        Console.WriteLine("Assunto padrão");
    }
    public void Enviar(string endereço, string assunto)
    {
        Console.WriteLine($"{endereço}");
        Console.WriteLine($"Assunto padrão : {assunto}");
    }
    public void Enviar(string endereço, decimal valor)
    {
        Console.WriteLine($"{endereço}");
        Console.WriteLine("proposta comercial");
        Console.WriteLine($"{valor}");
    }
    public void Enviar(decimal valor, string endereço)
    {
        Console.WriteLine($"{endereço}");
        Console.WriteLine("pagamento fornecedor");
        Console.WriteLine($"{valor}");
    }
}
