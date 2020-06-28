using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Alex", "Roberto", "Amanda" };

            list.Add("Maria");
            list.Add("joao");
            list.Add("ana");
            list.Insert(0, "marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count:  " + list.Count);

            /*
            list.Add
            list.Insert
            list.Count
            list.find
            list.findLast
            list.findIndex
            list.findLastIndex
            list.findAll
            list.Remove
            list.RemoveAll
            list.RemoveAt
            list.RemoveRange
            */
            Console.WriteLine("__________________________________________");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("__________________________________________");
            string s1 = list2.Find(x => x[0] == 'A');
            Console.WriteLine("Find: 'A' " + s1);

            Console.WriteLine("__________________________________________");

            string s2 = list2.FindLast(x => x[0] == 'A');
            Console.WriteLine("FindLast 'A': " + s2);

            Console.WriteLine("__________________________________________");
            int s3 = list2.FindIndex(x => x[0] == 'R');
            Console.WriteLine("FindIndex: "+s3);
        }
    }
}
