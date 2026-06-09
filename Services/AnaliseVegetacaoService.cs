using SpaceAlert.Interfaces;
using SpaceAlert.Models;

namespace SpaceAlert.Services
{
    public class AnaliseVegetacaoService : IAnalise
    {
        public Alerta GerarAlerta(Sensor sensor, string regiao)
        {
            if (sensor.Vegetacao <= 40)
            {
                return new Alerta(
                    regiao,
                    "Vegetação",
                    "AMARELO",
                    "Área com sinais de degradação ambiental."
                );
            }

            return new Alerta(
                regiao,
                "Vegetação",
                "VERDE",
                "Vegetação saudável."
            );
        }
    }
}