namespace SpaceAlert.Exceptions
{
    public class SensorException : Exception
    {
        public SensorException(string mensagem)
            : base(mensagem)
        {
        }
    }
}