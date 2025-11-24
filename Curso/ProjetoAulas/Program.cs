using System;
using Cadastro;
namespace Application;

public class Program
{
    public static void Main(string[] args)
    {
        // AulaClasses();
        // SomenteLeitura();
        Heranca();
    }

    private static void AulaClasses()
    {
        var resultado = Cadastro.Calculos.SomarNumeros(2, 5);
        System.Console.WriteLine("Resultado: " + resultado);


        var produto = new Cadastro.Produto();
        produto.SetId(1);
        produto.Descricao = "Teclado";
        produto.ImprimirDescricao();

    }

    private static void SomenteLeitura()
    {
        var produto = new Cadastro.Produto();
        produto.Descricao = "Mouse";
        System.Console.WriteLine(produto.Estoque);
    }

    private static void Heranca()
    {
        var pessoaFisica = new Cadastro.PessoaFisica();
        pessoaFisica.Id = 1;
        pessoaFisica.Endereco = "Endereco Teste";
        pessoaFisica.Cidade = "Cidade teste";
        pessoaFisica.Cep = "12313123123";
        pessoaFisica.CPF = "12344930835939";
        pessoaFisica.ImprimirDados();
        pessoaFisica.imprimirCPF();

    }
}

