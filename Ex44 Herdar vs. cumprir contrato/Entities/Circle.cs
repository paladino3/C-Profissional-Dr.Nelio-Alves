using Ex44.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex44.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        public override string ToString()
        {
            return "Circle color = "
                    + Color
                    + ", radius =  "
                    + Radius.ToString("F2", CultureInfo.InvariantCulture)
                    + ", area = "
                    + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
