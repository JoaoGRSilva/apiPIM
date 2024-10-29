using Microsoft.EntityFrameworkCore;
using Questionario.Data;
using Questionario.Models;
using Questionario.Repositorios.Interfaces;

namespace Questionario.Repositorios
{
    public class VisitanteRepositorio : IVisitanteRepositorio
    {
        private readonly QuestionarioDBContext _dbContext;

        public VisitanteRepositorio(QuestionarioDBContext questionarioDBContext)
        {
            _dbContext = questionarioDBContext;
        }

        public async Task<VisitanteModel> BuscarPorId(int id)
        {
            return await _dbContext.Visitantes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<VisitanteModel>> BuscarTodosOsVisitantes()
        {
            return await _dbContext.Visitantes.ToListAsync();
        }

        public async Task<VisitanteModel> Adicionar(VisitanteModel visitante)
        {
            _dbContext.Visitantes.Add(visitante);
            await _dbContext.SaveChangesAsync();

            return visitante;
        }


        public async Task<bool> Apagar(int id)
        {
            VisitanteModel visitantePorId = await BuscarPorId(id);

            if (visitantePorId == null)
            {
                throw new Exception($"Usuario id:{id} não foi localizado");
            }

            _dbContext.Visitantes.Remove(visitantePorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
