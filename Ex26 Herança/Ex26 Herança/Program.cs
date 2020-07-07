using Ex26_Herança.Entities;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Ex26_Herança
{
    class Program
    {
        static void Main(string[] args)
        {



            BusinessAccount b1 = new BusinessAccount(2080,"Bob Brown",3200,600 );

            Console.WriteLine(b1.Balance);

           // b1.Balance = 5;
        
        }



    }
}
