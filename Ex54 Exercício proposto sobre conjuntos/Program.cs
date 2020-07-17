using Ex54.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Ex54
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

            Console.Write("How many studants for course A? ");
            int a = int.Parse(Console.ReadLine());
            course.NewCourse(a);



            Console.Write("How many studants for course B? ");
            int b = int.Parse(Console.ReadLine());
            course.NewCourse(b);


            Console.Write("How many studants for course C? ");
            int c = int.Parse(Console.ReadLine());
            course.NewCourse(c);


            course.Count();


        }
    }
}
