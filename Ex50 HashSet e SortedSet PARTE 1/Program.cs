using System;
using System.Collections.Generic;

namespace Ex50
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            set.Add("PC");


            Console.WriteLine(set.Contains("TV"));


            //operacoes hashSet nao tem posicoes! entao nao posso usar 
            /*Por Exemplo: 
             for(int i = 0; i < set ; i++){
                Console.WriteLine(set[i]);
            }*/
            foreach (string i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
