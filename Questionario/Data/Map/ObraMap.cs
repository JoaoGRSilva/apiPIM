using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questionario.Models;

namespace Questionario.Data.Map;

public class ObraMap : IEntityTypeConfiguration<ObraModel>

{
    public void Configure(EntityTypeBuilder<ObraModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).IsRequired().HasMaxLength(144);
        builder.Property(x => x.Descricao).HasMaxLength(144);
    }
}
