namespace BDGou.models
{
    public class Reserva
    {
        public int IdReserva { get; set; } // Chave primária
        public int IdVeiculo { get; set; } // Chave estrangeira referenciando Veiculo
        public int IdCliente { get; set; } // Chave estrangeira referenciando Cliente
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        // Relacionamentos com Veiculo e Cliente
        public virtual Veiculo Veiculo { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
