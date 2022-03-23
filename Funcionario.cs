namespace projetoDoJose;

public class Funcionario
{
    public Funcionario(string nome, string cpf)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        this.DataDeContratacao = DateTime.Today;
    }

    public string Nome { get; set; }

    public string Cpf { get; set; }

    public DateTime DataDeContratacao { get; set; }
}
