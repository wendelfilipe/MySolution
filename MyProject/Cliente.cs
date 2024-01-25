namespace MyProject;

public class Cliente
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Idade { get; set; }
    public double Salario { get; set; }

    public Cliente(string name, string email, int idade,double salario)
    {
        Name = name;
        Email = email;
        Idade = idade;
        Salario = salario;

    }
}