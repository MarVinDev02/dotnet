
namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public string Titular { get; set; }
    
        public Conta()
        {
        }

        public Conta(int numero, decimal saldo, string titular)
        {
            Numero = numero;
            Saldo = saldo;
            Titular = titular;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            System.Console.WriteLine($"Seu saldo agora é {Saldo:C}.");

        }

        public void Retirar(decimal valor)
        {
            Saldo -= valor;
            System.Console.WriteLine($"Seu saldo agora é {Saldo:C}.");
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Seu saldo é {Saldo:C}.");
        }

        
    }
}