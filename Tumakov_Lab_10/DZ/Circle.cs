using System;

namespace Tumakov_Lab_10
{
    public class Circle : Point
    {
        private double radius;

        public Circle(int x, int y, double radius, string color, bool visible) : base(x, y, color, visible)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override void Display()
        {
            Console.WriteLine("Круг: X = {0}, Y = {1}, Радиус = {2}, Цвет = {3}, Видимость = {4}", x, y, radius, color, visible);
        }
    }

}
