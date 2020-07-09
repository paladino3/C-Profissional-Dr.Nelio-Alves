using System;
using System.Linq.Expressions;

namespace Ex33
{
    class Program
    {
        static void Main(string[] args)
        {
            //tratamento de exececoes

            try
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                int result = (number1 / number2);

                Console.WriteLine(result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de sintaxe, foi capturado uma letra ao invez de numero " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Erro nao nao pode dividir por zero! " + e.Message);
            }
            finally
            {
                // a palavra finally, realiza uma açao independente se funcionou o cod, ou deu erros!
                Console.WriteLine("\n\niNDEPENDENTE DO QUE ACONTEÇA, ESSA MENSSAGEM VAI APARECER! ");
            }

        }
    }
}
