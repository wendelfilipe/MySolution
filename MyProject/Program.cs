// See https://aka.ms/new-console-template for more information

Console.WriteLine("Exercicos pratico 2");


var ford = new Carro("SUV", "Ford", 100);
Console.WriteLine(ford.Modelo);


Console.WriteLine(ford.VelocidadeMaxima(ford.Velocidade));
public class Carro
{
    public string Modelo;
    public string Montadora;
    public int Velocidade;

    // vai passar os abributos da classe como parametro.
    public Carro(string modelo, string montadora, int velocidade)
    {
        Modelo = modelo;
        Montadora = montadora;
        Velocidade = velocidade;
    }
    
    public double VelocidadeMaxima(int potecia)
    {
        
        // o return retorna um valor quando o metodo é machado, entao nesse caso vai retorna a velocidade
        return potecia;
    }
}

