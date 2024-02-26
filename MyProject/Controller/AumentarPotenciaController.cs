using MyProject.Model.Service;

namespace MyProject.Controller;

public class AumentarPotenciaController
{
    public IAumentarPotencia AumentarPotencia;

    public AumentarPotenciaController(
        IAumentarPotencia aumentarPotencia
    )
    {
        AumentarPotencia = aumentarPotencia;
    }

    public void Chamar(int i)
    {
        AumentarPotencia.Aumentarpotencia(i);
    }
}