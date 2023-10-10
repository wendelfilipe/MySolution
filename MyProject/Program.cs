// See https://aka.ms/new-console-template for more information

Console.WriteLine("This");

// public class Client
// {
//     public string? name;
//     public int idade;
//
//     public Client(string? name, int idade)
//     {
//         this.name = name;
//         this.idade = idade;
//     }
// }

// var t1 = new Teste();
// t1.num1 = 58;
// t1.num2 = 56;
// t1.Exibir();
//
// var t2 = new Teste();
// t2.num1 = 59;
// t2.num2 = 52;
// t2.Exibir();


// public class Teste
// {
//     public int num1;
//     public int num2;
//
//     public void PassarParamentros(Teste t)
//     {
//         Console.WriteLine($"\nthis = {this}");
//         Console.WriteLine("num 1 = " + num1);
//         Console.WriteLine("num 2 = " + num2);
//     }
//     public void Exibir()
//     {
//         //Passando this como parametro (a classe teste)
//         PassarParamentros(this);
//     }
// }

var t1 = new Teste(999);
public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"\nConstructor com dois paramentros {num1} e {num2}");
    }
    public Teste(int num) : this(458,698)
    {
        Console.WriteLine($"\nConstructor com dois paramentros {num}");
    }
}