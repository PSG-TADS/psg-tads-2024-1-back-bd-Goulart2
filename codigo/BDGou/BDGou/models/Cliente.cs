namespace BDGou.models
{
    public class Cliente
    {
        public int IdCliente { get; set; } // Chave primária
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Relacionamento com Reserva (um cliente pode fazer várias reservas)
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
