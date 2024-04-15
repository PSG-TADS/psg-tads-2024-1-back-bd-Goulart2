namespace BDGou.models
{
    public class Filial
    {
        public int IdFilial { get; set; } // Chave primária
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        // Relacionamento com Funcionário (uma filial pode ter vários funcionários)
        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        // Relacionamento com Veiculo (uma filial pode ter vários veículos disponíveis para locação)
        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
