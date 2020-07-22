using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ex58.Services
{
    class CalculationServices
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return x * x;
        }
    }
}
