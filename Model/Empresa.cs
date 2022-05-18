namespace projetoDoJose.Model;

public class Empresa
{
    public Empresa(int id, string nomeFantasia, string cnpj, string razaoSocial)
    {
        this.Id = id;
        this.NomeFantasia = nomeFantasia;
        this.RazaoSocial = razaoSocial;
        this.Cnpj = cnpj;
        this.DataDeCriacao = DateTime.Today;
    }

    public int Id { get; set; }

    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }

    public string Cnpj { get; set; }

    public DateTime DataDeCriacao { get; set; }
}
