// namespace Curso
// {
//     public class Pratica
//     {
// var conta = new Banco.Conta();

// Console.WriteLine("Seja bem vindo\nO que deseja?\n");

// while (true)
// {
//     Console.WriteLine("Selecione as opções a seguir\n");
//     Console.WriteLine("1 - Mostrar saldo");
//     Console.WriteLine("2 - Depositar dinheiro");
//     Console.WriteLine("3 - Retirar dinheiro");
//     Console.WriteLine("4 - Sair");

//     var option = int.Parse(Console.ReadLine());

//     if (option == 1)
//     {
//         conta.MostrarSaldo();
//     }
//     else if (option == 2)
//     {
//         Console.WriteLine("Quanto deseja depositar?");
//         conta.Depositar(decimal.Parse(Console.ReadLine()));
//     }
//     else if (option == 3)
//     {
//         Console.WriteLine("Quanto deseja sacar?");
//         if (conta.Saldo > 0)
//         {
//             conta.Retirar(decimal.Parse(Console.ReadLine()));
//         }
//         else
//         {
//             Console.WriteLine($"Seu saldo é de {conta.Saldo}, ele não pode ficar negativo.\nDeposite dinheiro antes de sacar.");
//         }
//     }
//     else if (option == 4)
//     {
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Entrada Inválida\nPor favor, escolha novamente.");
//     }
// }        
//     }
// }