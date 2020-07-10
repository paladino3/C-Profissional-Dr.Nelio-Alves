using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Ex43.Entities
{
    class Locadora
    {
        public string ModeloCarro { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }
        public double SubTotal { get; set; }
        public double Impostos { get; set; }
        public double Total { get; set; }
        public Locadora(string modeloCarro, DateTime entrada, DateTime saida, double precoHora, double precoDia)
        {
            ModeloCarro = modeloCarro;
            Entrada = entrada;
            Saida = saida;
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }
        public double Imposto()
        {
            Total = 0.0;
            Impostos = 0.0;

            if (SubTotal >= 100)
            {
                Impostos += (SubTotal * 0.15);
                Total += Impostos + SubTotal;
                return Total;
            }
            Impostos += (SubTotal * 0.20);
            Total += Impostos + SubTotal;
            return Total;
        }

        public void Duracao(DateTime retirada, DateTime devolucao, double precoHora, double precoDia)
        {
            int dias = 0;
            int horas = 0;
            int minutos = 0;
            SubTotal = 0.0;
            TimeSpan tempo = devolucao.Subtract(retirada);
            Console.WriteLine("tempo total " + tempo);
            if (tempo.TotalHours > 12)
            {
                horas += tempo.Hours;
               
                if(dias > 0)
                {

                }



            }
            else if (tempo.TotalHours < 12)
            {
                minutos += tempo.Minutes;
                horas += tempo.Hours;
                Console.WriteLine(horas + " Total em hora(s)");
                Console.WriteLine(minutos + " Total em minuto(s)");

                if (minutos > 0)
                {
                    horas++;
                    SubTotal += horas * PrecoHora;
                    Console.WriteLine("Basic payament " + horas + " * " + precoHora.ToString("F2", CultureInfo.InvariantCulture) + " = " + SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    SubTotal += horas * PrecoHora;
                    Console.WriteLine("Basic payament " + horas + " * " + precoHora.ToString("F2", CultureInfo.InvariantCulture) + " = " + SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            else
            {
                throw new Exception("Erro na data informada");
            }

        }


        public override string ToString()
        {
            return "Pagamento Basico: " + SubTotal +
                "Impostos:  " + Impostos +
                "Total Geral: " + Imposto();
        }
    }


}

