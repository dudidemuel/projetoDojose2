using Microsoft.AspNetCore.Mvc;
using projetoDoJose.Model;

namespace projetoDoJose.Controllers;

[ApiController]
[Route("[controller]")]
public class EmpresasController : ControllerBase
{
    private readonly ILogger<EmpresasController> _logger;
    private readonly List<Empresa> empresas;

    public EmpresasController(ILogger<EmpresasController> logger)
    {
        _logger = logger;

        empresas = new List<Empresa>();
        empresas.Add(new Empresa(id: 1, nomeFantasia: "McDonalds", cnpj: "00.000.000/1111-22", razaoSocial: "Gilson SA"));
        empresas.Add(new Empresa(id: 2, nomeFantasia: "BuguerKing", cnpj: "00.000.001/1111-22", razaoSocial: "Maria SA"));
    }
}

