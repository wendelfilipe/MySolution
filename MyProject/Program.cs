// See https://aka.ms/new-console-template for more information

Console.WriteLine("metodos com paramentros");

// var x = new Parameters();
//
// x.name = "wendel";
// x.date = DateTime.Now;
//
// var name = x.name;
// var date = x.date;
//
// Parameters.Saudacao(name, date);
//
// class Parameters
// {
//     public string? name;
//     public DateTime date;
//
//     public static void Saudacao(string name, DateTime date)
//     {
//         Console.WriteLine(name);
//         Console.WriteLine(string.Format(date.ToString()));
//     }
// }

var minhaClasse = new MinhaClasse();

minhaClasse.Saudacao("Maria", DateTime.Now.ToShortDateString());

public class MinhaClasse
{
    public void Saudacao(string? name, string? date)
    {
        Console.WriteLine(name);
        Console.WriteLine(date);
    }
}