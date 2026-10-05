namespace A2FPS
{
    public class Multa
    {
        public int IdMulta { get; set; }
        public int IdAlquiler { get; set; }
        public int DiasRetraso { get; set; }
        public decimal Valor { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }

        public Multa()
        {
            Motivo = string.Empty;
            Estado = string.Empty;
        }

        public Multa(int idMulta, int idAlquiler, int diasRetraso, decimal valor, string motivo, string estado)
        {
            IdMulta = idMulta;
            IdAlquiler = idAlquiler;
            DiasRetraso = diasRetraso;
            Valor = valor;
            Motivo = motivo;
            Estado = estado;
        }
    }
}