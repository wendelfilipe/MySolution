// See https://aka.ms/new-console-template for more information

using MyProject.Controller;
using MyProject.Model.Service;

Console.WriteLine("Exercicio-3");
var implementation = new AumentarPotenciaService();
var AumentarPotencia = new AumentarPotenciaController(implementation);