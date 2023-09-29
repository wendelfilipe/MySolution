// See https://aka.ms/new-console-template for more information

Console.WriteLine("expressão do-while");

var i = 1;
do
{
    Console.WriteLine($"i = {i}");
    i++;
    if (i > 7)
    {
        break;
    }
}
while (i <= 10) ;
