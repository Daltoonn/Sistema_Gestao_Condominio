namespace SistemaReservaQuadraCondominio.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
    }
}
