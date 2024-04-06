using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.EntitiesConfiguration;

public class LivroConfiguration : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.HasKey(p => p.LivroId);
        builder.Property(p => p.Titulo)
            .IsRequired()
            .HasMaxLength(150);
        builder.Property(p => p.Autor)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(p => p.Lancamento)
            .IsRequired();
        builder.Property(p => p.Capa)
            .HasMaxLength(200);
    }
}
