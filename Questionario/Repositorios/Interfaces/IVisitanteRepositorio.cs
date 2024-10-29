using Questionario.Models;

namespace Questionario.Repositorios.Interfaces;

public interface IVisitanteRepositorio
{
    Task<List<VisitanteModel>> BuscarTodosOsVisitantes();
    Task<VisitanteModel> BuscarPorId(int id);
    Task<VisitanteModel> Adicionar (VisitanteModel visitante);
    Task<bool> Apagar(int id);
}
