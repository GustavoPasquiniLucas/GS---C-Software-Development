using SpaceAlert.Data;
using SpaceAlert.Models;
using SpaceAlert.Services;
using SpaceAlert.Utils;

namespace SpaceAlert
{
    public class Program
    {
        static void Main(string[] args)
        {
            SistemaMonitoramento sistema =
                new SistemaMonitoramento();

            bool executando = true;

            while (executando)
            {
                Console.Clear();

                Exibicao.ExibirMenu();

                Console.Write("Escolha uma opção: ");
                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.Write("Digite a região: ");
                        string? regiao = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(regiao))
                        {
                            regiao = "Região não informada";
                        }

                        Random random = new Random();

                        Sensor sensor = new Sensor(
                            random.Next(0, 101), // chuva
                            random.Next(15, 45), // temperatura
                            random.Next(0, 101), // umidade
                            random.Next(0, 101)  // vegetação
                        );
                        sistema.Monitorar(sensor, regiao);

                        Console.WriteLine("\nPressione ENTER...");
                        Console.ReadLine();

                        break;

                    case "2":

                        Console.WriteLine("\nHISTÓRICO DE ALERTAS\n");

                        foreach (var alerta in BancoAlertas.Alertas)
                        {
                            alerta.ExibirAlerta();
                        }

                        Console.WriteLine("\nPressione ENTER...");
                        Console.ReadLine();

                        break;

                    case "3":

                        executando = false;

                        break;

                    default:

                        Console.WriteLine("Opção inválida.\nPressione ENTER");
                        Console.ReadLine();

                        break;
                }
            }
        }
    }
}