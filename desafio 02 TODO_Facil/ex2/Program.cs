using ex2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo\t\tEspecificacao\t\tPreco\n");
            Console.WriteLine("   1\t\tCachorro Quente\t\tR$4.00");
            Console.WriteLine("   2\t\tX-Salada\t\tR$4.50");
            Console.WriteLine("   3\t\tX-bacon\t\t\tR$5.00");
            Console.WriteLine("   4\t\tTorrada Simples\t\tR$2.00");
            Console.WriteLine("   5\t\tRefrigerante\t\tR$1.50");

            string path = @"C:\Users\rolim\Desktop\Curso C# Profissional Dr.Nelio Alves\desafio 02 TODO_Facil\Lanches.txt";

            List<Pedido> lista = new List<Pedido>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vetor = sr.ReadLine().Split(',');
                    int codigo = int.Parse(vetor[0]);
                    string nome = vetor[1];
                    double valor = double.Parse(vetor[2], CultureInfo.InvariantCulture);
                    lista.Add(new Pedido() { Lanche = new Lanche(codigo, nome, valor) });
                }
            }

            // string[] vetors = Console.ReadLine().Split(',');
            // int p = int.Parse(vetors[0].Trim());

            int cont = 0;
            double total = 0.0;
            string info = "";
            Console.Write("\n\nDigite o seu pedido, (código): ");
            int n = int.Parse(Console.ReadLine());

            var valorPedido = lista.Where(x => x.Lanche.Cod == n).Select(x => x.Lanche.Preco);
            var pedidoInfo = lista.Where(p => p.Lanche.Cod == n).Select(p => p.Lanche.Nome);
            foreach (var item in valorPedido)
            {
                if (item > 1)
                {
                    cont++;
                }
                total += item;
            }
            foreach (var item in pedidoInfo)
            {
                info += item;
            }
            Console.WriteLine("Pedido: " + info + ", Valor R$: " + total.ToString("F2", CultureInfo.InvariantCulture));

            string resp = "s";

            while (resp == "s")
            {
                Console.Write("Deseja fazer um novo pedido? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    Console.Write("\n\nDigite o seu pedido, (código): ");
                    n = int.Parse(Console.ReadLine());
                    valorPedido = lista.Where(x => x.Lanche.Cod == n).Select(x => x.Lanche.Preco);
                    pedidoInfo = lista.Where(p => p.Lanche.Cod == n).Select(p => p.Lanche.Nome);
                    foreach (var item in valorPedido)
                    {
                        total += item;
                    }
                    foreach (var item in pedidoInfo)
                    {
                        info += ", " +item;
                    }
                    Console.WriteLine("Pedido: " + info + ", Valor R$: " + total.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    resp = "n";
                }


            }

            Console.WriteLine("\n\nPedido: " + info + ", Valor R$: " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor total do pedido ficou em R$" + total.ToString("F2", CultureInfo.InvariantCulture));







            /*  double CachorroQuente = 4.00;
              double X_Salada = 4.50;
              double X_bacon = 5.00;
              double TorradaSimples = 2.00;
              double Refrigerante = 1.50;

              Console.WriteLine("Codigo         Especificacao         Preco ");
              Console.WriteLine("   1           Cachorro Quente       R$4.00");
              Console.WriteLine("   2           X-Salada              R$4.50");
              Console.WriteLine("   3           X-bacon               R$5.00");
              Console.WriteLine("   4           Torrada Simples       R$2.00");
              Console.WriteLine("   5           Refrigerante          R$1.50");

              double valor1 = 0.0;
              double valor2 = 0.0;
              Console.Write("Digite o seu pedido: (mesma linha): ");
              string[] pedido = Console.ReadLine().Split(' ');
              int p1 = int.Parse(pedido[0]);
              int p2 = int.Parse(pedido[1]);

              if (p1 == 1)
              {
                  valor1 += 4.00;
              }
              else if (p1 == 2)
              {
                  valor1 += 4.50;
              }
              else if (p1 == 3)
              {
                  valor1 += 5.00;
              }
              else if (p1 == 4)
              {
                  valor1 += 2.00;
              }
              else if (p1 == 5)
              {
                  valor1 += 1.50;
              }

              if (p2 == 1)
              {
                  valor2 += 4.00;
              }
              else if (p2 == 2)
              {
                  valor2 += 4.50;
              }
              else if (p2 == 3)
              {
                  valor2 += 5.00;
              }
              else if (p2 == 4)
              {
                  valor2 += 2.00;
              }
              else if (p2 == 5)
              {
                  valor2 += 1.50;
              }

              var total = valor1 + valor2;
              Console.WriteLine(total);


      */
        }

    }
}
