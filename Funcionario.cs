namespace projetoDoJose;

public class Funcionario
{
    public Funcionario(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
        DataDeContratacao = DateTime.Today;
    }

    public string Nome { get; set; }

    public string Cpf { get; set; }

    public DateTime DataDeContratacao { get; set; }
}
