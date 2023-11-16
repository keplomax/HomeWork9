using System;

namespace Tumakov_Lab_10
{
    public class Rectangle : Point
    {
        private double width;
        private double height;

        public Rectangle(int x, int y, double width, double height, string color, bool visible) : base(x, y, color, visible)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return width;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
        }

        public double CalculateArea()
        {
            return width * height;
        }

        public override void Display()
        {
            Console.WriteLine("Прямоугольник: X = {0}, Y = {1}, Ширина = {2}, Высота = {3}, Цвет = {4}, Видимость = {5}", x, y, width, height, color, visible);
        }
    }

}
