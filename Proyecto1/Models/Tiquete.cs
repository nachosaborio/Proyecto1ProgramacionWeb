namespace Proyecto1.Models
{
    public class Tiquete
    {
        public DateTime FechaYHoraEntrada { get; set; }
        public DateTime FechaYHoraSalida { get; set; }
        public string? Placa { get; set;}
        public float TarifaPorHora { get; set; }
        public float TarifaPorMediaHora { get; set; }

	}
}
