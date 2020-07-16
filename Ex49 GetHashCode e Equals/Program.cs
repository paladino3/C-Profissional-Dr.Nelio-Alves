using Ex49.Entities;
using System;
using System.Buffers;
using System.Linq.Expressions;

namespace Ex49
{
    class Program
    {
        static void Main(string[] args)
        {
            Client A = new Client
            {
                Nome = "Alex Santos",
                Email = "Alex@gmail.com"
            };

            Client B = new Client
            {
                Nome = "Maria Oliveira",
                Email = "Maria@gmail.com"
            };

            Console.WriteLine(A.Equals(B));
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(B.GetHashCode());
        }
}
}
