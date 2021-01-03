using System;
using curso.Entities.Enums;

namespace curso.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
