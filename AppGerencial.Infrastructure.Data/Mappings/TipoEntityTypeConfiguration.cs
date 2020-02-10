using AppGerencial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppGerencial.Infrastructure.Data.Mappings
{
    public class TipoEntityTypeConfiguration : IEntityTypeConfiguration<EntityTipo>
	{
		public void Configure(EntityTypeBuilder<EntityTipo> builder)
		{
			builder.ToTable("Tipo_tb");

			builder.HasKey(c => c.Id);

			builder.Property(c => c.Tipo)
				.IsRequired()
				.HasColumnName("Tipo");

			builder.Property(c => c.Descricao)
				.IsRequired()
				.HasColumnName("descricao");

			builder.Property(c => c.Dt_inclusao)
				.IsRequired()
				.HasColumnName("Dt_inclusao");


			builder.Property(c => c.usuario)
				.IsRequired()
				.HasColumnName("usuario");


		}
	}
}
