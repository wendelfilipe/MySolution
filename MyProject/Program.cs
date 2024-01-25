// See https://aka.ms/new-console-template for more information


using MyProject;

Console.WriteLine("Exercici");
var cadastroServiceImplementation = new Cadastro();


CadastroController cadastroController = new CadastroController(cadastroServiceImplementation);
var cliente = cadastroController.RegistrarCliente();
cadastroController.ExibirDados(cliente);
cadastroController.Update(ref cliente);
cadastroController.ExibirDados(cliente);

