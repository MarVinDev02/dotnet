namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            AulaHeranca();

        }

        public static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Nome = "Marcus Vinicius";
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Rua Ururai";
            pessoaFisica.Cidade = "Rio de Janeiro";
            pessoaFisica.Cep = "21511-000";
            pessoaFisica.CPF = "1232323";
            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
        }        
    }
}