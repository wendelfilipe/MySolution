namespace MyProject.Model.Service;

public class AumentarPotenciaService : IAumentarPotencia
{
    public int Aumentarpotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }
}