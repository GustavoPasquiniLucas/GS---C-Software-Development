namespace SpaceAlert.Models
{
    public class Sensor
    {
        public double Chuva { get; set; }
        public double Temperatura { get; set; }
        public double UmidadeSolo { get; set; }
        public double Vegetacao { get; set; }

        public Sensor(
            double chuva,
            double temperatura,
            double umidadeSolo,
            double vegetacao)
        {
            Chuva = chuva;
            Temperatura = temperatura;
            UmidadeSolo = umidadeSolo;
            Vegetacao = vegetacao;
        }
    }
}