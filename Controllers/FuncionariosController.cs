using Microsoft.AspNetCore.Mvc;

namespace projetoDoJose.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionariosController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<FuncionariosController> _logger;

    public FuncionariosController(ILogger<FuncionariosController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFuncionarios")]
    public IEnumerable<Funcionario> Get()
    {
        var funcionarios = new List<Funcionario>();
        funcionarios.Add(new Funcionario(nome: "José", cpf: "00123456789"));
        funcionarios.Add(new Funcionario(nome: "Raissa", cpf: "12345678900"));

        return funcionarios;
    }
}
