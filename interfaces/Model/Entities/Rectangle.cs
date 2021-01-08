using System;
using System.Globalization;

namespace Curso.Model.Entities
{
    class Rectangle : AbstractShape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", widht ="
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height ="
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
