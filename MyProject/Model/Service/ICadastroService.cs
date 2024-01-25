namespace MyProject.Model.Service;

public interface ICadastroService
{
    Cliente Registrar(Cliente cliente);

    Cliente Registrar();

    void ExibirCadastro(Cliente cliente);

    void UpdateCliente(ref Cliente cliente);

    Cliente GetNovoCliente();
}