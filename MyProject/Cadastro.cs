using MyProject.Model.Service;

namespace MyProject;

public class Cadastro : ICadastroService
{
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Salario = 3500;
        return cliente;
    }

    public Cliente Registrar()
    {
        Cliente cliente = new ("Maria", "maria@maria", 20, 3000);
        return cliente;
    }

    public void ExibirCadastro(Cliente cliente)
    {
        Console.Write($"{cliente.Name} {cliente.Salario} {cliente.Email} {cliente.Idade}");
    }

    public void UpdateCliente(ref Cliente cliente)
    {
        var novoCliente = GetNovoCliente();

        cliente.Name = novoCliente.Name;
        cliente.Email = novoCliente.Email;
        cliente.Idade = novoCliente.Idade;
        cliente.Salario = novoCliente.Salario;
    }

    public Cliente GetNovoCliente()
    {
        Console.WriteLine("\nDigite um nome :");
        var name = Console.ReadLine();
        Console.WriteLine("Digite um email :");
        var email = Console.ReadLine();
        Console.WriteLine("digite sua idade :");
        var idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite seu salario :");
        var salario = Convert.ToDouble(Console.ReadLine());

        var clienteNovo = new Cliente(name, email, idade, salario)
        {
            Name = name,
            Email = email,
            Idade = idade,
            Salario = salario
        };
        return clienteNovo;
    }
    
}