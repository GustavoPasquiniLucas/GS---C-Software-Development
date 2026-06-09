namespace SpaceAlert.Models
{
    public class Alerta
    {
        public string Regiao { get; set; }
        public string Tipo { get; set; }
        public string Nivel { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }

        public Alerta(
            string regiao,
            string tipo,
            string nivel,
            string mensagem)
        {
            Regiao = regiao;
            Tipo = tipo;
            Nivel = nivel;
            Mensagem = mensagem;
            Data = DateTime.Now;
        }

        public void ExibirAlerta()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine($"REGIÃO: {Regiao}");
            Console.WriteLine($"TIPO: {Tipo}");
            Console.WriteLine($"NÍVEL: {Nivel}");
            Console.WriteLine($"MENSAGEM: {Mensagem}");
            Console.WriteLine($"DATA: {Data}");
            Console.WriteLine("==============================");
        }
    }
}