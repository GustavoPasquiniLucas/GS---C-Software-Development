using SpaceAlert.Interfaces;
using SpaceAlert.Models;

namespace SpaceAlert.Services
{
    public class AnaliseEnchenteService : IAnalise
    {
        public Alerta GerarAlerta(Sensor sensor, string regiao)
        {
            if (sensor.Chuva >= 80)
            {
                return new Alerta(
                    regiao,
                    "Enchente",
                    "VERMELHO",
                    "Risco alto de enchente na região."
                );
            }

            return new Alerta(
                regiao,
                "Enchente",
                "VERDE",
                "Sem riscos de enchente."
            );
        }
    }
}