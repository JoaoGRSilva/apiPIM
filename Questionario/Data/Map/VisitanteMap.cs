using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionario.Models;

namespace Questionario.Data.Map;

public class VisitanteMap : IEntityTypeConfiguration<VisitanteModel>

{
    public void Configure(EntityTypeBuilder<VisitanteModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).IsRequired().HasMaxLength(144);
        builder.Property(x => x.Email).HasMaxLength(144);
        builder.Property(x => x.Questao1);
        builder.Property(x => x.Questao2);
        builder.Property(x => x.Questao3);
        builder.Property(x => x.Questao4);
        builder.Property(x => x.Questao5);
    }
}
