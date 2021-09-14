
using Course.Entities.Enums;

namespace Course.Entities
{
    class Rectangule : Shape
    {

        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangule(double width, double higth, Color color) : base(color)
        {
            Width = width;
            Heigth = higth;
        }
        public override double Area()
        {
            return Width * Heigth;
        }
    }
}
