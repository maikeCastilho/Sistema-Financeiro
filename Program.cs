
using Sistema_Financeiro.Model;

namespace Sistema_Financeiro 
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(123);
            account.deposit(500);

            Console.WriteLine(account.Balance);
        }
    }

}