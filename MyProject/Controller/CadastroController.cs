
using MyProject;
using MyProject.Model.Service;

public class CadastroController
{
    public ICadastroService CadastroService;

    public CadastroController(
        ICadastroService cadastroService
    )
    {
        CadastroService = cadastroService;
    }
    public Cliente RegistrarCliente()
    {
        var cliente =CadastroService.Registrar();
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        CadastroService.ExibirCadastro(cliente);
    }

    public void Update(ref Cliente cliente)
    {
        CadastroService.UpdateCliente(ref cliente);
    }

    public void GetNovoCliete()
    {
        CadastroService.GetNovoCliente();
    }
    // teste curso 

    public static int x = 20;

    public void calc(int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do paramentro" + y);
    }
}

