using System.Collections.Generic;

namespace SpaceAlert.Models
{
    public class Historico
    {
        public List<Alerta> Alertas { get; set; }

        public Historico()
        {
            Alertas = new List<Alerta>();
        }
    }
}