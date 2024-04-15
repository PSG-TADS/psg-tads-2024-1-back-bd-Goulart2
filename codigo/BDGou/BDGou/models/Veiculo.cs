namespace BDGou.models
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; } // Chave primária
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public bool Status { get; set; } // Status pode ser "Disponível", "Reservado", etc.

        // Relacionamento com Reserva (um veículo pode ter várias reservas)
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
