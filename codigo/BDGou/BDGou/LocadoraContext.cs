namespace BDGou
{
    using Microsoft.EntityFrameworkCore;

    public class LocadoraContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Filial> Filiais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurações adicionais, como chaves primárias, chaves estrangeiras, etc.
            modelBuilder.Entity<Reserva>()
                .HasRequired(r => r.Veiculo)
                .WithMany(v => v.Reservas)
                .HasForeignKey(r => r.IdVeiculo);

            modelBuilder.Entity<Reserva>()
                .HasRequired(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.IdCliente);

            modelBuilder.Entity<Funcionario>()
                .HasRequired(f => f.Filial)
                .WithMany(filial => filial.Funcionarios)
                .HasForeignKey(f => f.IdFilial);

            modelBuilder.Entity<Filial>()
                .HasMany(filial => filial.Veiculos)
                .WithOptional(veiculo => veiculo.Filial)
                .Map(m => m.MapKey("IdFilial")); // Chave estrangeira em Veiculo referenciando Filial

            base.OnModelCreating(modelBuilder);
        }
    }
}
