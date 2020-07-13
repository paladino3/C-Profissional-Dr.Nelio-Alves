using Ex44.Model.Enums;

namespace Ex44.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // metodo abstrato, pois a classe tbm e abstrata!
    }
}
