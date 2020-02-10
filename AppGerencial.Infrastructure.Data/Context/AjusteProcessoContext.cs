using AppGerencial.Domain.Entities;
using AppGerencial.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AppGerencial.Infrastructure.Data.Context
{
    public class AjusteProcessoContext : DbContext
    {
        public DbSet<EntityTipo> Tipo { get; set; }
        private string GgetStringConnectionConfig()
        {
           string strcon = "Server=DESKTOP-HD80T8E\\SQLEXPRESS;Database=desenv_db;User Id=sa;Password=123456;";

            return strcon;
        }

        public AjusteProcessoContext(DbContextOptions<AjusteProcessoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new TipoEntityTypeConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GgetStringConnectionConfig());

            base.OnConfiguring(optionsBuilder);
        }


    }
}
