using SpaceAlert.Data;
using SpaceAlert.Interfaces;
using SpaceAlert.Models;

namespace SpaceAlert.Services
{
    public class SistemaMonitoramento
    {
        private List<IAnalise> analises;

        public SistemaMonitoramento()
        {
            analises = new List<IAnalise>
            {
                new AnaliseEnchenteService(),
                new AnaliseSecaService(),
                new AnaliseVegetacaoService()
            };
        }

        public void Monitorar(Sensor sensor, string regiao)
        {
            Console.WriteLine("\nDADOS DO SENSOR");
            Console.WriteLine($"Chuva: {sensor.Chuva} mm");
            Console.WriteLine($"Temperatura: {sensor.Temperatura} °C");
            Console.WriteLine($"Umidade do Solo: {sensor.UmidadeSolo}%");
            Console.WriteLine($"Vegetação: {sensor.Vegetacao}%");
            foreach (var analise in analises)
            {
                Alerta alerta = analise.GerarAlerta(sensor, regiao);

                BancoAlertas.Alertas.Add(alerta);

                alerta.ExibirAlerta();
            }
        }
    }
}