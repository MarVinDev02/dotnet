namespace Conversores;
//Parse e convert - Pesquisar depois sobre convert    
public class Conversor
{
    public void ConvertAndParse()
    {
        bool numero = bool.Parse("false"); //Converte um tipo de dado para o tipo que desejo.
        Console.WriteLine(numero);
    }

    public void TryParse()
    {
        var numero = "a";
        //Cria uma condição, que se houver a possibilidade de conversão, posso aplicar um bloco de código a partir disso.
        if(int.TryParse(numero, out int NumeroConvertido))
        {
            Console.WriteLine("Numero convertido.");
        }
        else
        {
            Console.WriteLine("Tá doidão?");
        }

    }

}

