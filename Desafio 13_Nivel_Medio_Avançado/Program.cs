using D13.Entities;
using D13.Services;
using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace D13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter contract data"); //dados gerais
            Console.Write("Number: "); //numero do contrato
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): "); // data inicial do contrato
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: "); //entre com o valor do contrato
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: "); //entre com o numero de parcelas
            int n = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, n);

            Console.WriteLine("\n\nInstallments: ");
            foreach (Installment installment in contract.installments)
            {
                Console.WriteLine(installment);

            }

            */



            Console.WriteLine("data");

            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            
            Console.WriteLine(data.AddMonths(1));



        }
    }
}