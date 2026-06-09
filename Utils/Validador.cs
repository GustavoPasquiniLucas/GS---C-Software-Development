using SpaceAlert.Exceptions;

namespace SpaceAlert.Utils
{
    public static class Validador
    {
        public static void ValidarSensor(double chuva)
        {
            if (chuva < 0)
            {
                throw new SensorException(
                    "Valor de chuva inválido."
                );
            }
        }
    }
}