namespace BDGou.models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; } // Chave primária
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Relacionamento com Filial (um funcionário pertence a uma filial)
        public int IdFilial { get; set; } // Chave estrangeira referenciando Filial
        public virtual Filial Filial { get; set; }

        // Relacionamento com Reserva (um funcionário pode ser responsável por uma ou várias reservas)
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
