using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Ex43.Entities
{
    class Locadora
    {
        public string       ModeloCarro         { get; private set; }
        public DateTime     Entrada             { get; private set; }
        public DateTime     Saida               { get; private set; }
        public double       PrecoHora           { get; private set; }
        public double       PrecoDia            { get; private set; }
        public double       SubTotal            { get; private set; }
        public double       Impostos            { get; private set; }
        public double       Total               { get; private set; }

        public Locadora(string modeloCarro, DateTime entrada, DateTime saida, double precoHora, double precoDia)
        {
            if(saida < entrada)
            {
                throw new Exception("Erro na data inserida!");
            }

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

            if (SubTotal > 100)
            {
                Impostos += (SubTotal * 0.15);
                Total += Impostos + SubTotal;
                return Total;
            }
            else
            {
                Impostos += (SubTotal * 0.20);
                Total += Impostos + SubTotal;
                return Total;
            }
           
        }

        public void Duracao(DateTime retirada, DateTime devolucao, double valorHora, double valorDia)
        {
            int dias = 0;
            int horas = 0;
            int minutos = 0;
            SubTotal = 0.0;
            TimeSpan tempo = devolucao.Subtract(retirada);
            Console.WriteLine("tempo total " + tempo);
            if (tempo.TotalHours > 12)
            {
                dias += tempo.Days;
                horas += tempo.Hours;
                minutos += tempo.Minutes;
                Console.WriteLine("Total em dia(s): " + dias);
                Console.WriteLine("Total em hora(s): " + horas);
                Console.WriteLine("Total em minuto(s): " + minutos);

                if (dias > 0 && horas > 0 )
                {
                    dias++;
                    SubTotal += dias * valorDia;
                    Console.WriteLine("Basic payament " + dias + " Dias * " + valorDia.ToString("F2", CultureInfo.InvariantCulture) + " = " + SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if(dias > 0 && minutos > 0)
                {
                    dias++;
                    SubTotal += dias * valorDia;
                    Console.WriteLine("Basic payament " + dias + " Dias * " + valorDia.ToString("F2", CultureInfo.InvariantCulture) + " = " + SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    SubTotal += dias * valorDia;
                    Console.WriteLine("Basic payament " + dias + " Dias * " + valorDia.ToString("F2", CultureInfo.InvariantCulture) + " = " + SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                }


            }
            else if (tempo.TotalHours <= 12)
            {
                dias += tempo.Days;
                minutos += tempo.Minutes;
                horas += tempo.Hours;
                Console.WriteLine("Total em dia(s): " + dias);
                Console.WriteLine("Total em hora(s): " + horas);
                Console.WriteLine("Total em minuto(s): " + minutos);

                if (minutos > 0)
                {
                    horas++;
                    SubTotal += horas * PrecoHora;
                    Console.WriteLine("Basic payament " + horas + " Horas * " + valorHora.ToString("F2", CultureInfo.InvariantCulture) + " = " + SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    SubTotal += horas * PrecoHora;
                    Console.WriteLine("Basic payament " + horas + " Horas * " + valorHora.ToString("F2", CultureInfo.InvariantCulture) + " = " + SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            else
            {
                throw new Exception("Erro na data informada");
            }

        }


        public override string ToString()
        {
            return "\nPagamento Basico: " + SubTotal.ToString("F2", CultureInfo.InvariantCulture) +
                "\nImpostos:  " + Impostos.ToString("F2", CultureInfo.InvariantCulture) +
                "\nTotal Geral: " + Total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}

