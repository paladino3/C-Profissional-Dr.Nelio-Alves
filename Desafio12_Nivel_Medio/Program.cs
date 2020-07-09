using D12.Entities;
using D12.Entities.Exceptions;
using System;
using System.Globalization;

namespace D12
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter Account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, withdraw);

                Console.Write("\n\nEnter amount for withdraw: ");
                withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(withdraw);

                Console.WriteLine(account.ToString());

            }
            catch (FormatException e)
            {
                Console.WriteLine("Error ao insirir dados! " + e.Message);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro nao inesperado! " + e.Message);
            }
        }
    }
}
