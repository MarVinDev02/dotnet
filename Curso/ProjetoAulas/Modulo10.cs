namespace Modulo10;

public class TrabalhandoComStrings
{
    public string nome { get; set; }
    public void ConverterLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        
        var resp = Console.ReadLine();
        
        var conversorLetraMinuscula = resp.ToLower();
        Console.WriteLine(conversorLetraMinuscula);
        

    }
}