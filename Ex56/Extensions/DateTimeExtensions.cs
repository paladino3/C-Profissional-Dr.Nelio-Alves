using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Timers;

namespace Ex56.Extensions
{
    static class DateTimeExtensions //tem que ser uma classe estatica
    {

        public static string ElapsedTime(this DateTime thisObj)
        {
            //tempo passado = duracao = tempo.agota - meu proprio objeto
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}
