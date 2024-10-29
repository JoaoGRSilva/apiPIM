using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Questionario.Models;
using Questionario.Repositorios.Interfaces;

namespace Questionario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VisitanteController : ControllerBase
{
    private readonly IVisitanteRepositorio _visitanteRepositorio;
    public VisitanteController(IVisitanteRepositorio visitanteRepositorio)
    {
        _visitanteRepositorio = visitanteRepositorio;
    }

    [HttpGet]
    public async Task<ActionResult<List<VisitanteModel>>> BuscarVisitantes()
    {
        List<VisitanteModel> visitantes = await _visitanteRepositorio.BuscarTodosOsVisitantes();
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<VisitanteModel>> BuscarPorId(int id)
    {
        VisitanteModel visitante = await _visitanteRepositorio.BuscarPorId(id);
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<VisitanteModel>> Cadastrar([FromBody] VisitanteModel visitanteModel)
    {
        VisitanteModel visitante = await _visitanteRepositorio.Adicionar(visitanteModel);
        return Ok(visitante);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<VisitanteModel>> Apagar(int id)
    {
        bool apagado = await _visitanteRepositorio.Apagar(id);
        return Ok(apagado);
    }
}
