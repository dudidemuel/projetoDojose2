namespace projetoDoJose.Model;

public class Funcionario
{
    public Funcionario(int id, string nome, string cpf)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.DataDeContratacao = DateTime.Today;
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public string Cpf { get; set; }

    public DateTime DataDeContratacao { get; set; }
}
