using System.Runtime.ConstrainedExecution;

namespace Modulo11;

public class ManipulandoDatas
{
    public void ManipulandoData()
    {
        var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
        //parse
        var date2 = DateTime.Parse("2022/12/22 19:25:24"); //Transforma uma String em DateTime.

        var dataAtual = DateTime.Now;

        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(dataAtual);
        System.Console.WriteLine(dataAtual.ToString("dd-MM-yyyy")); //Converte para a data que eu quero. 

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        System.Console.WriteLine(dateOffset1.LocalDateTime);        
        System.Console.WriteLine(dateOffset1.UtcDateTime); //FusoHorario.
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");

        var diff = date1 - date2;

        Console.WriteLine(diff.TotalDays);//Quantas horas faltam. 
        Console.WriteLine(diff.TotalHours);//Quantas horas faltam. 
    }

}