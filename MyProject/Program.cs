// See https://aka.ms/new-console-template for more information

Console.WriteLine("Construtor");


var aluno = new Aluno("Maria", 22, "feminino", "S");

Console.WriteLine(aluno.Name == null ? "null" : aluno.Name);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);
public class Aluno 
{
    public Aluno(string name, int idade, string sexo, string aprovado)
    {
        Name = name;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
        
    public string? Name;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}