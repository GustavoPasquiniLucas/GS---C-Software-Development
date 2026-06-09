using SpaceAlert.Interfaces;
using SpaceAlert.Models;

namespace SpaceAlert.Services
{
    public class AnaliseSecaService : IAnalise
    {
        public Alerta GerarAlerta(Sensor sensor, string regiao)
        {
            if (sensor.Temperatura >= 35 && sensor.UmidadeSolo <= 30)
            {
                return new Alerta(
                    regiao,
                    "Seca",
                    "VERMELHO",
                    "Risco alto de seca e estresse hídrico."
                );
            }

            return new Alerta(
                regiao,
                "Seca",
                "VERDE",
                "Níveis normais de umidade."
            );
        }
    }
}