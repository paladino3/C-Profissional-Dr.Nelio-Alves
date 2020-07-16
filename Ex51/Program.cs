using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Ex51
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 5, 4, 8, 11, 55, 663, 11, 0 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10,223 };

            // union

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // intersection

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);


            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> colletions)
        {
            foreach (T obj in colletions)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

        }
    }
}
