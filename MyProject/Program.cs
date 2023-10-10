// See https://aka.ms/new-console-template for more information

Console.WriteLine("Exercicos modulo methods");

var chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

var ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"os valores são {chevrolet.modelo} {chevrolet.montadora} {chevrolet.marca} {chevrolet.ano} {chevrolet.potencia}");
chevrolet.Acelerar(chevrolet.marca);
Console.WriteLine($"os valores são {ford.modelo} {ford.montadora} {ford.marca} {ford.ano} {ford.potencia}");
ford.Acelerar(ford.marca);
public class Carro
{
    public string modelo;
    public string montadora;
    public string marca;
    public int ano;
    public double potencia;

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    public Carro(string modelo, string montadora, string marca, int ano, double potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }
}