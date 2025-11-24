namespace Cadastro;

public static class Calculos // Classe estática.
{
    public static int SomarNumeros(int a, int b)
    {
        return a + b;
    }
}

public class Produto
{

    private int Id; //Atributo Privado

    public string Descricao { get; set; }

    public readonly int Estoque;  //Somente leitura. Não posso atribuir valor a ela. 

    public Produto()
    {
        Estoque = 1;
    }

    public void ImprimirDescricao()
    {
        Console.WriteLine(GetId() + " " + Descricao);
    }

    public void SetId(int id)
    {
        Id = id;
    }

    public int GetId()
    {
        return Id;
    }
}

public class Pessoa
{
    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }

    public void ImprimirDados()
    {
        System.Console.WriteLine(Id);
        System.Console.WriteLine(Endereco);
        System.Console.WriteLine(Cidade);
        System.Console.WriteLine(Cep);
    }
}

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }

    public void imprimirCPF()
    {
        System.Console.WriteLine(CPF);
    }
}