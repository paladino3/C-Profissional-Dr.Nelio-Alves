
using Ex32.Entities.Enums;

namespace Ex32.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area(); // metodo abstrato!

    }
}
