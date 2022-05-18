using Microsoft.AspNetCore.Mvc;
using projetoDoJose.Dtos;
using projetoDoJose.Model;

namespace projetoDoJose.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionariosController : ControllerBase
{
    private readonly ILogger<FuncionariosController> _logger;
    private readonly List<Funcionario> funcionarios;

    public FuncionariosController(ILogger<FuncionariosController> logger)
    {
        _logger = logger;

        funcionarios = new List<Funcionario>();
        funcionarios.Add(new Funcionario(id: 1, nome: "José", cpf: "00123456789"));
        funcionarios.Add(new Funcionario(id: 2, nome: "Raissa", cpf: "12345678900"));
        funcionarios.Add(new Funcionario(id: 3, nome: "Camila", cpf: "123457689023"));

    }

    [HttpGet(Name = "GetFuncionarios")]
    public IEnumerable<Funcionario> Get()
    {
        return funcionarios;
    }

    [HttpPost(Name = "PostFuncionario")]
    public Funcionario Post([FromBody] FuncionarioPostDto funcionario)
    {
        var novoId = funcionarios.Count + 1;
        funcionarios.Add(new Funcionario(novoId, funcionario.Nome, funcionario.Cpf));

        return funcionarios[funcionarios.Count - 1];
    }

    [HttpDelete(Name = "DeleteFuncionario")]
    public IEnumerable<Funcionario> Delete(int id)
    {
        var funcionario = funcionarios.First(x => x.Id == id);
        funcionarios.Remove(funcionario);
        return funcionarios;
    }

    [HttpPut(Name = "PutFuncionario")]
    public IEnumerable<Funcionario> Put([FromBody] FuncionarioPutDto funcionario)
    {
        var funcionarioNaLista = funcionarios.First(x => x.Id == funcionario.Id);
        var index = funcionarios.IndexOf(funcionarioNaLista);
        funcionarios[index] = new Funcionario(funcionario.Id, funcionario.Nome, funcionario.Cpf);
        return funcionarios;
    }
}

