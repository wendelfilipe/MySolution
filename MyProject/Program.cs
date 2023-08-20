// See https://aka.ms/new-console-template for more information

Console.WriteLine("Tratamento de DateTime");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

//criar uma data especifica usando formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2022,09,06);
Console.WriteLine(dataHoje);

//definir as horas 
DateTime dataHoraHoje = new DateTime(2022,09,06,16,45,00);
Console.WriteLine(dataHoraHoje);

// extrar informações da data atual

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);

// adicionando valores

Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));

// obter o dia da semana e o do ano

Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

// data no formado longo e curto

Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToLongTimeString());

Console.WriteLine(dataAtual.ToShortDateString());
Console.WriteLine(dataAtual.ToShortTimeString());
