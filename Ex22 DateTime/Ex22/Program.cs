using Microsoft.VisualBasic;
using System;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  DateTime data = new DateTime(2020, 7, 1, 18, 02, 50, 770);

              Console.WriteLine(data);

              Console.WriteLine("1) Data: "+data.Date);
              Console.WriteLine("2) Dia: "+data.Day);
              Console.WriteLine("3) DiaDaSemana: "+data.DayOfWeek);
              Console.WriteLine("4) DiaDoAno: "+data.DayOfYear);
              Console.WriteLine("5) Horas: "+data.Hour);
              Console.WriteLine("6) Kind: "+data.Kind);
              Console.WriteLine("7) Minutos: "+data.Minute);
              Console.WriteLine("9) Segundos: "+data.Second);
              Console.WriteLine("8) Milesegundos: "+data.Millisecond);
              Console.WriteLine("9) Ticks: "+data.Ticks);
              Console.WriteLine("10) TimeOfDay: "+data.TimeOfDay);
              Console.WriteLine("11) Ano: "+data.Year);
              Console.WriteLine("12) Mes: "+data.Month);
  */

            /*
                        DateTime data = new DateTime(2020, 7, 1, 18, 02, 50, 770);

                        Console.WriteLine(data.ToLongDateString());
                        Console.WriteLine(data.ToLongTimeString());
                        Console.WriteLine(data.ToShortTimeString());

                        string s1 = data.ToString();
                        string s2 = data.ToString("dd-MM-yyyy HH:mm:ss");
                        string s3 = data.ToString("dd-MM-yyyy HH:mm:ss.fff");

                        Console.WriteLine(s1);
                        Console.WriteLine(s2);
                        Console.WriteLine(s3);


                */

            DateTime data = new DateTime(2020, 7, 1, 18, 02, 50, 770);

            DateTime d2 = data.AddHours(2);
            DateTime d3 = data.AddMinutes(3);

            Console.WriteLine(data);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime dataAtual = DateTime.Now; // data atual
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine(dataAtual.ToLongDateString() + dataAtual.ToLongTimeString());
            Console.WriteLine(dataAtual.ToString());

            DateTime vencimento = dataAtual.AddDays(7);
            Console.WriteLine("Vencimento para: "+vencimento.ToString("dd/MM/yyyy"));


            Console.WriteLine("_________________________________________________");
            TimeSpan tempo = vencimento.Subtract(dataAtual);
            Console.WriteLine("Dias, Horas, Minutos... "+tempo);
            Console.WriteLine("Numeros de dias: "+tempo.ToString("dd"));
        }

    }
}
