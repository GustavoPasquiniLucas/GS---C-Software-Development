namespace SpaceAlert.Structs
{
    public struct Coordenada
    {
        public double Latitude;
        public double Longitude;

        public Coordenada(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}