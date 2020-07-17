using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ex52
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        HashSet<string> set = new HashSet<string>();

                        set.Add("Maria");
                        set.Add("Alex");

                        Console.WriteLine(set.Contains("Maria"));
                        //Um metodo interno procura atraves do GethashCod, e confima com equals
                         
             */


            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("PC", 4000.00));


            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 5));
            b.Add(new Point(5, 10));


            Product product = new Product("TV", 900.00); // obj diferente dentro da memoria, porque foi instanciado fora do conjunto

            Console.WriteLine(a.Contains(product)); //FALSE, porque os endeço de memoria sao diferentes, mesmo com o conteudo sendo extamente iguais; TIPO REFERENCIA


            //DEPOIS DE SER IMPLEMENTADO O METODO DE HASHCOD E EQUALS, PARA COMPARACAO O MESMO TESTE DA VERDADEIRO
            Console.WriteLine(a.Contains(product)); // TRUE



            Point point = new Point(5, 10);


            Console.WriteLine(b.Contains(point)); //true, mesmo que nao esteja implementado hashCod ou equals, porque Struct nao compara por tipo referencia, compara por tipo valor! Neste caso os valores sao exatamente igual!
        }
    }
}
