// See https://aka.ms/new-console-template for more information

Console.WriteLine("Passando paramentros entre classes");

var aluno = new Aluno();

Console.WriteLine("Nome :");
aluno.Name = Console.ReadLine();
Console.WriteLine("Idade :");
aluno.Idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sexo :");
aluno.Sexo = Console.ReadLine();
Console.WriteLine("Aprovado : S/N");
aluno.Aprovado = Console.ReadLine();

var curso = new Curso();

curso.Resultado(aluno);

public class Aluno
{
    public string Name;
    public int Idade;
    public string Sexo;
    public string Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\n O aluno {aluno.Name}, sexo {aluno.Sexo}, idade {aluno.Idade} anos ");
        if (aluno.Aprovado == "S")
        {
            Console.WriteLine($"O aluno {aluno.Name} foi aprovado");
        }
        else
        {
            Console.WriteLine($"O aluno foi reprovado");
        }
    }
}