// See https://aka.ms/new-console-template for more information

Console.WriteLine("Metodos");



var minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem vindo ");
        Console.WriteLine("15/10/2022");
        ExibirDataAtual();
    }

    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}