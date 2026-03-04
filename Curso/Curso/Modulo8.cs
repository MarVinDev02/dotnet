namespace Cadastro;

public class Pessoa
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }

    public void ImprimirDados()
    {
        System.Console.WriteLine(Nome);
        System.Console.WriteLine(Id);
        System.Console.WriteLine(Endereco);
        System.Console.WriteLine(Cidade);
        System.Console.WriteLine(Cep);
    }
}

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }

    public void ImprimirCpf()
    {
        System.Console.WriteLine(CPF);
    }
}