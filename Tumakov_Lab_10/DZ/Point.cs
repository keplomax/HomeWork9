using System;

namespace Tumakov_Lab_10
{
    public class Point : Figure, IMovable, IColorable, IVisible
    {
        protected int x;
        protected int y;

        public Point(int x, int y, string color, bool visible) : base(color, visible)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void MoveHorizontal(int distance)
        {
            x += distance;
        }

        public void MoveVertical(int distance)
        {
            y += distance;
        }

        public void ChangeColor(string color)
        {
            this.color = color;
        }

        public void SetVisible(bool visible)
        {
            this.visible = visible;
        }

        public bool IsVisible()
        {
            return visible;
        }

        public override void Display()
        {
            Console.WriteLine("Точка: X = {0}, Y = {1}, Цвет = {2}, Видимость = {3}", x, y, color, visible);
        }
    }
}
