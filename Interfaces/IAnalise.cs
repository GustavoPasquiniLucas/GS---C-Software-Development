using SpaceAlert.Models;

namespace SpaceAlert.Interfaces
{
    public interface IAnalise
    {
        Alerta GerarAlerta(Sensor sensor, string regiao);
    }
}