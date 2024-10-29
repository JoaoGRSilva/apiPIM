using Microsoft.EntityFrameworkCore;
using Questionario.Data.Map;
using Questionario.Models;

namespace Questionario.Data;

public class QuestionarioDBContext : DbContext
{
    public QuestionarioDBContext(DbContextOptions<QuestionarioDBContext> options)
        : base(options)
    {    
    }

    public DbSet<VisitanteModel> Visitantes { get; set; }
    public DbSet<ObraModel> Obra { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ObraMap());
        modelBuilder.ApplyConfiguration(new VisitanteMap());
        base.OnModelCreating(modelBuilder);
    }
}
