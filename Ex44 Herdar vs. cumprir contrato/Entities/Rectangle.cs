using Ex44.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex44.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = " + Color
                + ", width =  " + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = " + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
