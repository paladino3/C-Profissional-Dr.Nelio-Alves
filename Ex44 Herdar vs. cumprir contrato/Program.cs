using Ex44.Entities;
using Ex44.Model.Enums;
using System;

namespace Ex44
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape figura1 = new Circle(2.0, Color.White) { };
            IShape figura2 = new Rectangle(3.5, 4.2, Color.Black) { };


            Console.WriteLine(figura1);
            Console.WriteLine(figura2);
        }
    }
}
